using System;

namespace Exercise_3___Arrays_and_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert 5 numbers");
            var numbers = new int[5];
            var i = 0;
            while (i < 5)
            {
                Console.WriteLine("Please insert number: " + i);
                var input = Convert.ToInt32(Console.ReadLine());
                if (!Array.Exists(numbers, element => element == input))
                {
                    numbers[i] = input;
                    i++;
                    continue;
                }
                Console.WriteLine("Ese número ya existe");
            }
            Array.Sort(numbers);
            Console.WriteLine(String.Join(",", numbers));
        }
    }
}
