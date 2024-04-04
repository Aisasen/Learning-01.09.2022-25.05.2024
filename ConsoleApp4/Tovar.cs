using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Tovar
    {
        private string name;
        private double price;
        private int kvo;
        private static int total=0;

        public Tovar(string name, double price, int kvo)
        {
            Name = name;
            Price = price;
            Kvo = kvo;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value >= 1 && value <= 20)
                {
                    price = value;
                }
                else
                {
                    Console.WriteLine("Цена должна быть в диапазоне от 1 до 20.");
                }
            }
        }

        public int Kvo
        {
            get { return kvo; }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    kvo = value;
                }
                else
                {
                    Console.WriteLine("Количество должно быть в диапазоне от 0 до 10.");
                }
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("Товар: " + Name + " Цена: " + Price + " Колличество: " +Kvo);
        }
        public void ShowTotalPrice()
        {
            Console.WriteLine("Товар вида: " + Name + " стоит всего: " + Price*Kvo);
        }
        public void ShowTotalPriceAll()
        {
            Console.WriteLine("Товар стоит всего: " + total);
        }
    }
}
