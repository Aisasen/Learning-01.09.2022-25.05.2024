using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible=true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible=true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Visible=true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Visible=true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Text = textBox1.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Text = textBox2.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Text = textBox3.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Text = textBox4.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            BackColor = Color.LightPink;
            label5.Text = "Начало работы";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            button16.Visible = false;
            button13.Visible = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button15.Visible = false;
            button14.Visible = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button14.Visible=false;
            button17.Visible = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button13.Visible = false;
            button16.Visible = true;
            button17.Visible=false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button13.Visible = false;
            button16.Visible = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox5.Enabled = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox5.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            BackColor = Color.LightPink;
            label5.Text = "Начало работы";
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            BackColor = Color.Purple;
            Visible = false;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button24.Text = "1";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button23.Text = "1";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            button26.Text = "1";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            button25.Text = "М";
            BackColor= Color.Red;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            button5.Text = "1";
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            button12.Text = "М";
            BackColor = Color.Red;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button20.Text = "1";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            button28.Size = new System.Drawing.Size(80, 40);
            button29.Size = new System.Drawing.Size(80, 40);
            button30.Size = new System.Drawing.Size(80, 40);
        }
    }
}
