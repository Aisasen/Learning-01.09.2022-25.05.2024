using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class BMW : Avto, ITurbo, IEco
    {
        public override void Drive()    // переопределяем метод Drive
        {
            Model = "BMV5";
            Speed = 90; 
            Turbo();
            Eco();
        }
        public void Turbo()
        {
            Dop = "турбо";
        }   // реализуем интерфейс Turbo
        public void Eco()
        {
            Dop = "экологичный";
        }   // реализуем интерфейс Eco
    }
}
