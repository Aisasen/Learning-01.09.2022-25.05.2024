using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Moto: Transport
    {
        public Moto(string mo, int sp, int ma)
        {
            Model = mo;
            Speed = sp;
            Mass = ma;
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Мото Модель " + Model + " Скорость " + Speed + " Масса " + Mass);
        }
    }
}
