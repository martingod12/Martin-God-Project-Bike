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
    public class OrderItemService : Connection
    {
        public bool Insert(OrderItem req)
        {
            bool result = false;
            SqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SP_INSERT_ORDER_ITEM";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@order_id", req.order_id);
            cmd.Parameters.AddWithValue("@item_id", req.item_id);
            cmd.Parameters.AddWithValue("@product_id", req.product_id);
            cmd.Parameters.AddWithValue("@quantity", req.quantity);
            cmd.Parameters.AddWithValue("@list_price", req.list_price);
            cmd.Parameters.AddWithValue("@discount", req.discount);
            cmd.Transaction = Transaction.tran;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Msg.Error($"Error: {ex.Message}");
            }
            return result;
        }
    }
}
