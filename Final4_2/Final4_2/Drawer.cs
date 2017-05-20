using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace Final4_2
{
    class Drawer
    {
        Pen pen = new Pen(Color.Black);
        public int lenght = 30;
        public bool mouseClicked = true;
        public int a = 1;
        public Point p = new Point(0, 0);
        public Point[] location = new Point[1000];
        SolidBrush solid = new SolidBrush(Color.Red);
        public int i = 0;
        public void Draw(Graphics g)
        {
            g.FillEllipse(solid, location[i].X, location[i].Y, lenght, lenght);
            i++;
        }
       
    }
}
