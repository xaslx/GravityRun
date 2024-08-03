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
using static Gravity_Run.Form2;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gravity_Run
{
    public partial class Form4 : Form
    {
        Color originalForeColor;
        public Form4()
        {
            InitializeComponent();

            //убираем элементы управления формы
            this.ControlBox = false;

            //Выключаем стандартные эффекты у кнопок, при нажатии мышки и наведении мышки
            
            close.FlatAppearance.MouseOverBackColor = close.BackColor;
            close.FlatAppearance.MouseDownBackColor = close.BackColor;

            originalForeColor = close.ForeColor;
        }



        //закрываем текущую форму
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /*
        события для всех кнопок, при наведении на кнопку с помощью мышки или стрелок, меняет цвет,
        и потом обратно на оригинальный, если убрать наведение
        */
        private void close_Leave(object sender, EventArgs e)
        {
            close.ForeColor = originalForeColor;
        }

        private void close_Enter(object sender, EventArgs e)
        {
            close.ForeColor = Color.Lime;
        }


        //изменение состояния checkBox
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            //сохранение состояния checkBox в SharedData при старте Отмечен
            SharedData.IsCheckBoxChecked = checkBox1.Checked;

            //если checkBox не отмечен
            if (!checkBox1.Checked)
            {
                //выключаем музыку, меняем текст и цвет 
                MusicPlayer.Stop();
                checkBox1.Text = "Выключено";
                checkBox1.ForeColor = Color.Red;
            }
            //если отмечен
            else
            {
                //включаем музыку, меняем текст и цвет 
                MusicPlayer.Play();
                checkBox1.Text = "Включено";
                checkBox1.ForeColor = Color.Lime;
            }
        }

        //обновление класса SharedData
        public static class SharedData
        {
            public static bool IsCheckBoxChecked { get; set; } = true;
            public static bool IsMusicPlaying { get; set; } = false;
        }


        //при загрузке формы устанавливает значение checkBox
        private void Form4_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = SharedData.IsCheckBoxChecked;
        }
    }
}
