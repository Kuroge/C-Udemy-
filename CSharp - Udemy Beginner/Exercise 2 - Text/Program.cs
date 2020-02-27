using System;
using System.Collections.Generic;

namespace Exercise_2___Text
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, introduce números separados por '-'");
            var input = Console.ReadLine();
            if (!String.IsNullOrWhiteSpace(input))
            {
                List<int> numbers = new List<int>();
                foreach (var number in input.Split('-'))
                {
                    numbers.Add(Convert.ToInt32(number));
                }
                if (Duplicates(numbers))
                {
                    Console.WriteLine("Duplicates");
                }
                else
                {
                    Console.WriteLine("No duplicates");
                }
            }
        }
        public static bool Duplicates(List<int> numbers)
        {
            List<int> uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (uniques.Exists(duplicate => duplicate == number))
                {
                    return true;
                }
                uniques.Add(number);
            }
            return false;
        }
    }
}
