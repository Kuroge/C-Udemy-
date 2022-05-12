using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4___Text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor introduce una serie de palabras separadas por espacios");

            List<string> input = Console.ReadLine().Split(' ').ToList();

            if (string.IsNullOrWhiteSpace(string.Join("", input)))
            {
                Console.WriteLine("Error");
                return;
            }

            Console.WriteLine(ToPascalCase(input));
        }

        public static string ToPascalCase(List<string> input)
        {
            List<string> output = new List<string>();

            foreach (var word in input)
            {
                output.Add(char.ToUpper(word[0]) + word.Substring(1).ToLower());
            }
            return String.Join("", output);
        }
    }
}
