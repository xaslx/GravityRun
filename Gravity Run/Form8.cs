using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gravity_Run
{
    public partial class Form8 : Form
    {
        private int Score;
        private int Highscore;
        private int Lives;
        private int Speed;
        Color originalForeColor;


        public Form8()
        {
            InitializeComponent();

            //вызываем метод при запуске формы
            labelText();



            //Выключаем стандартные эффекты у кнопок, при нажатии мышки и наведении мышки
            ok.FlatAppearance.MouseOverBackColor = ok.BackColor;
            del.FlatAppearance.MouseOverBackColor = del.BackColor;
            back.FlatAppearance.MouseOverBackColor = back.BackColor;
            exit.FlatAppearance.MouseOverBackColor = exit.BackColor;

            ok.FlatAppearance.MouseDownBackColor = ok.BackColor;
            del.FlatAppearance.MouseDownBackColor = del.BackColor;
            back.FlatAppearance.MouseDownBackColor = back.BackColor;
            exit.FlatAppearance.MouseDownBackColor = exit.BackColor;

            //переменная для хранения оригинального цвета кнопки
            originalForeColor = ok.ForeColor;

            //если label2 равен такому тексту, то выключаем кнопку
            if (label2.Text == "Сохранений нет" || label2.Text == "Неверные данные")
            {


                ok.Enabled = false;

            }
        }

        private void labelText()
        {
            //проверка на то что такой файл есть
            if (File.Exists("saveData.txt"))
            {
                //читаем файл, разделяем его и записываем в массив
                string[] data = File.ReadAllText("saveData.txt").Split(',');

                //проверка на то что длина массива 4
                if (data.Length == 4)
                {
                    //получаем данные из файла и записываем их в переменные
                    Score = int.Parse(data[0]);
                    Highscore = int.Parse(data[1]);
                    Lives = int.Parse(data[2]);
                    Speed = int.Parse(data[3]);


                    //записываем новый текст для label2
                    label2.Text =
                                $"Ваш счет: {Score}\n" +
                                $"Ваш лучший результат: {Highscore}\n" +
                                $"Жизни: {Lives}\n" +
                                $"Скорость: {Speed}";
                }
                //если длина массива не 4
                else
                {
                    label2.Text = "Неверные данные";
                }

            }
            //если такого файла нет
            else
            {
                label2.Text = "Сохранений нет";
            }
        }



        //закрываем игру если нажать на кнопку
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ok_Click(object sender, EventArgs e)
        {

            //закрываем текущую форму
            this.Close();

            //закрываем Form2
            Form2 menu = Application.OpenForms.OfType<Form2>().FirstOrDefault();
            menu.Close();

            //получаем выбранные данные и передаем их в новую форму
            Form1 gameForm = new Form1(Score, Highscore, Lives, Speed);
            gameForm.Show();


        }

        //закрываем текущую форму
        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        /*
        события для всех кнопок, при наведении на кнопку с помощью мышки или стрелок, меняет цвет,
        и потом обратно на оригинальный, если убрать наведение
        */
        private void ok_Enter(object sender, EventArgs e)
        {
            ok.ForeColor = Color.Lime;
        }

        private void ok_Leave(object sender, EventArgs e)
        {
            ok.ForeColor = originalForeColor;
        }

        private void back_Enter(object sender, EventArgs e)
        {
            back.ForeColor = Color.Lime;
        }

        private void back_Leave(object sender, EventArgs e)
        {
            back.ForeColor = originalForeColor;
        }

        private void exit_Enter(object sender, EventArgs e)
        {
            exit.ForeColor = Color.Lime;
        }

        private void exit_Leave(object sender, EventArgs e)
        {
            exit.ForeColor = originalForeColor;
        }

        private void del_Enter(object sender, EventArgs e)
        {
            del.ForeColor = Color.Lime;
        }

        private void del_Leave(object sender, EventArgs e)
        {
            del.ForeColor = originalForeColor;

        }


      

        //кнопка удалить
        private void del_Click(object sender, EventArgs e)
        {
            //проверка есть ли файл
            if (File.Exists("saveData.txt"))
            {
                //удаляет файл
                File.Delete("saveData.txt");

                //выключает кнопку Загрузить
                ok.Enabled = false;

                //меняет текст label2
                label2.Text = "Сохранений нет";
            }
            //если файла нет то выводит табличку
            else
            {
                MessageBox.Show("Сохранения уже удалены", "Ошибка");
            }
        }

        
    }
}
