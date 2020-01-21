using System;

namespace Exercise_2___2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            if (number1 > number2)
            {
                Console.WriteLine(number1);
            }
            else
            {
                Console.WriteLine(number2);
            }
        }
    }
}
