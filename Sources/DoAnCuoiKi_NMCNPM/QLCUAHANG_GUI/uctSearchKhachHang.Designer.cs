namespace QLCUAHANG_GUI
{
    partial class uctSearchKhachHang
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearchResult = new System.Windows.Forms.Button();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.cmbFindCustomer = new System.Windows.Forms.ComboBox();
            this.dtgvListResultCustomer = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListResultCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tìm kiếm tên :";
            // 
            // btnSearchResult
            // 
            this.btnSearchResult.Location = new System.Drawing.Point(533, 18);
            this.btnSearchResult.Name = "btnSearchResult";
            this.btnSearchResult.Size = new System.Drawing.Size(75, 23);
            this.btnSearchResult.TabIndex = 18;
            this.btnSearchResult.Text = "Tìm kiếm";
            this.btnSearchResult.UseVisualStyleBackColor = true;
            this.btnSearchResult.Click += new System.EventHandler(this.btnSearchResult_Click);
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Location = new System.Drawing.Point(243, 20);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(284, 20);
            this.txtSearchCustomer.TabIndex = 20;
            this.txtSearchCustomer.TextChanged += new System.EventHandler(this.txtSearchCustomer_TextChanged);
            // 
            // cmbFindCustomer
            // 
            this.cmbFindCustomer.FormattingEnabled = true;
            this.cmbFindCustomer.Location = new System.Drawing.Point(109, 19);
            this.cmbFindCustomer.Name = "cmbFindCustomer";
            this.cmbFindCustomer.Size = new System.Drawing.Size(128, 21);
            this.cmbFindCustomer.TabIndex = 21;
            // 
            // dtgvListResultCustomer
            // 
            this.dtgvListResultCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListResultCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.DiaChi,
            this.SoDT});
            this.dtgvListResultCustomer.Location = new System.Drawing.Point(18, 65);
            this.dtgvListResultCustomer.Name = "dtgvListResultCustomer";
            this.dtgvListResultCustomer.ReadOnly = true;
            this.dtgvListResultCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvListResultCustomer.Size = new System.Drawing.Size(637, 133);
            this.dtgvListResultCustomer.TabIndex = 24;
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
            this.TenKH.Width = 160;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Width = 180;
            // 
            // SoDT
            // 
            this.SoDT.DataPropertyName = "SoDT";
            this.SoDT.HeaderText = "Số điện thoại";
            this.SoDT.Name = "SoDT";
            this.SoDT.ReadOnly = true;
            this.SoDT.Width = 154;
            // 
            // uctSearchKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtgvListResultCustomer);
            this.Controls.Add(this.cmbFindCustomer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSearchResult);
            this.Controls.Add(this.txtSearchCustomer);
            this.Name = "uctSearchKhachHang";
            this.Size = new System.Drawing.Size(675, 201);
            this.Load += new System.EventHandler(this.uctSearchKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListResultCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearchResult;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.ComboBox cmbFindCustomer;
        private System.Windows.Forms.DataGridView dtgvListResultCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT;
    }
}
