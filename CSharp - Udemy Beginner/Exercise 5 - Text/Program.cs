using System;

namespace Exercise_5___Text
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an english word");
            var input = Console.ReadLine();
            Console.WriteLine("There are {0} vowels in that word", CountVowels(input));

        }

        public static int CountVowels(string input)
        {
            char[] vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };
            var vowelsCount = 0;
            foreach (var letter in input.ToLower())
            {
                if (Array.Exists(vowels, vowel => vowel.Equals(letter)))
                {
                    vowelsCount += 1;
                }
            }
            return vowelsCount;
        }
    }
}
