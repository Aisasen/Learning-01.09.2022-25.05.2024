using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Circle: Figura
    {
        public Circle(int r)
        {
            Radius = r;
        }

        public override void Area()
        {
            Console.WriteLine("Площадь " + 2 * Math.PI * Radius);
        }
    }
}
