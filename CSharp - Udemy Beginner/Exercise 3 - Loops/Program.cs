using System;

namespace Exercise_3___Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Porfavor introduce un número:");
            var input = Convert.ToInt32(Console.ReadLine());
            var factorial = input;
            for (int i = input-1; i > 0; i--)
            {
                factorial *= i;
            }
            Console.WriteLine("5! = " + factorial);
        }
    }
}
