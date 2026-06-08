using System;
using System.Drawing;
using System.Windows.Forms;

namespace Edward_JeuFinale
{
    public partial class Form1 : Form
    {
        private readonly Random rng = new Random();

        private bool goLeft;
        private bool goRight;
        private bool jumping;
        private bool hasBall = true;
        private bool chargingShot;
        private bool shotInFlight;
        private bool scoreAnimationActive;

        private int jumpSpeed = 10;
        private int force = 8;
        private int playerSpeed = 10;

        private int ballVelocityX;
        private int ballVelocityY;
        private const int Gravity = 1;

        private DateTime shotStartTime;
        private const int MaxShotChargeMs = 900;
        private const int GreenWindowStartMs = 520;
        private const int GreenWindowEndMs = 700;

        private readonly Panel shotMeterBack = new Panel();
        private readonly Panel shotMeterFill = new Panel();
        private readonly Label shotMeterLabel = new Label();

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            KeyPreview = true;

            Bitmap brunson = new Bitmap(Properties.Resources.greensmall_Jalenbrunsonsprite);
            brunson.MakeTransparent(Color.LimeGreen);
            Player.Image = brunson;

            InitializeShotMeter();
            AttachBallToPlayer();
        }

        private void InitializeShotMeter()
        {
            shotMeterBack.Size = new Size(120, 14);
            shotMeterBack.BackColor = Color.FromArgb(60, 60, 60);
            shotMeterBack.BorderStyle = BorderStyle.FixedSingle;
            shotMeterBack.Visible = false;

            shotMeterFill.Location = new Point(1, 1);
            shotMeterFill.Size = new Size(0, 10);
            shotMeterFill.BackColor = Color.Gold;

            shotMeterLabel.AutoSize = true;
            shotMeterLabel.Text = "SHOT";
            shotMeterLabel.ForeColor = Color.White;
            shotMeterLabel.BackColor = Color.Transparent;
            shotMeterLabel.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
            shotMeterLabel.Visible = false;

            shotMeterBack.Controls.Add(shotMeterFill);
            Controls.Add(shotMeterBack);
            Controls.Add(shotMeterLabel);
            shotMeterBack.BringToFront();
            shotMeterLabel.BringToFront();
        }

        private void AttachBallToPlayer()
        {
            hasBall = true;
            shotInFlight = false;
            chargingShot = false;
            scoreAnimationActive = false;

            ballVelocityX = 0;
            ballVelocityY = 0;

            ball.Left = Player.Right - (ball.Width / 2) + 4;
            ball.Top = Player.Top + 18;

            shotMeterBack.Visible = false;
            shotMeterLabel.Visible = false;

            ball.BringToFront();
            Player.BringToFront();
        }

        private void ShootBall()
        {
            int holdMs = (int)(DateTime.UtcNow - shotStartTime).TotalMilliseconds;
            holdMs = Math.Max(0, Math.Min(MaxShotChargeMs, holdMs));

            float charge = holdMs / (float)MaxShotChargeMs;
            bool perfectRelease = holdMs >= GreenWindowStartMs && holdMs <= GreenWindowEndMs;

            hasBall = false;
            shotInFlight = true;
            chargingShot = false;
            shotMeterBack.Visible = false;
            shotMeterLabel.Visible = false;

            float targetX = hoop.Left + (hoop.Width / 2f);
            float targetY = hoop.Top + (hoop.Height / 2f);
            float startX = ball.Left + (ball.Width / 2f);
            float startY = ball.Top + (ball.Height / 2f);

            // More charge means a longer, stronger arc.
            int flightFrames = 28 + (int)(12 * charge);
            if (flightFrames < 20)
            {
                flightFrames = 20;
            }

            float idealVx = (targetX - startX) / flightFrames;
            float idealVy = ((targetY - startY) - (0.5f * Gravity * flightFrames * flightFrames)) / flightFrames;

            if (perfectRelease)
            {
                ballVelocityX = (int)Math.Round(idealVx);
                ballVelocityY = (int)Math.Round(idealVy);
            }
            else
            {
                // Slight error makes bad releases miss more often.
                ballVelocityX = (int)Math.Round(idealVx) + rng.Next(-4, 5);
                ballVelocityY = (int)Math.Round(idealVy) + rng.Next(-4, 5);
            }
        }

        private void Score()
        {
            // Transition directly into a falling-through-the-net motion.
            shotInFlight = false;
            scoreAnimationActive = true;

            if (ballVelocityY < 2)
            {
                ballVelocityY = 2;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Player.Top += jumpSpeed;

            if (goLeft)
            {
                Player.Left -= playerSpeed;
            }

            if (goRight)
            {
                Player.Left += playerSpeed;
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
                ball.Left = Player.Right - (ball.Width / 2) + 4;
                ball.Top = Player.Top + 18;
            }

            if (chargingShot)
            {
                int holdMs = (int)(DateTime.UtcNow - shotStartTime).TotalMilliseconds;
                holdMs = Math.Max(0, Math.Min(MaxShotChargeMs, holdMs));

                float charge = holdMs / (float)MaxShotChargeMs;
                int fillWidth = Math.Max(0, (int)((shotMeterBack.Width - 2) * charge));

                shotMeterBack.Visible = true;
                shotMeterLabel.Visible = true;
                shotMeterFill.Width = fillWidth;
                shotMeterFill.BackColor = (holdMs >= GreenWindowStartMs && holdMs <= GreenWindowEndMs) ? Color.LimeGreen : Color.Gold;
                shotMeterBack.Left = Player.Left + (Player.Width / 2) - (shotMeterBack.Width / 2);
                shotMeterBack.Top = Player.Top - 22;
                shotMeterLabel.Left = shotMeterBack.Left + 2;
                shotMeterLabel.Top = shotMeterBack.Top - 16;
            }

            if (shotInFlight)
            {
                ball.Left += ballVelocityX;
                ball.Top += ballVelocityY;
                ballVelocityY += Gravity;

                // Simple score detection: when the ball reaches the hoop while falling, snap it in.
                if (ball.Bounds.IntersectsWith(hoop.Bounds) && ballVelocityY > 0)
                {
                    Score();
                }

                if (ball.Top > ClientSize.Height || ball.Left > ClientSize.Width || ball.Left + ball.Width < 0)
                {
                    AttachBallToPlayer();
                }
            }
            else if (scoreAnimationActive)
            {
                ball.Top += ballVelocityY;
                ballVelocityY += Gravity;

                if (ball.Top > ClientSize.Height)
                {
                    AttachBallToPlayer();
                }
            }
            else if (!hasBall && ball.Bounds.IntersectsWith(Player.Bounds))
            {
                AttachBallToPlayer();
            }

            foreach (Control x in Controls)
            {
                if (x is PictureBox && (string)x.Tag == "platform")
                {
                    if (Player.Bounds.IntersectsWith(x.Bounds) && jumping == false)
                    {
                        force = 8;
                        Player.Top = x.Top - Player.Height;
                        jumpSpeed = 0;
                    }

                    x.BringToFront();
                }
            }

            ball.BringToFront();
            Player.BringToFront();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Not used right now.
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
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
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                goLeft = true;
            }

            if (e.KeyCode == Keys.D)
            {
                goRight = true;
            }

            if (e.KeyCode == Keys.Space && !jumping)
            {
                jumping = true;
            }

            if (e.KeyCode == Keys.W && hasBall && !shotInFlight && !chargingShot)
            {
                chargingShot = true;
                shotStartTime = DateTime.UtcNow;
                shotMeterBack.Visible = true;
                shotMeterLabel.Visible = true;
            }
        }

        private void background_Click(object sender, EventArgs e)
        {
        }
    }
}
