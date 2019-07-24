using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            ITaxable[] MyStuff = new ITaxable[3];

            MyStuff[0] = new House("Tel Aviv", "Arlozorov", 3400000, 150, 300);
            MyStuff[1] = new Bus(1211211, 130, 500000, 54);
            MyStuff[2] = new MyUnclesInheritance(10000000);

            // Calculate total value
            int MyTotalProperties = 0;
            for (int i = 0; i < MyStuff.Length; i++)
            {
                if (MyStuff[i] is House == true)
                {
                    MyTotalProperties += ((House)MyStuff[i]).Value;
                }
                else if (MyStuff[i] is Bus == true)
                {
                    MyTotalProperties += ((Bus)MyStuff[i]).Value;
                }
                else if (MyStuff[i] is MyUnclesInheritance == true)
                {
                    MyTotalProperties += ((MyUnclesInheritance)MyStuff[i]).HowMuch;
                }
            }

            MyTaxCalculator TCalc = new MyTaxCalculator();
            Console.WriteLine("My total taxes: " + TCalc.CalulateMyTaxes(MyStuff));
        }
    }
}
