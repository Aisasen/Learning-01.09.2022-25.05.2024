using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Num1, Num2, CountR=0;
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Keys.Enter.GetHashCode())
                Num1 = listBox1.SelectedIndex;
        }

        private void listBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
                switch (listBox2.SelectedIndex)
                {
                case 0:
                     Num2 = 0; 
                     break;
                case 1: 
                     Num2 = 1; 
                     break;
                case 2: 
                     Num2 = 3; 
                     break;
                case 3: 
                    Num2 = 2; 
                    break;
                case 4:
                    Num2 = 7;
                    break;
                case 5:
                    Num2 = 6;
                    break;
                case 6:
                    Num2 = 5;
                    break;
                case 7:
                    Num2 = 8;
                    break;
                case 8:
                    Num2 = 9;
                    break;
                case 9:
                    Num2 = 4;
                    break;
            }
            if (e.KeyChar == Keys.Enter.GetHashCode())
            {
                if (Num1 == Num2)
                {
                    label1.ForeColor = Color.Green;
                    CountR = CountR + 1;
                    label1.Text = "Правильно "+CountR;
                    listBox1.Items.Remove(listBox1.SelectedItem);
                }
                else
                {
                    label1.ForeColor = Color.Red;
                    label1.Text = "Ошибка";
                }
                if (CountR == 5)
                    MessageBox.Show("Тест окончен!");
            } 
        }
    }
}
