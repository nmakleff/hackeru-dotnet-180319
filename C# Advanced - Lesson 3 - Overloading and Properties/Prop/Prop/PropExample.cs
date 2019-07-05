using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prop
{
    class PropExample
    {
        private int _month;

        public int Month
        {
            get
            {
                return _month;
            }

            private set
            {
                if (value >= 1 && value <= 12)
                {
                    _month = value;
                }
            }
        }

        public int Year { get; set; }

        public PropExample()
        {
        }
    }
}
