using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Sample1
{
    class Program
    {
        static void Main(string[] args)
        {
            IIsLoaded[] listOfObjects = new IIsLoaded[3];

            listOfObjects[0] = new Monkey();
            listOfObjects[1] = new Employee();
            listOfObjects[2] = new Employee();

            LoadingMonitor lm = new LoadingMonitor(listOfObjects);
            Console.WriteLine(lm.LoadingPercentage() + "% of classes has been loaded");

        }
    }
}
