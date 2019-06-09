using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingGame
{
    public partial class Form1 : Form
    {
        int score = 0;
        int speed;
        PictureBox[] road = new PictureBox[8];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            speed = 3;
            road[0] = pictureBox1;
            road[1] = pictureBox2;
            road[2] = pictureBox3;
            road[3] = pictureBox4;
            road[4] = pictureBox5;
            road[5] = pictureBox6;
            road[6] = pictureBox7;
            road[7] = pictureBox8;

        }

        private void RoadMover_Tick(object sender, EventArgs e)
        {
            for(int i=0;i<=7;i++)
            {
                road[i].Top += speed;
                if (road[i].Top >=this.Height)
                {
                    road[i].Top = -road[i].Height;
                }
             }
            if(score>10 && score<20)
            {
                speed = 5;
            }
            if (score > 20 && score < 30)
            {
                speed = 6;
            }
            if (score > 30 && score < 40)
            {
                speed = 7;
            }
            if (score > 50 && score < 60)
            {
                speed = 8;
            }
            if (score > 60 && score < 70)
            {
                speed = 9;
            }
            if (score > 80 && score < 90)
            {
                speed = 10;
            }
            if (score > 100 && score < 110)
            {
                speed = 12;
            }

            speed_text.Text = "Speed" + speed;
            if(car.Bounds.IntersectsWith(Enemycar1.Bounds))
            {
                gameOver();
            }
            if (car.Bounds.IntersectsWith(Enemycar2.Bounds))
            {
                gameOver();
            }
            if (car.Bounds.IntersectsWith(Enemycar3.Bounds))
            {
                gameOver();
            }

        }
        private void gameOver()
        {
            replay_btn.Visible = true;
            End_text.Visible = true;
            RoadMover.Stop();
            enemy1_move.Stop();
            enemy2_move.Stop();
            enemy3_move.Stop();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

       
        private void car_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
              
                right_move.Start();
            }
            else if (e.KeyCode == Keys.Left)
            {
                
                left_move.Start();
            }
        }

        private void left_move_Tick(object sender, EventArgs e)
        {
            if(car.Location.X > 1)
            {
                car.Left -= 5;
            }
            
           
        }

        private void right_move_Tick(object sender, EventArgs e)
        {
            if (car.Location.X < 180)
            {
                car.Left += 5;
            }
          
               
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            right_move.Stop();
            left_move.Stop();
        }

        private void enemy1_move_Tick(object sender, EventArgs e)
        {

            Random r = new Random();
            int n = r.Next(0, 2);
            Enemycar1.Top += 3;
            if (Enemycar1.Top >= this.Height)
            {
                score += 1;
                Score_text.Text = "Score" + score;
                Enemycar1.Top = -((n * 150) + Enemycar1.Height);
                Enemycar1.Left = (n * 50) + 1;
            }
        }

        private void enemy2_move_Tick(object sender, EventArgs e)
        {

            Random r = new Random();
            int n = r.Next(0, 2);
            Enemycar2.Top += 2;
            if (Enemycar2.Top >= this.Height)
            {
                score += 1;
                Score_text.Text = "Score" + score;
                Enemycar2.Top = -((n * 150) + Enemycar2.Height);
                Enemycar2.Left = (n * 50) + 100;
            }
        }

        private void enemy3_move_Tick(object sender, EventArgs e)
        {

            Random r = new Random();
            int n = r.Next(0, 2);
            Enemycar3.Top += 1;
            if (Enemycar3.Top >= this.Height)
            {
                score += 1;
                Score_text.Text = "Score" + score;
                Enemycar3.Top = -((n * 150) + Enemycar3.Height);
                Enemycar3.Left = (n * 30) + 150;
            }
        }

        private void replay_btn_Click(object sender, EventArgs e)
        {
            score = 0;
            this.Controls.Clear();
            InitializeComponent();
            Form1_Load(e, e);
        }
    }
}
