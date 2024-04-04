using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            Avto myAvto = GetAvto();    // создание объекта myAvto myAvto.Drive();
            myAvto.Drive();
            myAvto.Show();
            Animal Koshka = new Cat("Musya",20,5);
            Koshka.Show();
            Animal Sobaka = new Dog("Oddi", 25, 14);
            Sobaka.Show();
            Figura krug = new Circle(7);
            krug.Area();
            Figura rec = new Rectangle(8,9);
            rec.Area();
            Tovar adidas = new Obev(20000, 47, "Adidas");
            adidas.Print();
            Tovar hike = new Odejda(37, "Red", 25000, "NatureHike");
            hike.Print();
            Tovar tarelka = new Posuda("Yellow",5000,"Berzh",3);
            tarelka.Print();
        }
        static Avto GetAvto()   // метод выбора автомобиля
        {
            Console.Write("Введите марку автомобиля (Vaz, Maz, BMV): ");
            string mod = Console.ReadLine();
            switch (mod)
            {
                case "Vaz": return new Vaz();
                case "Maz": return new Maz();
                case "BMV": return new BMW();
                default: return new Maz();
            }
        }
    }

}
