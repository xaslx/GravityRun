namespace Gravity_Run
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            play = new Button();
            statistics = new Button();
            settings = new Button();
            exit = new Button();
            save = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(308, 74);
            label1.Name = "label1";
            label1.Size = new Size(188, 98);
            label1.TabIndex = 0;
            label1.Text = "Gravity Run";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.run_down0;
            pictureBox1.Location = new Point(358, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // play
            // 
            play.BackColor = Color.Transparent;
            play.FlatStyle = FlatStyle.Flat;
            play.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            play.ForeColor = Color.White;
            play.Location = new Point(308, 199);
            play.Name = "play";
            play.Size = new Size(188, 32);
            play.TabIndex = 0;
            play.Text = "Играть";
            play.UseVisualStyleBackColor = false;
            play.Click += play_Click;
            play.Enter += play_Enter;
            play.Leave += play_Leave;
            play.MouseEnter += play_Enter;
            play.MouseLeave += play_Leave;
            // 
            // statistics
            // 
            statistics.BackColor = Color.Transparent;
            statistics.FlatStyle = FlatStyle.Flat;
            statistics.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            statistics.ForeColor = Color.White;
            statistics.Location = new Point(308, 355);
            statistics.Name = "statistics";
            statistics.Size = new Size(188, 32);
            statistics.TabIndex = 3;
            statistics.Text = "Статистика";
            statistics.UseVisualStyleBackColor = false;
            statistics.Click += statistics_Click;
            statistics.Enter += statistics_Enter;
            statistics.Leave += statistics_Leave;
            statistics.MouseEnter += statistics_Enter;
            statistics.MouseLeave += statistics_Leave;
            // 
            // settings
            // 
            settings.BackColor = Color.Transparent;
            settings.FlatStyle = FlatStyle.Flat;
            settings.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            settings.ForeColor = Color.White;
            settings.Location = new Point(308, 303);
            settings.Name = "settings";
            settings.Size = new Size(188, 32);
            settings.TabIndex = 2;
            settings.Text = "Настройки";
            settings.UseVisualStyleBackColor = false;
            settings.Click += settings_Click;
            settings.Enter += settings_Enter;
            settings.Leave += settings_Leave;
            settings.MouseEnter += settings_Enter;
            settings.MouseLeave += settings_Leave;
            // 
            // exit
            // 
            exit.BackColor = Color.Transparent;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            exit.ForeColor = Color.White;
            exit.Location = new Point(308, 407);
            exit.Name = "exit";
            exit.Size = new Size(188, 32);
            exit.TabIndex = 4;
            exit.Text = "Выход";
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            exit.Enter += exit_Enter;
            exit.Leave += exit_Leave;
            exit.MouseEnter += exit_Enter;
            exit.MouseLeave += exit_Leave;
            // 
            // save
            // 
            save.BackColor = Color.Transparent;
            save.FlatStyle = FlatStyle.Flat;
            save.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            save.ForeColor = Color.White;
            save.Location = new Point(308, 251);
            save.Name = "save";
            save.Size = new Size(188, 32);
            save.TabIndex = 1;
            save.Text = "Сохранения";
            save.UseVisualStyleBackColor = false;
            save.Click += save_Click;
            save.Enter += save_Enter;
            save.Leave += save_Leave;
            save.MouseEnter += save_Enter;
            save.MouseLeave += save_Leave;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_still;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(798, 456);
            Controls.Add(save);
            Controls.Add(exit);
            Controls.Add(settings);
            Controls.Add(statistics);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(play);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gravity Run";
            FormClosed += Form2_FormClosed;
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button play;
        private Button statistics;
        private Button settings;
        private Button exit;
        private Button save;
    }
}