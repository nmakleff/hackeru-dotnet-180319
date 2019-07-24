using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Bus: Vehicle, ITaxable
    {
        public int NumberOfSeats { get; set; }

        public Bus(int licenseNumber, int maxSpeed, int value, int numberOfSeats): base(licenseNumber, maxSpeed, value)
        {
            NumberOfSeats = numberOfSeats;
        }

        public double CalculateTax()
        {
            return NumberOfSeats * 50 + Value * 0.8;
        }
    }
}
