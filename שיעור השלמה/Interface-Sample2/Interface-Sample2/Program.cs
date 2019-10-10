using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Sample2
{
    class Program
    {
        static void Main(string[] args)
        {
            Monitor m = new Monitor();
            m.OnError += ShowError;
            ClassA a = new ClassA();
            ClassB b = new ClassB();
            ClassC c = new ClassC();
            ClassD d = new ClassD();
            m.AddMonitoredComponent(a);
            m.AddMonitoredComponent(b);
            m.AddMonitoredComponent(c);
            m.AddMonitoredComponent(d);
            m.Start();

            Console.WriteLine("Please enter class name to toggle status or 'q' to exit: ");
            string className = string.Empty;
            while (className != "q")
            {
                className = Console.ReadLine();
                if (className.ToLower() == "classa")
                    a.Status = (a.Status == EnumStatus.Error ? EnumStatus.OK : EnumStatus.Error);
                if (className.ToLower() == "classb")
                    b.Status = (b.Status == EnumStatus.Error ? EnumStatus.OK : EnumStatus.Error);
                if (className.ToLower() == "classc")
                    c.Status = (c.Status == EnumStatus.Error ? EnumStatus.OK : EnumStatus.Error);
                if (className.ToLower() == "classd")
                    d.Status = (d.Status == EnumStatus.Error ? EnumStatus.OK : EnumStatus.Error);

            }
        }

        public static void ShowError(string componentName)
        {
            Console.WriteLine("The component monitored reported on error on "
                + componentName);
        }

    }
}
