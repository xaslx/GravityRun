namespace Gravity_Run
{
    partial class Form5
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
            new_game = new Button();
            menu = new Button();
            exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(67, 12);
            label1.Name = "label1";
            label1.Size = new Size(289, 83);
            label1.TabIndex = 1;
            label1.Text = "Вы проиграли";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // new_game
            // 
            new_game.BackColor = Color.Transparent;
            new_game.FlatStyle = FlatStyle.Flat;
            new_game.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            new_game.ForeColor = Color.White;
            new_game.Location = new Point(101, 113);
            new_game.Margin = new Padding(3, 4, 3, 4);
            new_game.Name = "new_game";
            new_game.Size = new Size(215, 43);
            new_game.TabIndex = 1;
            new_game.Text = "Новая игра";
            new_game.UseVisualStyleBackColor = false;
            new_game.Click += new_game_Click;
            new_game.Enter += new_game_Enter;
            new_game.Leave += new_game_Leave;
            new_game.MouseEnter += new_game_Enter;
            new_game.MouseLeave += new_game_Leave;
            // 
            // menu
            // 
            menu.BackColor = Color.Transparent;
            menu.FlatStyle = FlatStyle.Flat;
            menu.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            menu.ForeColor = Color.White;
            menu.Location = new Point(101, 176);
            menu.Margin = new Padding(3, 4, 3, 4);
            menu.Name = "menu";
            menu.Size = new Size(215, 43);
            menu.TabIndex = 2;
            menu.Text = "Главное меню";
            menu.UseVisualStyleBackColor = false;
            menu.Click += menu_Click;
            menu.Enter += menu_Enter;
            menu.Leave += menu_Leave;
            menu.MouseEnter += menu_Enter;
            menu.MouseLeave += menu_Leave;
            // 
            // exit
            // 
            exit.BackColor = Color.Transparent;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            exit.ForeColor = Color.White;
            exit.Location = new Point(101, 239);
            exit.Margin = new Padding(3, 4, 3, 4);
            exit.Name = "exit";
            exit.Size = new Size(215, 43);
            exit.TabIndex = 3;
            exit.Text = "Выход";
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            exit.Enter += exit_Enter;
            exit.Leave += exit_Leave;
            exit.MouseEnter += exit_Enter;
            exit.MouseLeave += exit_Leave;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.forms;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(426, 307);
            Controls.Add(exit);
            Controls.Add(menu);
            Controls.Add(new_game);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Результат";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button new_game;
        private Button menu;
        private Button exit;
    }
}