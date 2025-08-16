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
    public class BrandServices : Connection
    {
        string table = "production.brands";
        public List<Brand> GetBrands()
        {
            List<Brand> brands = new List<Brand>();
            string query = $"SELECT * FROM {table}";
            SqlCommand cmd = new SqlCommand(query, GetConnection());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Brand brand = new Brand();
                brand.brand_id = Convert.ToInt16(reader["brand_id"]);
                brand.brand_name = reader["brand_name"].ToString();
                brands.Add(brand);
            }
            reader.Close();
            CloseConnx();
            return brands;
        }

        public Brand GetBrand(int id)
        {
            Brand brand = new Brand();
            string query = $"SELECT * FROM {table} where brand_id=@brand_id";
            SqlCommand cmd = new SqlCommand(query, GetConnection());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                brand.brand_id = Convert.ToInt16(reader["brand_id"]);
                brand.brand_name = reader["brand_name"].ToString();
            }
            reader.Close();
            CloseConnx();
            return brand;
        }

        // Insert brand
        public bool Insert(Brand request)
        {
            bool result = false;


            SqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SP_INSERT_BRAND";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@brand_name", request.brand_name);
            cmd.Transaction = Transaction.tran;
            try
            {
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                Msg.Error($"Error: {ex.Message}");
            }
            return result;
        }
        // Update brand
        public bool Update(Brand request)
        {
            bool result = false;
            SqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SP_UPDATE_BRAND";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@brand_id", request.brand_id);
            cmd.Parameters.AddWithValue("@brand_name", request.brand_name);
            cmd.Transaction = Transaction.tran;
            try
            {
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                Msg.Error(ex.Message);
            }
            return result;
        }
        // Delete brand
        public bool Delete(Brand request)
        {
            bool result = false;
            SqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SP_DELETE_BRAND";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@brand_name", request.brand_name);
            cmd.Transaction = Transaction.tran;
            try
            {
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                Msg.Error($"Error: {ex.Message}");
            }
            CloseConnx();
            return result;
        }
        // Get brand by name        
        // Get brand by name        
        // Get brand by name        
        // Get brand by name        
        // Get brand by name        
        // Get brand by name        
        // Get brand by name        
        // Get brand by name        
        // Get brand by name        
        // Get brand by name        
        // Get brand by name        
        // Get brand by name        
        // Get brand by name        
        // Get brand by name        
        // Get brand by name        


    }

}
