using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3___2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor introduce el ancho de la imagen: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Por favor introduce el alto de la imagen: ");
            int height = Convert.ToInt32(Console.ReadLine());

            if (width > height)
            {
                Console.WriteLine("La imagen está en modo Landscape");
            }
            else
            {
                Console.WriteLine("La imagen está en modo Portrait");
            }
        }
    }
}
