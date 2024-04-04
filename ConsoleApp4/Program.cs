using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student("Иван", 3);
            st1.ShowInfo();
            Student st2 = new Student("", 7);
            st2.ShowInfo();
            Student st3 = new Student("Пётр", "Петров", 20, 4);
            st3.ShowInfo();
            Student st4 = new Student("Петров", "", 19, 3);
            st4.ShowInfo();
            Student st5 = new Student("", "Акмар", 19, 3);
            st5.ShowInfo();
            st5.ShowInfo();
            Avto Merc = new Avto("Merc","Black", 121);
            Merc.ShowInfo();
            Kadry Divan = new Kadry("Диванчик", 33, "Самоходная Установка", 35);
            Divan.ShowInfo();
            Computer Asus = new Computer("Asus", 32, 250);
            Asus.ShowInfo();
            Tovar Shkaf = new Tovar("Shkaf", 15, 5);
            Shkaf.ShowInfo();
            Shkaf.ShowTotalPrice();
            Console.ReadKey();
        }
    }
}
