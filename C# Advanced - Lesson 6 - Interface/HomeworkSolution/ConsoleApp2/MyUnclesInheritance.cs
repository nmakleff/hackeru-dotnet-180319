using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class MyUnclesInheritance: ITaxable
    {
        public int HowMuch { get; set; }
        public MyUnclesInheritance(int howMuch)
        {
            HowMuch = howMuch;
        }

        public double CalculateTax()
        {
            return HowMuch * 0.25;
        }
    }
}
