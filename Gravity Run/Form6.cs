using System;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gravity_Run
{
    public partial class Form6 : Form
    {
        Color originalForeColor;
        public Form6()
        {
            InitializeComponent();

            //Выключаем стандартные эффекты у кнопок, при нажатии мышки и наведении мышки
            menu.FlatAppearance.MouseOverBackColor = menu.BackColor;
            reset.FlatAppearance.MouseOverBackColor = reset.BackColor;
            exit.FlatAppearance.MouseOverBackColor = exit.BackColor;

            menu.FlatAppearance.MouseDownBackColor = menu.BackColor;
            reset.FlatAppearance.MouseDownBackColor = reset.BackColor;
            exit.FlatAppearance.MouseDownBackColor = exit.BackColor;

            
            //вызывает метод при открытии формы
            DisplayTextFromFile();

            //проверка при открытии формы, если установлен такой текст то выключаем кнопку
            if (textBox1.Text == "Пока нет статистики...")
            {
                reset.Enabled = false;
            }

            //убираем элементы управления формы
            this.ControlBox = false;

            
            originalForeColor = menu.ForeColor;

        }


        //закрываем программу
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void DisplayTextFromFile()
        {
            string filePath = "stats.txt"; //путь к файлу

            if (File.Exists(filePath))
            {
                string textContent = File.ReadAllText(filePath);

                //отображение текста из файла через textBox
                textBox1.Text = textContent;
            }
            else
            {
                textBox1.Text = "Пока нет статистики...";
            }
        }

        //при нажатии на кнопку Главное меню
        private void menu_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр Form2
            Form2 menu = new Form2();

            //закрываем текущую форму
            this.Close();

            //открываем форму 2
            menu.Show();
        }

        /*
        события для всех кнопок, при наведении на кнопку с помощью мышки или стрелок, меняет цвет,
        и потом обратно на оригинальный, если убрать наведение
        */
        private void menu_Enter(object sender, EventArgs e)
        {
            menu.ForeColor = Color.Lime;
        }

        private void menu_Leave(object sender, EventArgs e)
        {
            menu.ForeColor = originalForeColor;
        }

        private void reset_Enter(object sender, EventArgs e)
        {
            reset.ForeColor = Color.Lime;
        }

        private void reset_Leave(object sender, EventArgs e)
        {
            reset.ForeColor = originalForeColor;
        }


        private void exit_Enter(object sender, EventArgs e)
        {
            exit.ForeColor = Color.Lime;
        }

        private void exit_Leave(object sender, EventArgs e)
        {
            exit.ForeColor = originalForeColor;
        }


        //нажатие на клавишу сброс
        private void reset_Click(object sender, EventArgs e)
        {
            //путь к файлу
            string filePath = Path.Combine(Application.StartupPath, "stats.txt");


            //проверяем существует ли файл перед удалением
            
            if (File.Exists(filePath))
            {
                //удаляем файл, очищаем textBox, устанавливаем новый текст и выключаем кнопку Сброс
                File.Delete(filePath);
                textBox1.Clear();
                textBox1.Text = "Пока нет статистики...";
                reset.Enabled = false;
            }

        }
    }
}
