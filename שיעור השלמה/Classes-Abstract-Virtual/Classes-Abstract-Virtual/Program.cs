using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Abstract_Virtual
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClassB ACB = new AbstractClassB();
            //ACB.PrintHello();

            AbstractClassA[] ArrayOfAbstracts = new AbstractClassA[3];
            ArrayOfAbstracts[0] = new AbstractClassB();
            ArrayOfAbstracts[1] = new AbstractClassC();
            ArrayOfAbstracts[2] = new AbstractClassC();

            for (int i = 0; i < 3; i++)
            {
                ArrayOfAbstracts[i].PrintWorld();
            }

            return;

            Console.WriteLine("Running VirtualClassA");
            VirtualClassA AVA = new VirtualClassA();
            AVA.PrintHello();

            Console.WriteLine("Running VirtualClassB");
            VirtualClassB AVB = new VirtualClassB();
            AVB.PrintHello();
            AVB.PrintIAMB();

            VirtualClassA A = AVB;
            A.PrintHello();

            ((VirtualClassB)A).PrintIAMB();
            VirtualClassB B = (VirtualClassB)A;
            B.PrintIAMB();
        }
    }
}
