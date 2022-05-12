using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2___Text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una lista de números separados por guiones: ");
            string input = Console.ReadLine();
            List<int> numbers = new List<int>();

            if (string.IsNullOrWhiteSpace(input))
            {
                return;
            }

            foreach (var number in input.Split('-'))
            {
                numbers.Add(Convert.ToInt32(number));
            }
            var repeatedValues = CheckDuplicates(numbers);

            Console.WriteLine(repeatedValues ? "Hay números repetidos en la lista" : "No hay números repetidos");
        }

        public static bool CheckDuplicates(List<int> numbers)
        {
            foreach (var number in numbers)
            {
                if (numbers.FindAll(i => i == number).Count > 1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
