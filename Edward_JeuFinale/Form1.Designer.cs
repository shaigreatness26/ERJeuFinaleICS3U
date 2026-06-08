namespace Edward_JeuFinale
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.ball = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.hoop = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(92)))));
            this.ball.BackgroundImage = global::Edward_JeuFinale.Properties.Resources.small_basketball;
            this.ball.Location = new System.Drawing.Point(303, 441);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(32, 32);
            this.ball.TabIndex = 4;
            this.ball.TabStop = false;
            this.ball.Tag = "ball";
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.BackgroundImage = global::Edward_JeuFinale.Properties.Resources.greensmall_Jalenbrunsonsprite;
            this.Player.Location = new System.Drawing.Point(223, 399);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(60, 74);
            this.Player.TabIndex = 3;
            this.Player.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(67, 479);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(359, 58);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "platform";
            // 
            // hoop
            // 
            this.hoop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(92)))));
            this.hoop.BackgroundImage = global::Edward_JeuFinale.Properties.Resources.basketballhoop1;
            this.hoop.Location = new System.Drawing.Point(783, 247);
            this.hoop.Name = "hoop";
            this.hoop.Size = new System.Drawing.Size(137, 154);
            this.hoop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.hoop.TabIndex = 1;
            this.hoop.TabStop = false;
            this.hoop.Tag = "hoop";
            // 
            // background
            // 
            this.background.BackgroundImage = global::Edward_JeuFinale.Properties.Resources.small_cavebackgroundlevel1;
            this.background.Location = new System.Drawing.Point(-350, -720);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(6400, 2500);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            this.background.Click += new System.EventHandler(this.background_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.hoop);
            this.Controls.Add(this.background);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Jeu Basket";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.PictureBox hoop;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer gameTimer;
    }
}

