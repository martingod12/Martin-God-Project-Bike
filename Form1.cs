using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIKE_STROE_POS
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(Share.Connection.GetConnection().State == ConnectionState.Open)
            {
                Share.Msg.Success("Connected");
            }
            else
            {
                Share.Msg.Error("Connection failed");
            }
        }
    }
}
