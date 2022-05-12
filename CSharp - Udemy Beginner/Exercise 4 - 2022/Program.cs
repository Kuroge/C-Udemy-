using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4___2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor introduce el límite de velocidad: ");
            int speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Por favor introduce la velocidad a la que circula el vehículo: ");
            int actualSpeed = Convert.ToInt32(Console.ReadLine());
            if (actualSpeed <= speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                CalculateDemeritPoints(speedLimit, actualSpeed);
            }
            Console.ReadKey();
        }
        public static void CalculateDemeritPoints(int speedLimit, int actualSpeed) 
        {
            int speedOverLimit = actualSpeed - speedLimit;
            int demeritPoints = speedOverLimit / 5;
            if (demeritPoints <= 12)
            {
                Console.WriteLine(demeritPoints + " " + "demerit points incurred.");
            }
            else
            {
                Console.WriteLine("License Suspended");
            }
        }
    }
}
