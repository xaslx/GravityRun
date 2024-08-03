namespace Gravity_Run
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            player = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            lblScore = new Label();
            lblHighScore = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            lblTime = new Label();
            gameTimerSeconds = new System.Windows.Forms.Timer(components);
            lblLives = new Label();
            help2 = new Label();
            help1 = new Label();
            help_timer = new System.Windows.Forms.Timer(components);
            help3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.platform_tilesblue;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.platform_tilesblue;
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // player
            // 
            player.BackColor = Color.Transparent;
            player.Image = Properties.Resources.run_down0;
            resources.ApplyResources(player, "player");
            player.Name = "player";
            player.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.box;
            resources.ApplyResources(pictureBox3, "pictureBox3");
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "obstacle";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.box;
            resources.ApplyResources(pictureBox4, "pictureBox4");
            pictureBox4.Name = "pictureBox4";
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "obstacle";
            // 
            // lblScore
            // 
            resources.ApplyResources(lblScore, "lblScore");
            lblScore.BackColor = Color.Transparent;
            lblScore.ForeColor = Color.White;
            lblScore.Name = "lblScore";
            // 
            // lblHighScore
            // 
            resources.ApplyResources(lblHighScore, "lblHighScore");
            lblHighScore.BackColor = Color.Transparent;
            lblHighScore.ForeColor = Color.White;
            lblHighScore.Name = "lblHighScore";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += GameTimerEvent;
            // 
            // lblTime
            // 
            resources.ApplyResources(lblTime, "lblTime");
            lblTime.BackColor = Color.Transparent;
            lblTime.ForeColor = Color.White;
            lblTime.Name = "lblTime";
            // 
            // gameTimerSeconds
            // 
            gameTimerSeconds.Enabled = true;
            gameTimerSeconds.Interval = 1000;
            gameTimerSeconds.Tick += gameTimerSeconds_Tick;
            // 
            // lblLives
            // 
            resources.ApplyResources(lblLives, "lblLives");
            lblLives.BackColor = Color.Transparent;
            lblLives.ForeColor = Color.Transparent;
            lblLives.Name = "lblLives";
            // 
            // help2
            // 
            resources.ApplyResources(help2, "help2");
            help2.BackColor = Color.Transparent;
            help2.ForeColor = Color.White;
            help2.Name = "help2";
            // 
            // help1
            // 
            resources.ApplyResources(help1, "help1");
            help1.BackColor = Color.Transparent;
            help1.ForeColor = Color.White;
            help1.Name = "help1";
            // 
            // help_timer
            // 
            help_timer.Interval = 3000;
            help_timer.Tick += help_timer_Tick;
            // 
            // help3
            // 
            resources.ApplyResources(help3, "help3");
            help3.BackColor = Color.Transparent;
            help3.ForeColor = Color.White;
            help3.Name = "help3";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_still;
            Controls.Add(help3);
            Controls.Add(help1);
            Controls.Add(help2);
            Controls.Add(lblLives);
            Controls.Add(lblTime);
            Controls.Add(lblHighScore);
            Controls.Add(lblScore);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(player);
            Controls.Add(pictureBox3);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox player;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label lblScore;
        private Label lblHighScore;
        private System.Windows.Forms.Timer gameTimer;
        private Label lblTime;
        private System.Windows.Forms.Timer GamerTimerSeconds;
        private System.Windows.Forms.Timer gameTimerSeconds;
        private Label lblLives;
        private Label help2;
        private Label help1;
        private System.Windows.Forms.Timer help_timer;
        private Label help3;
    }
}
