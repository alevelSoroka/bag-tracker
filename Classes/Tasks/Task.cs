using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagTracker.Classes.Tasks
{
    public abstract partial class Task
    {
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public float Complexity
        {
            get
            {
                return _complexyti;
            }
            set
            {
                _complexyti = value;
            }
        }
        public virtual byte Priority
        {
            get
            { return _priority; }
            set
            { _priority = value; }
        }

        public Task(string name, float complexity)
        {
            this.Name = name;
            this.Complexity = complexity + ((complexity / 10) * complexity);
            _iterationCounter = Complexity * Priority;

        }


        private bool IterationResult()
        {
            if (_random.Next(0, 100) < 70)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public float WorkIteration()
        {
            if (IterationResult())
            {
                return --_iterationCounter;
            }
            else
            {
                return _iterationCounter;
            }
        }
    }
}
