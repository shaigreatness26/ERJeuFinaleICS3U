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
            this.rimBounds = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.retroactionTir = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.feedbackTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rimBounds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
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
            this.Player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(92)))));
            this.Player.BackgroundImage = global::Edward_JeuFinale.Properties.Resources.small_Jalenbrunsonsprite;
            this.Player.Location = new System.Drawing.Point(146, 399);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(60, 74);
            this.Player.TabIndex = 3;
            this.Player.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(43, 479);
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
            this.hoop.Location = new System.Drawing.Point(1008, 76);
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
            // 
            // rimBounds
            // 
            this.rimBounds.Location = new System.Drawing.Point(1035, 169);
            this.rimBounds.Name = "rimBounds";
            this.rimBounds.Size = new System.Drawing.Size(61, 20);
            this.rimBounds.TabIndex = 5;
            this.rimBounds.TabStop = false;
            this.rimBounds.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(561, 479);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 58);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "platform";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(92)))));
            this.groupBox1.Controls.Add(this.retroactionTir);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(484, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 86);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // retroactionTir
            // 
            this.retroactionTir.AutoSize = true;
            this.retroactionTir.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retroactionTir.ForeColor = System.Drawing.Color.Green;
            this.retroactionTir.Location = new System.Drawing.Point(52, 42);
            this.retroactionTir.Name = "retroactionTir";
            this.retroactionTir.Size = new System.Drawing.Size(77, 23);
            this.retroactionTir.TabIndex = 1;
            this.retroactionTir.Text = "PARFAIT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Retroaction de tir:";
            // 
            // feedbackTimer
            // 
            this.feedbackTimer.Interval = 1600;
            this.feedbackTimer.Tick += new System.EventHandler(this.feedbackTimer_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox3.Location = new System.Drawing.Point(43, 309);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(359, 58);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "wall";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(43, 282);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(359, 10);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "platform";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 681);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rimBounds);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.hoop);
            this.Controls.Add(this.background);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Jeu Basket";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rimBounds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
        private System.Windows.Forms.PictureBox rimBounds;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label retroactionTir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer feedbackTimer;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

