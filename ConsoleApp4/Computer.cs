using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Computer
    {
        private string model;
        private int ram;
        private int hdd;

        public Computer(string model, int ram, int hdd)
        {
            Model = model;
            Ram = ram;
            Hdd = hdd;
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Ram
        {
            get { return ram; }
            set
            {
                if (value >= 2 && value <= 32)
                {
                    ram = value;
                }
                else
                {
                    Console.WriteLine("Объем ОЗУ должен быть в диапазоне от 2 до 32 Гбайт.");
                }
            }
        }

        public int Hdd
        {
            get { return hdd; }
            set
            {
                if (value >= 200 && value <= 2000)
                {
                    hdd = value;
                }
                else
                {
                    Console.WriteLine("Объем жесткого диска должен быть в диапазоне от 200 до 2000 Гбайт.");
                }
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("Модель: "+Model+" Объем ОЗУ: "+Ram+" Гбайт"+" Объем жесткого диска: " + Hdd + " Гбайт");
        }
    }
}
