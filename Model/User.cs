using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIKE_STROE_POS.Model
{
    public class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string full_name { get; set; }
        public bool active { get; set; }
        public int staff_id { get; set; }
    }
}
