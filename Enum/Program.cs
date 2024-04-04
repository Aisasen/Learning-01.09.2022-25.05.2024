using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank ibn1 = new Bank(20000, Bank.BankType.Personal);
            Bank ibn2 = new Bank(25000, Bank.BankType.Corporate);
            Bank.ShowInfo(ibn1);
            Bank.ShowInfo(ibn2);
            Bank.Append(ibn1, 22343);
            Bank.Recharge(ibn2, 4398);
            Bank.Recharge(ibn2, 50000);
        }
    }
}
