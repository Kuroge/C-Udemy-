using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1___Loops_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int divisibleBy3 = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i%3 == 0)
                {
                    divisibleBy3++;
                }
            }
            Console.WriteLine(divisibleBy3);
        }
    }
}
