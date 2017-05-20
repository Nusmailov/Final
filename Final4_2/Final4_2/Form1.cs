using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Drawer draw = new Drawer();
        public int a = 1;
        public bool mouseClicked = false;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }
        int i = 0;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {
            mouseClicked = true;
            draw.location[i].X = e.Location.X;
            draw.location[i].Y = e.Location.Y;
            draw.Draw(pictureBox1.CreateGraphics());
            i++;
        }
        private void pictureBox1_MouseUp_1(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        } 
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int j = 0; j < i; j++)
            {
                draw.location[j].Y++;
            }
            Refresh();
        }
    }
}
