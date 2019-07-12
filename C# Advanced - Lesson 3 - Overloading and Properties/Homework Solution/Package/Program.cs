using System;

namespace Package
{
    class Program
    {
        static void Main(string[] args)
        {
            Package package1 = new Package(1, 2, 3, Package.EnumDeliveryType.Express, 2500);
            Package package2 = new Package(2, 5, 4, Package.EnumDeliveryType.Regular, 5500);

            Console.WriteLine("Initiazing package {0}. Package status is: {1}", package1.PackageID, package1.Status);
            Console.WriteLine("Package #{0}, From customer #{1}, To customer #{2}, Shipment price is {3} NIS",
                package1.PackageID, package1.FromCustomerID, package1.ToCustomerID, package1.CalcPrice());
            Console.WriteLine("Package #{0}, From customer #{1}, To customer #{2}, Shipment price is {3} NIS",
                package2.PackageID, package2.FromCustomerID, package2.ToCustomerID, package2.CalcPrice());

            package1.Collected();
            Console.WriteLine("Collected package {0}. Package status is: {1}", package1.PackageID, package1.Status);
            package1.Delivered();
            Console.WriteLine("Delivered package {0}. Package status is: {1}", package1.PackageID, package1.Status);

            if (package2.Delivered() == true)
            {
                Console.WriteLine("Delivered package {0}. Package status is: {1}", package2.PackageID, package2.Status);
            }
            else
            {
                Console.WriteLine("Cannot deliver package {0} - it must be collected first. Package status is: {1}", package2.PackageID, package2.Status);
            }


            Console.WriteLine(5);
            Console.WriteLine(true);
            Console.WriteLine("bla bla");

            Console.WriteLine()
        }
    }
}
