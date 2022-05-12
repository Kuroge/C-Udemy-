using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4___Arrays_and_Lists_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            List<int> uniques = new List<int>();

            while (true)
            {
                Console.WriteLine("Por favor introduce un número: ");
                string input = Console.ReadLine();

                if (input.ToLower().Equals("quit"))
                {
                    break;
                }
                numbers.Add(Convert.ToInt32(input));
            }

            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                {
                    uniques.Add(number);
                }
            }
            Console.WriteLine($"{string.Join(",", uniques)}");

        }
    }
}
