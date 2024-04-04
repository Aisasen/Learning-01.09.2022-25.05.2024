using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Perim(int a) // два параметра
        {
            Console.WriteLine("Периметр квадрата = "+4*a);
        }
        static void Perim(int a, int b) // два параметра
        {
            Console.WriteLine("Периметр прямоугольника = {0}", 2 * a + 2 * b);
        }
        static void Perim(int a, int b, int d)  // три параметра
        {
            Console.WriteLine("Периметр треугольника = {0}", a + b + d);
        }
        static void Perim(params int[] ar)  // переменное число параметров
        {
            int p = 0;
            foreach (int x in ar) p += x;
            Console.WriteLine("Периметр "+ar.Length + "-угольника = "+p);
        }

        static void Main()
        {
            Perim(7);
            Perim(10, 20);
            Perim(3, 4, 5);
            Perim(2, 3, 4, 5, 6, 7, 9);

            Zakaz z1 = new Zakaz("Иванов", 1, "Люкс");
            z1.Show();
            Zakaz z2 = new Zakaz("Петров", 2);
            z2.Show();
            Zakaz z3 = new Zakaz("Сидоров");
            z3.Show();
            Zakaz z4 = new Zakaz();
            z4.Show();
            Zakaz z5 = new Zakaz("Петя", 6, "Крыло самолёта");
            z5.Show();
            Figura.ShowArea(4);
            Figura.ShowArea(4,5);
            Figura.ShowArea(4,5,8);
            Tour.TourCalc();
            Tour.TourCalc("Russia");
            Tour.TourCalc("Russia", 30);
            Zakaz.Cycle();
            Console.ReadKey();
        }
    }
}
