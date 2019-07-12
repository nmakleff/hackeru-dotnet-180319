using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class RoundTable: Table
    {
        protected int _radius;

        public RoundTable(int radius) : base(6)
        {
            Name = "RoundTable";
        }
    }
}
