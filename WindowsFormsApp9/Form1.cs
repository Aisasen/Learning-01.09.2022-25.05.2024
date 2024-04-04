using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Привет, " + textBox1.Text;
            pictureBox1.Visible = true;
            label2.BackColor = Color.Green;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label2.Text = "Прощай, " + textBox1.Text;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            label2.BackColor = Color.Red;
        }
    }
}
