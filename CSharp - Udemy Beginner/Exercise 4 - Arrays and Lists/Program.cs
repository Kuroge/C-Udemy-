using System;
using System.Collections.Generic;

namespace Exercise_4___Arrays_and_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberList = new List<int>();
            while (true)
            {
                Console.WriteLine("Por favor, inserta un número");
                var input = Console.ReadLine();
                if (input.ToLower().Equals("quit") || String.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                numberList.Add(Convert.ToInt32(input));
            }

            var uniques = new List<int>();
            foreach (var number in numberList)
            {
                if (!uniques.Contains(number))
                {
                    uniques.Add(number);
                }
            }
            Console.WriteLine("Los números unicos son: " + String.Join(",", uniques));
        }
    }
}
