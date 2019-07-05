using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEXample
{
    class OverloadingExample
    {
        public int X { get; set; }
        public int Y { get; set; }

        public OverloadingExample(int x)
        {
            Set(x);
        }

        public OverloadingExample(int x, int y)
        {
            Set(x, y);
        }

        public void Set(int x = 6, int y = 1)
        {
            X = x;
            Y = y;
        }

    }
}
