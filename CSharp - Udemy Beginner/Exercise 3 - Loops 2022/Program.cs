using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3___Loops_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor introduce un número para calcular su factorial: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int factorial = number;

            for (int i = number-1; i > 0; i--)
            {
                Console.WriteLine(i);
                factorial *= i;
            }
            Console.WriteLine($"!{number}={factorial}");
        }
    }
}
