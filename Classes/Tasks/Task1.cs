using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagTracker.Classes.Tasks
{
    abstract partial class Task
    {
        private string _name;
        private float _complexyti;
        private byte _priority;
        private float _iterationCounter;
        private Random _random = new Random();
    }
}
