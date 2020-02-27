using System;
using System.IO;

namespace Exercise_2___Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var longestWord = "";
            foreach (var word in File.ReadAllText(@"C:\temp\CSharpUdemy.txt").Split(" "))
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }
            Console.WriteLine(longestWord);
        }
    }
}
