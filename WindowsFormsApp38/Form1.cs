using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp38
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double result;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Red;
            Method_CangedFont();
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Yellow;
            Method_CangedFont();
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Green;
            Method_CangedFont();
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Arial", 12);
            Method_CangedFont();
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
          textBox1.Font = new Font("Arial", 18);
            Method_CangedFont();
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Arial", 24);
            Method_CangedFont();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Method_CangedFont();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Method_CangedFont();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Method_CangedFont();
        }
        private void Method_CangedFont()
        {
            var TempFont = textBox1.Font;
            var FontStyle1 = FontStyle.Regular;

            if (checkBox1.Checked) FontStyle1 |= FontStyle.Bold;
            if (checkBox2.Checked) FontStyle1 |= FontStyle.Italic;
            if (checkBox3.Checked) FontStyle1 |= FontStyle.Underline;
           
            textBox1.Font = new Font(TempFont.FontFamily, TempFont.Size, FontStyle1);
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            MethodOfCalculation();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            MethodOfCalculation();
        }
        public void MethodOfCalculation()
        {
            if (radioButton7.Checked) 
            {
                double R1 = double.Parse(textBox2.Text);
                double R2 = double.Parse(textBox3.Text);
                result = 1/R1 + 1/R2;
            }
            if (radioButton8.Checked)
            {
                double R1 = double.Parse(textBox2.Text);
                double R2 = double.Parse(textBox3.Text);
                result = (R1 * R2) / (R1 + R2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = result.ToString();
            label5.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox4.Text) > 13000 & (int.Parse(textBox4.Text) < 15000))
            {
                label7.Text = "Ваша скидка: 1%. Итог: " + int.Parse(textBox4.Text) * 0.99;
            }
            else if (int.Parse(textBox4.Text) > 15000 & (int.Parse(textBox4.Text) < 20000))
            {
                label7.Text = "Ваша скидка: 2%. Итог: " + int.Parse(textBox4.Text) * 0.98;
            }
            else if (int.Parse(textBox4.Text) > 20000)
            {
                label7.Text = "Ваша скидка: 3%. Итог: " + int.Parse(textBox4.Text) * 0.97;
            }
            else
                label7.Text = "Итог: " + int.Parse(textBox4.Text);
            label7.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double reverseCOEF = 1;
            if (checkBox4.Checked)
            {
                reverseCOEF = 2;
            }
            if (radioButton9.Checked)
            {
                label10.Text = "Результат: "+double.Parse(textBox5.Text)/double.Parse(textBox6.Text) * 205 * reverseCOEF;
            }
            else if (radioButton10.Checked)
            {
                label10.Text = "Результат: " + double.Parse(textBox5.Text) / double.Parse(textBox6.Text) * 255 * reverseCOEF;
            }
            else if (radioButton11.Checked)
            {
                label10.Text = "Результат: " + double.Parse(textBox5.Text) / double.Parse(textBox6.Text) * 310 * reverseCOEF;
            }
            label10.Visible = true;
        }
    }
}
