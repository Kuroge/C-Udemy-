using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int enteredValue;
            Console.WriteLine("Por favor introduce un número para calcular su factorial:");
            enteredValue = Convert.ToInt32(Console.ReadLine());
            int factorial = enteredValue;

            for (int i = enteredValue-1; i > 0; i--)
            {
                factorial = factorial * i;
            }

            Console.WriteLine("El factorial de {0} es: {1}.", enteredValue, factorial);
            Console.ReadKey();
        }
    }
}
