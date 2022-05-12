using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1___Interfaces
{
    public class NotifyByMail : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Notificando por email...");
        }
    }
}
