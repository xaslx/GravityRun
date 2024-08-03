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
using static Gravity_Run.Form4;
using static System.Formats.Asn1.AsnWriter;

namespace Gravity_Run
{
    public partial class Form2 : Form
    {
        Color originalForeColor;
        public Form2()
        {
            InitializeComponent();

            //Выключаем стандартные эффекты у кнопок, при нажатии мышки и наведении мышки
            play.FlatAppearance.MouseOverBackColor = play.BackColor;
            save.FlatAppearance.MouseOverBackColor = save.BackColor;
            statistics.FlatAppearance.MouseOverBackColor = statistics.BackColor;
            settings.FlatAppearance.MouseOverBackColor = settings.BackColor;
            exit.FlatAppearance.MouseOverBackColor = exit.BackColor;


            play.FlatAppearance.MouseDownBackColor = play.BackColor;
            save.FlatAppearance.MouseDownBackColor = save.BackColor;
            statistics.FlatAppearance.MouseDownBackColor = statistics.BackColor;
            settings.FlatAppearance.MouseDownBackColor = settings.BackColor;
            exit.FlatAppearance.MouseDownBackColor = exit.BackColor;

            //убираем элементы управления формы
            this.ControlBox = false;

            //ставим кнпоке оригинальный цвет
            originalForeColor = play.ForeColor;
        }




        public static class MusicPlayer
        {
            //создание обьекта SoundPlayer
            private static SoundPlayer player = new SoundPlayer("music.wav");
            
            //события для включения и отключения музыки
            public static event EventHandler PlayRequested;
            public static event EventHandler StopRequested;
            public static void Play()
            {
                //включить музыку
                player.PlayLooping();

                //вызов события PlayRequested
                PlayRequested?.Invoke(null, EventArgs.Empty);
            }

            public static void Stop()
            {
                //выключение музыки
                player.Stop();

                //вызов события StopRequested
                StopRequested?.Invoke(null, EventArgs.Empty);
            }
        }

        //закрываем программу
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //при нажатии на кнопку Играть
        private void play_Click(object sender, EventArgs e)
        {
            //создаем форму 1 и открываем ее
            Form1 gameForm = new Form1();
            gameForm.Show();


            //закрываем текущую форму
            this.Close();


        }


        //при нажатии на кнопку Настройки, открываем форму
        private void settings_Click(object sender, EventArgs e)
        {
            Form4 settings = new Form4();
            settings.ShowDialog();
        }

        //при нажатии на кнопку Статистика, открываем форму, и закрываем текущую форму
        private void statistics_Click(object sender, EventArgs e)
        {
            Form6 stats = new Form6();
            stats.Show();
            this.Close();
        }


        /*
        события для всех кнопок, при наведении на кнопку с помощью мышки или стрелок, меняет цвет,
        и потом обратно на оригинальный, если убрать наведение
        */
        private void play_Enter(object sender, EventArgs e)
        {
            play.ForeColor = Color.Lime;
        }

        private void play_Leave(object sender, EventArgs e)
        {
            play.ForeColor = originalForeColor;
        }

        private void save_Enter(object sender, EventArgs e)
        {
            save.ForeColor = Color.Lime;
        }

        private void save_Leave(object sender, EventArgs e)
        {
            save.ForeColor = originalForeColor;
        }

        private void settings_Enter(object sender, EventArgs e)
        {
            settings.ForeColor = Color.Lime;
        }

        private void settings_Leave(object sender, EventArgs e)
        {
            settings.ForeColor = originalForeColor;
        }


        private void statistics_Leave(object sender, EventArgs e)
        {
            statistics.ForeColor = originalForeColor;
        }

        private void statistics_Enter(object sender, EventArgs e)
        {
            statistics.ForeColor = Color.Lime;
        }

        private void exit_Enter(object sender, EventArgs e)
        {
            exit.ForeColor = Color.Lime;
        }

        private void exit_Leave(object sender, EventArgs e)
        {
            exit.ForeColor = originalForeColor;
        }



        //при загрузке формы проверяем состояние
        private void Form2_Load(object sender, EventArgs e)
        {
            //проверка состояния включена ли музыка, и отмечен ли чекбокс
            if (!SharedData.IsMusicPlaying && SharedData.IsCheckBoxChecked)
            {
                //включаем музыку
                MusicPlayer.Play();

                //меняем состояние 
                SharedData.IsMusicPlaying = true;
            }
        }


        //при закрытии формы 2
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            //меняем состояние
            SharedData.IsMusicPlaying = false;
        }


        //при нажатии на кнопку Сохранения открываем форму 8
        private void save_Click(object sender, EventArgs e)
        {
            Form8 saves = new Form8();
            saves.ShowDialog();
        }
    }
}
