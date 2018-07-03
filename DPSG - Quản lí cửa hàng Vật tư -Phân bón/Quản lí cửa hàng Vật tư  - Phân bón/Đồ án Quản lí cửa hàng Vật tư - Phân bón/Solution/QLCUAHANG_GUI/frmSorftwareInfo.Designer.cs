namespace QLCUAHANG_GUI
{
    partial class frmSorftwareInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSorftwareInfo));
            this.txtSorftwareInfo = new System.Windows.Forms.TextBox();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiDescribe = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSorftwareInfo
            // 
            this.txtSorftwareInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSorftwareInfo.Enabled = false;
            this.txtSorftwareInfo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSorftwareInfo.ForeColor = System.Drawing.Color.Black;
            this.txtSorftwareInfo.Location = new System.Drawing.Point(266, 12);
            this.txtSorftwareInfo.Multiline = true;
            this.txtSorftwareInfo.Name = "txtSorftwareInfo";
            this.txtSorftwareInfo.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtSorftwareInfo.Size = new System.Drawing.Size(576, 316);
            this.txtSorftwareInfo.TabIndex = 0;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.BackColor = System.Drawing.Color.Red;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nbiDescribe,
            this.navBarItem2,
            this.navBarItem1,
            this.navBarItem3,
            this.navBarItem4});
            this.navBarControl1.Location = new System.Drawing.Point(12, 12);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 248;
            this.navBarControl1.Size = new System.Drawing.Size(248, 316);
            this.navBarControl1.TabIndex = 1;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Quản lí cửa hàng Vật tư - Phân bón";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiDescribe),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem3),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem4)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // nbiDescribe
            // 
            this.nbiDescribe.Caption = "Mô tả";
            this.nbiDescribe.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbiDescribe.ImageOptions.LargeImage")));
            this.nbiDescribe.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiDescribe.ImageOptions.SmallImage")));
            this.nbiDescribe.Name = "nbiDescribe";
            this.nbiDescribe.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiDescribe_LinkClicked);
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "Cấu trúc phần mềm";
            this.navBarItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem2.ImageOptions.LargeImage")));
            this.navBarItem2.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem2.ImageOptions.SmallImage")));
            this.navBarItem2.Name = "navBarItem2";
            this.navBarItem2.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem2_LinkClicked);
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "Công nghệ";
            this.navBarItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem1.ImageOptions.LargeImage")));
            this.navBarItem1.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem1.ImageOptions.SmallImage")));
            this.navBarItem1.Name = "navBarItem1";
            this.navBarItem1.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem1_LinkClicked);
            // 
            // navBarItem3
            // 
            this.navBarItem3.Caption = "Môi trường cài đặt";
            this.navBarItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem3.ImageOptions.LargeImage")));
            this.navBarItem3.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem3.ImageOptions.SmallImage")));
            this.navBarItem3.Name = "navBarItem3";
            this.navBarItem3.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem3_LinkClicked);
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "Cài đặt phần mềm";
            this.navBarItem4.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem4.ImageOptions.SmallImage")));
            this.navBarItem4.Name = "navBarItem4";
            this.navBarItem4.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem4_LinkClicked);
            // 
            // frmSorftwareInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(867, 366);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.txtSorftwareInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSorftwareInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin phần mềm";
            this.Load += new System.EventHandler(this.frmSorftwareInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSorftwareInfo;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem nbiDescribe;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
    }
}