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
    public class OrderService : Connection
    {
        public bool Insert(Order req)
        {
            bool result = false;
            SqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SP_INSERT_ORDER";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@customer_id", req.customer_id);
            cmd.Parameters.AddWithValue("@required_date", req.reuired_date);
            cmd.Parameters.AddWithValue("@shipped_date", req.shipped_date);
            cmd.Parameters.AddWithValue("@store_id", req.store_id);
            cmd.Parameters.AddWithValue("@staff_id", req.staff_id);
            cmd.Parameters.Add("@order_id", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.Output;
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
        
    }
}
