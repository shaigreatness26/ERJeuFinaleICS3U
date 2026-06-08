using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Make all the buckets the level requires to kill all the enemies while dodging their attacks
// Have enemies shooting at you or whatever and you need to make a bucket n amount of times depending on the level
// After each bucket the ball spawns in a different place and you need to stay alive and get the ball



namespace Edward_JeuFinale
{

    public partial class Form1 : Form
    {

        private readonly Random rng = new Random();
        private bool goLeft;
        private bool goRight;
        private bool jumping;
        private bool hasKey;
        private bool chargingShot;
        private bool shotInFlight;
        private bool hasBall;

        private int jumpSpeed = 10;
        private int playerSpeed = 10;
        private int force = 8;
        private int backgroundSpeed = 8;
        private int scoreFallVelocity;

        private int ballVelocityX;
        private int ballVelocityY;
        private const int Gravity = 1;

        private DateTime shotStartTime;
        private const int MaxShotWindow = 900;
        private const int GreenWindowStart = 450;
        private const int GreenWindowEnd = 500;

        private readonly Panel shotMeterBack = new Panel();
        private readonly Panel shotMeterFill = new Panel(); // Du GPT
     
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            KeyPreview = true;
            InitializeShotMeter();

        }

        private void AttachBallToPlayer()
        {
            hasBall = true;
            shotInFlight = false;
            chargingShot = false;

            ballVelocityX = 0;
            ballVelocityY = 0;

            ball.Left = Player.Right - (ball.Width / 2) + 4;
            ball.Top = Player.Top + 18;

            ball.BringToFront();
    
        }


        private void ShootBall()
        {
           

            int holdMs = (int)(DateTime.UtcNow - shotStartTime).TotalMilliseconds;
            holdMs = Math.Max(0, Math.Min(MaxShotWindow, holdMs));

            float charge = holdMs / (float)MaxShotWindow;
            bool perfectRelease = holdMs >= GreenWindowStart && holdMs <= GreenWindowEnd;

            hasBall = false;
            shotInFlight = true;
            chargingShot = false;

            // (55, 102) est la position du centre dans l'image du panier
            float targetX = hoop.Left + (55f);
            float targetY = hoop.Top + (102f);

            // Centre du balle 
            float startX = ball.Left + (ball.Width / 2f);
            float startY = ball.Top + (ball.Height / 2f);

            // flightFrames determine combien de temps le balle reste dans l'air. Duration de l'animation.
            // Plus de charge -> plus de force -> plus de distance -> plus de temps dans l'air
            int flightFrames = 28 + (int)(12 * charge);
            if (flightFrames < 20)
            {
                flightFrames = 20;
            }

            float idealVx = (targetX - startX) / flightFrames;
            float idealVy = ((targetY - startY) - (0.5f * Gravity * flightFrames * flightFrames)) / flightFrames;


            if (perfectRelease)
            {

                groupBox1.Visible = true;
                retroactionTir.Text = "PARFAIT";
                retroactionTir.ForeColor = Color.Green;
                feedbackTimer.Stop();
                feedbackTimer.Start();


                // Tir au moment ideal
                ballVelocityX = (int)Math.Round(idealVx);
                ballVelocityY = (int)Math.Round(idealVy);
            }
            else
            {
                // Possible de faire un shot imparfait mais au hasard
                ballVelocityX = (int)Math.Round(idealVx) + rng.Next(-4, 5);
                ballVelocityY = (int)Math.Round(idealVy) + rng.Next(-4, 5);
                if (holdMs > GreenWindowEnd || holdMs > 900)
                {
                    groupBox1.Visible = true;
                    retroactionTir.Text = "TARD";
                    retroactionTir.ForeColor = Color.Red;
                    feedbackTimer.Stop();
                    feedbackTimer.Start();
                }
                else if(holdMs < GreenWindowStart)
                {
                    {
                        groupBox1.Visible = true;
                        retroactionTir.Text = "TOT";
                        retroactionTir.ForeColor = Color.Red;
                        feedbackTimer.Stop();
                        feedbackTimer.Start();
                    }
                }
            }




        }

        // GPT
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


        private void timer1_Tick(object sender, EventArgs e)
        {
            Player.Top += jumpSpeed;
            if (goLeft == true)
            {
                Player.Left -= playerSpeed;
            }
            if (goRight == true)
            {
                Player.Left += playerSpeed;
            }

            if (jumping == true)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }

            if (jumping == true && force < 0)
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
                goRight = false;
                goLeft = false;
                
                // GPT
                int holdMs = (int)(DateTime.UtcNow - shotStartTime).TotalMilliseconds;
                holdMs = Math.Max(0, Math.Min(MaxShotWindow, holdMs));

                float charge = holdMs / (float)MaxShotWindow;
                int fillWidth = Math.Max(0, (int)((shotMeterBack.Width - 2) * charge));

                shotMeterBack.Visible = true;
                shotMeterFill.Width = fillWidth;
                shotMeterFill.BackColor = (holdMs >= GreenWindowStart && holdMs <= GreenWindowEnd) ? Color.LimeGreen : Color.Gold;
                shotMeterBack.Left = Player.Left + (Player.Width / 2) - (shotMeterBack.Width / 2);
                shotMeterBack.Top = Player.Top - 22;
               
            }

            if (shotInFlight)
            {
                ball.Left += ballVelocityX;
                ball.Top += ballVelocityY;
                ballVelocityY += Gravity;


                if (ball.Top > ClientSize.Height || ball.Left > ClientSize.Width || ball.Left + ball.Width < 0)
                {
                    AttachBallToPlayer();
                }

                if (ball.Bounds.IntersectsWith(rimBounds.Bounds))
                {

                    ballVelocityY += 1;
                    ball.Left = hoop.Left + 55 - (ball.Width / 2);
                    ball.Top = hoop.Top + 102 - (ball.Height / 2);


                }

            }
            else if (!hasBall && ball.Bounds.IntersectsWith(Player.Bounds))
            {
                AttachBallToPlayer();
            }

            foreach (Control x in this.Controls)
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
            foreach (Control x in this.Controls)
            {

                if (x is PictureBox && (string)x.Tag == "platform")
                {



                    if (ball.Bounds.IntersectsWith(x.Bounds) )
                    {
                        shotInFlight = false;
                        ballVelocityX = 0;
                        ballVelocityY = 0;
                    }

                    x.BringToFront();

                }

            }

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

            if (e.KeyCode == Keys.W && hasBall && !shotInFlight)
            {
                chargingShot = true;
                shotStartTime = DateTime.UtcNow;
            }
            // Add a use key to shoot the ball and weapons


        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void feedbackTimer_Tick(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            feedbackTimer.Stop();
        }
    }
}
