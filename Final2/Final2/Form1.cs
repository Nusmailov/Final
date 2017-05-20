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
        string d = "1";
        string v = "2";
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 9; i++)
            {
                buttonArray[i] = new Button();
                buttonArray[i].Size = new Size(60, 30);
                buttonArray[i].Location = new Point(x, y);
                if (i % 2 == 0)
                {
                    buttonArray[i].Text = d;
                }
                else if (i % 3 == 0)
                {
                    buttonArray[i].Text = v;
                }
                else
                {
                    buttonArray[i].Text = c;
                }
                buttonArray[i].Click += button_Click;
                this.Controls.Add(buttonArray[i]);
                x += 65;
                if (x > 190)
                {
                    x = 30;
                    y += 34;
                }
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
           // textBox1.Text = buttonArray[1];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            for (int i = 0; i <= 16; i++)
            {
                if (buttonArray[i].Location.X == btn.Location.X && buttonArray[i].Location.Y == btn.Location.Y)
                {
                    textBox1.Text += buttonArray[i].Text;
                }
            }
        }
    }
}
