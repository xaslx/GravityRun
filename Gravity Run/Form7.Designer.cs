namespace Gravity_Run
{
    partial class Form7
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
            cont = new Button();
            save = new Button();
            exit = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // cont
            // 
            cont.BackColor = Color.Transparent;
            cont.FlatStyle = FlatStyle.Flat;
            cont.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cont.ForeColor = Color.White;
            cont.Location = new Point(49, 94);
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
            // save
            // 
            save.BackColor = Color.Transparent;
            save.FlatStyle = FlatStyle.Flat;
            save.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            save.ForeColor = Color.White;
            save.Location = new Point(49, 146);
            save.Name = "save";
            save.Size = new Size(188, 32);
            save.TabIndex = 1;
            save.Text = "Сохранить";
            save.UseVisualStyleBackColor = false;
            save.Click += save_Click;
            save.Enter += save_Enter;
            save.Leave += save_Leave;
            save.MouseEnter += save_Enter;
            save.MouseLeave += save_Leave;
            // 
            // exit
            // 
            exit.BackColor = Color.Transparent;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            exit.ForeColor = Color.White;
            exit.Location = new Point(49, 198);
            exit.Name = "exit";
            exit.Size = new Size(188, 32);
            exit.TabIndex = 2;
            exit.Text = "Выход";
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            exit.Enter += exit_Enter;
            exit.Leave += exit_Leave;
            exit.MouseEnter += exit_Enter;
            exit.MouseLeave += exit_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(71, 22);
            label1.Name = "label1";
            label1.Size = new Size(136, 30);
            label1.TabIndex = 3;
            label1.Text = "Сохранение";
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources.forms;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(297, 255);
            Controls.Add(label1);
            Controls.Add(exit);
            Controls.Add(save);
            Controls.Add(cont);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Form7";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Сохранения";
            KeyUp += Form7_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cont;
        private Button save;
        private Button exit;
        private Label label1;
    }
}