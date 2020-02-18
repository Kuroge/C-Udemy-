using System;
using System.Collections.Generic;

namespace Exercise_1___Text
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, inserta una serie de números separados por '-'");
            var input = Console.ReadLine();
            List<int> numbers = new List<int>();
            foreach (var number in input.Split("-"))
            {
                numbers.Add(Convert.ToInt32(number));
            }
            numbers.Sort();
            var isConsecutive = true;
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }
            if (isConsecutive)
            {
                Console.WriteLine("Son consecutivos");
            }
            else
            {
                Console.WriteLine("No son consecutivos");
            }

        }
    }
}
