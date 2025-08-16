using BIKE_STROE_POS.Model;
using BIKE_STROE_POS.Service;
using BIKE_STROE_POS.Share;
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
    public partial class FORM_BRAND: Form
    {
        BrandServices brandService = new BrandServices();
        Brand brand = new Brand();
        public FORM_BRAND()
        {
            InitializeComponent();

            dvgBrand.Columns.Clear();
            dvgBrand.Columns.Add("brand_id", "Brand ID");
            dvgBrand.Columns.Add("brand_name", "Brand Name");
            dvgBrand.ReadOnly = true;
            dvgBrand.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgBrand.AllowUserToAddRows = false;
            dvgBrand.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //dvgBrand.RowHeadersVisible = false;
            LoadData();
        }


        private void LoadData()
        {
            dvgBrand.Rows.Clear();
            foreach (Brand brand in brandService.GetBrands())
            {
                dvgBrand.Rows.Add(brand.brand_id, brand.brand_name);
            }
            dvgBrand.ClearSelection();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtBrandName.Text.Trim() == "")
            {
                Msg.Warning("Required Brand Name");
                return;
            }

            Transaction.tran = Connection.GetConnection().BeginTransaction();
            
            brand.brand_name = txtBrandName.Text;
            if (btnSave.Text == "Save")
            {
                if (!brandService.Insert(brand))
                {
                    Transaction.tran.Rollback();
                    Msg.Error("Failed to Insert Brand");
                }

                else
                {
                    if (brandService.Update(brand))
                    {
                        Transaction.tran.Commit();
                        Msg.Success("Brand Inserted Successfully");
                    }
                    else
                    {
                        Transaction.tran.Rollback();
                        
                    }
                }
            }
            Connection.CloseConnx();
            LoadData();
            ResetControl();
        }

        private void dvgBrand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dvgBrand.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dvgBrand.Rows[e.RowIndex];
                Brand brand = new Brand();
                brand.brand_id = Convert.ToInt16(row.Cells["brand_id"].Value);


                btnSave.Text = "Update";
                btnSave.Enabled = true;
                btnDelete.Enabled = true;
                txtBrandName.Text = row.Cells["brand_name"].Value.ToString();           
            }
        }
        private void ResetControl()
        {
            btnSave.Text = "Save";
            btnSave.Enabled = false;
            txtBrandName.Clear();
            btnDelete.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Text = "Save";
            btnSave.Enabled = true;
            txtBrandName.Clear();
            btnDelete.Enabled = false;
            

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
