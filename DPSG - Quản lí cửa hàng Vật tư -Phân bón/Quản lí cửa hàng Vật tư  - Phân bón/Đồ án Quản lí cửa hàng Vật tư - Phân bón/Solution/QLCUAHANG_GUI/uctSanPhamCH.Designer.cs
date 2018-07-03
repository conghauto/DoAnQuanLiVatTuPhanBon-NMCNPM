namespace QLCUAHANG_GUI
{
    partial class uctSanPhamCH
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctSanPhamCH));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvProductListOfStore = new System.Windows.Forms.DataGridView();
            this.MaSPCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThongSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BanLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvListImageProduct = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtUnitProduct = new System.Windows.Forms.TextBox();
            this.cbRetail = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAmonutRetail = new System.Windows.Forms.TextBox();
            this.rbMl = new System.Windows.Forms.RadioButton();
            this.rbKg = new System.Windows.Forms.RadioButton();
            this.txtUnitCH = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbListView = new System.Windows.Forms.ComboBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowseSelectImage = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnDeleteProductStore = new System.Windows.Forms.Button();
            this.btnUpdateProductStore = new System.Windows.Forms.Button();
            this.txtAmountOfProductCH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameProductCH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtParameter = new System.Windows.Forms.TextBox();
            this.txtPriceCH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDProductCH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductListOfStore)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.dtgvProductListOfStore);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1297, 260);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm trong Cửa hàng";
            // 
            // dtgvProductListOfStore
            // 
            this.dtgvProductListOfStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProductListOfStore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSPCH,
            this.TenSP,
            this.Gia,
            this.DonVi,
            this.SoLuong,
            this.HinhAnh,
            this.ThongSo,
            this.BanLe,
            this.SoLuongLe});
            this.dtgvProductListOfStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvProductListOfStore.Location = new System.Drawing.Point(3, 21);
            this.dtgvProductListOfStore.Name = "dtgvProductListOfStore";
            this.dtgvProductListOfStore.Size = new System.Drawing.Size(1291, 236);
            this.dtgvProductListOfStore.TabIndex = 0;
            // 
            // MaSPCH
            // 
            this.MaSPCH.DataPropertyName = "MaSPCH";
            this.MaSPCH.HeaderText = "Mã SPCH";
            this.MaSPCH.Name = "MaSPCH";
            this.MaSPCH.Width = 120;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.Name = "TenSP";
            this.TenSP.Width = 210;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.Name = "Gia";
            this.Gia.Width = 110;
            // 
            // DonVi
            // 
            this.DonVi.DataPropertyName = "DonVi";
            this.DonVi.HeaderText = "Đơn vị";
            this.DonVi.Name = "DonVi";
            this.DonVi.Width = 110;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 110;
            // 
            // HinhAnh
            // 
            this.HinhAnh.DataPropertyName = "HinhAnh";
            this.HinhAnh.HeaderText = "Hình ảnh";
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.Width = 95;
            // 
            // ThongSo
            // 
            this.ThongSo.DataPropertyName = "ThongSo";
            this.ThongSo.HeaderText = "Thông số ( kg / ml )";
            this.ThongSo.Name = "ThongSo";
            this.ThongSo.Width = 180;
            // 
            // BanLe
            // 
            this.BanLe.DataPropertyName = "BanLe";
            this.BanLe.HeaderText = "Sản phẩm bán lẻ";
            this.BanLe.Name = "BanLe";
            this.BanLe.Width = 150;
            // 
            // SoLuongLe
            // 
            this.SoLuongLe.DataPropertyName = "SoLuongLe";
            this.SoLuongLe.HeaderText = "Số lượng bán lẻ (kg)";
            this.SoLuongLe.Name = "SoLuongLe";
            this.SoLuongLe.Width = 155;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvListImageProduct);
            this.panel1.Location = new System.Drawing.Point(11, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 261);
            this.panel1.TabIndex = 5;
            // 
            // lvListImageProduct
            // 
            this.lvListImageProduct.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lvListImageProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvListImageProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvListImageProduct.LargeImageList = this.imageList;
            this.lvListImageProduct.Location = new System.Drawing.Point(0, 0);
            this.lvListImageProduct.Name = "lvListImageProduct";
            this.lvListImageProduct.Size = new System.Drawing.Size(563, 261);
            this.lvListImageProduct.SmallImageList = this.imageList;
            this.lvListImageProduct.TabIndex = 1;
            this.lvListImageProduct.UseCompatibleStateImageBehavior = false;
            this.lvListImageProduct.View = System.Windows.Forms.View.Tile;
            this.lvListImageProduct.Click += new System.EventHandler(this.lvListImageProduct_Click);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(32, 32);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Location = new System.Drawing.Point(583, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(728, 278);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.rbMl);
            this.panel3.Controls.Add(this.rbKg);
            this.panel3.Controls.Add(this.txtUnitCH);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cmbListView);
            this.panel3.Controls.Add(this.pictureBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnBrowseSelectImage);
            this.panel3.Controls.Add(this.btnLoad);
            this.panel3.Controls.Add(this.btnDeleteProductStore);
            this.panel3.Controls.Add(this.btnUpdateProductStore);
            this.panel3.Controls.Add(this.txtAmountOfProductCH);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtNameProductCH);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtParameter);
            this.panel3.Controls.Add(this.txtPriceCH);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtIDProductCH);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(722, 259);
            this.panel3.TabIndex = 17;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtUnitProduct);
            this.groupBox3.Controls.Add(this.cbRetail);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtAmonutRetail);
            this.groupBox3.Location = new System.Drawing.Point(270, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(179, 96);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // txtUnitProduct
            // 
            this.txtUnitProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitProduct.Location = new System.Drawing.Point(123, 72);
            this.txtUnitProduct.Name = "txtUnitProduct";
            this.txtUnitProduct.Size = new System.Drawing.Size(33, 20);
            this.txtUnitProduct.TabIndex = 12;
            this.txtUnitProduct.Text = "kg";
            // 
            // cbRetail
            // 
            this.cbRetail.AutoSize = true;
            this.cbRetail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRetail.Location = new System.Drawing.Point(9, 13);
            this.cbRetail.Name = "cbRetail";
            this.cbRetail.Size = new System.Drawing.Size(132, 23);
            this.cbRetail.TabIndex = 1;
            this.cbRetail.Text = "Sản  phẩm bán lẻ";
            this.cbRetail.UseVisualStyleBackColor = true;
            this.cbRetail.CheckedChanged += new System.EventHandler(this.cbRetail_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 19);
            this.label9.TabIndex = 11;
            this.label9.Text = "Số lượng bán lẻ";
            // 
            // txtAmonutRetail
            // 
            this.txtAmonutRetail.Location = new System.Drawing.Point(123, 42);
            this.txtAmonutRetail.Name = "txtAmonutRetail";
            this.txtAmonutRetail.Size = new System.Drawing.Size(50, 20);
            this.txtAmonutRetail.TabIndex = 13;
            this.txtAmonutRetail.Click += new System.EventHandler(this.txtAmonutRetail_Click);
            this.txtAmonutRetail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmonutRetail_KeyPress);
            // 
            // rbMl
            // 
            this.rbMl.AutoSize = true;
            this.rbMl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMl.Location = new System.Drawing.Point(214, 208);
            this.rbMl.Name = "rbMl";
            this.rbMl.Size = new System.Drawing.Size(37, 17);
            this.rbMl.TabIndex = 27;
            this.rbMl.TabStop = true;
            this.rbMl.Text = "ml";
            this.rbMl.UseVisualStyleBackColor = true;
            // 
            // rbKg
            // 
            this.rbKg.AutoSize = true;
            this.rbKg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKg.Location = new System.Drawing.Point(170, 208);
            this.rbKg.Name = "rbKg";
            this.rbKg.Size = new System.Drawing.Size(39, 17);
            this.rbKg.TabIndex = 26;
            this.rbKg.TabStop = true;
            this.rbKg.Text = "kg";
            this.rbKg.UseVisualStyleBackColor = true;
            // 
            // txtUnitCH
            // 
            this.txtUnitCH.FormattingEnabled = true;
            this.txtUnitCH.Items.AddRange(new object[] {
            "bao",
            "bịch",
            "chai",
            "thùng"});
            this.txtUnitCH.Location = new System.Drawing.Point(124, 144);
            this.txtUnitCH.Name = "txtUnitCH";
            this.txtUnitCH.Size = new System.Drawing.Size(125, 21);
            this.txtUnitCH.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(275, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 19);
            this.label7.TabIndex = 24;
            this.label7.Text = "Chế độ xem";
            // 
            // cmbListView
            // 
            this.cmbListView.FormattingEnabled = true;
            this.cmbListView.Items.AddRange(new object[] {
            "LargeIcon",
            "Details",
            "SmallIcon",
            "List",
            "Title"});
            this.cmbListView.Location = new System.Drawing.Point(364, 204);
            this.cmbListView.Name = "cmbListView";
            this.cmbListView.Size = new System.Drawing.Size(111, 21);
            this.cmbListView.TabIndex = 23;
            this.cmbListView.SelectedIndexChanged += new System.EventHandler(this.cmbListView_SelectedIndexChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.ErrorImage")));
            this.pictureBox.Location = new System.Drawing.Point(566, 40);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(142, 142);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 22;
            this.pictureBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(240, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "QUẢN LÍ SẢN PHẨM TRONG CỬA HÀNG";
            // 
            // btnBrowseSelectImage
            // 
            this.btnBrowseSelectImage.Location = new System.Drawing.Point(566, 200);
            this.btnBrowseSelectImage.Name = "btnBrowseSelectImage";
            this.btnBrowseSelectImage.Size = new System.Drawing.Size(142, 23);
            this.btnBrowseSelectImage.TabIndex = 17;
            this.btnBrowseSelectImage.Text = "Browse";
            this.btnBrowseSelectImage.UseVisualStyleBackColor = true;
            this.btnBrowseSelectImage.Click += new System.EventHandler(this.btnBrowseSelectImage_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(455, 152);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(89, 30);
            this.btnLoad.TabIndex = 17;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnDeleteProductStore
            // 
            this.btnDeleteProductStore.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProductStore.Location = new System.Drawing.Point(455, 100);
            this.btnDeleteProductStore.Name = "btnDeleteProductStore";
            this.btnDeleteProductStore.Size = new System.Drawing.Size(89, 30);
            this.btnDeleteProductStore.TabIndex = 17;
            this.btnDeleteProductStore.Text = "Xóa";
            this.btnDeleteProductStore.UseVisualStyleBackColor = true;
            // 
            // btnUpdateProductStore
            // 
            this.btnUpdateProductStore.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProductStore.Location = new System.Drawing.Point(455, 43);
            this.btnUpdateProductStore.Name = "btnUpdateProductStore";
            this.btnUpdateProductStore.Size = new System.Drawing.Size(89, 30);
            this.btnUpdateProductStore.TabIndex = 17;
            this.btnUpdateProductStore.Text = "Cập nhật";
            this.btnUpdateProductStore.UseVisualStyleBackColor = true;
            // 
            // txtAmountOfProductCH
            // 
            this.txtAmountOfProductCH.Location = new System.Drawing.Point(124, 110);
            this.txtAmountOfProductCH.Name = "txtAmountOfProductCH";
            this.txtAmountOfProductCH.Size = new System.Drawing.Size(125, 20);
            this.txtAmountOfProductCH.TabIndex = 16;
            this.txtAmountOfProductCH.Click += new System.EventHandler(this.txtAmountOfProductCH_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã SP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên SP";
            // 
            // txtNameProductCH
            // 
            this.txtNameProductCH.Location = new System.Drawing.Point(124, 77);
            this.txtNameProductCH.Name = "txtNameProductCH";
            this.txtNameProductCH.Size = new System.Drawing.Size(125, 20);
            this.txtNameProductCH.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Thông số";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Giá /Sản phẩm";
            // 
            // txtParameter
            // 
            this.txtParameter.Location = new System.Drawing.Point(124, 205);
            this.txtParameter.Name = "txtParameter";
            this.txtParameter.Size = new System.Drawing.Size(40, 20);
            this.txtParameter.TabIndex = 14;
            this.txtParameter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParameter_KeyPress);
            // 
            // txtPriceCH
            // 
            this.txtPriceCH.Location = new System.Drawing.Point(124, 176);
            this.txtPriceCH.Name = "txtPriceCH";
            this.txtPriceCH.Size = new System.Drawing.Size(125, 20);
            this.txtPriceCH.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Đơn vị";
            // 
            // txtIDProductCH
            // 
            this.txtIDProductCH.Location = new System.Drawing.Point(124, 47);
            this.txtIDProductCH.Name = "txtIDProductCH";
            this.txtIDProductCH.Size = new System.Drawing.Size(125, 20);
            this.txtIDProductCH.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Số lượng";
            // 
            // uctSanPhamCH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "uctSanPhamCH";
            this.Size = new System.Drawing.Size(1319, 559);
            this.Load += new System.EventHandler(this.uctSanPhamCH_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductListOfStore)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvProductListOfStore;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSPCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn HinhAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThongSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BanLe;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongLe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvListImageProduct;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtUnitProduct;
        private System.Windows.Forms.CheckBox cbRetail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAmonutRetail;
        private System.Windows.Forms.RadioButton rbMl;
        private System.Windows.Forms.RadioButton rbKg;
        private System.Windows.Forms.ComboBox txtUnitCH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbListView;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowseSelectImage;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnDeleteProductStore;
        private System.Windows.Forms.Button btnUpdateProductStore;
        private System.Windows.Forms.TextBox txtAmountOfProductCH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameProductCH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtParameter;
        private System.Windows.Forms.TextBox txtPriceCH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDProductCH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ImageList imageList;
    }
}
