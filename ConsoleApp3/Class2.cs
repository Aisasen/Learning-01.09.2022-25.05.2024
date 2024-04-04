using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Figura
    {
        public static void ShowArea(int a)
        {
            Console.WriteLine("Квадрат, площадь:" + a * a);
        }
        public static void ShowArea(int a, int b)
        {
            Console.WriteLine("Прямоугольник, площадь:" + a * b);
        }
        public static void ShowArea(int a, int b, int c)
        {
            Console.WriteLine("Трапеция, площадь:" + (a + b)/2 * c);
        }
    }
}
