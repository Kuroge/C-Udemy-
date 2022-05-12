using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2___Loops_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            while (true)
            {
                Console.WriteLine("Por favor introduce un número o 'ok' para salir");
                var input = Console.ReadLine();
                if (input.Equals("ok"))
                {
                    Console.WriteLine(count);
                    break;
                }
                count += Convert.ToInt32(input);
            }
        }
    }
}
