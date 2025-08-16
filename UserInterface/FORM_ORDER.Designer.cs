namespace BIKE_STROE_POS.UserInterface
{
    partial class FORM_ORDER
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flbBrand = new System.Windows.Forms.FlowLayoutPanel();
            this.flbCategory = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvOder = new System.Windows.Forms.DataGridView();
            this.flpProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.cboStore = new System.Windows.Forms.ComboBox();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOder)).BeginInit();
            this.SuspendLayout();
            // 
            // flbBrand
            // 
            this.flbBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flbBrand.Location = new System.Drawing.Point(12, 26);
            this.flbBrand.Name = "flbBrand";
            this.flbBrand.Size = new System.Drawing.Size(212, 37);
            this.flbBrand.TabIndex = 0;
            // 
            // flbCategory
            // 
            this.flbCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flbCategory.Location = new System.Drawing.Point(243, 26);
            this.flbCategory.Name = "flbCategory";
            this.flbCategory.Size = new System.Drawing.Size(212, 37);
            this.flbCategory.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("STZhongsong", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Brand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("STZhongsong", 9F);
            this.label2.Location = new System.Drawing.Point(240, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // dgvOder
            // 
            this.dgvOder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOder.Location = new System.Drawing.Point(462, 87);
            this.dgvOder.Name = "dgvOder";
            this.dgvOder.RowHeadersWidth = 51;
            this.dgvOder.RowTemplate.Height = 24;
            this.dgvOder.Size = new System.Drawing.Size(418, 478);
            this.dgvOder.TabIndex = 2;
            // 
            // flpProduct
            // 
            this.flpProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpProduct.Location = new System.Drawing.Point(3, 70);
            this.flpProduct.Name = "flpProduct";
            this.flpProduct.Size = new System.Drawing.Size(453, 580);
            this.flpProduct.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("STZhongsong", 9F);
            this.label3.Location = new System.Drawing.Point(462, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Category Item";
            // 
            // cboStore
            // 
            this.cboStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStore.FormattingEnabled = true;
            this.cboStore.Location = new System.Drawing.Point(462, 26);
            this.cboStore.Name = "cboStore";
            this.cboStore.Size = new System.Drawing.Size(175, 30);
            this.cboStore.TabIndex = 4;
            // 
            // cboCustomer
            // 
            this.cboCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(676, 28);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(168, 30);
            this.cboCustomer.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("STZhongsong", 9F);
            this.label4.Location = new System.Drawing.Point(462, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Store";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("STZhongsong", 9F);
            this.label5.Location = new System.Drawing.Point(677, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Customer";
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Location = new System.Drawing.Point(569, 571);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.Size = new System.Drawing.Size(311, 22);
            this.txtGrandTotal.TabIndex = 5;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(569, 599);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(82, 40);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(680, 599);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 40);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(781, 599);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 40);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("STZhongsong", 9F);
            this.label6.Location = new System.Drawing.Point(459, 574);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Greand Total";
            // 
            // FORM_ORDER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 651);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtGrandTotal);
            this.Controls.Add(this.cboCustomer);
            this.Controls.Add(this.cboStore);
            this.Controls.Add(this.flpProduct);
            this.Controls.Add(this.dgvOder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flbCategory);
            this.Controls.Add(this.flbBrand);
            this.Name = "FORM_ORDER";
            this.Text = "FORM_ORDER";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flbBrand;
        private System.Windows.Forms.FlowLayoutPanel flbCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvOder;
        private System.Windows.Forms.FlowLayoutPanel flpProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboStore;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label6;
    }
}