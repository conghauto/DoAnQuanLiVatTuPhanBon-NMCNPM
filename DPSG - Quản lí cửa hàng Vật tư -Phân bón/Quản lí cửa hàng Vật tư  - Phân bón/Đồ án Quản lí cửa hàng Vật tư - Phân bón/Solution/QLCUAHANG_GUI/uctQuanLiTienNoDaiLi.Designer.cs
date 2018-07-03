namespace QLCUAHANG_GUI
{
    partial class uctQuanLiTienNoDaiLi
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPayAgency = new System.Windows.Forms.TextBox();
            this.lbListBillOfAgency = new System.Windows.Forms.ListBox();
            this.lbClear = new System.Windows.Forms.LinkLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.dtgvListPayOfAgency = new System.Windows.Forms.DataGridView();
            this.MaTN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDL1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIDPayOfAgency = new System.Windows.Forms.TextBox();
            this.btnDeletePay = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.txtTotalDebt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDatePay = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameAgency = new System.Windows.Forms.TextBox();
            this.txtIDAgency = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvListAgency = new System.Windows.Forms.DataGridView();
            this.MaDL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListPayOfAgency)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListAgency)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox2.Controls.Add(this.txtPayAgency);
            this.groupBox2.Controls.Add(this.lbListBillOfAgency);
            this.groupBox2.Controls.Add(this.lbClear);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.dtgvListPayOfAgency);
            this.groupBox2.Controls.Add(this.txtIDPayOfAgency);
            this.groupBox2.Controls.Add(this.btnDeletePay);
            this.groupBox2.Controls.Add(this.btnPay);
            this.groupBox2.Controls.Add(this.txtTotalDebt);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dtpDatePay);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNameAgency);
            this.groupBox2.Controls.Add(this.txtIDAgency);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(396, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(669, 434);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // txtPayAgency
            // 
            this.txtPayAgency.Location = new System.Drawing.Point(346, 147);
            this.txtPayAgency.Name = "txtPayAgency";
            this.txtPayAgency.Size = new System.Drawing.Size(150, 26);
            this.txtPayAgency.TabIndex = 12;
            this.txtPayAgency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPayAgency_KeyPress);
            // 
            // lbListBillOfAgency
            // 
            this.lbListBillOfAgency.FormattingEnabled = true;
            this.lbListBillOfAgency.ItemHeight = 19;
            this.lbListBillOfAgency.Location = new System.Drawing.Point(541, 36);
            this.lbListBillOfAgency.Name = "lbListBillOfAgency";
            this.lbListBillOfAgency.Size = new System.Drawing.Size(108, 137);
            this.lbListBillOfAgency.TabIndex = 1;
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
            this.label11.Location = new System.Drawing.Point(11, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 19);
            this.label11.TabIndex = 6;
            this.label11.Text = "Mã thanh toán";
            // 
            // dtgvListPayOfAgency
            // 
            this.dtgvListPayOfAgency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListPayOfAgency.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTN,
            this.MaDL1,
            this.NgayTra,
            this.SoTienTra});
            this.dtgvListPayOfAgency.Location = new System.Drawing.Point(15, 275);
            this.dtgvListPayOfAgency.Name = "dtgvListPayOfAgency";
            this.dtgvListPayOfAgency.ReadOnly = true;
            this.dtgvListPayOfAgency.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgvListPayOfAgency.Size = new System.Drawing.Size(481, 138);
            this.dtgvListPayOfAgency.TabIndex = 5;
            this.dtgvListPayOfAgency.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListPayOfAgency_CellClick);
            // 
            // MaTN
            // 
            this.MaTN.DataPropertyName = "MaTN";
            this.MaTN.HeaderText = "Mã TT";
            this.MaTN.Name = "MaTN";
            this.MaTN.ReadOnly = true;
            // 
            // MaDL1
            // 
            this.MaDL1.DataPropertyName = "MaDL";
            this.MaDL1.HeaderText = "Mã DL";
            this.MaDL1.Name = "MaDL1";
            this.MaDL1.ReadOnly = true;
            this.MaDL1.Width = 105;
            // 
            // NgayTra
            // 
            this.NgayTra.DataPropertyName = "NgayTra";
            this.NgayTra.HeaderText = "Ngày trả";
            this.NgayTra.Name = "NgayTra";
            this.NgayTra.ReadOnly = true;
            this.NgayTra.Width = 115;
            // 
            // SoTienTra
            // 
            this.SoTienTra.DataPropertyName = "SoTienTra";
            this.SoTienTra.HeaderText = "Số tiền trả";
            this.SoTienTra.Name = "SoTienTra";
            this.SoTienTra.ReadOnly = true;
            this.SoTienTra.Width = 115;
            // 
            // txtIDPayOfAgency
            // 
            this.txtIDPayOfAgency.Enabled = false;
            this.txtIDPayOfAgency.Location = new System.Drawing.Point(121, 147);
            this.txtIDPayOfAgency.Name = "txtIDPayOfAgency";
            this.txtIDPayOfAgency.ReadOnly = true;
            this.txtIDPayOfAgency.Size = new System.Drawing.Size(121, 26);
            this.txtIDPayOfAgency.TabIndex = 4;
            // 
            // btnDeletePay
            // 
            this.btnDeletePay.Location = new System.Drawing.Point(541, 327);
            this.btnDeletePay.Name = "btnDeletePay";
            this.btnDeletePay.Size = new System.Drawing.Size(97, 32);
            this.btnDeletePay.TabIndex = 0;
            this.btnDeletePay.Text = "Xóa";
            this.btnDeletePay.UseVisualStyleBackColor = true;
            this.btnDeletePay.Click += new System.EventHandler(this.btnDeletePay_Click);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(541, 275);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(97, 32);
            this.btnPay.TabIndex = 0;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txtTotalDebt
            // 
            this.txtTotalDebt.Location = new System.Drawing.Point(121, 73);
            this.txtTotalDebt.Name = "txtTotalDebt";
            this.txtTotalDebt.Size = new System.Drawing.Size(121, 26);
            this.txtTotalDebt.TabIndex = 6;
            this.txtTotalDebt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalDebt_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(262, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "Số tiền trả: ";
            // 
            // dtpDatePay
            // 
            this.dtpDatePay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatePay.Location = new System.Drawing.Point(121, 179);
            this.dtpDatePay.Name = "dtpDatePay";
            this.dtpDatePay.Size = new System.Drawing.Size(121, 26);
            this.dtpDatePay.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ngày trả";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(537, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Danh sách hóa đơn ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã DL";
            // 
            // txtNameAgency
            // 
            this.txtNameAgency.Enabled = false;
            this.txtNameAgency.Location = new System.Drawing.Point(346, 40);
            this.txtNameAgency.Multiline = true;
            this.txtNameAgency.Name = "txtNameAgency";
            this.txtNameAgency.ReadOnly = true;
            this.txtNameAgency.Size = new System.Drawing.Size(150, 59);
            this.txtNameAgency.TabIndex = 3;
            // 
            // txtIDAgency
            // 
            this.txtIDAgency.Enabled = false;
            this.txtIDAgency.Location = new System.Drawing.Point(121, 40);
            this.txtIDAgency.Name = "txtIDAgency";
            this.txtIDAgency.ReadOnly = true;
            this.txtIDAgency.Size = new System.Drawing.Size(121, 26);
            this.txtIDAgency.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên đại lí";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvListAgency);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 434);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách Đại lí";
            // 
            // dtgvListAgency
            // 
            this.dtgvListAgency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListAgency.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDL,
            this.TenDL});
            this.dtgvListAgency.Location = new System.Drawing.Point(3, 40);
            this.dtgvListAgency.Name = "dtgvListAgency";
            this.dtgvListAgency.ReadOnly = true;
            this.dtgvListAgency.RowHeadersVisible = false;
            this.dtgvListAgency.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvListAgency.Size = new System.Drawing.Size(307, 388);
            this.dtgvListAgency.TabIndex = 1;
            this.dtgvListAgency.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListAgency_CellClick);
            // 
            // MaDL
            // 
            this.MaDL.DataPropertyName = "MaDL";
            this.MaDL.HeaderText = "Mã DL";
            this.MaDL.Name = "MaDL";
            this.MaDL.ReadOnly = true;
            this.MaDL.Width = 150;
            // 
            // TenDL
            // 
            this.TenDL.DataPropertyName = "TenDL";
            this.TenDL.HeaderText = "Tên đại lí";
            this.TenDL.Name = "TenDL";
            this.TenDL.ReadOnly = true;
            this.TenDL.Width = 150;
            // 
            // uctQuanLiTienNoDaiLi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "uctQuanLiTienNoDaiLi";
            this.Size = new System.Drawing.Size(1096, 516);
            this.Load += new System.EventHandler(this.uctQuanLiTienNoDaiLi_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListPayOfAgency)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListAgency)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPayAgency;
        private System.Windows.Forms.ListBox lbListBillOfAgency;
        private System.Windows.Forms.LinkLabel lbClear;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dtgvListPayOfAgency;
        private System.Windows.Forms.TextBox txtIDPayOfAgency;
        private System.Windows.Forms.Button btnDeletePay;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txtTotalDebt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDatePay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameAgency;
        private System.Windows.Forms.TextBox txtIDAgency;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvListAgency;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDL1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTienTra;
    }
}
