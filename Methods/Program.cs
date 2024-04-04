using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Methods.Higher(4, 10));
            int x = 0;
            int y = 1;
            Methods.SwapValues(ref x, ref y);
            Console.WriteLine(Convert.ToString(x) + " "+ y);
            Console.WriteLine(Methods.Factorial(5));
        }
    }
}
