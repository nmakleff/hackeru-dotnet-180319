using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class ProductsManager
    {
        private DAL _dal;

        public ProductsManager()
        {
            _dal = new DAL();
        }

        public void AddProduct(Product newProduct)
        {
            if (string.IsNullOrEmpty(newProduct.Name) == true)
                throw new Exception("Name cannot be empty");

            if (string.IsNullOrEmpty(newProduct.SerialNumber) == true)
                throw new Exception("Serial number cannot be empty");

            _dal.AddProduct(newProduct);
        }

        public void DeleteProduct(int productID)
        {
            if (_dal.IsProductExist(productID) == false)
                throw new Exception("Product do not exist");

            _dal.DeleteProduct(productID);
        }

        public Product[] GetProducts()
        {
            return _dal.GetProducts();
        }

        public Product GetProduct(int productID)
        {
            return _dal.GetProduct(productID);
        }
    }
}
