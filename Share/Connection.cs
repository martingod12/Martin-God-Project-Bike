using BIKE_STROE_POS.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIKE_STROE_POS.Share
{
    public class Connection
    {
        const string str = "Data Source = MSI\\SQLEXPRESS01; Initial Catalog = BikeStores; Integrated Security = True";
        private static SqlConnection connx = new SqlConnection(str);

        public static SqlConnection GetConnection()
        {
            if(connx.State == System.Data.ConnectionState.Closed)
            {
                connx.Open();
            }
            return connx;
        }
        public static void CloseConnx()
        {
            if(connx != null)
            {
                connx.Close();
            }
        }
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
        }
    }
}
