using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor introduce una lista de números separados por comas: ");
            var input = Console.ReadLine();
            var numbers = input.Split(',');
            int max = Convert.ToInt32(numbers[0]);

            for (int i = 0; i < numbers.Length; i++)
            {
                if (Convert.ToInt32(numbers[i]) > max)
                {
                    max = Convert.ToInt32(numbers[i]);
                }
            }

            Console.WriteLine("Max number is {0}", max);
            Console.ReadKey();
        
        }
    }
}
