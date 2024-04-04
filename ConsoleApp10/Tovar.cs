using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal abstract class Tovar
    {
        private string name;
        private int price;
        private int totalPrice;

        private int quantity;
        private int size;
        private int mass;
        private string color;


        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Size { get => size; set => size = value; }
        public int Mass { get => mass; set => mass = value; }
        public string Color { get => color; set => color = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }

        public abstract void CalcSum();
        public void Print()
        {
            Console.WriteLine("Имя товара " + Name);
            Console.WriteLine("Размер " + Size);
            Console.WriteLine("Масса " + Mass);
            Console.WriteLine("Цвет " + Color);
            Console.WriteLine("Количество " + Quantity);
            Console.WriteLine("Цена " + Price);
            Console.WriteLine("Итоговая цена " + totalPrice);
        }
    }
}
