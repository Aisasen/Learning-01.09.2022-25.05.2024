using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Velo: Transport
    {
        public Velo(string mo, int sp, int ma)
        {
            Model = mo;
            Speed = sp;
            Mass = ma;
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Вело Модель " + Model + " Скорость " + Speed + " Масса " + Mass);
        }
    }
}
