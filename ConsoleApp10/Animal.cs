using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal abstract class Animal
    {
        private string name;
        private int rost;
        private int ves;

        public string Name { get => name; set => name = value; }
        public int Rost { get => rost; set => rost = value; }
        public int Ves { get => ves; set => ves = value; }

        public void Show()  // объявляем обычный метод Show
        {
            Console.WriteLine("Имя " + Name + " Рост " + Rost + " Вес " + Ves);
        }
        public abstract void Golos();
    }
}
