using System;
using System.IO;
using System.Media;
using System.Security.Cryptography.Pkcs;
using System.Text.RegularExpressions;

namespace Gravity_Run
{
    public partial class Form1 : Form
    {
        //��������� ��������
        public int score { get; private set; }
        public int highScore { get; private set; }
        public int Lives { get; private set; }
        public int Speed { get; private set; }


        //������� ����������
        private DateTime start;
        int gravityValue = 8;
        int obstacleSpeed = 10;
        int gravity;
        bool gameOver;
        private int minutes = 0;
        private int seconds = 0;
        Random random = new Random();




        public Form1(int score = 0, int highScore = 0, int Lives = 3, int Speed = 10)
        {

            InitializeComponent();

            //��������� ����� ��� �������� �����
            RestartGame();

            //��������� �������� ���������� �����
            this.ControlBox = false;

            //������������� ���������� ��������
            this.score = score;
            this.highScore = highScore;
            this.Lives = Lives;
            this.Speed = Speed;


            //���� ���� ������ 50, �� ������ ������� �������� � ���� ������ (help1,2,3)
            if (score > 50)
            {
                this.BackgroundImage = Properties.Resources.b2;
                help1.ForeColor = Color.Black;
                help2.ForeColor = Color.Black;
                help3.ForeColor = Color.Black;
            }

            //��������� ���������� ������ ��� ������ ����
            UpdateLives();


        }

        //����� ��� ���������� ����������� �����
        private void UpdateLives()
        {
            lblLives.Text = "�����: " + Lives;
        }

        
        
        private void GameTimerEvent(object sender, EventArgs e)
        {
            //���� ���� ������ 50, �� ������ ������� �������� � ���� ������ (help1,2,3)
            if (score > 50)
            {
                this.BackgroundImage = Properties.Resources.b2;
                help1.ForeColor = Color.Black;
                help2.ForeColor = Color.Black;
                help3.ForeColor = Color.Black;
            }


            //������������� ������
            lblScore.Text = "����: " + score;
            lblHighScore.Text = "������ ���������: " + highScore;

            //��������� ������������� ��������� ���������
            player.Top += gravity;


            //���� ��������� ������ �� ��������� = 277
            if (player.Top > 277)
            {
                //������������ ���������� 0, ����. ��������� 277 � ������ ����������� ���������
                gravity = 0;
                player.Top = 277;
                player.Image = Properties.Resources.run_down0;
            }
            //���� ��������� ������ �� ��������� = 39
            else if (player.Top < 39)
            {
                //������������ ���������� 0, ����. ��������� 39 � ������ ����������� ���������
                gravity = 0;
                player.Top = 39;
                player.Image = Properties.Resources.run_up0;
            }

            //���� ��� �������� ���� ��������� ���������� �� �����
            foreach (Control x in this.Controls)
            {
                //��������, �������� �� ������� PictureBox � ����� "obstacle"
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    //�������� �������� ����� �� �������� �������� �����������
                    x.Left -= obstacleSpeed;

                    
                    //���� ����������� ����� �� ������� ������
                    if (x.Left < 0)
                    {
                        //���������� ����������� � ��������� �����
                        x.Left = random.Next(1200, 2700);

                        //����������� ����
                        score += 1;

                    }


                    //�������� ���������� �� �������� � ������������
                    if (x.Bounds.IntersectsWith(player.Bounds))
                    {

                        //���� �� ���� ���������
                        foreach (Control a in this.Controls)
                        {
                            if (a is PictureBox && (string)a.Tag == "obstacle")
                            {
                                //���� �������� ���������� ��, ���������� ����������� � ��������� �����
                                a.Left = random.Next(1200, 2700);

                            }
                        }

                        //���� ������ >= 0
                        if (Lives >= 0)
                        {
                            //��������� ����� �� 1
                            Lives--;

                            //������ ��������� ���������
                            player.Location = new Point(180, 150);
                            //������ ����������� ���������
                            player.Image = Properties.Resources.run_down0;
                            //������ ����������
                            gravity = gravityValue;


                            //���� ������ < 0
                            if (Lives < 0)
                            {
                                //���� � �����
                                string filePath = Path.Combine(Application.StartupPath, "stats.txt");

                                //�������� ����� ����
                                TimeSpan date_time = DateTime.Now - start;

                                //������������ ����
                                gameTimer.Stop();
                                gameTimerSeconds.Stop();
                                gameOver = true;

                                //���� ������� ���� ������ ������� ����� �� ������������� ������� ���� � ������� �����
                                highScore = score;

                                //���������� ���������� � ����
                                //���� ����� ��� �� ������� ���
                                //���� ���� �� ��������� � ����
                                using (StreamWriter sw = File.Exists(filePath) ? File.AppendText(filePath) : File.CreateText(filePath))
                                {
                                    sw.WriteLine("");
                                    sw.WriteLine("--------------------------------------------------");
                                    sw.WriteLine($"| ������������: {Environment.UserName}");
                                    sw.WriteLine($"| ������ ���������: {highScore}");
                                    sw.WriteLine($"| ������������ ����: {date_time.Minutes}:{date_time.Seconds}");
                                    sw.WriteLine($"| ���� � �����: {DateTime.Now}");
                                    sw.WriteLine("--------------------------------------------------");
                                }

                                //��������� ����� 5
                                Form5 res = new Form5();
                                res.ShowDialog();

                                //��� �������� ����� 5, �������� ����� RestartGame
                                RestartGame();
                                
                                
                            }

                            //��������� ���������� �����
                            UpdateLives();

                        }
                        //���������� �����������
                        x.Left = random.Next(800, 2000);


                        //���� ������� ���� ������ ������� ����� �� ������������� ������� ���� � ������� �����
                        if (score > highScore)
                        {
                            highScore = score;
                        }



                    }
                }
            }


            //���� ���� ������ 5
            if (score > 5)
            {
                //���� ���� == 6, �� ����������� �������� 12, ���������� 10
                if (score == 6)
                {
                    obstacleSpeed = 12;
                    gravityValue = 10;
                }
                //������ ��� ����� ���� ������������� �� 5, ���������� � �������� 2 � ���������� 2
                else
                {
                    obstacleSpeed = 12 + ((score - 5) / 5) * 2;
                    gravityValue = 10 + ((score - 5) / 5) * 2;
                }

            }
            
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            //���� gameOver = true
            if (gameOver)
            {
                //��� ���� ����� �� ���������� ������ �������
            }
            
            //���� gameOver = false
            else
            {
                //���� ������ ������� ������
                if (e.KeyCode == Keys.Space)
                {
                    //���� ������� ������ ����� 277 �� ���������
                    if (player.Top == 277)
                    {
                        //��������� ��������� ������
                        player.Top -= 10;
                        gravity = -gravityValue;
                    }
                    //���� ������� ������ ����� 39 �� ���������
                    else if (player.Top == 39)
                    {
                        //��������� ��������� ������
                        player.Top += 10;
                        gravity = gravityValue;
                    }
                }
                //���� ������ ������� ESC, �� ������������� ����, ��������� ����� 3
                //���� ������� ����� 3 �� ���� ������������
                else if (e.KeyCode == Keys.Escape)
                {
                    gameTimer.Stop();
                    gameTimerSeconds.Stop();

                    Form3 pause = new Form3();
                    pause.ShowDialog();

                    gameTimer.Start();
                    gameTimerSeconds.Start();

                }
                //���� ������ ������� S, �� ���� �����������
                //��������� ����� 7, � ���� �� ������� �� ���� �����������
                else if (e.KeyCode == Keys.S)
                {
                    //���� ������� ���� > ������� ����� �� ������� ����� ����������� ������� ����
                    if (score > highScore)
                    {
                        highScore = score;
                    }
      
                    gameTimer.Stop();
                    gameTimerSeconds.Stop();
                    Form7 form7 = new Form7(score, highScore, Lives, obstacleSpeed);
                    form7.ShowDialog();

                    gameTimer.Start();
                    gameTimerSeconds.Start();
                }
            }
            
        }

        //����� ������� ��������� ��� ������� �����
        private void RestartGame()
        {


            //��������� ���������� ������
            UpdateLives();
            //��� ������ ������, ���� ����� ���������, � ����� ������ help_timer ��������, �� ����� ��������
            gameTimerSeconds.Stop();
            gameTimer.Stop();

            //�������� ������ help_timer
            help_timer.Start();

           
            //��� ���� ����� ����� ��� ����� �� ���� ��������, � ������� ����������
            lblScore.Parent = pictureBox1;
            lblHighScore.Parent = pictureBox2;
            lblTime.Parent = pictureBox1;
            lblLives.Parent = pictureBox1;
            lblHighScore.Top = 0;

            //��������� ������� ���������, � ��� �����������
            player.Location = new Point(180, 150);
            player.Image = Properties.Resources.run_down0;

            //��������� ����, ����������, �����, ��������� ����
            score = 0;
            gravityValue = 8;
            gravity = gravityValue;
            obstacleSpeed = 10;
            Lives = 3;
            gameOver = true;

            //��������� ���������� ������� ����
            minutes = 0;
            seconds = 0;
            lblTime.Text = "�����: 00:00";

            //��� ������ ���� ����� ����� ������, ����� �������� ������ help_timer, ��� ����� �� �����
            help1.Visible = true;
            help2.Visible = true;
            help3.Visible = true;

            //���� ���� ������ 50, �� ������ ������� �������� � ���� ������ (help1,2,3)
            if (score > 50)
            {
                this.BackgroundImage = Properties.Resources.b2;
                help1.ForeColor = Color.Black;
                help2.ForeColor = Color.Black;
                help3.ForeColor = Color.Black;
            }
            //� ��������, ���������� ������� ��������
            else
            {
                this.BackgroundImage = Properties.Resources.background_still;
                help1.ForeColor = Color.White;
                help2.ForeColor = Color.White;
                help3.ForeColor = Color.White;
            }



            //���� �� ���� ��������� �� �����
            foreach (Control x in this.Controls)
            {

                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    //���������� ����������� � ��������� ����� ��� ������� ����
                    x.Left = random.Next(1200, 2700);

                }
            }

            


        }

        private void gameTimerSeconds_Tick(object sender, EventArgs e)
        {
            //������� �������
            seconds++;

            //���� ������� ����� 60 �� �������� �� � ���������� +1 � �������
            if (seconds == 60)
            {
                seconds = 0;
                minutes++;
            }

            //������������� ����� ��� lblTime
            lblTime.Text = "�����: " + minutes.ToString("00") + ":" + seconds.ToString("00");
        }

        //��������� ���������
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void help_timer_Tick(object sender, EventArgs e)
        {
            //��������� ������ help_timer
            help_timer.Stop();

            //��������� ����
            gameTimerSeconds.Start();
            gameTimer.Start();
            gameOver = false;

            //�������� ��������� ����� ���� ��� ����� ��������� �������
            start = DateTime.Now;

            //������� ������
            help1.Visible = false;
            help2.Visible = false;
            help3.Visible = false;
        }

    }
}
