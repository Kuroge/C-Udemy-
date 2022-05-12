using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5___Text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor introduce una palabra: ");
            var input = Console.ReadLine().ToLower();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error");
                return;
            }

            Console.WriteLine($"Se han encontrado {CountVowels(input)} vocales");
        }

        public static int CountVowels(string word)
        {
            int vowelCount = 0;
            foreach (var letter in word)
            {
                if (letter.Equals('a') || letter.Equals('e') || letter.Equals('i') || letter.Equals('o') || letter.Equals('u'))
                {
                    vowelCount++;
                }
            }
            return vowelCount;
        }
    }
}
