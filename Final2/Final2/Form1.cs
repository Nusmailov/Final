using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Button> btn = new List<Button>();
        private Random rnd = new Random();
        Button[] buttonArray = new Button[81];
        int x = 30;
        int y = 30;
        string c = "0";
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 16; i++)
            {
                buttonArray[i] = new Button();
                buttonArray[i].Size = new Size(60, 30);
                buttonArray[i].Location = new Point(x, y);
                buttonArray[i].Text = c;
                // buttonArray[i].Click += button_click;
                this.Controls.Add(buttonArray[i]);
                x += 65;
                if (x > 250)
                {
                    x = 30;
                    y += 34;
                }
            }
            /*for (int i = 1; i < 17; i++)
            {
                buttonArray[i].Click += button_click;
            }*/
        }
        private void button_click(object sender, MouseEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
