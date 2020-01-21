using System;

namespace Exercise_3___2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter width");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter height");
            int height = Convert.ToInt32(Console.ReadLine());
            if (width > height)
            {
                Console.WriteLine("Image is a landscape");
            }
            else
            {
                Console.WriteLine("Image is a portrait");
            }
        }
    }
}
