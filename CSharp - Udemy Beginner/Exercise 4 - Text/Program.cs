using System;
using System.Collections.Generic;

namespace Exercise_4___Text
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Porfavor introduce una serie de palabras separadas por espacios");
            var input = Console.ReadLine();
            Console.WriteLine(ToPascalCase(input));

        }
        public static string ToPascalCase(string input)
        {
            var inputList = input.ToLower().Split(" ");
            List<string> pascalVar = new List<string>();
            for (int i = 0; i < inputList.Length; i++)
            {
                pascalVar.Add(inputList[i].Substring(0, 1).ToUpper() + inputList[i].Substring(1));
            }
            return String.Join("", pascalVar);
        }
    }
}
