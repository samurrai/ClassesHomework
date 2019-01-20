using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[5];
        }
    }
    partial class Car
    {
        public void Beep()
        {
            Console.WriteLine("Beep!");
        }
    }
}
