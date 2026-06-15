namespace Edward_JeuFinale
{
    partial class Level3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level3));
            this.dribbleTimer = new System.Windows.Forms.Timer(this.components);
            this.feedbackTimer = new System.Windows.Forms.Timer(this.components);
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.retroactionTir = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.ballSpawnPlatform = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.rimBounds = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.hoop = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballSpawnPlatform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rimBounds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // dribbleTimer
            // 
            this.dribbleTimer.Interval = 750;
            // 
            // feedbackTimer
            // 
            this.feedbackTimer.Interval = 1600;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.retroactionTir);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(330, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 86);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "retroaction";
            this.groupBox1.Visible = false;
            // 
            // retroactionTir
            // 
            this.retroactionTir.AutoSize = true;
            this.retroactionTir.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retroactionTir.ForeColor = System.Drawing.Color.Green;
            this.retroactionTir.Location = new System.Drawing.Point(41, 42);
            this.retroactionTir.Name = "retroactionTir";
            this.retroactionTir.Size = new System.Drawing.Size(96, 23);
            this.retroactionTir.TabIndex = 1;
            this.retroactionTir.Tag = "retroaction";
            this.retroactionTir.Text = "EXCELLENT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 26);
            this.label1.TabIndex = 0;
            this.label1.Tag = "retroaction";
            this.label1.Text = "Retroaction de tir:";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.IndianRed;
            this.pictureBox10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox10.BackgroundImage")));
            this.pictureBox10.Location = new System.Drawing.Point(994, 179);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(126, 508);
            this.pictureBox10.TabIndex = 25;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "lava";
            // 
            // ballSpawnPlatform
            // 
            this.ballSpawnPlatform.Location = new System.Drawing.Point(237, 315);
            this.ballSpawnPlatform.Name = "ballSpawnPlatform";
            this.ballSpawnPlatform.Size = new System.Drawing.Size(359, 10);
            this.ballSpawnPlatform.TabIndex = 24;
            this.ballSpawnPlatform.TabStop = false;
            this.ballSpawnPlatform.Tag = "platform";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox3.Location = new System.Drawing.Point(237, 331);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(359, 58);
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "wall";
            // 
            // rimBounds
            // 
            this.rimBounds.BackColor = System.Drawing.Color.SandyBrown;
            this.rimBounds.Location = new System.Drawing.Point(654, 138);
            this.rimBounds.Name = "rimBounds";
            this.rimBounds.Size = new System.Drawing.Size(61, 20);
            this.rimBounds.TabIndex = 21;
            this.rimBounds.TabStop = false;
            this.rimBounds.Tag = "rimBounds";
            this.rimBounds.Visible = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(92)))));
            this.ball.BackgroundImage = global::Edward_JeuFinale.Properties.Resources.small_basketball;
            this.ball.Location = new System.Drawing.Point(273, 277);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(32, 32);
            this.ball.TabIndex = 20;
            this.ball.TabStop = false;
            this.ball.Tag = "ball";
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(65)))));
            this.Player.BackgroundImage = global::Edward_JeuFinale.Properties.Resources.bsmall_Jalenbrunsonsprite;
            this.Player.Location = new System.Drawing.Point(341, 483);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(52, 74);
            this.Player.TabIndex = 19;
            this.Player.TabStop = false;
            // 
            // hoop
            // 
            this.hoop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(156)))), ((int)(((byte)(238)))));
            this.hoop.BackgroundImage = global::Edward_JeuFinale.Properties.Resources.basketballhoop1;
            this.hoop.Location = new System.Drawing.Point(627, 45);
            this.hoop.Name = "hoop";
            this.hoop.Size = new System.Drawing.Size(137, 154);
            this.hoop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.hoop.TabIndex = 18;
            this.hoop.TabStop = false;
            this.hoop.Tag = "hoop";
            // 
            // background
            // 
            this.background.BackgroundImage = global::Edward_JeuFinale.Properties.Resources.ChatGPT_Image_Jun_1__2026__08_16_55_AM;
            this.background.Location = new System.Drawing.Point(-2153, -880);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(6400, 2500);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.background.TabIndex = 26;
            this.background.TabStop = false;
            // 
            // Level3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 733);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.ballSpawnPlatform);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.rimBounds);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.hoop);
            this.Controls.Add(this.background);
            this.Name = "Level3";
            this.Text = "Level3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballSpawnPlatform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rimBounds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer dribbleTimer;
        private System.Windows.Forms.Timer feedbackTimer;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label retroactionTir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox ballSpawnPlatform;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox rimBounds;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox hoop;
        private System.Windows.Forms.PictureBox background;
    }
}