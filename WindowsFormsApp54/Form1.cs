using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WindowsFormsApp54
{
    public partial class Form1 : Form
    {
        private List<Sharik> balls = new List<Sharik>();
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            DoubleBuffered = true;

            InitializeBalls(5);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            g = CreateGraphics();
            foreach (var ball in balls)
            {
                ball.Move(g);
            }
        }
        private void InitializeBalls(int count)
        {
            balls.Clear();

            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                int radius = 20;
                Color color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)); 
                int x = random.Next(ClientSize.Width - 2 * (radius + 5)); 
                int y = random.Next(ClientSize.Height - 2 * (radius + 5));
                int dx = random.Next(5) + 1; 
                int dy = random.Next(5) + 1;

                balls.Add(new Sharik(radius, color, x, y, dx, dy));
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
            InitializeBalls(trackBar1.Value);
        }
    }
}
