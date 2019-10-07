using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Abstract_Virtual
{
    abstract class AbstractClassA
    {
        public void PrintHello()
        {
            Console.WriteLine("AbstractClassA.PrintHello(): Hello");
            PrintWorld();
        }

        public abstract void PrintWorld();

    }
}
