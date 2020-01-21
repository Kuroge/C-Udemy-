using System;

namespace Exercise_1___2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 1 and 10");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0 && number < 11)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
