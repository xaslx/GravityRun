using System;
using System.IO;
using System.Media;
using System.Security.Cryptography.Pkcs;
using System.Text.RegularExpressions;

namespace Gravity_Run
{
    public partial class Form1 : Form
    {
        //публичные свойства
        public int score { get; private set; }
        public int highScore { get; private set; }
        public int Lives { get; private set; }
        public int Speed { get; private set; }


        //создаем переменные
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

            //запускаем метод при открытии формы
            RestartGame();

            //выключаем элементы управления формы
            this.ControlBox = false;

            //устанавливаем полученные значения
            this.score = score;
            this.highScore = highScore;
            this.Lives = Lives;
            this.Speed = Speed;


            //если счет больше 50, то меняем фоновую картинку и цвет текста (help1,2,3)
            if (score > 50)
            {
                this.BackgroundImage = Properties.Resources.b2;
                help1.ForeColor = Color.Black;
                help2.ForeColor = Color.Black;
                help3.ForeColor = Color.Black;
            }

            //Обновляем показатели жизней при старте игры
            UpdateLives();


        }

        //метод для обновления показателей жизни
        private void UpdateLives()
        {
            lblLives.Text = "Жизни: " + Lives;
        }

        
        
        private void GameTimerEvent(object sender, EventArgs e)
        {
            //если счет больше 50, то меняем фоновую картинку и цвет текста (help1,2,3)
            if (score > 50)
            {
                this.BackgroundImage = Properties.Resources.b2;
                help1.ForeColor = Color.Black;
                help2.ForeColor = Color.Black;
                help3.ForeColor = Color.Black;
            }


            //устанавливаем тексты
            lblScore.Text = "Счёт: " + score;
            lblHighScore.Text = "Лучший результат: " + highScore;

            //изменение вертикального положения персонажа
            player.Top += gravity;


            //если положения игрока по вертикали = 277
            if (player.Top > 277)
            {
                //устаналиваем гравитацию 0, верт. положение 277 и меняем изображение персонажа
                gravity = 0;
                player.Top = 277;
                player.Image = Properties.Resources.run_down0;
            }
            //если положение игрока по вертикали = 39
            else if (player.Top < 39)
            {
                //устаналиваем гравитацию 0, верт. положение 39 и меняем изображение персонажа
                gravity = 0;
                player.Top = 39;
                player.Image = Properties.Resources.run_up0;
            }

            //цикл для перебора всех элементов управления на форме
            foreach (Control x in this.Controls)
            {
                //проверка, является ли элемент PictureBox с тегом "obstacle"
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    //смещение элемента влево на величину скорости препятствий
                    x.Left -= obstacleSpeed;

                    
                    //если препятствие вышло за пределы экрана
                    if (x.Left < 0)
                    {
                        //перемещаем препятствие в случайное место
                        x.Left = random.Next(1200, 2700);

                        //увеличиваем счет
                        score += 1;

                    }


                    //проверка столкнулся ли персонаж с препятствием
                    if (x.Bounds.IntersectsWith(player.Bounds))
                    {

                        //цикл по всем элементам
                        foreach (Control a in this.Controls)
                        {
                            if (a is PictureBox && (string)a.Tag == "obstacle")
                            {
                                //если персонаж столкнулся то, перемещаем препятствие в случайное место
                                a.Left = random.Next(1200, 2700);

                            }
                        }

                        //если жизней >= 0
                        if (Lives >= 0)
                        {
                            //уменьшаем жизнь на 1
                            Lives--;

                            //меняем положение персонажа
                            player.Location = new Point(180, 150);
                            //меняем изображения персонажа
                            player.Image = Properties.Resources.run_down0;
                            //меняем гравитацию
                            gravity = gravityValue;


                            //если жизней < 0
                            if (Lives < 0)
                            {
                                //путь к файлу
                                string filePath = Path.Combine(Application.StartupPath, "stats.txt");

                                //получаем время игры
                                TimeSpan date_time = DateTime.Now - start;

                                //останаливаем игру
                                gameTimer.Stop();
                                gameTimerSeconds.Stop();
                                gameOver = true;

                                //если текущий счет больше лучшего счета то устанавливаем текущий счет к лучшему счету
                                highScore = score;

                                //записываем статистику в файл
                                //если файла нет то создаем его
                                //если есть то добавляем в него
                                using (StreamWriter sw = File.Exists(filePath) ? File.AppendText(filePath) : File.CreateText(filePath))
                                {
                                    sw.WriteLine("");
                                    sw.WriteLine("--------------------------------------------------");
                                    sw.WriteLine($"| Пользователь: {Environment.UserName}");
                                    sw.WriteLine($"| Лучший результат: {highScore}");
                                    sw.WriteLine($"| Длительность игры: {date_time.Minutes}:{date_time.Seconds}");
                                    sw.WriteLine($"| Дата и Время: {DateTime.Now}");
                                    sw.WriteLine("--------------------------------------------------");
                                }

                                //открываем форму 5
                                Form5 res = new Form5();
                                res.ShowDialog();

                                //при закрытии формы 5, вызываем метод RestartGame
                                RestartGame();
                                
                                
                            }

                            //обновляем показатели жизни
                            UpdateLives();

                        }
                        //перемещаем препятствие
                        x.Left = random.Next(800, 2000);


                        //если текущий счет больше лучшего счета то устанавливаем текущий счет к лучшему счету
                        if (score > highScore)
                        {
                            highScore = score;
                        }



                    }
                }
            }


            //если счет больше 5
            if (score > 5)
            {
                //если счет == 6, то присваиваем скорости 12, гравитации 10
                if (score == 6)
                {
                    obstacleSpeed = 12;
                    gravityValue = 10;
                }
                //каждый раз когда счет увеличивается на 5, прибавляем к скорости 2 и гравитации 2
                else
                {
                    obstacleSpeed = 12 + ((score - 5) / 5) * 2;
                    gravityValue = 10 + ((score - 5) / 5) * 2;
                }

            }
            
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            //если gameOver = true
            if (gameOver)
            {
                //для того чтобы не получилось нажать клавиши
            }
            
            //если gameOver = false
            else
            {
                //если нажать клавишу Пробел
                if (e.KeyCode == Keys.Space)
                {
                    //если позиция игрока равна 277 по вертикали
                    if (player.Top == 277)
                    {
                        //изменение положения игрока
                        player.Top -= 10;
                        gravity = -gravityValue;
                    }
                    //если позиция игрока равна 39 по вертикали
                    else if (player.Top == 39)
                    {
                        //изменение положения игрока
                        player.Top += 10;
                        gravity = gravityValue;
                    }
                }
                //если нажать клавишу ESC, то останавливаем игру, открываем форму 3
                //если закрыть форму 3 то игра продолжиться
                else if (e.KeyCode == Keys.Escape)
                {
                    gameTimer.Stop();
                    gameTimerSeconds.Stop();

                    Form3 pause = new Form3();
                    pause.ShowDialog();

                    gameTimer.Start();
                    gameTimerSeconds.Start();

                }
                //если нажать клавишу S, то игра остановится
                //откроется форма 7, и если ее закрыть то игра продолжится
                else if (e.KeyCode == Keys.S)
                {
                    //если текущий счет > лучшего счета то лучшему счету присваиваем текущий счет
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

        //метод который вызвается при запуске формы
        private void RestartGame()
        {


            //обновляем показатели жизней
            UpdateLives();
            //при вызове метода, игра будет выключена, и когда таймер help_timer кончится, то будет включена
            gameTimerSeconds.Stop();
            gameTimer.Stop();

            //включаем таймер help_timer
            help_timer.Start();

           
            //для того чтобы текст был видно на фоне картинок, и сделать прозрачным
            lblScore.Parent = pictureBox1;
            lblHighScore.Parent = pictureBox2;
            lblTime.Parent = pictureBox1;
            lblLives.Parent = pictureBox1;
            lblHighScore.Top = 0;

            //начальная позиция персонажа, и его изображение
            player.Location = new Point(180, 150);
            player.Image = Properties.Resources.run_down0;

            //начальный счет, гравитация, жизни, состояние игры
            score = 0;
            gravityValue = 8;
            gravity = gravityValue;
            obstacleSpeed = 10;
            Lives = 3;
            gameOver = true;

            //установки начального времени игры
            minutes = 0;
            seconds = 0;
            lblTime.Text = "Время: 00:00";

            //при начале игры будут видны тексты, когда кончится таймер help_timer, они будут не видны
            help1.Visible = true;
            help2.Visible = true;
            help3.Visible = true;

            //если счет больше 50, то меняем фоновую картинку и цвет текста (help1,2,3)
            if (score > 50)
            {
                this.BackgroundImage = Properties.Resources.b2;
                help1.ForeColor = Color.Black;
                help2.ForeColor = Color.Black;
                help3.ForeColor = Color.Black;
            }
            //и наоборот, возвращаем прежние значения
            else
            {
                this.BackgroundImage = Properties.Resources.background_still;
                help1.ForeColor = Color.White;
                help2.ForeColor = Color.White;
                help3.ForeColor = Color.White;
            }



            //цикл по всем элементам на форме
            foreach (Control x in this.Controls)
            {

                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    //перемещаем препятствие в случайное место при запуске игры
                    x.Left = random.Next(1200, 2700);

                }
            }

            


        }

        private void gameTimerSeconds_Tick(object sender, EventArgs e)
        {
            //считаем секунды
            seconds++;

            //если секунды равны 60 то обнуляем их и прибавояем +1 к минутам
            if (seconds == 60)
            {
                seconds = 0;
                minutes++;
            }

            //устанавливаем текст для lblTime
            lblTime.Text = "Время: " + minutes.ToString("00") + ":" + seconds.ToString("00");
        }

        //закрываем программу
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void help_timer_Tick(object sender, EventArgs e)
        {
            //выключаем таймер help_timer
            help_timer.Stop();

            //запускаем игру
            gameTimerSeconds.Start();
            gameTimer.Start();
            gameOver = false;

            //засекаем основнове время игры без учета подсказок вначале
            start = DateTime.Now;

            //убираем тексты
            help1.Visible = false;
            help2.Visible = false;
            help3.Visible = false;
        }

    }
}
