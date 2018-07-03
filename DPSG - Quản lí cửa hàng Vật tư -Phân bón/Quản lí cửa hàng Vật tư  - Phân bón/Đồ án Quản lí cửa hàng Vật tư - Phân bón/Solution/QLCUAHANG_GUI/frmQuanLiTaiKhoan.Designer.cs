namespace QLCUAHANG_GUI
{
    partial class frmQuanLiTaiKhoan
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkClear = new System.Windows.Forms.LinkLabel();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.txtPosition = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtNumberPhone = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvListUser = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.linkClear);
            this.panel2.Controls.Add(this.btnUpdateUser);
            this.panel2.Controls.Add(this.btnDeleteUser);
            this.panel2.Controls.Add(this.txtPosition);
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.txtNumberPhone);
            this.panel2.Controls.Add(this.txtUser);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(711, 119);
            this.panel2.TabIndex = 0;
            // 
            // linkClear
            // 
            this.linkClear.AutoSize = true;
            this.linkClear.Location = new System.Drawing.Point(570, 83);
            this.linkClear.Name = "linkClear";
            this.linkClear.Size = new System.Drawing.Size(31, 13);
            this.linkClear.TabIndex = 4;
            this.linkClear.TabStop = true;
            this.linkClear.Text = "Clear";
            this.linkClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkClear_LinkClicked);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(607, 78);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateUser.TabIndex = 3;
            this.btnUpdateUser.Text = "Sửa";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(607, 32);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteUser.TabIndex = 3;
            this.btnDeleteUser.Text = "Xóa";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // txtPosition
            // 
            this.txtPosition.FormattingEnabled = true;
            this.txtPosition.Items.AddRange(new object[] {
            "Admin",
            "Nhân viên"});
            this.txtPosition.Location = new System.Drawing.Point(137, 74);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(121, 21);
            this.txtPosition.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(418, 32);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(121, 20);
            this.txtAddress.TabIndex = 1;
            // 
            // txtNumberPhone
            // 
            this.txtNumberPhone.Location = new System.Drawing.Point(418, 75);
            this.txtNumberPhone.Name = "txtNumberPhone";
            this.txtNumberPhone.Size = new System.Drawing.Size(121, 20);
            this.txtNumberPhone.TabIndex = 1;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(137, 32);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(121, 20);
            this.txtUser.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(333, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(333, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chức vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvListUser);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 213);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dtgvListUser
            // 
            this.dtgvListUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.UserName,
            this.ChucVu,
            this.DiaChi,
            this.SoDT});
            this.dtgvListUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvListUser.Location = new System.Drawing.Point(3, 22);
            this.dtgvListUser.Name = "dtgvListUser";
            this.dtgvListUser.ReadOnly = true;
            this.dtgvListUser.Size = new System.Drawing.Size(705, 188);
            this.dtgvListUser.TabIndex = 2;
            this.dtgvListUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListUser_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "Tên đăng nhập";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 140;
            // 
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "ChucVu";
            this.ChucVu.HeaderText = "Chức vụ";
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.ReadOnly = true;
            this.ChucVu.Width = 150;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Width = 190;
            // 
            // SoDT
            // 
            this.SoDT.DataPropertyName = "SoDT";
            this.SoDT.HeaderText = "Số điện thoại";
            this.SoDT.Name = "SoDT";
            this.SoDT.ReadOnly = true;
            this.SoDT.Width = 120;
            // 
            // frmQuanLiTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 358);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuanLiTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí tài khoản";
            this.Load += new System.EventHandler(this.frmQuanLiTaiKhoan_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.ComboBox txtPosition;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtNumberPhone;
        private System.Windows.Forms.LinkLabel linkClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvListUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT;
    }
}