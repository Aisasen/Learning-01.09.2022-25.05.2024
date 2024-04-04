using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HanoiTowers
{
    public partial class HelloScreen : Form
    {
        public HelloScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            title.Visible = false;
            author.Visible = false;
            begin.Visible = false;
            Game game = new Game();
            game.Show();
            this.Hide();
        }

        private void HelloScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
