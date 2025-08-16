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
    public class CategoryService : Connection
    {
        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            string query = "SELECT * FROM production.categories";
            SqlCommand cmd = new SqlCommand(query, GetConnection());
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Category category = new Category();
                category.category_id = Convert.ToInt16(dr["category_id"]);
                category.category_name = dr["category_name"].ToString();
                categories.Add(category);
            }
            dr.Close();
            CloseConnx();
            return categories;
        }

    }
}
