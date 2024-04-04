using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Zakaz
    {
        private string fam; 
        private int size; 
        private string comfort;
        // создаем четыре конструктора

        public Zakaz(string fm, int sz, string cmf) // 3 параметра
        { 
            fam = fm;
            size = sz;
            comfort = cmf; 
        }
        public Zakaz(string fm, int sz) // 2 параметра
        { 
            fam = fm;
            size = sz;
            comfort = "стандарт"; 
        }
        public Zakaz(string fm) // 1-параметр
        { 
            fam = fm;
            size = 3;
            comfort = "стандарт"; 
        }
        public Zakaz()  // без параметров
        { 
            fam = "неизвестный";
            size = 6;
            comfort = "общежитие"; 
        }
        public void Show()
        {
            Console.WriteLine(fam+ " забронировал "+size +" местный номер класса " +comfort);
        }
        public static void Cycle()
        {
            while (true)
            {
                Console.WriteLine("Введите Фамилию");
                string fam = Console.ReadLine();
                if (fam == "Q")
                {
                    return;
                }
                Console.WriteLine("Введите количество мест в номере");
                string nom = Console.ReadLine();
                if (nom == "Q")
                {
                    return;
                }
                Console.WriteLine("Введите комфорт");
                string com = Console.ReadLine();
                if (com == "Q")
                {
                    return;
                }
                if (fam!=null & nom!=null & com!=null)
                {
                    Zakaz zakazy = new Zakaz(fam, Convert.ToInt32(nom), com);
                    zakazy.Show();
                }
                
                if (com==null)
                {
                    Zakaz zakazy = new Zakaz(fam, Convert.ToInt32(nom));
                    zakazy.Show();
                }
                if (com == null & nom==null)
                {
                    Zakaz zakazy = new Zakaz(fam);
                    zakazy.Show();
                }
            }
        }
    }
}
