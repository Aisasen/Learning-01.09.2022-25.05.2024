using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Pen: Tovar
    {
        public int kvo;
        public Pen(string name, int price, int kvok)
        {
            Name = name;
            Price = price;
            this.kvo = kvok;
        }
        public override void Calc()
        {
            Console.WriteLine("Стоимость товара вида: " + Name + ", " + Price*kvo);
        }
    }
}
