using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Bank
    {
        private static int nextId = 1;
        public int Id = 0;

        private int balance;
        public int Balance { get => balance; set => balance = value; }
        public enum BankType
        {
            Personal,
            Corporate,
            Charitable,
            Deposit,
        }
        public BankType Type { get; set; }
        public Bank() { }
        public Bank (int b, BankType ty) 
        { 
            this.balance = b;
            this.Type = ty;
            Id = nextId;
            nextId++;
        }
        public static void ShowInfo (Bank ibn)
        {
            Console.WriteLine("Тип: " + ibn.Type);
            Console.WriteLine("ID: " + ibn.Id);
            Console.WriteLine("Баланс: " + ibn.balance);
        }
        public static void Append(Bank ibn, int summ)
        {
            ibn.Balance += summ;
            Console.WriteLine("На счёте №" + ibn.Id + " осталось " + ibn.Balance);
        }
        public static void Recharge (Bank ibn, int summ)
        {
            if (ibn.Balance < summ)
            {
                Console.WriteLine("Недостаточно средств.");
            }
            else
            {
                ibn.Balance -= summ;
                Console.WriteLine("На счёте №" + ibn.Id + " осталось " + ibn.Balance);
            }
        }
    }
}
