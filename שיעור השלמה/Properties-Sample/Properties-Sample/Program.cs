using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Human h = new Human("David");

            h.Age = 20;
            Console.WriteLine(h.Age);
            h.Age = -1;
            Console.WriteLine(h.Age);
            h.Age = 19;
            Console.WriteLine(h.Age);
            h.Age = 21;
            Console.WriteLine(h.Age);
            h.Age = 200;
            Console.WriteLine(h.Age);

        }
    }
}
