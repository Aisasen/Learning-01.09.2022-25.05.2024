using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Cat: Animal
    {
        public Cat()
        {
        }
        public Cat(string nam, int ros, int ve)
        {
            Name = nam;
            Rost = ros;
            Ves = ve;
        }
        public override void Golos()
        {
            Console.WriteLine("Мяу-мяу-мяу!");
        }
    }
}
