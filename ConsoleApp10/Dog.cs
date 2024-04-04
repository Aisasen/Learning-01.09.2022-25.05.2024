using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Dog: Animal
    {
        public Dog(string nam, int ros, int ve)
        {
            Name = nam;
            Rost = ros;
            Ves = ve;
        }
        public override void Golos()
        {
            Console.WriteLine("Гав-гав-гав!");
        }
    }
}
