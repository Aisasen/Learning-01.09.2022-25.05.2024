using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Book: Tovar
    {
        public int kvo;
        public Book(string name, int price, int kovk)
        {
            Name = name;
            Price = price;
            this.kvo = kovk;
        }
        public override void Calc()
        {
            Console.WriteLine("Стоимость товара вида: " + Name + ", " + Price * kvo);
        }
    }
}
