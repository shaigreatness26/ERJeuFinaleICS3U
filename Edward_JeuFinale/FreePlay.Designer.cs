namespace Edward_JeuFinale
{
    partial class FreePlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FreePlay));
            this.rimBounds = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.feedbackTimer = new System.Windows.Forms.Timer(this.components);
            this.dribbleTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.retroactionTir = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.spawnPlatform = new System.Windows.Forms.PictureBox();
            this.hoop = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.durationTir = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.midrangeBounds = new System.Windows.Forms.PictureBox();
            this.fourPointBounds = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rimBounds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spawnPlatform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midrangeBounds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourPointBounds)).BeginInit();
            this.SuspendLayout();
            // 
            // rimBounds
            // 
            this.rimBounds.BackColor = System.Drawing.Color.SandyBrown;
            this.rimBounds.Location = new System.Drawing.Point(1714, 328);
            this.rimBounds.Name = "rimBounds";
            this.rimBounds.Size = new System.Drawing.Size(61, 20);
            this.rimBounds.TabIndex = 8;
            this.rimBounds.TabStop = false;
            this.rimBounds.Tag = "rimBounds";
            this.rimBounds.Visible = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Black;
            this.ball.BackgroundImage = global::Edward_JeuFinale.Properties.Resources.small_basketball;
            this.ball.Location = new System.Drawing.Point(800, 550);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(32, 32);
            this.ball.TabIndex = 7;
            this.ball.TabStop = false;
            this.ball.Tag = "ball";
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Black;
            this.Player.BackgroundImage = global::Edward_JeuFinale.Properties.Resources.bsmall_Jalenbrunsonsprite;
            this.Player.Location = new System.Drawing.Point(522, 526);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(60, 74);
            this.Player.TabIndex = 6;
            this.Player.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // feedbackTimer
            // 
            this.feedbackTimer.Interval = 1600;
            this.feedbackTimer.Tick += new System.EventHandler(this.feedbackTimer_Tick);
            // 
            // dribbleTimer
            // 
            this.dribbleTimer.Tick += new System.EventHandler(this.dribbleTimer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.durationTir);
            this.groupBox1.Controls.Add(this.retroactionTir);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(723, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 100);
            this.groupBox1.TabIndex = 9;
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
            // spawnPlatform
            // 
            this.spawnPlatform.Location = new System.Drawing.Point(-10, 606);
            this.spawnPlatform.Name = "spawnPlatform";
            this.spawnPlatform.Size = new System.Drawing.Size(1922, 11);
            this.spawnPlatform.TabIndex = 10;
            this.spawnPlatform.TabStop = false;
            this.spawnPlatform.Tag = "platform";
            // 
            // hoop
            // 
            this.hoop.BackColor = System.Drawing.Color.Black;
            this.hoop.BackgroundImage = global::Edward_JeuFinale.Properties.Resources.basketballhoop1;
            this.hoop.Location = new System.Drawing.Point(1685, 239);
            this.hoop.Name = "hoop";
            this.hoop.Size = new System.Drawing.Size(137, 154);
            this.hoop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.hoop.TabIndex = 11;
            this.hoop.TabStop = false;
            this.hoop.Tag = "hoop";
            this.hoop.Visible = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.IndianRed;
            this.pictureBox12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox12.BackgroundImage")));
            this.pictureBox12.Location = new System.Drawing.Point(1898, -168);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(53, 1074);
            this.pictureBox12.TabIndex = 21;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "lava";
            this.pictureBox12.Visible = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.IndianRed;
            this.pictureBox14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox14.BackgroundImage")));
            this.pictureBox14.Location = new System.Drawing.Point(-10, 680);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(1922, 43);
            this.pictureBox14.TabIndex = 23;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Tag = "lava";
            this.pictureBox14.Visible = false;
            // 
            // durationTir
            // 
            this.durationTir.AutoSize = true;
            this.durationTir.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationTir.ForeColor = System.Drawing.Color.Aqua;
            this.durationTir.Location = new System.Drawing.Point(64, 65);
            this.durationTir.Name = "durationTir";
            this.durationTir.Size = new System.Drawing.Size(51, 23);
            this.durationTir.TabIndex = 3;
            this.durationTir.Tag = "retroaction";
            this.durationTir.Text = "_ Ms";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(662, 182);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(35, 13);
            this.scoreLabel.TabIndex = 24;
            this.scoreLabel.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.pictureBox1.Location = new System.Drawing.Point(650, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 42);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(641, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 54);
            this.label2.TabIndex = 26;
            this.label2.Text = "00";
            // 
            // midrangeBounds
            // 
            this.midrangeBounds.Location = new System.Drawing.Point(1223, 424);
            this.midrangeBounds.Name = "midrangeBounds";
            this.midrangeBounds.Size = new System.Drawing.Size(669, 250);
            this.midrangeBounds.TabIndex = 27;
            this.midrangeBounds.TabStop = false;
            this.midrangeBounds.Visible = false;
            // 
            // fourPointBounds
            // 
            this.fourPointBounds.Location = new System.Drawing.Point(-268, 424);
            this.fourPointBounds.Name = "fourPointBounds";
            this.fourPointBounds.Size = new System.Drawing.Size(669, 250);
            this.fourPointBounds.TabIndex = 28;
            this.fourPointBounds.TabStop = false;
            this.fourPointBounds.Visible = false;
            // 
            // FreePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Edward_JeuFinale.Properties.Resources.ChatGPT_Image_Jun_15__2026__05_39_43_PM;
            this.ClientSize = new System.Drawing.Size(1924, 774);
            this.Controls.Add(this.fourPointBounds);
            this.Controls.Add(this.midrangeBounds);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.spawnPlatform);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rimBounds);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.hoop);
            this.Name = "FreePlay";
            this.Text = "FreePlay";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FreePlay_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FreePlay_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.rimBounds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spawnPlatform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midrangeBounds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourPointBounds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox rimBounds;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer feedbackTimer;
        private System.Windows.Forms.Timer dribbleTimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label retroactionTir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox spawnPlatform;
        private System.Windows.Forms.PictureBox hoop;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.Label durationTir;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox midrangeBounds;
        private System.Windows.Forms.PictureBox fourPointBounds;
    }
}