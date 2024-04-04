using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp43
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int r = trackBar1.Value;
            textBox1.Text = Convert.ToString(r);
            textBox2.Text = Convert.ToString(Math.PI * r * r);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal U = numericUpDown1.Value;
            decimal R = numericUpDown2.Value;
            textBox3.Text = Convert.ToString(U / R);
        }

        public decimal r1 = 1;
        public decimal r2 = 1;
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            r1 = numericUpDown3.Value;
            r2 = numericUpDown4.Value;
            ShowR(); 
        }
        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            r1 = numericUpDown3.Value;
            r2 = numericUpDown4.Value;
            ShowR(); 
        }
        public void ShowR()
        {
            label7.Text = Convert.ToString(1 / (1 / r1 + 1 / r2));
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label8.Text = "R1 = " + Convert.ToString(trackBar2.Value);
            if (radioButton2.Checked)
            {
                label10.Text = Convert.ToString(trackBar2.Value + trackBar3.Value);
            }
            else if (radioButton1.Checked)
            {
                label10.Text = Convert.ToString(1/Convert.ToDouble(trackBar2.Value) + 1/Convert.ToDouble(trackBar3.Value));
            }
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label9.Text = "R2 = " + Convert.ToString(trackBar3.Value);
            if (radioButton2.Checked)
            {
                label10.Text = Convert.ToString(trackBar2.Value + trackBar3.Value);
            }
            else if (radioButton1.Checked)
            {
                label10.Text = Convert.ToString(1 / Convert.ToDouble(trackBar2.Value) + 1 / Convert.ToDouble(trackBar3.Value));
            }
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            label13.Text = "R = "+Convert.ToString(trackBar4.Value);
            textBox5.Text = Convert.ToString(2 * Math.PI* trackBar4.Value);
            textBox4.Text = Convert.ToString(4/3*Math.PI*Math.Pow(trackBar4.Value,3));
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            label14.Text = "V = "+Convert.ToString(trackBar5.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox6.Text = Convert.ToString(trackBar5.Value * trackBar5.Value / (2 * 9.8));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox7.Text = Convert.ToString(Double.Parse(textBox8.Text) * 9.8 * trackBar6.Value);
        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            label17.Text = "h = " + Convert.ToString(trackBar6.Value);
        }

        private void trackBar7_Scroll(object sender, EventArgs e)
        {
            label21.Text = "t = "+Convert.ToString(trackBar7.Value);
            label20.Text = Convert.ToString(Double.Parse(textBox9.Text) * trackBar7.Value);
        }

        private void trackBar8_Scroll(object sender, EventArgs e)
        {
            label23.Text = "Расход Квт/ч "+Convert.ToString(trackBar8.Value);
            label24.Text = "Оплата "+Convert.ToString(trackBar8.Value * numericUpDown5.Value);
        }

        private void trackBar11_Scroll(object sender, EventArgs e)
        {
            label27.Text = "Растояние км "+Convert.ToString(trackBar11.Value);
            label28.Text = Convert.ToString(trackBar11.Value/ trackBar10.Value * trackBar9.Value);
        }

        private void trackBar10_Scroll(object sender, EventArgs e)
        {
            label26.Text = "Расход бензина на 100 км "+Convert.ToString(trackBar10.Value);
            label28.Text = Convert.ToString(trackBar11.Value / trackBar10.Value * trackBar9.Value);
        }

        private void trackBar9_Scroll(object sender, EventArgs e)
        {
            label25.Text = "Цена бензина за 1 литр "+Convert.ToString(trackBar9.Value);
            label28.Text = Convert.ToString(trackBar11.Value / trackBar10.Value * trackBar9.Value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label29.Text = "Тенге " + Convert.ToString(Decimal.Parse(textBox10.Text) * numericUpDown8.Value);
            label30.Text = "Доллар " + Convert.ToString(Decimal.Parse(textBox10.Text) * numericUpDown7.Value);
            label31.Text = "Рос.рубль " + Convert.ToString(Decimal.Parse(textBox10.Text) * numericUpDown6.Value);
        }
    }
}
