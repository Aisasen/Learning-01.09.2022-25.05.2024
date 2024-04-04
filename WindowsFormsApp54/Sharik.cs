using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp54
{
    internal class Sharik
    {
        int radius;
        int x;
        int y;
        SolidBrush br;
        int dx;
        int dy;
        public Sharik(int r, Color c, int x0, int y0, int d_x, int d_y)
        {
            radius = r;
            br = new SolidBrush(c);
            x = x0;
            y = y0;
            dx = d_x;
            dy = d_y;
        }
        public void Next()
        {
            if (x >= Form1.ActiveForm.Width - 2 * (radius + dx))
                dx = -dx;
            if (x < 0)
                dx = -dx;
            x += dx;
            if (y >= Form1.ActiveForm.Height - SystemInformation.CaptionHeight - 2 * (radius + dy))
                dy = -dy;
            if (y < 0)
                dy = -dy;
            y += dy;
        }
        public void Move(Graphics g)
        {
            Next(); // вычисление нового положения шара
            g.FillEllipse(br, x, y, 2 * radius, 2 * radius);
            Form1.ActiveForm.Invalidate();
        }
    }
}
