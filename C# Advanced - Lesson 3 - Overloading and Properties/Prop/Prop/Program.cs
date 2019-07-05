using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prop
{
    class Program
    {
        static void Main(string[] args)
        {
            PropExample PE = new PropExample();
            Console.WriteLine("Set the value of 1");
            PE.Month = 1;
            Console.WriteLine(PE.Month);
            Console.WriteLine("Set the value of 13");
            PE.Month = 13;
            Console.WriteLine(PE.Month);
            PE.Year = 12;
            Console.WriteLine(PE.Year);
        }
    }
}
