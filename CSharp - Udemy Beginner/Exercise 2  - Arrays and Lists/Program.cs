using System;

namespace Exercise_2____Arrays_and_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, introduce tu nombre:");
            var input = Console.ReadLine();
            var array = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                array[i] = input[i];
            }
            Array.Reverse(array);
            Console.WriteLine(String.Join("",array));
        }
    }
}
