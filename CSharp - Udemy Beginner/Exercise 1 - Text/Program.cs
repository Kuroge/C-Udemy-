using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1___Text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor introduce una lista de números separados por guiones: ");

            string[] input = Console.ReadLine().Split('-');
            bool isConsecutive = IsConsecutive(input);

            Console.WriteLine(isConsecutive ? "La lista es consecutiva" : "La lista no es consecutiva");
        }

        public static bool IsConsecutive(string[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (Convert.ToInt32(numbers[0]) > Convert.ToInt32(numbers[numbers.Length - 1]))
                {
                    if (Convert.ToInt32(numbers[i + 1]) == Convert.ToInt32(numbers[i]) - 1)
                    {
                        continue;
                    }
                }
                else
                {
                    if (Convert.ToInt32(numbers[i + 1]) == Convert.ToInt32(numbers[i]) + 1)
                    {
                        continue;
                    }
                }
                return false;
            }
            return true;
        }
    }
}
