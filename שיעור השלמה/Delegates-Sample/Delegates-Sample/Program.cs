using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Sample
{
    class Program
    {
        CoffeeMaker coffeeMaker;

        public void FillUpMilk(int Milk)
        {
            Console.WriteLine("The coffee machine is out of milk. Adding 1 Liter");
            coffeeMaker.Milk += 1000;
            Console.WriteLine("{0} -> {1}", Milk, coffeeMaker.Milk);

        }

        public void FillUpCoffee(int Coffee)
        {
            Console.WriteLine("The coffee machine is out of coffee. Adding 10 spoons");
            coffeeMaker.Coffee += 10;
            Console.WriteLine("{0} -> {1}", Coffee, coffeeMaker.Coffee);
        }

        public void FillUpSugar(int Sugar)
        {
            Console.WriteLine("The coffee machine is out of sugar. Adding 10 spoons");
            coffeeMaker.Sugar += 10;
            Console.WriteLine("{0} -> {1}", Sugar, coffeeMaker.Sugar);
        }

        public void Run()
        {
            coffeeMaker = new CoffeeMaker();
            coffeeMaker.OnOutOfMilk += FillUpMilk;
            coffeeMaker.OnOutOfCoffee += FillUpCoffee;
            coffeeMaker.OnOutOfSugar += FillUpSugar;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Create a cup of coffee");
                coffeeMaker.MakeCoffee(2, 1);
            }
        }

        static void Main(string[] args)
        {
            Program P = new Program();
            P.Run();
        }
    }
}
