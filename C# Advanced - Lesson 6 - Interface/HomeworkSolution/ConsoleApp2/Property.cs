using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Property
    {
        public string City { get; set; }
        public string Street { get; set; }
        public int Value { get; set; }

        public Property(string city, string street, int value)
        {
            City = city;
            Street = street;
            Value = value;
        }
    }
}
