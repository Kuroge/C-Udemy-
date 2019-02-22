using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            while (true)
            {
                Console.WriteLine("Por favor introduce un número o 'ok' para salir");
                var enteredValue = Console.ReadLine();

                if (enteredValue.ToUpper().Equals("OK"))
                {
                    Console.WriteLine("La suma total es: {0}", count);
                    break;
                }
                else
                {
                    count += Convert.ToInt32(enteredValue);
                }
            }
            Console.ReadKey();
        }
    }
}
