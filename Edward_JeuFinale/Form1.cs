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
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        bool goLeft, goRight, jumping, hasKey;
        int jumpSpeed = 10;
        int force = 8;
        int playerSpeed = 10;
        int backgroundSpeed = 8;
        bool shooting = false;
        int ballVelocityX = 0;
        int ballVelocityY = 0;
        int ballWeight = 1;

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

            if (shooting == true)
            {
                ball.Left -= ballVelocityX;
                ball.Top -= ballVelocityY;
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


                // ballx += ballSpeed
                // bally = a * Math.Pow(ballx, 2)

               

            }

            }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Delete this

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
            if (e.KeyCode == Keys.W)
            {
                shooting = false;
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
            if (e.KeyCode == Keys.W)
            {
                shooting = true;
            }

            // Add a use key to shoot the ball and weapons


        }

     


        private void background_Click(object sender, EventArgs e)
        {

        }
    }
}
