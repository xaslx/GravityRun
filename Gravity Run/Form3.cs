using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gravity_Run
{
    public partial class Form3 : Form
    {

        Color originalForeColor;
        public Form3()
        {
            InitializeComponent();

            //для перехвата нажатия клавиш
            this.KeyPreview = true;

            //убираем элементы управления формы
            this.ControlBox = false;


            //Выключаем стандартные эффекты у кнопок, при нажатии мышки и наведении мышки
            cont.FlatAppearance.MouseOverBackColor = cont.BackColor;
            new_game.FlatAppearance.MouseOverBackColor = new_game.BackColor;
            menu.FlatAppearance.MouseOverBackColor = menu.BackColor;
            settings.FlatAppearance.MouseOverBackColor = settings.BackColor;
            exit.FlatAppearance.MouseOverBackColor = exit.BackColor;

            cont.FlatAppearance.MouseDownBackColor = cont.BackColor;
            new_game.FlatAppearance.MouseDownBackColor = new_game.BackColor;
            menu.FlatAppearance.MouseDownBackColor = menu.BackColor;
            settings.FlatAppearance.MouseDownBackColor = settings.BackColor;
            exit.FlatAppearance.MouseDownBackColor = exit.BackColor;

            originalForeColor = cont.ForeColor;
        }


        //закрываем текущую форму
        private void cont_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //закрываем программу
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        //при нажатии кнопки Главное меню
        private void menu_Click(object sender, EventArgs e)
        {
            //создаем экземпляр Формы 2
            Form2 menu = new Form2();

            
            //закрываем Форму 1
            Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (form1 != null)
            {
                form1.Close();
            }

            //закрываем текущую форму
            this.Close();

            //открываем форму 2
            menu.Show();

        }


        /*
        события для всех кнопок, при наведении на кнопку с помощью мышки или стрелок, меняет цвет,
        и потом обратно на оригинальный, если убрать наведение
        */
        private void cont_Enter(object sender, EventArgs e)
        {
            cont.ForeColor = Color.Lime;
        }

        private void cont_Leave(object sender, EventArgs e)
        {
            cont.ForeColor = originalForeColor;
        }

        private void menu_Enter(object sender, EventArgs e)
        {
            menu.ForeColor = Color.Lime;
        }

        private void menu_Leave(object sender, EventArgs e)
        {
            menu.ForeColor = originalForeColor;
        }

        private void settings_Enter(object sender, EventArgs e)
        {
            settings.ForeColor = Color.Lime;
        }

        private void settings_Leave(object sender, EventArgs e)
        {
            settings.ForeColor = originalForeColor;
        }

        private void exit_Enter(object sender, EventArgs e)
        {
            exit.ForeColor = Color.Lime;
        }

        private void exit_Leave(object sender, EventArgs e)
        {
            exit.ForeColor = originalForeColor;
        }

        private void new_game_Leave(object sender, EventArgs e)
        {
            new_game.ForeColor = originalForeColor;
        }

        private void new_game_Enter(object sender, EventArgs e)
        {
            new_game.ForeColor = Color.Lime;
        }

        //при нажатии на кнопку Настройки , открывается форма 4
        private void settings_Click(object sender, EventArgs e)
        {
            Form4 settings = new Form4();
            settings.ShowDialog();
        }

        //при нажатии кнопки ESC , текущая форма закрывается
        private void Form3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {

                this.Close();
            }
        }

        //при нажатии на кнопку Новая игра
        private void new_game_Click(object sender, EventArgs e)
        {

            //создаем экземпляр формы 1 и закрываем ее
            Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();

            if (form1 != null)
            {
                form1.Close();
            }

            //закрываем текущую форму
            this.Close(); 

            //снова создаем форму 1 и открываем ее
            Form1 newForm1 = new Form1();
            newForm1.Show();
        }

    }
}
