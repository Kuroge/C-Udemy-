using System;
using System.Collections.Generic;

namespace Exercise_5___Arrays_and_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray;
            while (true)
            {
                Console.WriteLine("Por favor introduce una lista de números separados por comas");
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("La lista está vacia");
                    continue;
                }
                stringArray = input.Split(",");
                if (stringArray.Length < 5)
                {
                    Console.WriteLine("La lista debe contener 5 números");
                    continue;
                }
                break;
            }

            var numbers = new List<int>();

            foreach (var number in stringArray)
            {
                numbers.Add(Convert.ToInt32(number));
            }

            numbers.Sort();
            Console.WriteLine("Los tres números mas pequeños son: " + String.Join(",", numbers.GetRange(0, 3)));
        }
    }
}
