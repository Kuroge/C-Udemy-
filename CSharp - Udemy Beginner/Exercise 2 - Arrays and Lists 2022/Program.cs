using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2___Arrays_and_Lists_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor introduce tu nombre: ");
            string name = Console.ReadLine();
            char[] chars = name.ToCharArray();
            Array.Reverse(chars);

            Console.WriteLine(string.Join(",", chars));
        }
    }
}
