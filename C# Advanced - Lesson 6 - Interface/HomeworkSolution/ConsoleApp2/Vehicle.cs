using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Vehicle
    {
        public int LicenseNumber { get; set; }
        public int MaxSpeed { get; set; }
        public int Value { get; set; }

        public Vehicle(int licenseNumber, int maxSpeed, int value)
        {
            LicenseNumber = licenseNumber;
            MaxSpeed = maxSpeed;
            Value = value;
        }
    }
}
