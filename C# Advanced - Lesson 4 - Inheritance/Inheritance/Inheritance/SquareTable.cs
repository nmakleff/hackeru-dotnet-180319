using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class SquareTable: Table
    {
        private int _width;
        private int _depth;

        public SquareTable(int width, int depth, int numberOfSeats) : base(numberOfSeats)
        {
            Name = "SquareTable";
            _width = width;
            _depth = depth;
        }
    }
}
