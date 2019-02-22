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

            int divisibleByThree = 0;

            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    divisibleByThree++;
                }
            }

            Console.WriteLine(divisibleByThree + " numbers are divisible by three with no remainder.");
            Console.ReadKey();
        }
    }
}
