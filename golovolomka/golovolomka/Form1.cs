using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace golovolomka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int n = 4;
        int win = 24;
        private void button1_Click(object sender, EventArgs e)
        {
            int ik, c, k, ak;
            Button btn = sender as Button;
            ik = Convert.ToInt32((btn as Button).Tag) / 2;
            c = Convert.ToInt32((btn as Button).Tag) % 2;
            k = n - ik;
            ak = Math.Abs(k);
            if (ak<3)
                if (((c == 0) && (k > 0)) || ((c == 1) && (k < 0)))
                {
                    btn.Tag = (Convert.ToInt32((btn as Button).Tag) + 2 * k);
                    (btn as Button).Left = btn.Left + 56 * k;
                    win = win - ak;
                    n = ik;
                }
            if (win == 0)
            {
                Text = "Победа!";
                panel1.BackColor = Color.Fuchsia;
                panel1.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
