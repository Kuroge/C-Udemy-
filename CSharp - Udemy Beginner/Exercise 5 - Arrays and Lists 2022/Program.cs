using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5___Arrays_and_Lists_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> validList = new List<int>();

            while (true)
            {
                Console.WriteLine("Por favor introduce una lista de números separados por comas: ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input) || input.Split(',').Count() < 5)
                {
                    Console.WriteLine("La lista no es válida, introduce otra.");
                    continue;
                }
                foreach (var number in input.Split(','))
                {
                    validList.Add(Convert.ToInt32(number));
                }
                break;
            }
            validList.Sort();
            Console.WriteLine($"{String.Join(", ", validList.GetRange(0,3))}");
        }
    }
}
