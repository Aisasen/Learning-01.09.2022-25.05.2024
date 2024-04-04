using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Netbook: Notebook
    {
        public double mass;
        public Netbook(){}
        public Netbook(double mas, int time)
        {
            this.mass = mas;
            this.Time = time;
        }
        public override void Start()
        {
            Console.WriteLine("Model "+ "Включается, заряд "+ Time+ " мин, масса: "+ mass);
        }
    }
}
