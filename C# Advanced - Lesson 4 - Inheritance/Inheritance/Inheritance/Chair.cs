using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Chair: Furniture
    {
        private string _cushinType;

        public Chair() : base("Chair", 4)
        {
            _cushinType = "";
        }
        public Chair(string cushinType) : base("Chair", 4)
        {
            _cushinType = cushinType;
        }
    }
}
