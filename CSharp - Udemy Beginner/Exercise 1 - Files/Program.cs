using System;
using System.IO;

namespace Exercise_1___Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var txt = File.ReadAllText(@"C:\temp\CSharpUdemy.txt");
            Console.WriteLine("File contains {0} words", txt.Split(" ").Length);

        }
    }
}
