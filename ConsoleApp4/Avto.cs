using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp4
{
    internal class Avto
    {
        private string brand;
        private string color;
        private int skor;

        public Avto() { }
        public Avto(string brand, string color, int skor)
        {
            Brand = brand;
            Color = color;
            Skor = skor;
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public int Skor
        {
            get { return skor; }
            set
            {
                if (value >= 20 && value <= 120)
                {
                    skor = value;
                }
                else
                {
                    Console.WriteLine("Скорость должна быть в диапазоне от 20 до 120 км/ч.");
                }
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("Брэнд: "+Brand+" Цвет: "+Color+" Скорость: "+Skor);
        }
    }
}
