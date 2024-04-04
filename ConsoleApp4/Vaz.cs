using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Vaz : Avto, IEco
    {
        public override void Drive()// переопределяем метод Drive
        { 
            Model = "vaz2107";
            Speed = 70; 
            Eco(); 
        }
        public void Eco()
        {
            Dop = "экологичный";
        }   // реализуем интерфейс Eco
    }

}
