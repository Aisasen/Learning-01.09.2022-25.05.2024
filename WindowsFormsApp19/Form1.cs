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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WindowsFormsApp19
{
    public partial class Form1 : Form
    {
        int count = 0;
        int zeros = 0;
        int ones = 0;
        int prepSymbol = 0;
        int reversei = 0;
        int evenone = 0;
        int oddone = 0;
        static string numbers = "";
        StringBuilder s = new StringBuilder(numbers);
        static string reverse = "";
        StringBuilder t = new StringBuilder(reverse);
        static string even = "";
        StringBuilder ev = new StringBuilder(reverse);
        static string odd = "";
        StringBuilder o = new StringBuilder(reverse);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            int len = str.Length;
            for (int i = 0; i < len; i++)
            {
                reversei = len - i;
                if (str[i] == ' ')
                {
                    count++;
                }
                
                if (str[i]== '0')
                {
                    zeros++;
                }

                if (str[i] == '1')
                {
                    ones++;
                }

                if (str[i] == ',' || str[i] == '.' || str[i] == '!' || str[i] == '?' || str[i] == '-')
                {
                    prepSymbol++;
                }
                if (int.TryParse(Convert.ToString(str[i]), out int number))
                {
                    s.Append(number);
                }

                if (reversei%2 == 0)
                {
                    t.Append(str[reversei]);
                }

                if (i % 2 == 0)
                {
                    o.Append(str[i]);
                }

                if (i % 2 == 1)
                {
                    ev.Append(str[i]);
                }
            }
            label1.Text = "Количество пробелов = " + count.ToString();
            label3.Text = "Слов = " + (count + 1);
            count = 0;
            label2.Text = "Нули = " + zeros + " Единицы = " + ones;
            zeros = 0;
            ones = 0;
            label4.Text = "Знаков препинания = " + prepSymbol;
            prepSymbol = 0;
            label5.Text = "Цифры: " + Convert.ToString(s.ToString());
            s.Clear();
            label6.Text = "Четные обратные: " + Convert.ToString(t.ToString());
            label7.Text = "Четные: " + Convert.ToString(o.ToString());
            label8.Text = "Нечётные: " + Convert.ToString(ev.ToString());
            t.Clear();
            o.Clear();
            ev.Clear();
        }
    }
}
