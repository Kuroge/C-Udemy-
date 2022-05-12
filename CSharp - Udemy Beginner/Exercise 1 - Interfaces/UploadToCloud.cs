using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1___Interfaces
{
    public class UploadToCloud : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Subiendo a la nube...");
        }
    }
}
