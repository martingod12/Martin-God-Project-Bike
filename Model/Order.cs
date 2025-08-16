using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIKE_STROE_POS.Model
{
    public class Order
    {
        public int order_id { get; set; }
        public int customer_id { get; set; }
        public DateTime order_date { get; set; }
        public DateTime reuired_date { get; set; }
        public DateTime shipped_date { get; set; }
        public int store_id { get; set; }
        public int staff_id { get; set; }

    }
}
