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

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseClicked = true;
            draw.location.X = e.Location.X;
            draw.location.Y = e.Location.Y;
            draw.Draw(pictureBox1.CreateGraphics());
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            draw.location.Y++;
        }
    }
}
