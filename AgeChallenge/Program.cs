using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int currentYear = 2022;

            Console.WriteLine("¿Qué edad tienes?");
            Int32 age = 0;
            Int32.TryParse(Console.ReadLine(), out age);
            int x = currentYear - age;
            Console.WriteLine("Naciste en el año " + x);
            Console.ReadKey();
        }
    }
}
