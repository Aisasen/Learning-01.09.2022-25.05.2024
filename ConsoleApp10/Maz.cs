using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Maz : Avto, ITurbo
    {
        public override void Drive()    // переопределяем метод Drive
        {
            Model = "Maz200";
            Speed = 90; 
            Turbo();
        }
        public void Turbo()
        {
            Dop = "турбо";
        }   // реализуем интерфейс Turbo
    }

}
