using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3- Write a program and ask the user to enter the width and height of an image.
             *Then tell if the image is landscape or portrait.*/
            int width;
            int height;
            string aspectRatio;

            Console.WriteLine("Please enter width of image: ");
            width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter height of image: ");
            height = Convert.ToInt32(Console.ReadLine());

            aspectRatio = width > height ? "Landscape" : "Portrait";

            Console.WriteLine("The aspect ratio of the image is {0}.", aspectRatio);
            Console.ReadKey();
        }
    }
}
