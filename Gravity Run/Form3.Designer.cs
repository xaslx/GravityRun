namespace Gravity_Run
{
    partial class Form3
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
            label1 = new Label();
            menu = new Button();
            settings = new Button();
            exit = new Button();
            cont = new Button();
            new_game = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(148, 9);
            label1.Name = "label1";
            label1.Size = new Size(147, 43);
            label1.TabIndex = 1;
            label1.Text = "ПАУЗА";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menu
            // 
            menu.BackColor = Color.Transparent;
            menu.FlatStyle = FlatStyle.Flat;
            menu.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            menu.ForeColor = Color.White;
            menu.Location = new Point(131, 169);
            menu.Name = "menu";
            menu.Size = new Size(188, 32);
            menu.TabIndex = 2;
            menu.Text = "Главное меню";
            menu.UseVisualStyleBackColor = false;
            menu.Click += menu_Click;
            menu.Enter += menu_Enter;
            menu.Leave += menu_Leave;
            menu.MouseEnter += menu_Enter;
            menu.MouseLeave += menu_Leave;
            // 
            // settings
            // 
            settings.BackColor = Color.Transparent;
            settings.FlatStyle = FlatStyle.Flat;
            settings.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            settings.ForeColor = Color.White;
            settings.Location = new Point(131, 221);
            settings.Name = "settings";
            settings.Size = new Size(188, 32);
            settings.TabIndex = 3;
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
            exit.Location = new Point(131, 273);
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
            // cont
            // 
            cont.BackColor = Color.Transparent;
            cont.FlatStyle = FlatStyle.Flat;
            cont.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cont.ForeColor = Color.White;
            cont.Location = new Point(131, 65);
            cont.Name = "cont";
            cont.Size = new Size(188, 32);
            cont.TabIndex = 0;
            cont.Text = "Продолжить";
            cont.UseVisualStyleBackColor = false;
            cont.Click += cont_Click;
            cont.Enter += cont_Enter;
            cont.Leave += cont_Leave;
            cont.MouseEnter += cont_Enter;
            cont.MouseLeave += cont_Leave;
            // 
            // new_game
            // 
            new_game.BackColor = Color.Transparent;
            new_game.FlatStyle = FlatStyle.Flat;
            new_game.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            new_game.ForeColor = Color.White;
            new_game.Location = new Point(131, 117);
            new_game.Name = "new_game";
            new_game.Size = new Size(188, 32);
            new_game.TabIndex = 1;
            new_game.Text = "Новая игра";
            new_game.UseVisualStyleBackColor = false;
            new_game.Click += new_game_Click;
            new_game.Enter += new_game_Enter;
            new_game.Leave += new_game_Leave;
            new_game.MouseEnter += new_game_Enter;
            new_game.MouseLeave += new_game_Leave;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.forms;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(442, 328);
            Controls.Add(new_game);
            Controls.Add(cont);
            Controls.Add(exit);
            Controls.Add(settings);
            Controls.Add(menu);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Пауза";
            KeyUp += Form3_KeyUp;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button menu;
        private Button settings;
        private Button exit;
        private Button cont;
        private Button new_game;
    }
}