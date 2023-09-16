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
    public class Explode
    {

        private Func<Bitmap[]> FindBitmap = () =>
        {
            string[] str_arr = new string[7];
            for (int i = 0; i < 7; i++)
            {
                string str = Directory.GetParent(
                    Directory.GetCurrentDirectory()).Parent.FullName
                    + "\\Images" + "\\" + (i + 1).ToString() + ".png";
                str_arr[i] = str;
            }
            Bitmap[] bmp_arr = new Bitmap[7];
            for (int i = 0; i < 7; i++)
            {
                
                bmp_arr[i] = new Bitmap(str_arr[i]);
            }
            return bmp_arr;
        };
        public int x { get; set; }
        public int y { get; set; }
        public Bitmap[] bmp;
        public int index { get; set; }
        
        public Explode(int x,int y)
        {
            index = 0;
            bmp = this.FindBitmap();
            this.x = x;
            this.y = y;
        }
        public void CreateGraphics(Graphics g,int index)
        {
            g.DrawImage(bmp[index%7],this.x,this.y);
        }




    }
}
