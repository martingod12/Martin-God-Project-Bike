using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIKE_STROE_POS.Share
{
    public class Msg
    {
        public static void Success(string message = "Success")
        {
            MessageBox.Show(message, "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void Error(string message = "Error")
        {
            MessageBox.Show(message, "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void Warning(string message = "Warning")
        {
            MessageBox.Show(message, "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static bool Confirm(string message = "Are you sure?")
        {
           if(MessageBox.Show(message, "System", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }
    }
}
