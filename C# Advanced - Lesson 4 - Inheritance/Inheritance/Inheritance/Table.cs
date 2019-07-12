using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Table: Furniture
    {
        protected int _numberOfSeats;

        public Table() : base("Table", 4)
        {

        }
        public Table(int numberOfSeats) : base("Table", 4)
        {
            _numberOfSeats = numberOfSeats;
        }
    }
}
