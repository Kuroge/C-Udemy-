using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2___2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor introduce el primer número: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Por favor introduce el segundo número: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2)
            {
                Console.WriteLine(number1);
            }
            else
            {
                Console.WriteLine(number2);
            }
            Console.ReadKey();
        }
    }
}
