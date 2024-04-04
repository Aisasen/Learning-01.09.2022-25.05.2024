using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Cat: Animal
    {
        public Cat(string name, double ves, string col)
        {
            Name = name;
            Ves = ves;
            Col = col;
        }
        public override void Golos()
        {
            Console.WriteLine(Name+" мяу");
        }
    }
}
