using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Furniture
    {
        public string Name { get; protected set; }
        public int NumberOfLegs { get; protected set; }

        public Furniture()
        {
            Name = string.Empty;
            NumberOfLegs = 0;
        }

        public Furniture(string name, int numberOfLegs)
        {
            Name = name;
            NumberOfLegs = numberOfLegs;
        }
    }
}
