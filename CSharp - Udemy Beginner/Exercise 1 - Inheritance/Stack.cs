using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1___Inheritance
{
    public class Stack
    {
        private List<object> _stack { get; set; }


        public Stack()
        {
            this._stack = new List<object>();
        }

        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("Cannot add null object to the stack");
            }
            this._stack.Insert(0, obj);
        }

        public object Pop()
        {
            if (this._stack.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty, please add some objects with the Push() method before calling the Pop() method.");
            }

            var tempObject = this._stack[0];
            this._stack.RemoveAt(0);

            return tempObject;
        }

        public void Clear()
        {
            this._stack.Clear();
        }
    }
}
