namespace QLCUAHANG_GUI
{
    partial class uctDaiLi
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
            this.label9 = new System.Windows.Forms.Label();
            this.grbListAgency = new System.Windows.Forms.GroupBox();
            this.dtgvAgencyInfoList = new System.Windows.Forms.DataGridView();
            this.MaDL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbAgency = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNumberPhone = new System.Windows.Forms.TextBox();
            this.txtAddressOfAgency = new System.Windows.Forms.TextBox();
            this.txtNameAgency = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDAgency = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbIDAgency = new System.Windows.Forms.Label();
            this.btnDeleteAgency = new System.Windows.Forms.Button();
            this.btnUpdateAgency = new System.Windows.Forms.Button();
            this.btnAddAgency = new System.Windows.Forms.Button();
            this.grbListAgency.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAgencyInfoList)).BeginInit();
            this.grbAgency.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(867, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "DANH SÁCH  ĐẠI LÍ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(168, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "THÔNG TIN ĐẠI LÍ";
            // 
            // grbListAgency
            // 
            this.grbListAgency.Controls.Add(this.dtgvAgencyInfoList);
            this.grbListAgency.Location = new System.Drawing.Point(582, 82);
            this.grbListAgency.Name = "grbListAgency";
            this.grbListAgency.Size = new System.Drawing.Size(699, 260);
            this.grbListAgency.TabIndex = 15;
            this.grbListAgency.TabStop = false;
            // 
            // dtgvAgencyInfoList
            // 
            this.dtgvAgencyInfoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAgencyInfoList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDL,
            this.TenDL,
            this.DiaChi,
            this.SoDT});
            this.dtgvAgencyInfoList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvAgencyInfoList.Location = new System.Drawing.Point(3, 16);
            this.dtgvAgencyInfoList.Name = "dtgvAgencyInfoList";
            this.dtgvAgencyInfoList.ReadOnly = true;
            this.dtgvAgencyInfoList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvAgencyInfoList.Size = new System.Drawing.Size(693, 241);
            this.dtgvAgencyInfoList.TabIndex = 9;
            // 
            // MaDL
            // 
            this.MaDL.DataPropertyName = "MaDL";
            this.MaDL.HeaderText = "Mã đại lí";
            this.MaDL.Name = "MaDL";
            this.MaDL.ReadOnly = true;
            // 
            // TenDL
            // 
            this.TenDL.DataPropertyName = "TenDL";
            this.TenDL.HeaderText = "Tên đại lí";
            this.TenDL.Name = "TenDL";
            this.TenDL.ReadOnly = true;
            this.TenDL.Width = 150;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Width = 170;
            // 
            // SoDT
            // 
            this.SoDT.DataPropertyName = "SoDT";
            this.SoDT.HeaderText = "Số điện thoại";
            this.SoDT.Name = "SoDT";
            this.SoDT.ReadOnly = true;
            this.SoDT.Width = 160;
            // 
            // grbAgency
            // 
            this.grbAgency.Controls.Add(this.panel2);
            this.grbAgency.Location = new System.Drawing.Point(19, 82);
            this.grbAgency.Name = "grbAgency";
            this.grbAgency.Size = new System.Drawing.Size(536, 260);
            this.grbAgency.TabIndex = 14;
            this.grbAgency.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtNumberPhone);
            this.panel2.Controls.Add(this.txtAddressOfAgency);
            this.panel2.Controls.Add(this.txtNameAgency);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtIDAgency);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbIDAgency);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 241);
            this.panel2.TabIndex = 2;
            // 
            // txtNumberPhone
            // 
            this.txtNumberPhone.Location = new System.Drawing.Point(152, 141);
            this.txtNumberPhone.Name = "txtNumberPhone";
            this.txtNumberPhone.Size = new System.Drawing.Size(145, 20);
            this.txtNumberPhone.TabIndex = 2;
            // 
            // txtAddressOfAgency
            // 
            this.txtAddressOfAgency.Location = new System.Drawing.Point(152, 105);
            this.txtAddressOfAgency.Name = "txtAddressOfAgency";
            this.txtAddressOfAgency.Size = new System.Drawing.Size(145, 20);
            this.txtAddressOfAgency.TabIndex = 2;
            // 
            // txtNameAgency
            // 
            this.txtNameAgency.Location = new System.Drawing.Point(152, 65);
            this.txtNameAgency.Name = "txtNameAgency";
            this.txtNameAgency.Size = new System.Drawing.Size(144, 20);
            this.txtNameAgency.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số điện thoại";
            // 
            // txtIDAgency
            // 
            this.txtIDAgency.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtIDAgency.Location = new System.Drawing.Point(152, 26);
            this.txtIDAgency.Name = "txtIDAgency";
            this.txtIDAgency.ReadOnly = true;
            this.txtIDAgency.Size = new System.Drawing.Size(144, 20);
            this.txtIDAgency.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên đại lí";
            // 
            // lbIDAgency
            // 
            this.lbIDAgency.AutoSize = true;
            this.lbIDAgency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDAgency.Location = new System.Drawing.Point(22, 26);
            this.lbIDAgency.Name = "lbIDAgency";
            this.lbIDAgency.Size = new System.Drawing.Size(58, 16);
            this.lbIDAgency.TabIndex = 0;
            this.lbIDAgency.Text = "Mã đại lí";
            // 
            // btnDeleteAgency
            // 
            this.btnDeleteAgency.Location = new System.Drawing.Point(328, 367);
            this.btnDeleteAgency.Name = "btnDeleteAgency";
            this.btnDeleteAgency.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAgency.TabIndex = 16;
            this.btnDeleteAgency.Text = "Xóa";
            this.btnDeleteAgency.UseVisualStyleBackColor = true;
            // 
            // btnUpdateAgency
            // 
            this.btnUpdateAgency.Location = new System.Drawing.Point(212, 367);
            this.btnUpdateAgency.Name = "btnUpdateAgency";
            this.btnUpdateAgency.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateAgency.TabIndex = 17;
            this.btnUpdateAgency.Text = "Cập nhật";
            this.btnUpdateAgency.UseVisualStyleBackColor = true;
            // 
            // btnAddAgency
            // 
            this.btnAddAgency.Location = new System.Drawing.Point(104, 367);
            this.btnAddAgency.Name = "btnAddAgency";
            this.btnAddAgency.Size = new System.Drawing.Size(75, 23);
            this.btnAddAgency.TabIndex = 18;
            this.btnAddAgency.Text = "Thêm";
            this.btnAddAgency.UseVisualStyleBackColor = true;
            // 
            // uctDaiLi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnDeleteAgency);
            this.Controls.Add(this.btnUpdateAgency);
            this.Controls.Add(this.btnAddAgency);
            this.Controls.Add(this.grbListAgency);
            this.Controls.Add(this.grbAgency);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Name = "uctDaiLi";
            this.Size = new System.Drawing.Size(1284, 525);
            this.Load += new System.EventHandler(this.uctDaiLi_Load);
            this.grbListAgency.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAgencyInfoList)).EndInit();
            this.grbAgency.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grbListAgency;
        private System.Windows.Forms.GroupBox grbAgency;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNumberPhone;
        private System.Windows.Forms.TextBox txtAddressOfAgency;
        private System.Windows.Forms.TextBox txtNameAgency;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDAgency;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbIDAgency;
        private System.Windows.Forms.Button btnDeleteAgency;
        private System.Windows.Forms.Button btnUpdateAgency;
        private System.Windows.Forms.Button btnAddAgency;
        private System.Windows.Forms.DataGridView dtgvAgencyInfoList;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT;
    }
}
