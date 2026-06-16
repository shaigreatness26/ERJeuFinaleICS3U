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
            this.dribbleTimer = new System.Windows.Forms.Timer(this.components);
            this.feedbackTimer = new System.Windows.Forms.Timer(this.components);
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.retroactionTir = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.canonTimer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.canon1 = new System.Windows.Forms.PictureBox();
            this.spawnPlatform = new System.Windows.Forms.PictureBox();
            this.ballSpawnPlatform = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.rimBounds = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.hoop = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spawnPlatform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballSpawnPlatform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rimBounds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.SuspendLayout();
            // 
            // dribbleTimer
            // 
            this.dribbleTimer.Interval = 750;
            this.dribbleTimer.Tick += new System.EventHandler(this.dribbleTimer_Tick);
            // 
            // feedbackTimer
            // 
            this.feedbackTimer.Interval = 1600;
            this.feedbackTimer.Tick += new System.EventHandler(this.feedbackTimer_Tick);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
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
            // canonTimer
            // 
            this.canonTimer.Interval = 3000;
            this.canonTimer.Tick += new System.EventHandler(this.canonTimer_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1004, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 21);
            this.label3.TabIndex = 34;
            this.label3.Text = "Nombre de morts :";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Edward_JeuFinale.Properties.Resources.bullet1;
            this.pictureBox4.Location = new System.Drawing.Point(820, 503);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(13, 14);
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            // 
            // canon1
            // 
            this.canon1.BackgroundImage = global::Edward_JeuFinale.Properties.Resources.cannonLeft1;
            this.canon1.Location = new System.Drawing.Point(820, 500);
            this.canon1.Name = "canon1";
            this.canon1.Size = new System.Drawing.Size(110, 57);
            this.canon1.TabIndex = 28;
            this.canon1.TabStop = false;
            this.canon1.Tag = "canon";
            // 
            // spawnPlatform
            // 
            this.spawnPlatform.Location = new System.Drawing.Point(127, 563);
            this.spawnPlatform.Name = "spawnPlatform";
            this.spawnPlatform.Size = new System.Drawing.Size(1175, 10);
            this.spawnPlatform.TabIndex = 27;
            this.spawnPlatform.TabStop = false;
            this.spawnPlatform.Tag = "platform";
            // 
            // ballSpawnPlatform
            // 
            this.ballSpawnPlatform.Location = new System.Drawing.Point(237, 315);
            this.ballSpawnPlatform.Name = "ballSpawnPlatform";
            this.ballSpawnPlatform.Size = new System.Drawing.Size(388, 10);
            this.ballSpawnPlatform.TabIndex = 24;
            this.ballSpawnPlatform.TabStop = false;
            this.ballSpawnPlatform.Tag = "platform";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox3.Location = new System.Drawing.Point(150, 324);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(651, 33);
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
            this.ball.Location = new System.Drawing.Point(1249, 525);
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
            this.Player.Location = new System.Drawing.Point(415, 483);
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(803, 483);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 10);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "platform";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(273, 503);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 70);
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "wall";
            // 
            // pictureBox21
            // 
            this.pictureBox21.BackColor = System.Drawing.Color.IndianRed;
            this.pictureBox21.BackgroundImage = global::Edward_JeuFinale.Properties.Resources.lava;
            this.pictureBox21.Location = new System.Drawing.Point(591, 552);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(49, 13);
            this.pictureBox21.TabIndex = 42;
            this.pictureBox21.TabStop = false;
            this.pictureBox21.Tag = "lava";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.IndianRed;
            this.pictureBox5.BackgroundImage = global::Edward_JeuFinale.Properties.Resources.lava;
            this.pictureBox5.Location = new System.Drawing.Point(843, 479);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(49, 13);
            this.pictureBox5.TabIndex = 43;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "lava";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.IndianRed;
            this.pictureBox6.BackgroundImage = global::Edward_JeuFinale.Properties.Resources.lava;
            this.pictureBox6.Location = new System.Drawing.Point(678, 383);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(49, 13);
            this.pictureBox6.TabIndex = 44;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "lava";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(1103, 441);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(127, 10);
            this.pictureBox7.TabIndex = 45;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "platform";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.IndianRed;
            this.pictureBox8.BackgroundImage = global::Edward_JeuFinale.Properties.Resources.lava;
            this.pictureBox8.Location = new System.Drawing.Point(1162, 438);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(49, 13);
            this.pictureBox8.TabIndex = 46;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "lava";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(1072, 337);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(127, 10);
            this.pictureBox9.TabIndex = 47;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "platform";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox10.Location = new System.Drawing.Point(1103, 457);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(148, 22);
            this.pictureBox10.TabIndex = 48;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "wall";
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox11.Location = new System.Drawing.Point(922, 237);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(61, 88);
            this.pictureBox11.TabIndex = 49;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "wall";
            // 
            // pictureBox12
            // 
            this.pictureBox12.Location = new System.Drawing.Point(935, 229);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(34, 10);
            this.pictureBox12.TabIndex = 50;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "platform";
            // 
            // Level3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 733);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox21);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.canon1);
            this.Controls.Add(this.spawnPlatform);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ballSpawnPlatform);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.rimBounds);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.hoop);
            this.Controls.Add(this.background);
            this.Name = "Level3";
            this.Text = "Level3";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Level2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Level2_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spawnPlatform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballSpawnPlatform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rimBounds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
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
        private System.Windows.Forms.PictureBox ballSpawnPlatform;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox rimBounds;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox hoop;
        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.PictureBox spawnPlatform;
        private System.Windows.Forms.PictureBox canon1;
        private System.Windows.Forms.Timer canonTimer;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
    }
}