using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1___2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor introduce un número entre 1 y 10");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
