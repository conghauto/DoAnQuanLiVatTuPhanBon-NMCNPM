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
            this.ThongSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbProductOfAgency = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUnitDL = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbKg = new System.Windows.Forms.RadioButton();
            this.rbMl = new System.Windows.Forms.RadioButton();
            this.txtParameter = new System.Windows.Forms.TextBox();
            this.cmbIDAgency = new System.Windows.Forms.ComboBox();
            this.txtNameProductDL = new System.Windows.Forms.TextBox();
            this.txtPriceDL = new System.Windows.Forms.TextBox();
            this.txtIDProductDL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDeleteProductAgency = new System.Windows.Forms.Button();
            this.btnUpdateProductAgency = new System.Windows.Forms.Button();
            this.btnAddProductAgency = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grbListProductOfAgency.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductListOfAgency)).BeginInit();
            this.grbProductOfAgency.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(63, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "SẢN PHẨM CỦA ĐẠI LÍ";
            // 
            // grbListProductOfAgency
            // 
            this.grbListProductOfAgency.Controls.Add(this.dtgvProductListOfAgency);
            this.grbListProductOfAgency.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.ThongSo});
            this.dtgvProductListOfAgency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvProductListOfAgency.Location = new System.Drawing.Point(3, 22);
            this.dtgvProductListOfAgency.Name = "dtgvProductListOfAgency";
            this.dtgvProductListOfAgency.ReadOnly = true;
            this.dtgvProductListOfAgency.RowHeadersVisible = false;
            this.dtgvProductListOfAgency.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvProductListOfAgency.Size = new System.Drawing.Size(913, 392);
            this.dtgvProductListOfAgency.TabIndex = 1;
            // 
            // MaSPDL
            // 
            this.MaSPDL.DataPropertyName = "MaSPDL";
            this.MaSPDL.HeaderText = "Mã SP";
            this.MaSPDL.Name = "MaSPDL";
            this.MaSPDL.ReadOnly = true;
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
            this.Gia.Width = 120;
            // 
            // DonVi
            // 
            this.DonVi.DataPropertyName = "DonVi";
            this.DonVi.HeaderText = "Đơn vị";
            this.DonVi.Name = "DonVi";
            this.DonVi.ReadOnly = true;
            // 
            // ThongSo
            // 
            this.ThongSo.DataPropertyName = "ThongSo";
            this.ThongSo.HeaderText = "Thông số/ Sản phẩm ( kg hoặc ml )";
            this.ThongSo.Name = "ThongSo";
            this.ThongSo.ReadOnly = true;
            this.ThongSo.Width = 280;
            // 
            // grbProductOfAgency
            // 
            this.grbProductOfAgency.Controls.Add(this.panel1);
            this.grbProductOfAgency.Location = new System.Drawing.Point(10, 57);
            this.grbProductOfAgency.Name = "grbProductOfAgency";
            this.grbProductOfAgency.Size = new System.Drawing.Size(281, 417);
            this.grbProductOfAgency.TabIndex = 7;
            this.grbProductOfAgency.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.txtUnitDL);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtParameter);
            this.panel1.Controls.Add(this.cmbIDAgency);
            this.panel1.Controls.Add(this.txtNameProductDL);
            this.panel1.Controls.Add(this.txtPriceDL);
            this.panel1.Controls.Add(this.txtIDProductDL);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 398);
            this.panel1.TabIndex = 1;
            // 
            // txtUnitDL
            // 
            this.txtUnitDL.FormattingEnabled = true;
            this.txtUnitDL.Items.AddRange(new object[] {
            "bịch",
            "bao",
            "gói",
            "chai",
            "thùng"});
            this.txtUnitDL.Location = new System.Drawing.Point(110, 240);
            this.txtUnitDL.Name = "txtUnitDL";
            this.txtUnitDL.Size = new System.Drawing.Size(152, 22);
            this.txtUnitDL.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbKg);
            this.panel2.Controls.Add(this.rbMl);
            this.panel2.Location = new System.Drawing.Point(149, 280);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(113, 26);
            this.panel2.TabIndex = 2;
            // 
            // rbKg
            // 
            this.rbKg.AutoSize = true;
            this.rbKg.Location = new System.Drawing.Point(11, 9);
            this.rbKg.Name = "rbKg";
            this.rbKg.Size = new System.Drawing.Size(40, 18);
            this.rbKg.TabIndex = 2;
            this.rbKg.TabStop = true;
            this.rbKg.Text = "kg";
            this.rbKg.UseVisualStyleBackColor = true;
            // 
            // rbMl
            // 
            this.rbMl.AutoSize = true;
            this.rbMl.Location = new System.Drawing.Point(78, 9);
            this.rbMl.Name = "rbMl";
            this.rbMl.Size = new System.Drawing.Size(39, 18);
            this.rbMl.TabIndex = 2;
            this.rbMl.TabStop = true;
            this.rbMl.Text = "ml";
            this.rbMl.UseVisualStyleBackColor = true;
            // 
            // txtParameter
            // 
            this.txtParameter.Location = new System.Drawing.Point(110, 286);
            this.txtParameter.Name = "txtParameter";
            this.txtParameter.Size = new System.Drawing.Size(33, 22);
            this.txtParameter.TabIndex = 2;
            this.txtParameter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParameter_KeyPress);
            // 
            // cmbIDAgency
            // 
            this.cmbIDAgency.FormattingEnabled = true;
            this.cmbIDAgency.Location = new System.Drawing.Point(110, 140);
            this.cmbIDAgency.Name = "cmbIDAgency";
            this.cmbIDAgency.Size = new System.Drawing.Size(152, 22);
            this.cmbIDAgency.TabIndex = 3;
            // 
            // txtNameProductDL
            // 
            this.txtNameProductDL.Location = new System.Drawing.Point(110, 90);
            this.txtNameProductDL.Name = "txtNameProductDL";
            this.txtNameProductDL.Size = new System.Drawing.Size(152, 22);
            this.txtNameProductDL.TabIndex = 2;
            // 
            // txtPriceDL
            // 
            this.txtPriceDL.Location = new System.Drawing.Point(110, 189);
            this.txtPriceDL.Name = "txtPriceDL";
            this.txtPriceDL.Size = new System.Drawing.Size(152, 22);
            this.txtPriceDL.TabIndex = 4;
            // 
            // txtIDProductDL
            // 
            this.txtIDProductDL.Enabled = false;
            this.txtIDProductDL.Location = new System.Drawing.Point(110, 49);
            this.txtIDProductDL.Name = "txtIDProductDL";
            this.txtIDProductDL.ReadOnly = true;
            this.txtIDProductDL.Size = new System.Drawing.Size(152, 22);
            this.txtIDProductDL.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thông số";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 14);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã đại lí";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 14);
            this.label8.TabIndex = 0;
            this.label8.Text = "Đơn vị";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 14);
            this.label9.TabIndex = 0;
            this.label9.Text = "Giá / sản phẩm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 14);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tên SP";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 14);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mã SP";
            // 
            // btnDeleteProductAgency
            // 
            this.btnDeleteProductAgency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDeleteProductAgency.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteProductAgency.Image = global::QLCUAHANG_GUI.Properties.Resources.delete_3;
            this.btnDeleteProductAgency.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteProductAgency.Location = new System.Drawing.Point(234, 479);
            this.btnDeleteProductAgency.Name = "btnDeleteProductAgency";
            this.btnDeleteProductAgency.Size = new System.Drawing.Size(54, 27);
            this.btnDeleteProductAgency.TabIndex = 14;
            this.btnDeleteProductAgency.Text = "Xóa";
            this.btnDeleteProductAgency.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteProductAgency.UseVisualStyleBackColor = false;
            // 
            // btnUpdateProductAgency
            // 
            this.btnUpdateProductAgency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnUpdateProductAgency.BackgroundImage = global::QLCUAHANG_GUI.Properties.Resources.update_2;
            this.btnUpdateProductAgency.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateProductAgency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProductAgency.Location = new System.Drawing.Point(173, 480);
            this.btnUpdateProductAgency.Name = "btnUpdateProductAgency";
            this.btnUpdateProductAgency.Size = new System.Drawing.Size(48, 24);
            this.btnUpdateProductAgency.TabIndex = 15;
            this.btnUpdateProductAgency.UseVisualStyleBackColor = false;
            // 
            // btnAddProductAgency
            // 
            this.btnAddProductAgency.BackColor = System.Drawing.Color.MediumPurple;
            this.btnAddProductAgency.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddProductAgency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProductAgency.ForeColor = System.Drawing.Color.Black;
            this.btnAddProductAgency.Image = global::QLCUAHANG_GUI.Properties.Resources.add_2;
            this.btnAddProductAgency.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProductAgency.Location = new System.Drawing.Point(97, 480);
            this.btnAddProductAgency.Name = "btnAddProductAgency";
            this.btnAddProductAgency.Size = new System.Drawing.Size(59, 24);
            this.btnAddProductAgency.TabIndex = 13;
            this.btnAddProductAgency.Text = "Thêm";
            this.btnAddProductAgency.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddProductAgency.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(10, 480);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(64, 24);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // uctSanPhamDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Controls.Add(this.btnClear);
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.TextBox txtNameProductDL;
        private System.Windows.Forms.TextBox txtPriceDL;
        private System.Windows.Forms.TextBox txtIDProductDL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDeleteProductAgency;
        private System.Windows.Forms.Button btnUpdateProductAgency;
        private System.Windows.Forms.Button btnAddProductAgency;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbKg;
        private System.Windows.Forms.RadioButton rbMl;
        private System.Windows.Forms.TextBox txtParameter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtUnitDL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSPDL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThongSo;
    }
}
