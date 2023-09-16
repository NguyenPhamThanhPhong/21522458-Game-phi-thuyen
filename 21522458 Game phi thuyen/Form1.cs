using _21522458_Game_phi_thuyen.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21522458_Game_phi_thuyen
{
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            start_game();
            


        }

        List<Stone> stones  = new List<Stone>();
        List<Bullet> bullets = new List<Bullet>();
        List<Explode> explodes = new List<Explode>();

        private bool[] move = new bool[4];
        private int x, y;
        

        int score = 0;
        bool lose = false;

        bool up = false;
        bool down = false;
        bool right = false;
        bool left = false;
        private void gameOver()
        {
            pictureBox1.Visible = false;
            timer_appear.Stop();
            timer_fall.Stop();
            timer_move.Stop();
            timer_shoot.Stop();
            timer_explode.Stop();
            DialogResult result =  MessageBox.Show(
                "Thua rồi!:(( \n Bạn có muốn thoát trò chơi?", "Notification",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void start_game()
        {
            lose = false;
            timer_appear.Start();
            timer_fall.Start();
            timer_move.Start();
            timer_shoot.Start();
            timer_explode.Start();
            stones.Clear();
            bullets.Clear();
            explodes.Clear();
            score = 0;
            up = down = right = left = false;
            pictureBox1.Visible = true;
            pictureBox1.Location = new Point(this.ClientSize.Width/2,this.ClientSize.Height/2);
        }
        private void CreateStone()
        {
            Random rnd = new Random();
            int Max = this.ClientSize.Width;
            int x = rnd.Next(0,Max-50);
            stones.Add(new Stone(x,0));
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach(Explode ee in explodes)
            {
                ee.CreateGraphics(g, ee.index);
            }
            foreach(Stone st in stones)
            {
                st.CreateGraphics(g);
            }
            foreach(Bullet b in bullets)
            {
                b.CreateGraphics(g);
            }
        }

        private void timer_appear_Tick(object sender, EventArgs e)
        {
            CreateStone();
        }

        private void timer_fall_Tick(object sender, EventArgs e)
        {
            stones.RemoveAll(st => st.y >= this.ClientSize.Height -100);
            foreach(Stone st in stones)
            {
                st.y += 5;
            }
        }

        private void timer_move_Tick(object sender, EventArgs e)
        {
            int PosX = this.pictureBox1.Location.X;
            int PosY = this.pictureBox1.Location.Y;

            if (left == true && pictureBox1.Left > 0)
            {
                this.pictureBox1.Left -= 10;
            }
            if (right == true && pictureBox1.Right < this.ClientSize.Width)
            {
                int z = this.pictureBox1.Location.X;
                this.pictureBox1.Location = new Point(z + 10, PosY);
            }
            if (up == true && pictureBox1.Top > 0)
            {
                this.pictureBox1.Top -= 10;

            }
            if (down == true && pictureBox1.Top < this.ClientSize.Height - pictureBox1.Height)
            {
                //MessageBox.Show("down");
                this.pictureBox1.Top += 10;
            }
            foreach (Stone st in stones)
            {
                if (st.IsHitSpaceship(pictureBox1))
                    lose = true;
            }
            if(lose)
            {
                gameOver();
                start_game();
                return;
            }
            this.Invalidate();
        }
        private void HitTarget()
        {
            try
            {
                for (int i = 0; i < bullets.Count; i++)
                {
                    for (int j = 0; j < stones.Count; j++)
                    {
                        if (bullets[i].IsHitStone(stones[j]))
                        {
                            Explode temp_ex = new Explode(stones[j].x, stones[j].y);
                            explodes.Add(temp_ex);
                            score += 10;
                            stones.RemoveAt(j);
                            bullets.RemoveAt(i);
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void timer_shoot_Tick(object sender, EventArgs e)
        {
            //bullets.RemoveAll(bb => (bb.y <= 0 || bb.IsHitStone(stones)));
            HitTarget();
            bullets.RemoveAll(bb => (bb.y <= 0));
            label_score.Text = "Score: " + score.ToString(); 
            foreach (Bullet b in bullets)
            {
                b.Shoot();
            }
        }

        private void timer_explode_Tick(object sender, EventArgs e)
        {
            foreach(Explode ee in explodes)
            {
                ee.index= ee.index+1;
            }
            explodes.RemoveAll(ee => ee.index >= 7);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int LocationX = pictureBox1.Location.X;
            int LocationY = pictureBox1.Location.Y;

            
            if (e.KeyCode == Keys.Left)
                left = true;
            if (e.KeyCode == Keys.Right)
                right = true;
            if (e.KeyCode == Keys.Up)
                up = true;
            if (e.KeyCode == Keys.Down)
                down = true;
            if (e.KeyCode == Keys.Space)
                bullets.Add(new Bullet(LocationX + pictureBox1.Width/2 , LocationY));
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
            if (e.KeyCode == Keys.Right)
                right = false;
            if (e.KeyCode == Keys.Up)
                up = false;
            if (e.KeyCode == Keys.Down)
                down = false;
        }


    }
}
