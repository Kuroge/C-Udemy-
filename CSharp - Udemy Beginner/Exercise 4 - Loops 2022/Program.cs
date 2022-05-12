using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4___Loops_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int randomNumber = new Random().Next(1, 10);
            Console.WriteLine($"El número secreto es: {randomNumber}");
            Console.WriteLine("Tienes cuatro oportunidades para acertar el número!");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Introduce el número: ");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == randomNumber)
                {
                    Console.WriteLine("Has ganado!");
                    break;
                }
                Console.WriteLine("Has perdido!");
            }
            Console.WriteLine("Se acabó!");
        }
    }
}
