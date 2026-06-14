using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Reflection;
using System.Windows.Forms;

namespace Edward_JeuFinale
{
    public class GameLevelForm : Form
    {
        private readonly Random rng = new Random();

        private bool goLeft;
        private bool goRight;
        private bool jumping;
        private bool chargingShot;
        private bool shotInFlight;
        private bool hasBall;
        private bool dribbling;

        private int jumpSpeed = 10;
        private int playerSpeed = 10;
        private int force = 8;
        private int backgroundSpeed = 10;
        private int score;
        private int ballVelocityX;
        private int ballVelocityY;
        private const int Gravity = 1;

        private DateTime shotStartTime;
        private const int MaxShotWindow = 900;
        private const int GreenWindowStart = 450;
        private const int GreenWindowEnd = 500;

        private readonly Panel shotMeterBack = new Panel();
        private readonly Panel shotMeterFill = new Panel();
        private readonly SoundPlayer dribblePlayer = new SoundPlayer(Properties.Resources.dribble);

        private readonly Dictionary<Control, Point> originalPositions = new Dictionary<Control, Point>();

        private PictureBox background;
        private PictureBox hoop;
        private PictureBox ballSpawnPlatform;
        private PictureBox player;
        private PictureBox ball;
        private PictureBox rimBounds;
        private PictureBox spawnPlatform;
        private GroupBox feedbackBox;
        private Label feedbackLabel;
        private Timer gameTimer;
        private Timer feedbackTimer;
        private Timer dribbleTimer;

        protected virtual int RequiredScore => 1;
        protected virtual string LevelCompleteMessage => "Tutoriel termine! Continuer au selecteur de niveaux?";
        protected virtual string LevelCompleteTitle => "Quitte Niveau";

        protected void InitializeGameLevel()
        {
            ResolveControls();
            InitializeShotMeter();
            CacheOriginalPositions();

            if (dribbleTimer != null)
            {
                dribbleTimer.Start();
            }
        }

        protected virtual void OnLevelComplete()
        {
            Close();
        }

        protected virtual void timer1_Tick(object sender, EventArgs e)
        {
            if (player == null || ball == null)
            {
                return;
            }

            player.Top += jumpSpeed;

            if (goLeft)
            {
                player.Left -= playerSpeed;
                MoveWorld("forward");
            }

            if (goRight)
            {
                player.Left += playerSpeed;
                MoveWorld("back");
            }

            if (jumping)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }

            if (jumping && force < 0)
            {
                jumping = false;
            }

            if (hasBall)
            {
                ball.Left = player.Right - (ball.Width / 2) + 4;
                ball.Top = player.Top + 18;
            }

            if (chargingShot)
            {
                goRight = false;
                goLeft = false;

                int holdMs = GetShotHoldMilliseconds();
                float charge = holdMs / (float)MaxShotWindow;
                int fillWidth = Math.Max(0, (int)((shotMeterBack.Width - 2) * charge));

                shotMeterBack.Visible = true;
                shotMeterFill.Width = fillWidth;
                shotMeterFill.BackColor = (holdMs >= GreenWindowStart && holdMs <= GreenWindowEnd) ? Color.LimeGreen : Color.Gold;
                shotMeterBack.Left = player.Left + (player.Width / 2) - (shotMeterBack.Width / 2);
                shotMeterBack.Top = player.Top - 22;
            }

            if (shotInFlight)
            {
                ball.Left += ballVelocityX;
                ball.Top += ballVelocityY;
                ballVelocityY += Gravity;

                if (rimBounds != null && ball.Bounds.IntersectsWith(rimBounds.Bounds))
                {
                    ballVelocityY += 1;
                    ball.Left = hoop.Left + 55 - (ball.Width / 2);
                    ball.Top = hoop.Top + 102 - (ball.Height / 2);
                    score++;
                }
            }
            else if (!hasBall && ball.Bounds.IntersectsWith(player.Bounds))
            {
                AttachBallToPlayer();
            }

            if (score >= RequiredScore)
            {
                gameTimer?.Stop();

                DialogResult result = MessageBox.Show(
                    LevelCompleteMessage,
                    LevelCompleteTitle,
                    MessageBoxButtons.OKCancel);

                if (result == DialogResult.Yes || result == DialogResult.OK)
                {
                    OnLevelComplete();
                }
                else
                {
                    Application.Exit();
                }

                return;
            }

            HandlePlayerCollisions();
            HandleBallCollisions();
        }

        protected virtual void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.D)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.Space)
            {
                jumping = false;
            }

            if (e.KeyCode == Keys.W && chargingShot && hasBall)
            {
                ShootBall();
                feedbackTimer?.Stop();
                feedbackTimer?.Start();
            }
        }

        protected virtual void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                goLeft = true;
                background.Left += backgroundSpeed;
            }

            if (e.KeyCode == Keys.D)
            {
                goRight = true;
                background.Left -= backgroundSpeed;
            }

            if (e.KeyCode == Keys.Space && !jumping)
            {
                jumping = true;
            }

            if (e.KeyCode == Keys.W && hasBall && !shotInFlight)
            {
                chargingShot = true;
                shotStartTime = DateTime.UtcNow;
                shotMeterBack.Visible = true;
                shotMeterFill.Visible = true;
            }
        }

        protected virtual void feedbackTimer_Tick(object sender, EventArgs e)
        {
            if (feedbackBox != null)
            {
                feedbackBox.Visible = false;
            }

            shotMeterBack.Visible = false;
            shotMeterFill.Visible = false;

            if (feedbackTimer != null)
            {
                feedbackTimer.Stop();
            }
        }

        protected virtual void dribbleTimer_Tick(object sender, EventArgs e)
        {
            if (hasBall)
            {
                if (!dribbling)
                {
                    dribbling = true;
                }

                dribblePlayer.Play();
            }
            else
            {
                dribbling = false;
                dribblePlayer.Stop();
            }
        }

        private void AttachBallToPlayer()
        {
            hasBall = true;
            shotInFlight = false;
            chargingShot = false;

            ballVelocityX = 0;
            ballVelocityY = 0;

            ball.Left = player.Right - (ball.Width / 2) + 4;
            ball.Top = player.Top + 18;
            ball.BringToFront();
        }

        private void ShootBall()
        {
            int holdMs = GetShotHoldMilliseconds();
            float charge = holdMs / (float)MaxShotWindow;
            bool perfectRelease = holdMs >= GreenWindowStart && holdMs <= GreenWindowEnd;

            hasBall = false;
            shotInFlight = true;
            chargingShot = false;

            float targetX = hoop.Left + 55f;
            float targetY = hoop.Top + 102f;
            float startX = ball.Left + (ball.Width / 2f);
            float startY = ball.Top + (ball.Height / 2f);

            int flightFrames = 28 + (int)(12 * charge);
            if (flightFrames < 20)
            {
                flightFrames = 20;
            }

            float idealVx = (targetX - startX) / flightFrames;
            float idealVy = ((targetY - startY) - (0.5f * Gravity * flightFrames * flightFrames)) / flightFrames;

            SoundPlayer greenAudio = new SoundPlayer(Properties.Resources.green48kHz);
            if (perfectRelease)
            {
                ShowFeedback("EXCELLENT", Color.Green);
                greenAudio.Play();
                ballVelocityX = (int)Math.Round(idealVx);
                ballVelocityY = (int)Math.Round(idealVy);
            }
            else
            {
                ballVelocityX = (int)Math.Round(idealVx) + rng.Next(-10, 15);
                ballVelocityY = (int)Math.Round(idealVy) + rng.Next(-10, 15);

                if (holdMs > GreenWindowEnd || holdMs > MaxShotWindow)
                {
                    ShowFeedback("TARD", Color.Red);
                }
                else if (holdMs < GreenWindowStart)
                {
                    ShowFeedback("TOT", Color.Red);
                }
            }
        }

        private void ShowFeedback(string message, Color color)
        {
            if (feedbackBox == null || feedbackLabel == null)
            {
                return;
            }

            feedbackBox.BringToFront();
            feedbackBox.Visible = true;
            feedbackLabel.Text = message;
            feedbackLabel.ForeColor = color;
            feedbackTimer?.Stop();
            feedbackTimer?.Start();
        }

        private void InitializeShotMeter()
        {
            shotMeterBack.Size = new Size(200, 14);
            shotMeterBack.BackColor = Color.FromArgb(60, 60, 60);
            shotMeterBack.BorderStyle = BorderStyle.FixedSingle;
            shotMeterBack.Visible = false;

            shotMeterFill.Location = new Point(1, 1);
            shotMeterFill.Size = new Size(0, 10);
            shotMeterFill.BackColor = Color.Gold;
            shotMeterBack.Controls.Add(shotMeterFill);
            Controls.Add(shotMeterBack);
            shotMeterBack.BringToFront();
        }

        private int GetShotHoldMilliseconds()
        {
            int holdMs = (int)(DateTime.UtcNow - shotStartTime).TotalMilliseconds;
            return Math.Max(0, Math.Min(MaxShotWindow, holdMs));
        }

        private void MoveWorld(string direction)
        {
            foreach (Control control in Controls)
            {
                if (control is PictureBox pictureBox)
                {
                    string tag = pictureBox.Tag as string;
                    if (tag == "platform" || tag == "lava" || tag == "wall" || tag == "hoop" || tag == "rimBounds" || (tag == "ball" && !hasBall) || tag == "retroaction")
                    {
                        if (direction == "back")
                        {
                            pictureBox.Left -= backgroundSpeed;
                        }
                        else if (direction == "forward")
                        {
                            pictureBox.Left += backgroundSpeed;
                        }
                    }
                }
            }
        }

        private void HandlePlayerCollisions()
        {
            foreach (Control control in Controls)
            {
                if (!(control is PictureBox pictureBox))
                {
                    continue;
                }

                string tag = pictureBox.Tag as string;
                if (tag == "wall")
                {
                    if (player.Bounds.IntersectsWith(pictureBox.Bounds) && !jumping)
                    {
                        force += 67;
                        jumpSpeed += 67;
                    }

                    pictureBox.BringToFront();
                }

                if (tag == "platform")
                {
                    if (player.Bounds.IntersectsWith(pictureBox.Bounds) && !jumping)
                    {
                        force = 8;
                        player.Top = pictureBox.Top - player.Height;
                        jumpSpeed = 0;
                    }

                    pictureBox.BringToFront();
                }
            }
        }

        private void HandleBallCollisions()
        {
            foreach (Control control in Controls)
            {
                if (!(control is PictureBox pictureBox))
                {
                    continue;
                }

                string tag = pictureBox.Tag as string;
                if (tag == "platform" || tag == "wall")
                {
                    if (ball.Bounds.IntersectsWith(pictureBox.Bounds))
                    {
                        shotInFlight = false;
                        ballVelocityX = 0;
                        ballVelocityY = 0;
                    }

                    pictureBox.BringToFront();
                }

                if (tag == "lava")
                {
                    if (player.Bounds.IntersectsWith(pictureBox.Bounds))
                    {
                        ResetLevel();
                    }

                    if (ball.Bounds.IntersectsWith(pictureBox.Bounds))
                    {
                        ballVelocityX = 0;
                        ballVelocityY = 0;
                        shotInFlight = false;
                        ball.Location = ballSpawnPlatform.Location + new Size(36, -35);
                    }

                    pictureBox.BringToFront();
                }
            }
        }

        private void ResetLevel()
        {
            foreach (Control control in Controls)
            {
                if (originalPositions.ContainsKey(control))
                {
                    control.Location = originalPositions[control];
                }
            }

            player.Location = spawnPlatform.Location + new Size(-50, -80);
            ball.Location = ballSpawnPlatform.Location + new Size(36, -35);
            shotInFlight = false;
            chargingShot = false;
            hasBall = false;
            ballVelocityX = 0;
            ballVelocityY = 0;
        }

        private void CacheOriginalPositions()
        {
            originalPositions.Clear();

            foreach (Control control in Controls)
            {
                if (!originalPositions.ContainsKey(control))
                {
                    originalPositions.Add(control, control.Location);
                }
            }
        }

        private void ResolveControls()
        {
            background = RequireControl<PictureBox>("background");
            hoop = RequireControl<PictureBox>("hoop");
            ballSpawnPlatform = RequireControl<PictureBox>("ballSpawnPlatform");
            player = RequireControl<PictureBox>("Player");
            ball = RequireControl<PictureBox>("ball");
            rimBounds = RequireControl<PictureBox>("rimBounds");
            spawnPlatform = RequireControl<PictureBox>("spawnPlatform");
            feedbackBox = FindControl<GroupBox>("groupBox1");
            feedbackLabel = FindControl<Label>("retroactionTir");
            gameTimer = FindComponent<Timer>("gameTimer");
            feedbackTimer = FindComponent<Timer>("feedbackTimer");
            dribbleTimer = FindComponent<Timer>("dribbleTimer");

            if (background == null || hoop == null || ball == null || player == null || spawnPlatform == null)
            {
                throw new InvalidOperationException("The level is missing one or more required controls.");
            }
        }

        private T RequireControl<T>(string name) where T : Control
        {
            T control = FindControl<T>(name);
            if (control == null)
            {
                throw new InvalidOperationException("Missing required control: " + name);
            }

            return control;
        }

        private T FindControl<T>(string name) where T : Control
        {
            return FindControlRecursive<T>(Controls, name);
        }

        private T FindControlRecursive<T>(Control.ControlCollection controls, string name) where T : Control
        {
            foreach (Control control in controls)
            {
                if (control.Name == name && control is T typedControl)
                {
                    return typedControl;
                }

                T nested = FindControlRecursive<T>(control.Controls, name);
                if (nested != null)
                {
                    return nested;
                }
            }

            return null;
        }

        private T FindComponent<T>(string name) where T : class
        {
            FieldInfo field = GetType().GetField(name, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            if (field == null)
            {
                return null;
            }

            return field.GetValue(this) as T;
        }
    }
}
