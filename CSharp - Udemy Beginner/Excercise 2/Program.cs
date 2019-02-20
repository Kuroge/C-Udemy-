using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2- Write a program which takes two numbers from the console and displays the maximum of the two.*/

            int number1;
            int number2;

            Console.WriteLine("Please, enter first number:");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, enter second number:");
            number2 = Convert.ToInt32(Console.ReadLine());

            var max = number1 > number2 ? number1 : number2;

            Console.WriteLine("Max is: {0}", max);
            Console.ReadKey();
        }
    }
}
