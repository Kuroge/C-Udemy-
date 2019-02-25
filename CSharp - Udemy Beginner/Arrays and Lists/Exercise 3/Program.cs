using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();

            while (numbers.Count < 5)
            {
                Console.WriteLine("Enter an unique number: ");
                var input = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(input))
                {
                    Console.WriteLine("El número introducido no es único.");
                    continue;
                }
                else
                {
                    numbers.Add(input);
                }
            }
            numbers.Sort();
            Console.WriteLine("Los números ordenados son: {0}",string.Join(",", numbers));
            Console.ReadKey();
        }
    }
}
