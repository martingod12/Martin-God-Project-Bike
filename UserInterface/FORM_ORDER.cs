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
    public partial class FORM_ORDER: Form
    {
        BrandServices brandService = new BrandServices();
        CategoryService categoryService = new CategoryService();
        ProductService productService = new ProductService();
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

            Helper.BindCombobox(cboStore, "select store_id,store_name from sales.stores");
            Helper.BindCombobox(cboCustomer, "select customer_id,first_name + ' ' + last_name as full_name from sales.customers");

            LoadBrand();
            LoadCategory();
            FilterProduct();
        }
        
        private void LoadBrand()
        {
            foreach(Brand brand in brandService.GetBrands())
            {
                Button button = new Button();
                button.Name = brand.brand_id.ToString();
                button.Text = brand.brand_name.ToString();
                button.Height = 20;
                flbBrand.Controls.Add(button);
            }
            flbBrand.FlowDirection = FlowDirection.LeftToRight;
            flbBrand.AutoScroll = true;

        }
        private void LoadCategory()
        {
            // Fix: Use the GetCategories() method from CategoryService instead of GetConnection()
            foreach (Category category in new CategoryService().GetCategories())
            {
                Button button = new Button();
                button.Name = category.category_id.ToString();
                button.Text = category.category_name.ToString();
                button.Height = 20;
                flbCategory.Controls.Add(button);
            }
            flbCategory.FlowDirection = FlowDirection.LeftToRight;
            flbCategory.AutoScroll = true;
        }
        private void FilterProduct()
        {
            foreach(Product product in productService.GetProducts())
            {
                Button button = new Button();
                button.Name = product.product_id.ToString();
                button.Text = product.product_name.ToString();
                button.Height = 100;
                button.Width = 100;
                flpProduct.Controls.Add(button);
                flpProduct.AutoScroll = true;
            }
        }

    }
}
