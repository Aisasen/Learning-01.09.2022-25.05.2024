using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp53
{
    public partial class Form1 : Form
    {
        int k = 10;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
            timer3.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            samolet.Left = samolet.Left + 2;
            if (samolet.Left + samolet.Width > Width)
            {
                samolet.Left = -30;
            }
            samolet2.Left = samolet2.Left + 1;
            if (samolet2.Left + samolet2.Width > Width)
            {
                samolet2.Left = -30;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                men.Left += 10;
            }
            if (e.KeyCode == Keys.Left)
            {
                men.Left -= 10;
            }
            if (e.KeyCode == Keys.Space && pula.Visible == false)
            {
                pula.Visible = true;
                pula.Left = men.Left;
                pula.Top = men.Top - pula.Height;
                timer2.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int x, y, h, w;
            int x0, y0, h0, w0, x02, y02, h02, w02;
            x = pula.Left;
            y = pula.Top;
            h = pula.Height;
            w = pula.Width;
            x0 = samolet.Left;
            y0 = samolet.Top;
            h0 = samolet.Height;
            w0 = samolet.Width;
            x02 = samolet2.Left;
            y02 = samolet2.Top;
            h02 = samolet2.Height;
            w02 = samolet2.Width;
            if (((x +w > x0 && x < x0 +w0 && y+h <y0 && y< y0 + h0) || (x + w > x02 && x < x02 + w02 && y + h < y02 && y < y02 + h02)) && pula.Visible == true)
            {
                k++;
                label1.Text = k.ToString();
                pula.Visible = false;
                Wincheck();
            }
            pula.Top -= 5;
            if (pula.Top < 0)
            {
                timer2.Enabled = false;
                pula.Visible = false;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (bomba.Visible == false)
            {
                bomba.Visible = true;
                bomba.Left = samolet.Left + 15;
                bomba.Top = samolet.Top + 5;
            }
            else
            {
                bomba.Top = bomba.Top + 1;
                if (bomba.Top > men.Top + 30)
                {
                    bomba.Visible = false;
                }
            }
            if (bomba2.Visible == false)
            {
                bomba2.Visible = true;
                bomba2.Left = samolet2.Left + 15;
                bomba2.Top = samolet2.Top + 5;
            }
            else
            {
                bomba2.Top = bomba2.Top + 1;
                if (bomba2.Top > men.Top + 30)
                {
                    bomba2.Visible = false;
                }
            }
            if (bomba.Top > men.Top && bomba.Left > men.Left && bomba.Left < men.Left + men.Width)
            {
                k--;
                label1.Text = k.ToString();
                bomba.Visible = false;
                Wincheck();
            }
            if (bomba2.Top > men.Top && bomba2.Left > men.Left && bomba2.Left < men.Left + men.Width)
            {
                k--;
                label1.Text = k.ToString();
                bomba2.Visible = false;
                Wincheck();
            }
        }
        public void Wincheck ()
        {
            if (k >= 20)
            {
                label1.Text = "Вы победили!";
            }
            else if (k <= 0)
            {
                label1.Text = "Вы проиграли!";
            }
        }
    }
}
