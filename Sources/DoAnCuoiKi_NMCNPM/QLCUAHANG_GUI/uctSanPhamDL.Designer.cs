namespace QLCUAHANG_GUI
{
    partial class uctSanPhamDL
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbListProductOfAgency = new System.Windows.Forms.GroupBox();
            this.dtgvProductListOfAgency = new System.Windows.Forms.DataGridView();
            this.MaSPDL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbProductOfAgency = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbIDAgency = new System.Windows.Forms.ComboBox();
            this.txtAmountDL = new System.Windows.Forms.TextBox();
            this.txtUnitDL = new System.Windows.Forms.TextBox();
            this.txtNameProductDL = new System.Windows.Forms.TextBox();
            this.txtPriceDL = new System.Windows.Forms.TextBox();
            this.txtIDProductDL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDeleteProductAgency = new System.Windows.Forms.Button();
            this.btnUpdateProductAgency = new System.Windows.Forms.Button();
            this.btnAddProductAgency = new System.Windows.Forms.Button();
            this.grbListProductOfAgency.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductListOfAgency)).BeginInit();
            this.grbProductOfAgency.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(622, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "DANH SÁCH SẢN PHẨM CỦA ĐẠI LÍ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "SẢN PHẨM CỦA ĐẠI LÍ";
            // 
            // grbListProductOfAgency
            // 
            this.grbListProductOfAgency.Controls.Add(this.dtgvProductListOfAgency);
            this.grbListProductOfAgency.Location = new System.Drawing.Point(310, 57);
            this.grbListProductOfAgency.Name = "grbListProductOfAgency";
            this.grbListProductOfAgency.Size = new System.Drawing.Size(919, 417);
            this.grbListProductOfAgency.TabIndex = 8;
            this.grbListProductOfAgency.TabStop = false;
            // 
            // dtgvProductListOfAgency
            // 
            this.dtgvProductListOfAgency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProductListOfAgency.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSPDL,
            this.TenSP,
            this.MaDL,
            this.Gia,
            this.DonVi,
            this.SoLuong});
            this.dtgvProductListOfAgency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvProductListOfAgency.Location = new System.Drawing.Point(3, 16);
            this.dtgvProductListOfAgency.Name = "dtgvProductListOfAgency";
            this.dtgvProductListOfAgency.ReadOnly = true;
            this.dtgvProductListOfAgency.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvProductListOfAgency.Size = new System.Drawing.Size(913, 398);
            this.dtgvProductListOfAgency.TabIndex = 1;
            // 
            // MaSPDL
            // 
            this.MaSPDL.DataPropertyName = "MaSPDL";
            this.MaSPDL.HeaderText = "Mã SP";
            this.MaSPDL.Name = "MaSPDL";
            this.MaSPDL.ReadOnly = true;
            this.MaSPDL.Width = 110;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            this.TenSP.Width = 170;
            // 
            // MaDL
            // 
            this.MaDL.DataPropertyName = "MaDL";
            this.MaDL.HeaderText = "Mã đại lí";
            this.MaDL.Name = "MaDL";
            this.MaDL.ReadOnly = true;
            this.MaDL.Width = 135;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            this.Gia.Width = 150;
            // 
            // DonVi
            // 
            this.DonVi.DataPropertyName = "DonVi";
            this.DonVi.HeaderText = "Đơn vị";
            this.DonVi.Name = "DonVi";
            this.DonVi.ReadOnly = true;
            this.DonVi.Width = 135;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 170;
            // 
            // grbProductOfAgency
            // 
            this.grbProductOfAgency.Controls.Add(this.panel1);
            this.grbProductOfAgency.Location = new System.Drawing.Point(23, 57);
            this.grbProductOfAgency.Name = "grbProductOfAgency";
            this.grbProductOfAgency.Size = new System.Drawing.Size(271, 417);
            this.grbProductOfAgency.TabIndex = 7;
            this.grbProductOfAgency.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbIDAgency);
            this.panel1.Controls.Add(this.txtAmountDL);
            this.panel1.Controls.Add(this.txtUnitDL);
            this.panel1.Controls.Add(this.txtNameProductDL);
            this.panel1.Controls.Add(this.txtPriceDL);
            this.panel1.Controls.Add(this.txtIDProductDL);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 398);
            this.panel1.TabIndex = 1;
            // 
            // cmbIDAgency
            // 
            this.cmbIDAgency.FormattingEnabled = true;
            this.cmbIDAgency.Location = new System.Drawing.Point(93, 140);
            this.cmbIDAgency.Name = "cmbIDAgency";
            this.cmbIDAgency.Size = new System.Drawing.Size(136, 21);
            this.cmbIDAgency.TabIndex = 3;
            // 
            // txtAmountDL
            // 
            this.txtAmountDL.Location = new System.Drawing.Point(93, 279);
            this.txtAmountDL.Name = "txtAmountDL";
            this.txtAmountDL.Size = new System.Drawing.Size(136, 20);
            this.txtAmountDL.TabIndex = 6;
            // 
            // txtUnitDL
            // 
            this.txtUnitDL.Location = new System.Drawing.Point(93, 240);
            this.txtUnitDL.Name = "txtUnitDL";
            this.txtUnitDL.Size = new System.Drawing.Size(136, 20);
            this.txtUnitDL.TabIndex = 5;
            // 
            // txtNameProductDL
            // 
            this.txtNameProductDL.Location = new System.Drawing.Point(93, 90);
            this.txtNameProductDL.Name = "txtNameProductDL";
            this.txtNameProductDL.Size = new System.Drawing.Size(136, 20);
            this.txtNameProductDL.TabIndex = 2;
            // 
            // txtPriceDL
            // 
            this.txtPriceDL.Location = new System.Drawing.Point(93, 189);
            this.txtPriceDL.Name = "txtPriceDL";
            this.txtPriceDL.Size = new System.Drawing.Size(136, 20);
            this.txtPriceDL.TabIndex = 4;
            // 
            // txtIDProductDL
            // 
            this.txtIDProductDL.Enabled = false;
            this.txtIDProductDL.Location = new System.Drawing.Point(93, 49);
            this.txtIDProductDL.Name = "txtIDProductDL";
            this.txtIDProductDL.ReadOnly = true;
            this.txtIDProductDL.Size = new System.Drawing.Size(136, 20);
            this.txtIDProductDL.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã đại lí";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Đơn vị";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Giá";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tên SP";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mã SP";
            // 
            // btnDeleteProductAgency
            // 
            this.btnDeleteProductAgency.Location = new System.Drawing.Point(219, 490);
            this.btnDeleteProductAgency.Name = "btnDeleteProductAgency";
            this.btnDeleteProductAgency.Size = new System.Drawing.Size(75, 36);
            this.btnDeleteProductAgency.TabIndex = 14;
            this.btnDeleteProductAgency.Text = "Xóa";
            this.btnDeleteProductAgency.UseVisualStyleBackColor = true;
            // 
            // btnUpdateProductAgency
            // 
            this.btnUpdateProductAgency.Location = new System.Drawing.Point(119, 490);
            this.btnUpdateProductAgency.Name = "btnUpdateProductAgency";
            this.btnUpdateProductAgency.Size = new System.Drawing.Size(75, 36);
            this.btnUpdateProductAgency.TabIndex = 15;
            this.btnUpdateProductAgency.Text = "Cập nhật";
            this.btnUpdateProductAgency.UseVisualStyleBackColor = true;
            // 
            // btnAddProductAgency
            // 
            this.btnAddProductAgency.Location = new System.Drawing.Point(26, 490);
            this.btnAddProductAgency.Name = "btnAddProductAgency";
            this.btnAddProductAgency.Size = new System.Drawing.Size(75, 36);
            this.btnAddProductAgency.TabIndex = 13;
            this.btnAddProductAgency.Text = "Thêm";
            this.btnAddProductAgency.UseVisualStyleBackColor = true;
            // 
            // uctSanPhamDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnDeleteProductAgency);
            this.Controls.Add(this.btnUpdateProductAgency);
            this.Controls.Add(this.btnAddProductAgency);
            this.Controls.Add(this.grbListProductOfAgency);
            this.Controls.Add(this.grbProductOfAgency);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "uctSanPhamDL";
            this.Size = new System.Drawing.Size(1257, 559);
            this.grbListProductOfAgency.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductListOfAgency)).EndInit();
            this.grbProductOfAgency.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbListProductOfAgency;
        private System.Windows.Forms.DataGridView dtgvProductListOfAgency;
        private System.Windows.Forms.GroupBox grbProductOfAgency;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbIDAgency;
        private System.Windows.Forms.TextBox txtAmountDL;
        private System.Windows.Forms.TextBox txtUnitDL;
        private System.Windows.Forms.TextBox txtNameProductDL;
        private System.Windows.Forms.TextBox txtPriceDL;
        private System.Windows.Forms.TextBox txtIDProductDL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDeleteProductAgency;
        private System.Windows.Forms.Button btnUpdateProductAgency;
        private System.Windows.Forms.Button btnAddProductAgency;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSPDL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}
