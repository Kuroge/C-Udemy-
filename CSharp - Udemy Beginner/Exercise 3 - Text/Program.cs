using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3___Text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor introduce una hora en formato 24h (ej: 23:34)");

            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid time");
                return;
            }

            List<int> hour = new List<int>();

            foreach (var time in input.Split(':'))
            {
                hour.Add(Convert.ToInt32(time));
            }

            Console.WriteLine(ValidateTime(hour) ? "Ok" : "Invalid Time");

        }

        public static bool ValidateTime(List<int> hour)
        {
            if ((hour[0] >= 0 && hour[0] < 24) && (hour[1] >= 0 && hour[1] < 60))
            {
                return true;
            }
            return false;
        }
    }
}
