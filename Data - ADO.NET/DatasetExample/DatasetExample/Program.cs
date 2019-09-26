using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DatasetExample
{
    class Program
    {
        const string CONNECTOIN_STRING = @"Data Source=.\sqlexpress;Initial Catalog=HackerU;Integrated Security=True";

        static void Main(string[] args)
        {
            DataSet ds1 = new DataSet();
            DataSet ds2 = new DataSet();

            using (SqlConnection con = new SqlConnection(CONNECTOIN_STRING))
            {
                con.Open();
                string SQL = string.Format("SELECT * FROM Products");
                using (SqlDataAdapter da = new SqlDataAdapter(SQL, con))
                {
                    
                    da.Fill(ds1);
                }

                SQL = string.Format("SELECT * FROM Users");
                using (SqlDataAdapter da = new SqlDataAdapter(SQL, con))
                {

                    da.Fill(ds2);
                }

                con.Close();
            }

            ds1.Merge(ds2);
            int x = 1;
        }
    }
}
