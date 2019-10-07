using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Abstract_Virtual
{
    class VirtualClassB: VirtualClassA
    {
        public override void PrintWorld()
        {
            //base.PrintWorld();
            Console.WriteLine("VirtualClassB.PrintWorld(): World");
        }

        public void PrintIAMB()
        {
            Console.WriteLine("I am B!");
        }
    }
}
