using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Tovar
    {
        private string name;
        private int price;

        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }

        public Tovar() { }
        public Tovar(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public virtual void Calc()
        {
            Console.WriteLine("Стоимость товара вида: " + Name + ", " + Price);
        }
    }
}
