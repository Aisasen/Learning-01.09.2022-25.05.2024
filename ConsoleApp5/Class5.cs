using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Avto: Transport
    {
        public Avto(string mo, int sp, int ma)
        {
            Model = mo;
            Speed = sp;
            Mass = ma;
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Авто Модель " + Model + " Скорость " + Speed + " Масса " + Mass);
        }
    }
}
