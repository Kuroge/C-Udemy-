using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {

            /*4- Your job is to write a program for a speed camera. For simplicity, ignore the details
             *such as camera, sensors, etc and focus purely on the logic. Write a program that asks the
             *user to enter the speed limit. Once set, the program asks for the speed of a car. If the 
             *user enters a value less than the speed limit, program should display Ok on the console. 
             *If the value is above the speed limit, the program should calculate the number of demerit points.
             *For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
             *If the number of demerit points is above 12, the program should display License Suspended.*/


            int speedLimit;
            int actualSpeed;
            int demeritPoints;

            Console.WriteLine("Please, enter the speed limit: ");
            speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, enter the actual speed of the car: ");
            actualSpeed = Convert.ToInt32(Console.ReadLine());

            demeritPoints = actualSpeed > speedLimit ? ((actualSpeed - speedLimit) / 5) : 0;

            if (demeritPoints  > 0 && demeritPoints <= 12)
            {
                Console.WriteLine("Demerit points: {0}", demeritPoints);
            }
            else if (demeritPoints > 12)
            {
                Console.WriteLine("Lincese Suspended");
            }
            else
            {
                Console.WriteLine("Ok");
            }

            Console.ReadKey();

        }
    }
}
