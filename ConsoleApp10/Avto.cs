using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal abstract class Avto
    {
        // объявляем поля с модификатором protected, доступные в классах-потомках
        protected string model;
        protected int speed;
        protected string dop;

        public string Model { get => model; set => model = value; }
        public int Speed { get => speed; set => speed = value; }
        public string Dop { get => dop; set => dop = value; }

        public abstract void Drive();   // объявляем абстрактный метод Drive
        public void Show()  // объявляем обычный метод Show
        {
            Console.WriteLine("модель {0}, скорость {1}, двигатель {2}", Model, Speed, Dop);
        }
    }
    interface ITurbo 
    { 
        void Turbo(); 
    }
    interface IEco 
    { 
        void Eco(); 
    }

}
