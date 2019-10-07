using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Abstract_Virtual
{
    class VirtualClassA
    {
        public void PrintHello()
        {
            Console.WriteLine("VirtualClassA.PrintHello(): Hello");
            PrintWorld();
        }

        public virtual void PrintWorld()
        {
            Console.WriteLine("VirtualClassA.PrintWorld(): World");
        }
    }
}
