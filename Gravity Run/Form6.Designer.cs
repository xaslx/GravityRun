namespace Gravity_Run
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            exit = new Button();
            menu = new Button();
            reset = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // exit
            // 
            exit.BackColor = Color.Transparent;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            exit.ForeColor = Color.White;
            exit.Location = new Point(603, 601);
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
            // menu
            // 
            menu.BackColor = Color.Transparent;
            menu.FlatStyle = FlatStyle.Flat;
            menu.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            menu.ForeColor = Color.White;
            menu.Location = new Point(14, 601);
            menu.Margin = new Padding(3, 4, 3, 4);
            menu.Name = "menu";
            menu.Size = new Size(215, 43);
            menu.TabIndex = 0;
            menu.Text = "Главное меню";
            menu.UseVisualStyleBackColor = false;
            menu.Click += menu_Click;
            menu.Enter += menu_Enter;
            menu.Leave += menu_Leave;
            menu.MouseEnter += menu_Enter;
            menu.MouseLeave += menu_Leave;
            // 
            // reset
            // 
            reset.BackColor = Color.Transparent;
            reset.FlatStyle = FlatStyle.Flat;
            reset.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            reset.ForeColor = Color.White;
            reset.Location = new Point(309, 601);
            reset.Margin = new Padding(3, 4, 3, 4);
            reset.Name = "reset";
            reset.Size = new Size(215, 43);
            reset.TabIndex = 1;
            reset.Text = "Сброс";
            reset.UseVisualStyleBackColor = false;
            reset.Click += reset_Click;
            reset.Enter += reset_Enter;
            reset.Leave += reset_Leave;
            reset.MouseEnter += reset_Enter;
            reset.MouseLeave += reset_Leave;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Black;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.ForeColor = Color.Lime;
            textBox1.Location = new Point(14, 16);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(804, 549);
            textBox1.TabIndex = 4;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_still;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(832, 681);
            Controls.Add(textBox1);
            Controls.Add(reset);
            Controls.Add(menu);
            Controls.Add(exit);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Статистика";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exit;
        private Button menu;
        private Button reset;
        private TextBox textBox1;
    }
}