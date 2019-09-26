using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Menu
    {
        public void RunMenu()
        {
            ProductsManager PM = new ProductsManager();

            int option;
            do
            {
                option = DisplayMenu();

                switch (option)
                {
                    case 1:
                        try
                        {
                            Product newP = GetProductFromUser();
                            PM.AddProduct(newP);
                            Console.WriteLine("Product added successfully");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error adding product: " + ex.Message);
                        }
                        break;
                    case 2:
                        try
                        {
                            int productID = GetProductIDToDelete();
                            PM.DeleteProduct(productID);
                            Console.WriteLine("Product deleted successfully");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error deleting product: " + ex.Message);
                        }
                        break;
                    case 3:
                        try
                        {
                            Product[] productsList = PM.GetProducts();
                            PrintProducts(productsList);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error getting products list: " + ex.Message);
                        }
                        break;
                }
            }
            while (option != 4);
        }

        public void PrintProducts(Product[] products)
        {
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Product ID: {0}, Name: {1}, Serial Number: {2}, Price {3}", products[i].ProductID, products[i].Name, products[i].SerialNumber, products[i].Price);
            }
        }

        public int GetProductIDToDelete()
        {
            Console.Write("Enter a product id to delete: ");
            int pid = int.Parse(Console.ReadLine());

            return pid;
        }

        public Product GetProductFromUser()
        {
            Product p = new Product();

            Console.WriteLine("Enter new product");
            Console.Write("Please enter product name: ");
            p.Name = Console.ReadLine();
            Console.Write("Please enter product serial number: ");
            p.SerialNumber = Console.ReadLine();
            Console.Write("Please enter product serial price: ");
            p.Price = float.Parse(Console.ReadLine());

            return p;
        }

        private int DisplayMenu()
        {
            Console.WriteLine("Main menu:");
            Console.WriteLine();
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Delete Product");
            Console.WriteLine("3. List Products");
            Console.WriteLine();
            Console.WriteLine("4. Quit");

            int selected = 0;
            while (selected < 1 || selected > 4)
            {
                if (int.TryParse(Console.ReadLine(), out selected) == true)
                {
                    if (selected < 1 || selected > 4)
                    {
                        Console.WriteLine("Illegal selection. Please enter 1-4");
                    }
                }
                else
                {
                    Console.WriteLine("Illegal selection. Please enter 1-4");
                    Console.WriteLine();
                }
            }

            return selected;
        }
}
}
