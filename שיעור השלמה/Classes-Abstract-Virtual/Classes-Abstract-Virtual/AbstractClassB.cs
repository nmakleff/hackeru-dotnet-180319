using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Abstract_Virtual
{
    class AbstractClassB : AbstractClassA
    {
        public override void PrintWorld()
        {
            Console.WriteLine("AbstractClassB.PrintHello(): World");
        }
    }
}
