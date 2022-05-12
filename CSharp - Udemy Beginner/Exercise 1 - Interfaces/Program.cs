using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1___Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WorkflowEngine engine = new WorkflowEngine();
            engine.AddActivity(new NotifyByMail());
            engine.AddActivity(new EncodeVideo());
            engine.AddActivity(new UploadToCloud());

            engine.ExecuteActivities();

        }
    }
}
