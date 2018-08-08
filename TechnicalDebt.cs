using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagTracker
{
    class TechnicalDebt : Task
    {
        public TechnicalDebt(string name, string complexity) : base(name, complexity)
        {
            Prioriti = 0.5;
        }

        public override float Prioriti
        {
            get
            {
                return _prioriti;
            }
            set
            {
                _prioriti = 0.5;
            }
        }
    }
}
