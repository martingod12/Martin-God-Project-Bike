using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIKE_STROE_POS.UserInterface
{
    public partial class FORM_ORDER: Form
    {
        public FORM_ORDER()
        {
            InitializeComponent();
            flbBrand.BorderStyle = BorderStyle.FixedSingle;
            flbCategory.BorderStyle = BorderStyle.FixedSingle;
            flpProduct.BorderStyle = BorderStyle.FixedSingle;

            dgvOder.Columns.Clear();
            dgvOder.Columns.Add("PRODUCT_ID", "Id");
            dgvOder.Columns.Add("PRODUCT_NAME", "Description");
            DataGridViewTextBoxColumn txtQty = new DataGridViewTextBoxColumn();
            txtQty.HeaderText = "Qty";
            txtQty.Name = "QTY";
            dgvOder.Columns.Add(txtQty);
            DataGridViewTextBoxColumn txtDiscount = new DataGridViewTextBoxColumn();
            txtDiscount.HeaderText = "Discount";
            txtDiscount.Name = "DISCOUNT";
            dgvOder.Columns.Add(txtDiscount);
            dgvOder.Columns.Add("TOTAL", "Total");

            dgvOder.AllowUserToAddRows = false;
            dgvOder.RowHeadersVisible = false;
            dgvOder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

    }
}
