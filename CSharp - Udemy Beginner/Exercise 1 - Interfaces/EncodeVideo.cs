using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1___Interfaces
{
    public class EncodeVideo : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Codificando video...");
        }
    }
}
