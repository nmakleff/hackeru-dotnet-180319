using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class House: Property, ITaxable
    {
        public int HouseArea { get; set; }
        public int YardArea { get; set; }

        public House(string city, string street, int value, int houseArea, int yardArea): base(city, street, value)
        {
            HouseArea = houseArea;
            YardArea = yardArea;
        }

        public double CalculateTax()
        {
            return HouseArea * 100 + YardArea * 50 + Value * 0.1;
        }
    }
}
