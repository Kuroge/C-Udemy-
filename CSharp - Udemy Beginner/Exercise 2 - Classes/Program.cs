using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2___Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post recetaPan = new Post("Receta de pan casero", "Para nuestra receta necesitaremos mucha paciencia ekisde");

            recetaPan.UpVote();
            recetaPan.DownVote();
            recetaPan.UpVote();
            recetaPan.UpVote();
            recetaPan.UpVote();
            recetaPan.UpVote();
            recetaPan.UpVote();
            recetaPan.UpVote();
            recetaPan.UpVote();
            recetaPan.UpVote();

            Console.WriteLine("Tu post tiene {0} votos.", recetaPan.VoteValue);
        }
    }
}
