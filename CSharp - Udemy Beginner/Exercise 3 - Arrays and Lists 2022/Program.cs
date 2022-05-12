using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3___Arrays_and_Lists_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            int counter = 0;

            while (counter < 5)
            {
                Console.WriteLine("Por favor introduce un número: ");
                int temp = Convert.ToInt32(Console.ReadLine());

                if (Array.IndexOf(numbers, temp) != -1)
                {
                    Console.WriteLine("El número ya existe en el Array, introduce otro");
                    continue;
                }
                numbers[counter] = temp;
                counter++;
            }
            Array.Sort(numbers);
            Console.WriteLine(string.Join(",", numbers));
        }
    }
}
