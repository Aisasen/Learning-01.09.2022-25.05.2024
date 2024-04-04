using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Rectangle: Figura
    {
        public Rectangle(int sa,int sb)
        {
            A=sa;
            B=sb;
        }

        public override void Area()
        {
            Console.WriteLine("Площадь "+A * B);
        }
    }
}
