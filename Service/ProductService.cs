using BIKE_STROE_POS.Model;
using BIKE_STROE_POS.Share;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIKE_STROE_POS.Service
{
    public class ProductService : Connection
    {
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            SqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM production.products";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Product product = new Product()
                {
                    product_id = Convert.ToInt32(dr["product_id"]),
                    product_name = Convert.ToString(dr["product_name"]),
                    brand_id = Convert.ToInt16(dr["brand_id"]),
                    category_id = Convert.ToInt16(dr["category_id"]),
                    model_year = Convert.ToInt16(dr["model_year"]),
                    list_price = Convert.ToDecimal(dr["list_price"])
                };
                products.Add(product);
            }
            dr.Close();
            CloseConnx();
            return products;



        }
    }
}
