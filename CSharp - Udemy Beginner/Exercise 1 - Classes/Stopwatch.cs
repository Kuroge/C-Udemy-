using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1___Classes
{
    public class Stopwatch
    {
        private DateTime StartTime { get; set; }

        private DateTime StopTime { get; set; }

        public TimeSpan Duration
        {
            get { return StopTime - StartTime; }
        }


        public void Start()
        {
            if (StartTime != new DateTime())
            {
                throw new InvalidOperationException("The stopwatch was already started");
            }
            StartTime = DateTime.Now;
        }

        public void Stop()
        {
            if (StopTime != new DateTime())
            {
                throw new InvalidOperationException("The stopwatch was already stopped");
            }
            else if (StartTime == new DateTime())
            {
                throw new InvalidOperationException("The stopwatch neeeds to be started before stopping it");
            }
            StopTime = DateTime.Now;
        }

        public void Clear()
        {
            StartTime = new DateTime();
            StopTime = new DateTime();
        }

    }
}
