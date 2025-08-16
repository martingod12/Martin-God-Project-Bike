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
    public partial class FORM_MAIN : Form
    {
        public FORM_MAIN()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true;
        }
        Form frmBrand = null;
        
        private void brandToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (frmBrand == null || frmBrand.Visible == false)
            {
                frmBrand = new FORM_BRAND();
                frmBrand.MdiParent = this;
                frmBrand.StartPosition = FormStartPosition.CenterScreen;
                frmBrand.Show();
            }
        }
        Form frmOrder = null;
        private void oderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmOrder == null || frmOrder.Visible == false)
            {
                frmOrder = new FORM_ORDER();
                frmOrder.MdiParent = this;
                frmOrder.StartPosition = FormStartPosition.CenterScreen;
                frmOrder.Show();
            }
        }
    }
}
