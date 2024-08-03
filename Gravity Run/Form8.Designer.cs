namespace Gravity_Run
{
    partial class Form8
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
            label2 = new Label();
            ok = new Button();
            back = new Button();
            exit = new Button();
            del = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(87, 9);
            label1.Name = "label1";
            label1.Size = new Size(254, 37);
            label1.TabIndex = 0;
            label1.Text = "Ваши сохранения";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(407, 121);
            label2.TabIndex = 1;
            // 
            // ok
            // 
            ok.BackColor = Color.Transparent;
            ok.FlatStyle = FlatStyle.Flat;
            ok.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ok.ForeColor = Color.White;
            ok.Location = new Point(12, 204);
            ok.Name = "ok";
            ok.Size = new Size(407, 32);
            ok.TabIndex = 0;
            ok.Text = "Загрузить";
            ok.UseVisualStyleBackColor = false;
            ok.Click += ok_Click;
            ok.Enter += ok_Enter;
            ok.Leave += ok_Leave;
            ok.MouseEnter += ok_Enter;
            ok.MouseLeave += ok_Leave;
            // 
            // back
            // 
            back.BackColor = Color.Transparent;
            back.FlatStyle = FlatStyle.Flat;
            back.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            back.ForeColor = Color.White;
            back.Location = new Point(12, 308);
            back.Name = "back";
            back.Size = new Size(407, 32);
            back.TabIndex = 2;
            back.Text = "Назад";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            back.Enter += back_Enter;
            back.Leave += back_Leave;
            back.MouseEnter += back_Enter;
            back.MouseLeave += back_Leave;
            // 
            // exit
            // 
            exit.BackColor = Color.Transparent;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            exit.ForeColor = Color.White;
            exit.Location = new Point(12, 360);
            exit.Name = "exit";
            exit.Size = new Size(407, 32);
            exit.TabIndex = 3;
            exit.Text = "Выход";
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            exit.Enter += exit_Enter;
            exit.Leave += exit_Leave;
            exit.MouseEnter += exit_Enter;
            exit.MouseLeave += exit_Leave;
            // 
            // del
            // 
            del.BackColor = Color.Transparent;
            del.FlatStyle = FlatStyle.Flat;
            del.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            del.ForeColor = Color.White;
            del.Location = new Point(12, 256);
            del.Name = "del";
            del.Size = new Size(407, 32);
            del.TabIndex = 1;
            del.Text = "Удалить сохранение";
            del.UseVisualStyleBackColor = false;
            del.Click += del_Click;
            del.Enter += del_Enter;
            del.Leave += del_Leave;
            del.MouseEnter += del_Enter;
            del.MouseLeave += del_Leave;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.forms;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(431, 419);
            Controls.Add(del);
            Controls.Add(exit);
            Controls.Add(back);
            Controls.Add(ok);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Form8";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Сохранения";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button ok;
        private Button back;
        private Button exit;
        private Button del;
    }
}