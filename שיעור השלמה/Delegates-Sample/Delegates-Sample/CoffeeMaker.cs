using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Sample
{
    class CoffeeMaker
    {
        public int Milk { get; set; }
        public int Sugar { get; set; }
        public int Coffee { get; set; }

        public delegate void OutOfMilk(int Milk);
        public delegate void OutOfSugar(int Sugar);
        public delegate void OutOfCoffee(int Coffee);

        public event OutOfMilk OnOutOfMilk;
        public event OutOfSugar OnOutOfSugar;
        public event OutOfCoffee OnOutOfCoffee;

        public CoffeeMaker()
        {
            Milk = 1000;
            Sugar = 10;
            Coffee = 6;
        }

        public bool MakeCoffee(int numOfSugarSpoons, int numOfCoffeeSpoons)
        {
            if (Milk < 200 && OnOutOfMilk != null)
                OnOutOfMilk(Milk);
            if (Milk < 200)
                return false;
            Milk -= 200;

            if (Sugar < numOfSugarSpoons && OnOutOfSugar != null)
                OnOutOfSugar(Sugar);
            if (Sugar < numOfSugarSpoons)
                return false;
            Sugar -= numOfSugarSpoons;

            if (Coffee < numOfCoffeeSpoons && OnOutOfCoffee != null)
                OnOutOfCoffee(Coffee);
            if (Coffee < numOfCoffeeSpoons)
                return false;
            Coffee -= numOfCoffeeSpoons;

            return true;
        }

    }
}
