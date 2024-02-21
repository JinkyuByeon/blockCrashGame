using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blockCrashGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Ball_x = 4;
        int Ball_y = 4;
        int score = 0;


        private void Get_Score()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "block")
                {
                    if (ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        Controls.Remove(x);
                        Ball_y = -Ball_y;
                        score++;
                        lbl_score.Text = "Score : " + score;
                    }
                }
            }
        }

        private void Game_over()
        {
            if (score > 17)
            {
                timer1.Stop();
                MessageBox.Show("You Win");
            }
            if (ball.Top + ball.Height > ClientSize.Height)
            {
                timer1.Stop();
                MessageBox.Show("Game over");
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            int speedX = initialSpeedX + acceleration * score;
            int speedY = initialSpeedY + acceleration * score;

            Ball_movement(speedX, speedY);
            Get_Score();
            Game_over();
        }

        private int initialSpeedX = 4; // 초기 공의 이동 속도
        private int initialSpeedY = 4;
        private int acceleration = 1; // 공의 이동 속도가 증가하는 정도

        private void Ball_movement(int speedX, int speedY)
        {
            ball.Left += speedX;
            ball.Top += speedY;

            // 공이 벽에 부딪혔을 때 방향을 바꿔줌
            if (ball.Left + ball.Width >= ClientSize.Width || ball.Left <= 0)
            {
                speedX = -speedX; // x축 방향 전환
            }
            if (ball.Top <= 0 || ball.Bounds.IntersectsWith(player.Bounds))
            {
                speedY = -speedY; // y축 방향 전환
            }
        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && player.Left > 0)
            {
                player.Left -= 5;
            }
            if (e.KeyCode == Keys.Right && player.Right < 480)
            {
                player.Left += 5;
            }
        }

    }
}