using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp50
{
    public partial class Form1 : Form
    {
        int seconds = 0;
        int errors = 0;
        int temp = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void listBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            string modifiers = "";

            if (e.Alt)
            {
                modifiers += "Alt + ";
            }

            if (e.Control)
            {
                modifiers += "Ctrl + ";
            }

            label1.Text = "Нажата клавиша " + modifiers + e.KeyCode;
            listBox1.Items.Add($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} - {modifiers}{e.KeyCode}");
        }
        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            listBox1.Items.Add("Нажата левая кнопка мыши");
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "В глубокой миске смешайте муку и соль. В центре муки сделайте углубление и добавьте яйца. Медленно перемешивайте муку с яйцами, пока не получится крошечные кусочки теста.";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "Раскатайте тесто в тонкий слой на столе, посыпанном мукой.Придайте листу теста нужную толщину (вы можете нарезать его на полосы или ленты с помощью ножа или формы).";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "Доведите воду до кипения в большой кастрюле. Посолите воду.Положите лапшу в кипящую воду и варите 2-3 минуты, или до готовности.Отцедите лапшу и промойте ее холодной водой.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] == textBox2.Text[i])
                {
                    continue;
                }
                else
                    errors++;
            }
            timer1.Stop();
            temp = textBox1.Text.Length / seconds;
            label4.Text = "Вы набрали текст за " + seconds + " секунд. Ошибок в тексте " + errors + " . Скорость печати " + temp + " cимволов в секунду";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            timer1.Start();
        }
    }
}
