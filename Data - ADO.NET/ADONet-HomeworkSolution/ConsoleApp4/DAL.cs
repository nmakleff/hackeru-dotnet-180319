using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApp4
{
    class DAL
    {
        const string CONNECTOIN_STRING = @"Data Source=.\sqlexpress;Initial Catalog=HackerU;Integrated Security=True";

        public void AddProduct(Product p)
        {
            using (SqlConnection con = new SqlConnection(CONNECTOIN_STRING))
            {
                con.Open();
                string SQL = string.Format("INSERT INTO Products (Name, SerialNumber, Price) VALUES ('{0}', '{1}', {2})", p.Name, p.SerialNumber, p.Price);
                using (SqlCommand cmd = new SqlCommand(SQL, con))
                {
                    cmd.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public void DeleteProduct(int productID)
        {
            using (SqlConnection con = new SqlConnection(CONNECTOIN_STRING))
            {
                con.Open();
                string SQL = string.Format("DELETE FROM Products WHERE ProductID = " + productID);
                using (SqlCommand cmd = new SqlCommand(SQL, con))
                {
                    cmd.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public bool IsProductExist(int productID)
        {
            using (SqlConnection con = new SqlConnection(CONNECTOIN_STRING))
            {
                con.Open();
                string SQL = string.Format("SELECT * FROM Products WHERE ProductID=" + productID);
                using (SqlCommand cmd = new SqlCommand(SQL, con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    bool retVal =  reader.HasRows;
                    con.Close();

                    return retVal;
                }
            }
        }

        public Product GetProduct(int productID)
        {
            using (SqlConnection con = new SqlConnection(CONNECTOIN_STRING))
            {
                con.Open();
                string SQL = string.Format("SELECT * FROM Products WHERE ProductID=" + productID);
                using (SqlCommand cmd = new SqlCommand(SQL, con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows == false)
                        return null;

                    reader.Read();
                    Product retVal = new Product()
                    {
                        Name = (string)reader["Name"],
                        SerialNumber = (string)reader["SerialNumber"],
                        Price = (float)reader["Price"],
                        ProductID = (int)reader["ProductID"]
                    };

                    return retVal;
                }
            }
        }

        public Product[] GetProducts()
        {
            using (SqlConnection con = new SqlConnection(CONNECTOIN_STRING))
            {
                con.Open();
                string SQL = string.Format("SELECT * FROM Products");
                using (SqlCommand cmd = new SqlCommand(SQL, con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows == false)
                        return new Product[0];

                    List<Product> retVal = new List<Product>();
                    while (reader.Read())
                    {
                        retVal.Add(new Product()
                        {
                            Name = reader["Name"].ToString(),
                            SerialNumber = reader["SerialNumber"].ToString(),
                            Price = (double?)reader["Price"],
                            ProductID = (int?)reader["ProductID"]
                        });
                    }

                    
                    return retVal.ToArray();
                }
            }
        }
    }
}
