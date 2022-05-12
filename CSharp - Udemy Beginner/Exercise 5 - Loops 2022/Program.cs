using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5___Loops_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una lista de números separados por comas: ");
            string input = Console.ReadLine();
            char[] separator = { ',' };
            string[] numberList = input.Split(separator);
            int biggestNumber = 0;

            foreach (var number in numberList)
            {
                if (Convert.ToInt32(number) > biggestNumber)
                {
                    biggestNumber = Convert.ToInt32(number);
                }
            }
            Console.WriteLine($"El número más grande es: {biggestNumber}");
        }
    }
}
