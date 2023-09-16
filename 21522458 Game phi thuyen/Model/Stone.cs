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
    public class Stone
    {
        public int x;
        public int y;
        private static string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Images"+"\\Burger.png";
        public Bitmap bmp = new Bitmap(path);
        public Stone(int x,int y)
        {
            this.x = x;
            this.y = y;
        }

        public void CreateGraphics(Graphics g)
        {
            g.DrawImage(bmp, x, y);
        }
        public bool IsHitSpaceship(PictureBox p)
        {
            int x1 = x-50;
            int x2 = x + bmp.Width;
            int y1 = y;
            int y2 = y + bmp.Height;

            int LocX = p.Location.X;
            int LocY = p.Location.Y;

            if(LocX>x1 && LocX<x2 && LocY>y1 && LocY<y2) 
            {
                return true;
            }
            return false;
        }
    }
}
