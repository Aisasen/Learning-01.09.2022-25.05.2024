using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer comp2 = new Computer("Dell", 4096);
            comp2.Start();
            comp2.End();
            Notebook nb = new Notebook("Asus", 1024, 120);
            nb.Start();
            nb.End();
            Netbook netb = new Netbook(4,60);
            netb.Start();
            Transport auto = new Avto("Ferari",200,400);
            auto.Start();
            Transport velos = new Velo("Stern", 50, 5);
            velos.Start();
            Transport moci = new Moto("Hardvan", 250, 70);
            moci.Start();
            Animal kot = new Cat("Муся",5,"Черно-белый");
            Animal sobak = new Dog("Одди",10,"Рыжий");
            kot.Golos();
            sobak.Golos();
            Tovar VoinaIMir = new Book("Война и Мир", 1000, 4);
            VoinaIMir.Calc();
            Tovar Adil = new Book("Adil", 200, 25);
            Adil.Calc();
            Tovar Erzha = new Book("Ержа", 2000, 2);
            Erzha.Calc();
        }
    }
}
