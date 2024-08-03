using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gravity_Run
{
    public partial class Form5 : Form
    {
        Color originalForeColor;
        public Form5()
        {
            InitializeComponent();

            //выключаем элементы управления формы
            this.ControlBox = false;
            originalForeColor = new_game.ForeColor;


            //Выключаем стандартные эффекты у кнопок, при нажатии мышки и наведении мышки
            new_game.FlatAppearance.MouseOverBackColor = new_game.BackColor;
            menu.FlatAppearance.MouseOverBackColor = menu.BackColor;
            exit.FlatAppearance.MouseOverBackColor = exit.BackColor;

            new_game.FlatAppearance.MouseDownBackColor = new_game.BackColor;
            menu.FlatAppearance.MouseDownBackColor = menu.BackColor;
            exit.FlatAppearance.MouseDownBackColor = exit.BackColor;
        }


        //закрываем программу
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //при нажатии на кнопку Главное меню
        private void menu_Click(object sender, EventArgs e)
        {
            //создаем экземпляр формы 2
            Form2 menu = new Form2();

            //зкрываем форму 1
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
        private void new_game_Enter(object sender, EventArgs e)
        {
            new_game.ForeColor = Color.Lime;
        }

        private void new_game_Leave(object sender, EventArgs e)
        {
            new_game.ForeColor = originalForeColor;
        }

        private void menu_Enter(object sender, EventArgs e)
        {
            menu.ForeColor = Color.Lime;
        }

        private void menu_Leave(object sender, EventArgs e)
        {
            menu.ForeColor = originalForeColor;
        }

        private void exit_Enter(object sender, EventArgs e)
        {
            exit.ForeColor = Color.Lime;
        }

        private void exit_Leave(object sender, EventArgs e)
        {
            exit.ForeColor = originalForeColor;
        }


        //при нажатии Новая игра , закрываем текущую форму
        private void new_game_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
