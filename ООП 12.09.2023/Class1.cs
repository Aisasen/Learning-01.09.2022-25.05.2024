using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Worker
    {
        public string name;
        public string surname;
        public int rate;
        public int days;
        public void GetFullName()
        {
            Console.WriteLine(name);
            Console.WriteLine(surname);
        }
        public int GetSalary(int rate, int days)
        {
            return rate * days;
        }
    }
}
