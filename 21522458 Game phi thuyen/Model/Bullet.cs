using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21522458_Game_phi_thuyen.Model
{
    public class Bullet
    {
        public int x { get; set; }
        public int y { get; set; }
        private static string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Images" + "\\Egg.png";
        public Bitmap bmp = new Bitmap(path);

        public Bullet(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Shoot()
        {
            this.y -= 10;
        }
        public void CreateGraphics(Graphics g)
        {
            g.DrawImage(bmp, x, y);
        }
        public bool IsHitStone(Stone s)
        {
            int x1 = s.x - 15;
            int x2 = s.x + s.bmp.Width;
            int y1 = s.y;
            int y2 = s.y + s.bmp.Height;

            if (x > x1 && x < x2 && y > y1 && y < y2)
            {
                return true;
            }

            return false;
        }
    }
}
