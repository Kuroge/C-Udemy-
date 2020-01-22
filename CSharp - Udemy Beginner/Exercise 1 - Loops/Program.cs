using System;

namespace Exercise_1___Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersDivisibleByThree = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    numbersDivisibleByThree += 1;
                }
            }
            Console.WriteLine("There are " + numbersDivisibleByThree + " divisibles by three between 1 and 100");
        }
    }
}
