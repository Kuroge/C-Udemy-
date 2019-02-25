using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            var name = Console.ReadLine().ToCharArray();
            Console.WriteLine("Your name reversed is: {0}", string.Join("", name.Reverse()));
            Console.ReadKey();
        }
    }
}
