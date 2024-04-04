using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Kadry
    {
        private string fam;
        private int age;
        private string dol;
        private int staj;

        public Kadry(string fam, int age, string dol, int staj)
        {
            Fam = fam;
            Age = age;
            Dol = dol;
            Staj = staj;
        }

        public string Fam
        {
            get { return fam; }
            set { fam = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 16 && value <= 60)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Возраст должен быть в диапазоне от 16 до 60 лет.");
                }
            }
        }

        public string Dol
        {
            get { return dol; }
            set { dol = value; }
        }

        public int Staj
        {
            get { return staj; }
            set
            {
                if (value >= 0 && value <= Age)
                {
                    staj = value;
                }
                else
                {
                    Console.WriteLine("Стаж должен быть в диапазоне от 0 до текущего возраста!");
                }
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("Фамилия: " + Fam + " Возраст: " + Age + " Должность: " + Dol + " Стаж: " + Staj);
        }
    }
}
