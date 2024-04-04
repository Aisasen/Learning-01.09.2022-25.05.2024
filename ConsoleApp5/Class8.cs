using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Animal
    {
        private string name;
        private double ves;
        private string col;

        public string Name { get => name; set => name = value; }
        public double Ves { get => ves; set => ves = value; }
        public string Col { get => col; set => col = value; }
        public Animal() { }
        public Animal(string name, double ves, string col)
        {
            Name = name;
            Ves = ves;
            Col = col;
        }
        public void Run()
        {
            Console.WriteLine(Name+" Бежит");
        }
        public void Sleep()
        {
            Console.WriteLine(Name+" Спит");
        }
        public virtual void Golos()
        {
            Console.WriteLine(Name+" Подаёт голос");
        }
    }
}
