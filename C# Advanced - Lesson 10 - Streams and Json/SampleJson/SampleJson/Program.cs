using Newtonsoft.Json;
using System;

namespace SampleJson
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product()
            {
                ID = 1,
                Name = "Bicycle",
                Price = 123,
                Lines = new Line[] {new Line() { Blabla = "Bla bla 1", Gaga = 1 }, new Line() { Blabla = "Bla bla 2", Gaga = 2} }
            };

            string Json = JsonConvert.SerializeObject(p1);

            Console.WriteLine(Json);

            Product p2 = JsonConvert.DeserializeObject<Product>(Json);
            dynamic p3 = JsonConvert.DeserializeObject(Json);

        }
    }
}
