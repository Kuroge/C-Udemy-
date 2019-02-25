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
            var numbers = new List<int>();
            while (true)
            {
                Console.WriteLine("Introduce una lista de números separados por comas: ");
                List<string> inputs = Console.ReadLine().Split(',').ToList();

                if (inputs.Count < 5 || !inputs.Any())
                {
                    Console.WriteLine("Invalid list, retry");
                    continue;
                }

                foreach (var input in inputs)
                {
                    numbers.Add(Convert.ToInt32(input));
                }
                break;
            }
            numbers.Sort();

            Console.WriteLine("The three smallest numbers are {0}", string.Join(",", numbers.GetRange(0, 3)));
            Console.ReadKey();
        }
    }
}
