using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (HackerUEntities e = new HackerUEntities())
            {
                // Add new product(record) to database
                Product np = new Product()
                {
                    Name = "Todays special",
                    Price = 200,
                    SerialNumber = "lkjsdhfljf"
                };
                e.Products.Add(np);
                e.SaveChanges();    // Update the changes to the database (in this case, add a product)


                // Delete a record
                e.Products.Remove(e.Products.First());  // Marks an element to be deleted. 
                                                        // Also can done this way:  e.Entry(e.Products.First()).State = System.Data.Entity.EntityState.Deleted;
                e.SaveChanges(); // Update the changes to the database (in this case, remove a product)


                // Update a record
                Product pToUpdate = e.Products.First();
                pToUpdate.Price = 1000000;
                // In order to update a record, we need to mark the records metadata as "modified", so it would be saved when calling e.SaveChanges()
                e.Entry(pToUpdate).State = System.Data.Entity.EntityState.Modified;
                e.SaveChanges();

                // Read all purchases and show purchase data, items and product name
                foreach (var p in e.Purchases)
                {
                    Console.WriteLine("Purchase ID: {0}, Purchase Date: {1}, Purchase Amount: {2}", p.ID, p.PurchaseDate, p.TotalAmount);

                    Console.WriteLine("The purchase include the following items:");
                    foreach (var i in p.PurchaseItems)
                    {
                        Console.WriteLine("Product: {0}, Quantity: {1}, Price: {2}", i.Product.Name, i.Quantity, i.Price);
                    }
                }
            }
        }
    }
}
