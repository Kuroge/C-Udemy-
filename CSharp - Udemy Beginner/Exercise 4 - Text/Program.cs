using System;
using System.Collections.Generic;

namespace Exercise_4___Text
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Porfavor introduce una serie de palabras separadas por comas");
            var input = Console.ReadLine().ToLower().Split(" ");
            List<string> pascalVar = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                pascalVar.Add(input[i].Substring(0, 1).ToUpper() + input[i].Substring(1));
            }
            Console.WriteLine(String.Join("", pascalVar));


        }
    }
}
