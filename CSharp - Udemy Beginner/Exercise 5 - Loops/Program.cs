using System;

namespace Exercise_5___Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, introduce 4 números:");
            var input = Console.ReadLine();
            var numbers = input.Split(',');
            var max = 0;
            foreach (var number in numbers)
            {
                if (Convert.ToInt32(number) > max)
                {
                    max = Convert.ToInt32(number);
                }
            }
            Console.WriteLine("Max is: " + max);
        }
    }
}
