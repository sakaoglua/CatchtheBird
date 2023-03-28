using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchtheBird
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int a, b, i, point;

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void kolayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i = i + 1;
            if (i==2)
            {
                pictureBox1.Location = new System.Drawing.Point(a,b);
                b = rnd.Next(300);
                a = rnd.Next(500);
                i = 0;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            a=rnd.Next(500);
            b = rnd.Next(300);
            pictureBox1.Location = new System.Drawing.Point(a,b);
            label2.Text=point.ToString();
            point = point + 1;
        }

        private void ortaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            timer1.Interval = 500;
        }

        private void zorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
