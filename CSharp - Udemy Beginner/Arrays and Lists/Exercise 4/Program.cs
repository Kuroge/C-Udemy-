using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Please enter a number: ");
                var input = Console.ReadLine();
                if (input.ToUpper().Equals("QUIT"))
                {
                    break;
                }
                numbers.Add(Convert.ToInt32(input));
            }
            var uniques = new List<int>();

            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                {
                    uniques.Add(number);
                }
            }

            Console.WriteLine("The list of unique numbers is: {0}", string.Join(",", uniques));
            Console.ReadKey();

        }
    }
}
