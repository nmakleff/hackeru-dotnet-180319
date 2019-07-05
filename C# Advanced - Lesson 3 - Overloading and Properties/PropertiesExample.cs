using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEXample
{
    class PropertiesExample
    {
        private int _month;

        public int Month
        {
            get
            {
                return _month;
            }

            set
            {
                if (value >= 1 && value <= 12)
                {
                    _month = value;
                }
            }
        }

        public PropertiesExample(int month)
        {
            Month = month;
        }
    }
}
