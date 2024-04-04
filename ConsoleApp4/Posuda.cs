using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Posuda: Tovar
    {
        public Posuda(string col, int pr, string nam, int quant)
        {
            Color = col;
            Price = pr;
            Name = nam;
            Quantity = quant;
        }

        public override void CalcSum()
        {
            TotalPrice = Quantity*Price;
        }
    }
}
