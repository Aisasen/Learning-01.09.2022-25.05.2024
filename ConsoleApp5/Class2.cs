using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Notebook : Computer
    {
        private  int time;
        public new int Time
        {
            get { return time; }
            set { time = (value < 10) ? 15 : value; }
        }
        // Конструкторы не наследуются, а вызываются! Поэтому их нужно создавать
        // в каждом классе-потомке. При этом можно ссылаться на базовый класс
        // и лишь добавлять новые параметры.
        public Notebook() { }
        public Notebook(string model, int ram, int time)
        { this.Time = time; }
        // Создадим новый метод End класса – наследника с модификатором override.
        public override void Start()
        {
            Console.WriteLine("{0} Включается, заряд {1} мин", Model, Time);
        }
        public override void End()
        {
            Console.WriteLine("{0} выключается, заряд {1} мин", Model, Time);
        }

    }
}
