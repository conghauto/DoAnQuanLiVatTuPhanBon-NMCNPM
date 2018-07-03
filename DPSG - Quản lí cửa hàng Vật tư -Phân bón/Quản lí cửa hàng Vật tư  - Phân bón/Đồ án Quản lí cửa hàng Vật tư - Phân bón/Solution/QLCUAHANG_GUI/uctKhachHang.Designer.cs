namespace QLCUAHANG_GUI
{
    partial class uctKhachHang
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
            this.grbInfoCustomer = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbClear = new System.Windows.Forms.LinkLabel();
            this.txtNameCustomer = new System.Windows.Forms.TextBox();
            this.txtTotalDebt = new System.Windows.Forms.TextBox();
            this.txtNumberPhone = new System.Windows.Forms.TextBox();
            this.txtAddressCustomer = new System.Windows.Forms.TextBox();
            this.txtIDCustomer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbIDCustomer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnHideList = new System.Windows.Forms.Button();
            this.grbListInfoOfCustomer = new System.Windows.Forms.GroupBox();
            this.dtgvCustomersListOfStore = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlListCustomer = new System.Windows.Forms.Panel();
            this.grbInfoCustomer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grbListInfoOfCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomersListOfStore)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInfoCustomer
            // 
            this.grbInfoCustomer.Controls.Add(this.panel1);
            this.grbInfoCustomer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInfoCustomer.Location = new System.Drawing.Point(20, 44);
            this.grbInfoCustomer.Name = "grbInfoCustomer";
            this.grbInfoCustomer.Size = new System.Drawing.Size(510, 168);
            this.grbInfoCustomer.TabIndex = 9;
            this.grbInfoCustomer.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbClear);
            this.panel1.Controls.Add(this.txtNameCustomer);
            this.panel1.Controls.Add(this.txtTotalDebt);
            this.panel1.Controls.Add(this.txtNumberPhone);
            this.panel1.Controls.Add(this.txtAddressCustomer);
            this.panel1.Controls.Add(this.txtIDCustomer);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbIDCustomer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 148);
            this.panel1.TabIndex = 5;
            // 
            // lbClear
            // 
            this.lbClear.AutoSize = true;
            this.lbClear.Location = new System.Drawing.Point(30, 123);
            this.lbClear.Name = "lbClear";
            this.lbClear.Size = new System.Drawing.Size(36, 13);
            this.lbClear.TabIndex = 4;
            this.lbClear.TabStop = true;
            this.lbClear.Text = "Clear";
            this.lbClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbClear_LinkClicked);
            // 
            // txtNameCustomer
            // 
            this.txtNameCustomer.Location = new System.Drawing.Point(348, 34);
            this.txtNameCustomer.Name = "txtNameCustomer";
            this.txtNameCustomer.Size = new System.Drawing.Size(129, 21);
            this.txtNameCustomer.TabIndex = 3;
            // 
            // txtTotalDebt
            // 
            this.txtTotalDebt.Location = new System.Drawing.Point(348, 106);
            this.txtTotalDebt.Name = "txtTotalDebt";
            this.txtTotalDebt.Size = new System.Drawing.Size(131, 21);
            this.txtTotalDebt.TabIndex = 3;
            this.txtTotalDebt.Click += new System.EventHandler(this.txtTotalDebt_Click);
            this.txtTotalDebt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumberPhone_KeyPress);
            // 
            // txtNumberPhone
            // 
            this.txtNumberPhone.Location = new System.Drawing.Point(348, 73);
            this.txtNumberPhone.Name = "txtNumberPhone";
            this.txtNumberPhone.Size = new System.Drawing.Size(131, 21);
            this.txtNumberPhone.TabIndex = 3;
            this.txtNumberPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumberPhone_KeyPress);
            // 
            // txtAddressCustomer
            // 
            this.txtAddressCustomer.Location = new System.Drawing.Point(82, 73);
            this.txtAddressCustomer.Name = "txtAddressCustomer";
            this.txtAddressCustomer.Size = new System.Drawing.Size(122, 21);
            this.txtAddressCustomer.TabIndex = 3;
            // 
            // txtIDCustomer
            // 
            this.txtIDCustomer.Enabled = false;
            this.txtIDCustomer.Location = new System.Drawing.Point(80, 34);
            this.txtIDCustomer.Name = "txtIDCustomer";
            this.txtIDCustomer.ReadOnly = true;
            this.txtIDCustomer.Size = new System.Drawing.Size(124, 21);
            this.txtIDCustomer.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tổng nợ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số Điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tên KH";
            // 
            // lbIDCustomer
            // 
            this.lbIDCustomer.AutoSize = true;
            this.lbIDCustomer.Location = new System.Drawing.Point(30, 37);
            this.lbIDCustomer.Name = "lbIDCustomer";
            this.lbIDCustomer.Size = new System.Drawing.Size(42, 13);
            this.lbIDCustomer.TabIndex = 1;
            this.lbIDCustomer.Text = "Mã KH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(800, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCustomer.Location = new System.Drawing.Point(350, 226);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCustomer.TabIndex = 13;
            this.btnDeleteCustomer.Text = "Xóa";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCustomer.Location = new System.Drawing.Point(226, 226);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateCustomer.TabIndex = 14;
            this.btnUpdateCustomer.Text = "Cập nhật";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Location = new System.Drawing.Point(105, 226);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnAddCustomer.TabIndex = 15;
            this.btnAddCustomer.Text = "Thêm";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(570, 226);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnHideList
            // 
            this.btnHideList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHideList.Location = new System.Drawing.Point(696, 226);
            this.btnHideList.Name = "btnHideList";
            this.btnHideList.Size = new System.Drawing.Size(75, 23);
            this.btnHideList.TabIndex = 13;
            this.btnHideList.Text = "<<";
            this.btnHideList.UseVisualStyleBackColor = true;
            this.btnHideList.Click += new System.EventHandler(this.btnHideList_Click);
            // 
            // grbListInfoOfCustomer
            // 
            this.grbListInfoOfCustomer.Controls.Add(this.dtgvCustomersListOfStore);
            this.grbListInfoOfCustomer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListInfoOfCustomer.Location = new System.Drawing.Point(567, 44);
            this.grbListInfoOfCustomer.Name = "grbListInfoOfCustomer";
            this.grbListInfoOfCustomer.Size = new System.Drawing.Size(643, 165);
            this.grbListInfoOfCustomer.TabIndex = 18;
            this.grbListInfoOfCustomer.TabStop = false;
            // 
            // dtgvCustomersListOfStore
            // 
            this.dtgvCustomersListOfStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCustomersListOfStore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.DiaChi,
            this.SoDT,
            this.TongNo});
            this.dtgvCustomersListOfStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvCustomersListOfStore.Location = new System.Drawing.Point(3, 18);
            this.dtgvCustomersListOfStore.Name = "dtgvCustomersListOfStore";
            this.dtgvCustomersListOfStore.ReadOnly = true;
            this.dtgvCustomersListOfStore.RowHeadersVisible = false;
            this.dtgvCustomersListOfStore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvCustomersListOfStore.Size = new System.Drawing.Size(637, 144);
            this.dtgvCustomersListOfStore.TabIndex = 23;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên Khách hàng";
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            this.TenKH.Width = 140;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Width = 150;
            // 
            // SoDT
            // 
            this.SoDT.DataPropertyName = "SoDT";
            this.SoDT.HeaderText = "Số điện thoại";
            this.SoDT.Name = "SoDT";
            this.SoDT.ReadOnly = true;
            this.SoDT.Width = 120;
            // 
            // TongNo
            // 
            this.TongNo.DataPropertyName = "TongNo";
            this.TongNo.HeaderText = "Tổng nợ";
            this.TongNo.Name = "TongNo";
            this.TongNo.ReadOnly = true;
            this.TongNo.Width = 120;
            // 
            // pnlListCustomer
            // 
            this.pnlListCustomer.Location = new System.Drawing.Point(23, 269);
            this.pnlListCustomer.Name = "pnlListCustomer";
            this.pnlListCustomer.Size = new System.Drawing.Size(819, 339);
            this.pnlListCustomer.TabIndex = 19;
            // 
            // uctKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Controls.Add(this.pnlListCustomer);
            this.Controls.Add(this.grbListInfoOfCustomer);
            this.Controls.Add(this.btnHideList);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grbInfoCustomer);
            this.Name = "uctKhachHang";
            this.Size = new System.Drawing.Size(1232, 525);
            this.Load += new System.EventHandler(this.uctKhachHang_Load);
            this.grbInfoCustomer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbListInfoOfCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomersListOfStore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grbInfoCustomer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNameCustomer;
        private System.Windows.Forms.TextBox txtNumberPhone;
        private System.Windows.Forms.TextBox txtAddressCustomer;
        private System.Windows.Forms.TextBox txtIDCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbIDCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnHideList;
        private System.Windows.Forms.GroupBox grbListInfoOfCustomer;
        private System.Windows.Forms.Panel pnlListCustomer;
        private System.Windows.Forms.DataGridView dtgvCustomersListOfStore;
        private System.Windows.Forms.LinkLabel lbClear;
        private System.Windows.Forms.TextBox txtTotalDebt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongNo;
    }
}
