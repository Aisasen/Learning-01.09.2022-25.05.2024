using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker Student = new Worker();
            Student.name = "Vladimir";
            Student.surname = "Tarasov";
            Student.rate = 200;
            Student.days = 30;
            Student.GetFullName();
            Console.WriteLine(Student.GetSalary(Student.rate, Student.days));
            MyString TextTest = new MyString();
            TextTest.text = "asdfghj jhjdshgfuf vhburhvru";
            Console.WriteLine(TextTest.Reverse(TextTest.text));
            Console.WriteLine(TextTest.UcFirst(TextTest.text));
            Console.WriteLine(TextTest.UcWords(TextTest.text));
        }
    }
}
