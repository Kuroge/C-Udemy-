using System;

namespace Exercise_4___Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int trys = 4;
            var random = new Random();
            var randomNumber = random.Next(1, 10);
            Console.WriteLine(randomNumber);
            for (int i = 0; i < trys; i++)
            {
                Console.WriteLine("Intenta adivinar el número! - Intento nº " + (i+1));
                var input = Convert.ToInt32(Console.ReadLine());
                if (input == randomNumber)
                {
                    Console.WriteLine("Has ganado!");
                    break;
                }
                Console.WriteLine("Has perdido!");
                continue;
            }
        }
    }
}
