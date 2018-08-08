using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagTracker.Classes.Tasks
{
    abstract partial class Task
    {
        protected string _name;
        protected float _complexity;
        protected byte _priority;
        protected float _iterationCounter;
        protected Random _random = new Random();
    }
}
