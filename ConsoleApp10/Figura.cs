using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal abstract class Figura
    {
        private int radius;
        private int a;
        private int b;

        public int Radius { get => radius; set => radius = value; }
        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }

        public abstract void Area ();
    }
}
