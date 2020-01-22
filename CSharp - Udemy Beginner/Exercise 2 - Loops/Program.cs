using System;

namespace Exercise_2___Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            while (true)
            {
                Console.WriteLine("Please enter a number:");
                var input = Console.ReadLine();
                if (input.ToLower().Equals("ok"))
                {
                    break;
                }
                sum += Convert.ToInt32(input);
            }
            Console.WriteLine("La suma de los números introducidos es:" + sum);
        }
    }
}
