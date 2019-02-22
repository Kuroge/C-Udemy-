using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int secret = random.Next(1, 10);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Shhh, secret is {0}", secret);
                Console.WriteLine("Introduce un número: ");
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == secret)
                {
                    Console.WriteLine("You won!");
                    break;
                }
                else
                {
                    Console.WriteLine("You lost! Keep trying");
                }
            }

            Console.WriteLine("Kill yourself");
            Console.ReadKey();
            
        }
    }
}
