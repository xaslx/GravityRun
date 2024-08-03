using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace Gravity_Run
{
    public partial class Form7 : Form
    {
        //публичные свойства
        public int Score { get; private set; }
        public int Highscore { get; private set; }
        public int Lives { get; private set; }
        public int Speed { get; private set; }

        Color originalForeColor;

        public Form7(int score, int highscore, int lives, int speed)
        {
            InitializeComponent();


            //устанавливает переданные значения 
            this.Score = score;
            this.Highscore = highscore;
            this.Lives = lives;
            this.Speed = speed;

            //чтобы перехватывать нажатия клавиш
            this.KeyPreview = true;


            //Выключаем стандартные эффекты у кнопок, при нажатии мышки и наведении мышки
            cont.FlatAppearance.MouseOverBackColor = cont.BackColor;
            save.FlatAppearance.MouseOverBackColor = save.BackColor;
            exit.FlatAppearance.MouseOverBackColor = exit.BackColor;


            cont.FlatAppearance.MouseDownBackColor = cont.BackColor;
            save.FlatAppearance.MouseDownBackColor = save.BackColor;
            exit.FlatAppearance.MouseDownBackColor = exit.BackColor;

            //переменная для хранения оригинального цвета кнопки
            originalForeColor = cont.ForeColor;
        }

        //метод для записи данных в файл
        private void SaveGameData()
        {
            string saveData = $"{Score},{Highscore},{Lives},{Speed}";
            File.WriteAllText("saveData.txt", saveData);
        }


        //закрывает программу
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //если нажать на кнопку сохранить то вызывается метод SaveGameData
        private void save_Click(object sender, EventArgs e)
        {
            SaveGameData();
            MessageBox.Show("Успешно сохранено", "Сохранение", MessageBoxButtons.OK);
        }

        //закрывает форму
        private void cont_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void save_Enter(object sender, EventArgs e)
        {
            save.ForeColor = Color.Lime;
        }

        private void save_Leave(object sender, EventArgs e)
        {
            save.ForeColor = originalForeColor;
        }

        private void exit_Enter(object sender, EventArgs e)
        {
            exit.ForeColor = Color.Lime;
        }

        private void exit_Leave(object sender, EventArgs e)
        {
            exit.ForeColor = originalForeColor;
        }


        //при нажатии ESC в данной форме, она закрывается
        private void Form7_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {

                this.Close();
            }
        }
    }
}