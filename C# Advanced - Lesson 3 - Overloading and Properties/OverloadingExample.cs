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

        public void Set(int x, int y = 1)
        {
            X = x;
            Y = y;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            // There are two constructors to choose from - one with one parameter and another with two
            OverloadingExample OE1 = new OverloadingExample(1, 3);
            OverloadingExample OE2 = new OverloadingExample(1);

            // The function "set" has two options, but one is optional as it has a default value
            OE1.Set(2, 5);  // will set the values x=2 and y=5
            OE1.Set(9);     // will set the values x=9 and y=1 (y=1 is the default value when it is not provided)
        }
    }
}
