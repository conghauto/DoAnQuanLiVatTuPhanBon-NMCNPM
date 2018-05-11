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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvListImageProduct = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.txtAmountOfProductCH = new System.Windows.Forms.TextBox();
            this.txtUnitCH = new System.Windows.Forms.TextBox();
            this.txtNameProductCH = new System.Windows.Forms.TextBox();
            this.txtPriceCH = new System.Windows.Forms.TextBox();
            this.txtIDProductCH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbListView = new System.Windows.Forms.ComboBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowseSelectImage = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnDeleteProductStore = new System.Windows.Forms.Button();
            this.btnUpdateProductStore = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvProductListOfStore = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductListOfStore)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvListImageProduct);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 530);
            this.panel1.TabIndex = 0;
            // 
            // lvListImageProduct
            // 
            this.lvListImageProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvListImageProduct.LargeImageList = this.imageList;
            this.lvListImageProduct.Location = new System.Drawing.Point(0, 0);
            this.lvListImageProduct.Name = "lvListImageProduct";
            this.lvListImageProduct.Size = new System.Drawing.Size(560, 530);
            this.lvListImageProduct.SmallImageList = this.imageList;
            this.lvListImageProduct.TabIndex = 0;
            this.lvListImageProduct.UseCompatibleStateImageBehavior = false;
            this.lvListImageProduct.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lvListImageProduct_ItemCheck);
            this.lvListImageProduct.SelectedIndexChanged += new System.EventHandler(this.lvListImageProduct_SelectedIndexChanged);
            this.lvListImageProduct.Click += new System.EventHandler(this.lvListImageProduct_Click);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(64, 64);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // txtAmountOfProductCH
            // 
            this.txtAmountOfProductCH.Location = new System.Drawing.Point(85, 118);
            this.txtAmountOfProductCH.Name = "txtAmountOfProductCH";
            this.txtAmountOfProductCH.Size = new System.Drawing.Size(136, 20);
            this.txtAmountOfProductCH.TabIndex = 16;
            // 
            // txtUnitCH
            // 
            this.txtUnitCH.Location = new System.Drawing.Point(85, 158);
            this.txtUnitCH.Name = "txtUnitCH";
            this.txtUnitCH.Size = new System.Drawing.Size(136, 20);
            this.txtUnitCH.TabIndex = 15;
            // 
            // txtNameProductCH
            // 
            this.txtNameProductCH.Location = new System.Drawing.Point(85, 84);
            this.txtNameProductCH.Name = "txtNameProductCH";
            this.txtNameProductCH.Size = new System.Drawing.Size(136, 20);
            this.txtNameProductCH.TabIndex = 13;
            // 
            // txtPriceCH
            // 
            this.txtPriceCH.Location = new System.Drawing.Point(85, 195);
            this.txtPriceCH.Name = "txtPriceCH";
            this.txtPriceCH.Size = new System.Drawing.Size(136, 20);
            this.txtPriceCH.TabIndex = 14;
            // 
            // txtIDProductCH
            // 
            this.txtIDProductCH.Location = new System.Drawing.Point(85, 47);
            this.txtIDProductCH.Name = "txtIDProductCH";
            this.txtIDProductCH.Size = new System.Drawing.Size(136, 20);
            this.txtIDProductCH.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Đơn vị";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên SP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã SP";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cmbListView);
            this.panel3.Controls.Add(this.pictureBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnBrowseSelectImage);
            this.panel3.Controls.Add(this.btnView);
            this.panel3.Controls.Add(this.btnDeleteProductStore);
            this.panel3.Controls.Add(this.btnUpdateProductStore);
            this.panel3.Controls.Add(this.txtAmountOfProductCH);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtUnitCH);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtNameProductCH);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtPriceCH);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtIDProductCH);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(682, 242);
            this.panel3.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(278, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
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
            this.cmbListView.Location = new System.Drawing.Point(348, 194);
            this.cmbListView.Name = "cmbListView";
            this.cmbListView.Size = new System.Drawing.Size(130, 21);
            this.cmbListView.TabIndex = 23;
            this.cmbListView.SelectedIndexChanged += new System.EventHandler(this.cmbListView_SelectedIndexChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.ErrorImage")));
            this.pictureBox.Location = new System.Drawing.Point(497, 47);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(106, 131);
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
            this.label3.Size = new System.Drawing.Size(199, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "SẢN PHẨM TRONG CỬA HÀNG";
            // 
            // btnBrowseSelectImage
            // 
            this.btnBrowseSelectImage.Location = new System.Drawing.Point(497, 195);
            this.btnBrowseSelectImage.Name = "btnBrowseSelectImage";
            this.btnBrowseSelectImage.Size = new System.Drawing.Size(106, 23);
            this.btnBrowseSelectImage.TabIndex = 17;
            this.btnBrowseSelectImage.Text = "Browse";
            this.btnBrowseSelectImage.UseVisualStyleBackColor = true;
            this.btnBrowseSelectImage.Click += new System.EventHandler(this.btnBrowseSelectImage_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(270, 148);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(89, 30);
            this.btnView.TabIndex = 17;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnDeleteProductStore
            // 
            this.btnDeleteProductStore.Location = new System.Drawing.Point(270, 104);
            this.btnDeleteProductStore.Name = "btnDeleteProductStore";
            this.btnDeleteProductStore.Size = new System.Drawing.Size(89, 30);
            this.btnDeleteProductStore.TabIndex = 17;
            this.btnDeleteProductStore.Text = "Xóa";
            this.btnDeleteProductStore.UseVisualStyleBackColor = true;
            // 
            // btnUpdateProductStore
            // 
            this.btnUpdateProductStore.Location = new System.Drawing.Point(270, 47);
            this.btnUpdateProductStore.Name = "btnUpdateProductStore";
            this.btnUpdateProductStore.Size = new System.Drawing.Size(89, 30);
            this.btnUpdateProductStore.TabIndex = 17;
            this.btnUpdateProductStore.Text = "Cập nhật";
            this.btnUpdateProductStore.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Location = new System.Drawing.Point(569, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(688, 261);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // dtgvProductListOfStore
            // 
            this.dtgvProductListOfStore.AllowUserToAddRows = false;
            this.dtgvProductListOfStore.AllowUserToDeleteRows = false;
            this.dtgvProductListOfStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProductListOfStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvProductListOfStore.Location = new System.Drawing.Point(3, 21);
            this.dtgvProductListOfStore.Name = "dtgvProductListOfStore";
            this.dtgvProductListOfStore.ReadOnly = true;
            this.dtgvProductListOfStore.Size = new System.Drawing.Size(679, 236);
            this.dtgvProductListOfStore.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvProductListOfStore);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(572, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 260);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm trong Cửa hàng";
            // 
            // uctSanPhamCH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Name = "uctSanPhamCH";
            this.Size = new System.Drawing.Size(1298, 559);
            this.Load += new System.EventHandler(this.uctSanPhamCH_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductListOfStore)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvListImageProduct;
        private System.Windows.Forms.TextBox txtAmountOfProductCH;
        private System.Windows.Forms.TextBox txtUnitCH;
        private System.Windows.Forms.TextBox txtNameProductCH;
        private System.Windows.Forms.TextBox txtPriceCH;
        private System.Windows.Forms.TextBox txtIDProductCH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDeleteProductStore;
        private System.Windows.Forms.Button btnUpdateProductStore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button btnBrowseSelectImage;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridView dtgvProductListOfStore;
        private System.Windows.Forms.ComboBox cmbListView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
