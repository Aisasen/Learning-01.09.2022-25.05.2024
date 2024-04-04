using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Dog: Animal
    {
        public Dog(string name, double ves, string col)
        {
            Name = name;
            Ves = ves;
            Col = col;
        }
        public override void Golos()
        {
            Console.WriteLine(Name + " гав");
        }
    }
}
