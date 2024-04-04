using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace ConsoleApp4
{
    internal class Student
    {
        private string fam;
        private int kurs;
        private int age;
        private string name;
        private int id = 300;

        public string Fam 
        {
            get
            {
                if (fam == "")
                {
                    return "Неизвестный";
                }
                TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
                string titleCase = textInfo.ToTitleCase(fam);
                return titleCase;
            }
            set
            {
                fam = value;
            }
        }

        public int Kurs 
        {
            get 
            { 
                return kurs; 
            }
            set 
            { 
                kurs = (value < 1 || value > 4) ? 0 : value; 
            }
        }

        public int Age { get => age; set => age = value; }
        public string Name 
        {
            get 
            {
                if (name =="")
                {
                    return "Неизвестный";
                }
                return name;
            }
            set 
            {
                name = value;
            }
             
        }

        public Student() { }  
        public Student(string fam, int kurs)   
        {
            this.Fam = fam;
            this.Kurs = kurs;  
        }
        public Student (string name, string fam, int age, int kurs)
        {
            this.Age = age;
            this.Name = name;
            this.Fam = fam;
            this.Kurs = kurs;
        }
        public int Id { get { return id++; } }

        public void ShowInfo()  
        {
            Console.WriteLine("Студент "+ Kurs+" курса "+Fam+" "+Name+" Возраст: "+Age+" ID: "+Id);
        }

    }
}
