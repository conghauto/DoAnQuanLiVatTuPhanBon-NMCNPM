namespace QLCUAHANG_GUI
{
    partial class uctQuanLiTienNoKhachHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvListCustomer = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbListBill = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDCustomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameCustomer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalDebt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalDebtOfPay = new System.Windows.Forms.TextBox();
            this.lbClear = new System.Windows.Forms.LinkLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.dtgvListPay = new System.Windows.Forms.DataGridView();
            this.MaTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIDPay = new System.Windows.Forms.TextBox();
            this.btnDeletePay = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnUpdateTotalDebt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListCustomer)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListPay)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvListCustomer);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 454);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách khách hàng";
            // 
            // dtgvListCustomer
            // 
            this.dtgvListCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH});
            this.dtgvListCustomer.Location = new System.Drawing.Point(3, 40);
            this.dtgvListCustomer.Name = "dtgvListCustomer";
            this.dtgvListCustomer.ReadOnly = true;
            this.dtgvListCustomer.RowHeadersVisible = false;
            this.dtgvListCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvListCustomer.Size = new System.Drawing.Size(307, 408);
            this.dtgvListCustomer.TabIndex = 1;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            this.MaKH.Width = 150;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên khách hàng";
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            this.TenKH.Width = 150;
            // 
            // lbListBill
            // 
            this.lbListBill.FormattingEnabled = true;
            this.lbListBill.ItemHeight = 19;
            this.lbListBill.Location = new System.Drawing.Point(541, 44);
            this.lbListBill.Name = "lbListBill";
            this.lbListBill.Size = new System.Drawing.Size(108, 118);
            this.lbListBill.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã KH";
            // 
            // txtIDCustomer
            // 
            this.txtIDCustomer.Enabled = false;
            this.txtIDCustomer.Location = new System.Drawing.Point(121, 40);
            this.txtIDCustomer.Name = "txtIDCustomer";
            this.txtIDCustomer.ReadOnly = true;
            this.txtIDCustomer.Size = new System.Drawing.Size(121, 26);
            this.txtIDCustomer.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên khách hàng";
            // 
            // txtNameCustomer
            // 
            this.txtNameCustomer.Enabled = false;
            this.txtNameCustomer.Location = new System.Drawing.Point(390, 40);
            this.txtNameCustomer.Name = "txtNameCustomer";
            this.txtNameCustomer.ReadOnly = true;
            this.txtNameCustomer.Size = new System.Drawing.Size(106, 26);
            this.txtNameCustomer.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(534, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Danh sách hóa đơn ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tổng nợ";
            // 
            // txtTotalDebt
            // 
            this.txtTotalDebt.Location = new System.Drawing.Point(121, 73);
            this.txtTotalDebt.Name = "txtTotalDebt";
            this.txtTotalDebt.Size = new System.Drawing.Size(121, 26);
            this.txtTotalDebt.TabIndex = 6;
            this.txtTotalDebt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalDebt_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox2.Controls.Add(this.txtPay);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtTotalDebtOfPay);
            this.groupBox2.Controls.Add(this.lbListBill);
            this.groupBox2.Controls.Add(this.lbClear);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.dtgvListPay);
            this.groupBox2.Controls.Add(this.txtIDPay);
            this.groupBox2.Controls.Add(this.btnDeletePay);
            this.groupBox2.Controls.Add(this.btnPay);
            this.groupBox2.Controls.Add(this.txtTotalDebt);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNameCustomer);
            this.groupBox2.Controls.Add(this.txtIDCustomer);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(399, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(669, 419);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // txtPay
            // 
            this.txtPay.Location = new System.Drawing.Point(390, 130);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(106, 26);
            this.txtPay.TabIndex = 12;
            this.txtPay.Click += new System.EventHandler(this.txtPay_Click);
            this.txtPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPay_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Sau khi thanh toán tổng nợ :";
            // 
            // txtTotalDebtOfPay
            // 
            this.txtTotalDebtOfPay.Location = new System.Drawing.Point(223, 220);
            this.txtTotalDebtOfPay.Name = "txtTotalDebtOfPay";
            this.txtTotalDebtOfPay.Size = new System.Drawing.Size(100, 26);
            this.txtTotalDebtOfPay.TabIndex = 6;
            this.txtTotalDebtOfPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalDebtOfPay_KeyPress);
            // 
            // lbClear
            // 
            this.lbClear.AutoSize = true;
            this.lbClear.Location = new System.Drawing.Point(11, 253);
            this.lbClear.Name = "lbClear";
            this.lbClear.Size = new System.Drawing.Size(42, 19);
            this.lbClear.TabIndex = 11;
            this.lbClear.TabStop = true;
            this.lbClear.Text = "Clear";
            this.lbClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbClear_LinkClicked);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 19);
            this.label11.TabIndex = 6;
            this.label11.Text = "Mã thanh toán";
            // 
            // dtgvListPay
            // 
            this.dtgvListPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListPay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTT,
            this.MaKH1,
            this.NgayTra,
            this.SoTienTra,
            this.TinhTrang});
            this.dtgvListPay.Location = new System.Drawing.Point(15, 275);
            this.dtgvListPay.Name = "dtgvListPay";
            this.dtgvListPay.ReadOnly = true;
            this.dtgvListPay.RowHeadersVisible = false;
            this.dtgvListPay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgvListPay.Size = new System.Drawing.Size(507, 138);
            this.dtgvListPay.TabIndex = 5;
            this.dtgvListPay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListPay_CellClick);
            // 
            // MaTT
            // 
            this.MaTT.DataPropertyName = "MaTT";
            this.MaTT.HeaderText = "Mã TT";
            this.MaTT.Name = "MaTT";
            this.MaTT.ReadOnly = true;
            // 
            // MaKH1
            // 
            this.MaKH1.DataPropertyName = "MaKH";
            this.MaKH1.HeaderText = "Mã KH";
            this.MaKH1.Name = "MaKH1";
            this.MaKH1.ReadOnly = true;
            // 
            // NgayTra
            // 
            this.NgayTra.DataPropertyName = "NgayTra";
            this.NgayTra.HeaderText = "Ngày trả";
            this.NgayTra.Name = "NgayTra";
            this.NgayTra.ReadOnly = true;
            // 
            // SoTienTra
            // 
            this.SoTienTra.DataPropertyName = "SoTienTra";
            this.SoTienTra.HeaderText = "Số tiền trả";
            this.SoTienTra.Name = "SoTienTra";
            this.SoTienTra.ReadOnly = true;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.ReadOnly = true;
            // 
            // txtIDPay
            // 
            this.txtIDPay.Enabled = false;
            this.txtIDPay.Location = new System.Drawing.Point(121, 127);
            this.txtIDPay.Name = "txtIDPay";
            this.txtIDPay.ReadOnly = true;
            this.txtIDPay.Size = new System.Drawing.Size(121, 26);
            this.txtIDPay.TabIndex = 4;
            // 
            // btnDeletePay
            // 
            this.btnDeletePay.Location = new System.Drawing.Point(552, 350);
            this.btnDeletePay.Name = "btnDeletePay";
            this.btnDeletePay.Size = new System.Drawing.Size(97, 32);
            this.btnDeletePay.TabIndex = 0;
            this.btnDeletePay.Text = "Xóa";
            this.btnDeletePay.UseVisualStyleBackColor = true;
            this.btnDeletePay.Click += new System.EventHandler(this.btnDeletePay_Click);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(552, 295);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(97, 32);
            this.btnPay.TabIndex = 0;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnAddPayout_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(276, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "Số tiền trả";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 160);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 26);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ngày trả";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(395, 470);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(226, 19);
            this.label9.TabIndex = 9;
            this.label9.Text = "Bạn có muốn cập nhật lại Tổng nợ ?";
            // 
            // btnUpdateTotalDebt
            // 
            this.btnUpdateTotalDebt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTotalDebt.Location = new System.Drawing.Point(650, 466);
            this.btnUpdateTotalDebt.Name = "btnUpdateTotalDebt";
            this.btnUpdateTotalDebt.Size = new System.Drawing.Size(88, 26);
            this.btnUpdateTotalDebt.TabIndex = 12;
            this.btnUpdateTotalDebt.Text = "Cập nhật";
            this.btnUpdateTotalDebt.UseVisualStyleBackColor = true;
            this.btnUpdateTotalDebt.Click += new System.EventHandler(this.btnUpdateTotalDebt_Click);
            // 
            // uctQuanLiTienNoKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnUpdateTotalDebt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Name = "uctQuanLiTienNoKhachHang";
            this.Size = new System.Drawing.Size(1096, 516);
            this.Load += new System.EventHandler(this.uctQuanLiTienNoKhachHang_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListCustomer)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListPay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbListBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalDebt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalDebtOfPay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dtgvListPay;
        private System.Windows.Forms.Button btnDeletePay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIDPay;
        private System.Windows.Forms.LinkLabel lbClear;
        private System.Windows.Forms.DataGridView dtgvListCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.Button btnUpdateTotalDebt;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTienTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
    }
}
