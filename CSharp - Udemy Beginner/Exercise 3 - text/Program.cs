using System;

namespace Exercise_3___text
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Porfavor introduce una hora en formato 24 horas. (ej. 19:00)");
            var input = Console.ReadLine();
            DateTime time;
            if (String.IsNullOrWhiteSpace(input) || !DateTime.TryParse(input, out time))
            {
                Console.WriteLine("Invalid");
            }
            else
            {
                Console.WriteLine("Ok");
            }
        }
    }
}
