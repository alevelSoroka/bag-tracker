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
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentNullException("Parameter cannot be null!!!");
                }
            }
        }

        public string Complexity
        { 
            set
            {
                if (float.TryParse(value, out float variable))
                {
                    if (variable > 0 & variable <= 5)
                    {
                        _complexity = variable + ((variable / 10) * variable);
                    }
                    else
                    {
                        throw new Exception("Сomplexity can be from 1 to 5!!!");
                    }
                }
                else
                {
                    throw new Exception("It was not introduced number!!!");
                }
            }
        }

        public abstract float Prioriti { get; set; }

        public Task(string name, string complexity)
        {
            this.Name = name;
            this.Complexity = complexity;
            _iterationCounter = _complexity * Prioriti;
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
