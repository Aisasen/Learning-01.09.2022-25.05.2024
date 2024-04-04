using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public int minute=0;
        public int second=0;
        public int milisecond=0;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        public void Step(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + random.Next(20), pictureBox1.Location.Y);
            pictureBox2.Location = new Point(pictureBox2.Location.X + random.Next(20), pictureBox2.Location.Y);
            pictureBox3.Location = new Point(pictureBox3.Location.X + random.Next(20), pictureBox3.Location.Y);
            if (pictureBox1.Location.X >= 670)
            {
                label4.Text = "Победитель: Таракан 1";
                label4.Visible=true;
                timer1.Stop();
                timer2.Stop();
                button2.Visible=true;
                minute = 0;
                second = 0;
                milisecond = 0;
    }
            else if (pictureBox2.Location.X >= 670)
            {
                label4.Text = "Победитель: Таракан 2";
                label4.Visible = true;
                timer1.Stop();
                timer2.Stop();
                button2.Visible = true;
                minute = 0;
                second = 0;
                milisecond = 0;
            }
            else if (pictureBox3.Location.X >= 670)
            {
                label4.Text = "Победитель: Таракан 3";
                label4.Visible = true;
                timer1.Stop();
                timer2.Stop();
                button2.Visible = true;
                minute = 0;
                second = 0;
                milisecond = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            button1.Visible=false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(119, 169);
            pictureBox2.Location = new Point(119, 231);
            pictureBox3.Location = new Point(119, 293);
            label4.Visible=false;
            button1.Visible = true;
            button2.Visible = false;
        }
        public void TimerSteps(object sender, EventArgs e)
        {
            milisecond++;
            if (milisecond == 100)
            {
                second++;
                milisecond = 0;
            }
            if (second == 60)
            {
                minute++;
                second = 0;
            }
            label5.Text = Convert.ToString(minute) + ":" + Convert.ToString(second) + ":" + Convert.ToString(milisecond);
            label5.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            button3.Visible = false;
            button4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            button4.Visible = false;
            button3.Visible = true;
        }
    }
}
