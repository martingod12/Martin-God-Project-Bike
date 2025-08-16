using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIKE_STROE_POS.Share
{
    public class Transaction
    {
        public static SqlTransaction tran;
        internal static object transaction;
    }
}
