using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Computer
    {
        private string model;
        public int ram;

        public string Model { get => model; set => model = value; }
        public int Ram { get => ram; set => ram = value; }

        public Computer()
        {

        }
        public Computer(string model, int ram) 
        {
            Ram = ram;
            Model = model;
        }
        public virtual void Start()
        {
            Console.WriteLine("Включение, память: "+ram+" Модель: "+ Model);
        }
        public virtual void End()
        {
            Console.WriteLine("Выключается, память: " + ram + " Модель: " + Model);
        }
    }
}
