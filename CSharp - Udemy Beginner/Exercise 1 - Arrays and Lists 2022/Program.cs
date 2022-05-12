using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1___Arrays_and_Lists_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> likes = new List<string>();

            while (true)
            {

                Console.WriteLine("Por favor introduce un nombre: ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                likes.Add(input);
            }

            if (likes.Count == 1)
            {
                Console.WriteLine($"A {likes[0]} le ha gustado tu post.");
            }
            else if (likes.Count == 2)
            {
                Console.WriteLine($"A {likes[0]} y a {likes[1]} les ha gustado tu post.");
            }
            else if (likes.Count > 2)
            {
                Console.WriteLine($"A {likes[0]}, {likes[1]}  y a {likes.Count - 2} más les ha gustado tu post.");
            }
        }
    }
}
