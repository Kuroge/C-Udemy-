using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise_1___Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Primer uso
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Thread.Sleep(5000);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Duration);

            // Segundo uso
            stopwatch.Clear();
            stopwatch.Start();
            Thread.Sleep(6000);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Duration);

            // Tercer uso 
            stopwatch.Clear();
            stopwatch.Stop();
              
        }
    }
}
