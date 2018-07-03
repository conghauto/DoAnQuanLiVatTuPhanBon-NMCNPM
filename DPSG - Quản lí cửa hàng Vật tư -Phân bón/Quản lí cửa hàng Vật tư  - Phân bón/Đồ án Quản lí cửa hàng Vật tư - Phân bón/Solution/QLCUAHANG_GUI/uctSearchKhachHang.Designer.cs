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
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.cmbFindCustomer = new System.Windows.Forms.ComboBox();
            this.dtgvListResultCustomer = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearchResult = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListResultCustomer)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSearchCustomer.Location = new System.Drawing.Point(0, 0);
            this.txtSearchCustomer.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtSearchCustomer.Multiline = true;
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(411, 21);
            this.txtSearchCustomer.TabIndex = 20;
            this.txtSearchCustomer.TextChanged += new System.EventHandler(this.txtSearchCustomer_TextChanged);
            // 
            // cmbFindCustomer
            // 
            this.cmbFindCustomer.FormattingEnabled = true;
            this.cmbFindCustomer.ItemHeight = 13;
            this.cmbFindCustomer.Location = new System.Drawing.Point(152, 24);
            this.cmbFindCustomer.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cmbFindCustomer.Name = "cmbFindCustomer";
            this.cmbFindCustomer.Size = new System.Drawing.Size(130, 21);
            this.cmbFindCustomer.TabIndex = 21;
            // 
            // dtgvListResultCustomer
            // 
            this.dtgvListResultCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListResultCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.DiaChi,
            this.SoDT,
            this.TongNo});
            this.dtgvListResultCustomer.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvListResultCustomer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtgvListResultCustomer.Location = new System.Drawing.Point(24, 72);
            this.dtgvListResultCustomer.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dtgvListResultCustomer.Name = "dtgvListResultCustomer";
            this.dtgvListResultCustomer.ReadOnly = true;
            this.dtgvListResultCustomer.RowHeadersVisible = false;
            this.dtgvListResultCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvListResultCustomer.Size = new System.Drawing.Size(733, 153);
            this.dtgvListResultCustomer.TabIndex = 24;
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
            this.DiaChi.Width = 160;
            // 
            // SoDT
            // 
            this.SoDT.DataPropertyName = "SoDT";
            this.SoDT.HeaderText = "Số điện thoại";
            this.SoDT.Name = "SoDT";
            this.SoDT.ReadOnly = true;
            this.SoDT.Width = 135;
            // 
            // TongNo
            // 
            this.TongNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TongNo.DataPropertyName = "TongNo";
            this.TongNo.HeaderText = "Tổng nợ";
            this.TongNo.Name = "TongNo";
            this.TongNo.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnSearchResult);
            this.panel1.Location = new System.Drawing.Point(313, 24);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(444, 21);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtSearchCustomer);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(2);
            this.panel2.Size = new System.Drawing.Size(412, 21);
            this.panel2.TabIndex = 0;
            // 
            // btnSearchResult
            // 
            this.btnSearchResult.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnSearchResult.BackgroundImage = global::QLCUAHANG_GUI.Properties.Resources.search_1;
            this.btnSearchResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchResult.ForeColor = System.Drawing.Color.Black;
            this.btnSearchResult.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSearchResult.Location = new System.Drawing.Point(411, 0);
            this.btnSearchResult.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnSearchResult.Name = "btnSearchResult";
            this.btnSearchResult.Size = new System.Drawing.Size(34, 23);
            this.btnSearchResult.TabIndex = 18;
            this.btnSearchResult.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnSearchResult.UseVisualStyleBackColor = false;
            this.btnSearchResult.Click += new System.EventHandler(this.btnSearchResult_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(20, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tìm kiếm tên";
            // 
            // uctSearchKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvListResultCustomer);
            this.Controls.Add(this.cmbFindCustomer);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "uctSearchKhachHang";
            this.Size = new System.Drawing.Size(829, 245);
            this.Load += new System.EventHandler(this.uctSearchKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListResultCustomer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.ComboBox cmbFindCustomer;
        private System.Windows.Forms.DataGridView dtgvListResultCustomer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearchResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongNo;
        private System.Windows.Forms.Label label5;
    }
}
