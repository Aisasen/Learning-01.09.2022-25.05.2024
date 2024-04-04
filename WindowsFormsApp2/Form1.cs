using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private Form2 users;
        private Form3 catalog;
        private Form4 zakaz;
        private Form5 tovars;
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            users = new Form2();
            users.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tovars = new Form5();
            tovars.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            zakaz = new Form4();
            zakaz.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            catalog = new Form3();
            catalog.Visible = true;
        }
    }
}
