using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class MyTaxCalculator
    {
        public double CalulateMyTaxes(ITaxable[] Mythings)
        {
            double MyTotalTax = 0;
            for (int i = 0; i < Mythings.Length; i++)
            {
                MyTotalTax += Mythings[i].CalculateTax();
            }

            return MyTotalTax;
        }
    }
}
