﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagTracker
{
    class Bug : Task
    {
        

        public Bug(string name, string complexity) : base(name, complexity)
        {
            Prioriti = 2;
        }

        public override float Prioriti
        {
            get
            {
                return _prioriti;
            }
            set
            {
                _prioriti = 2;
            }
        }
    }
}
