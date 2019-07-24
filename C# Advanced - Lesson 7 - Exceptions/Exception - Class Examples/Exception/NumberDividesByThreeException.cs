using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionExample
{
    class NumberDividesByThreeException: Exception
    {
        public NumberDividesByThreeException(): base("Number can be divided by three")
        {
        }
    }
}
