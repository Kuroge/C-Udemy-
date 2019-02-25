using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            while (true)
            {
                Console.WriteLine("Write the names of the people who liked your post on Feisbus: ");
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                else
                {
                    names.Add(input);
                }
            }

            if (names.Count == 1)
            {
                Console.WriteLine("{0} likes your post", names[0]);
            }
            else if (names.Count == 2)
            {
                Console.WriteLine("{0} and {1} liked your post", names[0], names[1]);
            }
            else if (names.Count > 2)
            {
                Console.WriteLine("{0}, {1} and {2} others liked your post.", names[0], names[1], names.Count - 2);
            }
            Console.ReadKey();
        }
    }
}
