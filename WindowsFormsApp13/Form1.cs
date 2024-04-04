using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public int count = 1;
        public int bcount = 0;
        public int tcount = 0;
        public int lcount = 0;

        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (e.Location.X <= this.Size.Width/2)
            {
                Button b = new Button();
                b.Parent = this;
                b.Location = new Point(e.Location.X, e.Location.Y);
                b.Size = new Size(100, 100);
                b.Text = "" + e.Location.X + "; " + e.Location.Y;
            }
            else
            {
                TextBox t = new TextBox();
                t.Parent = this;
                t.Location = new Point(e.Location.X, e.Location.Y);
                t.Size = new Size(100, 100);
                t.Text = "" + e.Location.X + "; " + e.Location.Y;
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Button b2 = new Button();
            b2.Parent = panel1;
            b2.Location = new Point(e.Location.X, e.Location.Y);
            b2.Size = new Size(100, 100);
            b2.Text = "" + e.Location.X + "; " + e.Location.Y;
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            Button b3 = new Button();
            b3.Parent = panel3;
            b3.Size = new Size(100, 100);
            b3.Text = "" + e.Location.X + "; " + e.Location.Y;
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox t2 = new TextBox();
            t2.Parent = panel4;
            t2.Size = new Size(100, 100);
            t2.Text = "" + e.Location.X + "; " + e.Location.Y;
        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            Label l = new Label();
            l.Parent = panel2;
            l.Size = new Size(100, 100);
            l.Text = "" + e.Location.X + "; " + e.Location.Y;
        }

        private void panel5_MouseClick(object sender, MouseEventArgs e)
        {
            if (count%2==0)
            {
                Button b4 = new Button();
                b4.Parent = panel5;
                b4.Location = new Point(e.Location.X, e.Location.Y);
                b4.Size = new Size(100, 100);
                b4.Text = "" + e.Location.X + "; " + e.Location.Y;
                count++;
            }
            else
            {
                TextBox t3 = new TextBox();
                t3.Parent = panel5;
                t3.Size = new Size(100, 100);
                t3.Location = new Point(e.Location.X-t3.Size.Width, e.Location.Y- t3.Size.Height);
                t3.Text = "" + e.Location.X + "; " + e.Location.Y;
                count++;
            }
        }

        private void panel6_MouseClick(object sender, MouseEventArgs e)
        {
            int controlType = random.Next(3);
            if (controlType == 0)
            {
                Button b5 = new Button();
                b5.Parent = panel6;
                b5.Location = new Point(e.Location.X, e.Location.Y);
                b5.Size = new Size(100, 100);
                b5.Text = "" + e.Location.X + "; " + e.Location.Y;
                bcount++;
                label1.Text = ""+bcount;
            }
            if (controlType == 1)
            {
                TextBox t4 = new TextBox();
                t4.Parent = panel6;
                t4.Location = new Point(e.Location.X, e.Location.Y);
                t4.Size = new Size(100, 100);
                t4.Text = "" + e.Location.X + "; " + e.Location.Y;
                tcount++;
                label2.Text = "" + tcount;
            }
            if (controlType == 2)
            {
                Label l2 = new Label();
                l2.Parent = panel6;
                l2.Location = new Point(e.Location.X, e.Location.Y);
                l2.Size = new Size(100, 100);
                l2.Text = "" + e.Location.X + "; " + e.Location.Y;
                lcount++;
                label3.Text = "" + lcount;
            }
        }
    }
}
