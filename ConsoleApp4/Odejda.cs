using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Odejda: Tovar
    {
        public Odejda(int siz, string col, int pr, string nam)
        {
            Size = siz;
            Color = col;
            Price = pr;
            Name = nam;
        }

        public override void CalcSum()
        {
            TotalPrice = Size * Price;
        }
    }
}
