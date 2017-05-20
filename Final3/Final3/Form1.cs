using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int c = 12;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int x = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                label1.BackColor = Color.Red;
                x++;
            }
            else if (x == 1)
            {
                label2.BackColor = Color.Red;
                x++;
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
