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


    class Program
    {
        static void Main(string[] args)
        {

            PropertiesExample PE = new PropertiesExample(2);
            PE.Month = 1;
            Console.WriteLine(PE.Month);  // Will write 1
            PE.Month = 13;
            Console.WriteLine(PE.Month);  // Will still write one, because 13 is illegal value and therefore will be ignored
         }
    }
}
