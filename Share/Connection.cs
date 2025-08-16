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

            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT product_id, product_name, brand_id, category_id, model_year, list_price FROM Products", GetConnection()))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = new Product
                            {
                                product_id = reader.GetInt32(reader.GetOrdinal("product_id")),
                                product_name = reader.GetString(reader.GetOrdinal("product_name")),
                                brand_id = reader.GetInt32(reader.GetOrdinal("brand_id")),
                                category_id = reader.GetInt32(reader.GetOrdinal("category_id")),
                                model_year = reader.GetInt32(reader.GetOrdinal("model_year")),
                                list_price = reader.GetDecimal(reader.GetOrdinal("list_price"))
                            };
                            products.Add(product);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log it)
                throw new Exception("Error fetching products", ex);
            }
            finally
            {
                CloseConnx();
            }

            return products;
        }
    }
}
