using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Furniture[] StoreInventory = new Furniture[6];

            StoreInventory[0] = new Table(2);
            StoreInventory[1] = new SquareTable(160, 100, 6);
            StoreInventory[2] = new RoundTable(160);
            StoreInventory[3] = new Chair();
            StoreInventory[4] = new Chair("Mushi");
            StoreInventory[5] = new Chair("Mushi Mushi");


            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Furniture #{0}: {1}", i, StoreInventory[i].Name);
            }
        }
    }
}
