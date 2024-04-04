using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Transport
    {
        private string model;
        private int speed;
        private int mass;

        public string Model { get => model; set => model = value; }
        public int Speed { get => speed; set => speed = value; }
        public int Mass { get => mass; set => mass = value; }

        public Transport()
        {

        }
        public Transport(string mo, int sp, int ma)
        {
            Model = mo;
            Speed = sp;
            Mass = ma;
        }
        public void Start()
        {
            Console.WriteLine("Старт Модель " + Model + " Скорость " + Speed + " Масса " + Mass);
        }
        public void Stop()
        {
            Console.WriteLine("Остановка Модель " + Model + " Скорость " + Speed + " Масса " + Mass);
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine("Модель " + Model + " Скорость " + Speed + " Масса " + Mass);
        }
    }
}
