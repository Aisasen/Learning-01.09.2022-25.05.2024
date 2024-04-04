using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random x = new Random();
            int n = x.Next(1, 5);
            switch (n)
            {
                case 1:
                    if (button1.Location.X >= 700)
                    {
                        goto case 2;
                    }
                    button1.Location = new Point(button1.Location.X + button1.Size.Width, button1.Location.Y);
                    break;
                case 2:
                    if (button1.Location.Y >= 415)
                    {
                        goto case 3;
                    }
                    button1.Location = new Point(button1.Location.X, button1.Location.Y + button1.Size.Height);
                    break;
                case 3:
                    if (button1.Location.X <= 100)
                    {
                        goto case 4;
                    }
                    button1.Location = new Point(button1.Location.X - button1.Size.Width, button1.Location.Y);
                    break;
                case 4:
                    if (button1.Location.Y <= 15)
                    {
                        goto case 1;
                    }
                    button1.Location = new Point(button1.Location.X, button1.Location.Y - button1.Size.Height);
                    break;
            }
        }
    }
}
