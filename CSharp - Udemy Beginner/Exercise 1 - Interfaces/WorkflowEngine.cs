using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1___Interfaces
{
    public class WorkflowEngine
    {
        private IList<IActivity> _activities { get; set; }

        public WorkflowEngine()
        {
            this._activities = new List<IActivity>();
        }

        public void AddActivity(IActivity activity)
        {
            _activities.Add(activity);
        }

        public void ExecuteActivities()
        {
            if (_activities.Count == 0)
            {
                throw new InvalidOperationException("No activities to execute.");
            }

            foreach (IActivity activity in _activities)
            {
                activity.Execute();
            }
        }

    }
}
