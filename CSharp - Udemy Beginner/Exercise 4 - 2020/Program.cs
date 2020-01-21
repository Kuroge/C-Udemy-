using System;

namespace Exercise_4___2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter the speed limit");
            int speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, enter the current speed");
            int currentSpeed = Convert.ToInt32(Console.ReadLine());
            int demeritPoints;
            if (currentSpeed <= speedLimit)
            {
                Console.WriteLine("OK");
            }
            else
            {
                demeritPoints = (currentSpeed - speedLimit) / 5;
                if (demeritPoints < 12)
                {
                    Console.WriteLine($"{demeritPoints} demerit points");
                }
                else
                {
                    Console.WriteLine("License Suspended");
                }
            }
        }
    }
}
