using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Tour
    {
        public static void TourCalc()
        {
            Console.WriteLine("Чёрное море: бесплатно");
        }
        public static void TourCalc(string county)
        {
            Console.WriteLine(county+": 1 день, 5000 рублей");
        }
        public static void TourCalc(string county, int days)
        {
            Console.WriteLine(county+": "+days+" дней, стоимость - "+5000*days+" рублей");
        }
    }
}
