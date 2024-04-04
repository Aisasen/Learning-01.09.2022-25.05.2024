using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Methods
    {
        public static int Higher(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else if (a < b)
            {
                return b;
            }
            return a;
        }
        public static void SwapValues(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static bool Factorial(int n, out int result)
        {
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                try
                {
                    checked
                    {
                        factorial *= i;
                    }
                }
                catch (OverflowException)
                {
                    result = 0;
                    return false;
                }
            }
            result = factorial;
            return true;
        }
    }
}
