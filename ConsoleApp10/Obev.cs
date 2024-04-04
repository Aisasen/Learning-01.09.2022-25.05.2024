using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    
    internal class Obev: Tovar
    {private int size;
        public Obev(int pr, int siz, string nam)
        {
            Price = pr;
            Size = siz;
            Name = nam;
        }

        public override void CalcSum()
        {
            TotalPrice = Size * Price;
        }
    }
}
