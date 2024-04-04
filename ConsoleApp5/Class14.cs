using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Candy: Tovar
    {
        public double ves;
        public Candy(string name, int price, double vesy)
        {
            Name = name;
            Price = price;
            this.ves = vesy;
        }
        public override void Calc()
        {
            Console.WriteLine("Стоимость товара вида: " + Name + ", " + Price * ves);
        }
    }
}
