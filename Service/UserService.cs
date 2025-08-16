using BIKE_STROE_POS.Model;
using BIKE_STROE_POS.Share;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIKE_STROE_POS.Service
{
    public class UserService : Connection
    {
        public static User LogonUser = new User();

        public static bool Login(User req)
        {
            bool result = false;
            string query = "select * from tbl_user where username=@usr and password=@pwd and active=1";
            SqlCommand cmd = new SqlCommand(query, GetConnection());
            cmd.Parameters.Add("@usr", SqlDbType.VarChar, 20).Value = req.username;
            cmd.Parameters.Add("@pwd", SqlDbType.VarChar, 20).Value = req.password;

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()) 
            { 
                LogonUser.id = Convert.ToInt16(dr["id"]);
                LogonUser.username = dr["username"].ToString();
                LogonUser.password = dr["password"].ToString();
                LogonUser.full_name = dr["full_name"].ToString();
                LogonUser.active = Convert.ToBoolean(dr["active"]);
                LogonUser.staff_id = Convert.ToInt16(dr["staff_id"]);
                result = true;
            }
            dr.Close();
            CloseConnx();
            return result;
        }
    }
}
