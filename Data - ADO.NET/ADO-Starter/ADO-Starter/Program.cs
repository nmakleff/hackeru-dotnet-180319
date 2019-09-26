using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ADO_Starter
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=HackerU;Integrated Security=True");
                con.Open();

                string SQL = string.Format("SELECT * FROM Users");
                SqlCommand cmd = new SqlCommand(SQL, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine("ID: {0}", reader["ID"]);
                    Console.WriteLine("First name: {0}", reader["FirstName"]);
                    Console.WriteLine("Last name: {0}", reader["LastName"]);
                    Console.WriteLine("Gender: {0}", reader["Gender"]);
                    Console.WriteLine("---------------------------------");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Oops, something went wrong (" + ex.Message + ")");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
