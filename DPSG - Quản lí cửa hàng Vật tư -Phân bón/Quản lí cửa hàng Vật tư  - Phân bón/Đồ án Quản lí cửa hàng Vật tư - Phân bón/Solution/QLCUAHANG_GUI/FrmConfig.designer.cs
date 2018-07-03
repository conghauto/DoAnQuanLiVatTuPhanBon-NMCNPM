namespace QLCUAHANG_GUI
{
    partial class FrmConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfig));
            this.foderPath = new System.Windows.Forms.FolderBrowserDialog();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabServer = new System.Windows.Forms.TabPage();
            this.btnConnect = new DevComponents.DotNetBar.ButtonX();
            this.btnAttach = new DevComponents.DotNetBar.ButtonX();
            this.btnBrowser = new DevComponents.DotNetBar.ButtonX();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.cbDatabase = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbServer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.tabServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabServer);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(477, 225);
            this.tabMain.TabIndex = 0;
            // 
            // tabServer
            // 
            this.tabServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tabServer.Controls.Add(this.btnConnect);
            this.tabServer.Controls.Add(this.btnAttach);
            this.tabServer.Controls.Add(this.btnBrowser);
            this.tabServer.Controls.Add(this.txtPath);
            this.tabServer.Controls.Add(this.label4);
            this.tabServer.Controls.Add(this.btnCancel);
            this.tabServer.Controls.Add(this.btnSave);
            this.tabServer.Controls.Add(this.cbDatabase);
            this.tabServer.Controls.Add(this.label3);
            this.tabServer.Controls.Add(this.cbServer);
            this.tabServer.Controls.Add(this.label2);
            this.tabServer.Location = new System.Drawing.Point(4, 22);
            this.tabServer.Name = "tabServer";
            this.tabServer.Padding = new System.Windows.Forms.Padding(3);
            this.tabServer.Size = new System.Drawing.Size(469, 199);
            this.tabServer.TabIndex = 0;
            this.tabServer.Text = "Server";
            this.tabServer.Click += new System.EventHandler(this.tabServer_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnConnect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnConnect.Location = new System.Drawing.Point(73, 164);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Kết nối";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnAttach
            // 
            this.btnAttach.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAttach.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAttach.Location = new System.Drawing.Point(154, 164);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(75, 23);
            this.btnAttach.TabIndex = 4;
            this.btnAttach.Text = "Tạo DB";
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // btnBrowser
            // 
            this.btnBrowser.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBrowser.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBrowser.Location = new System.Drawing.Point(349, 36);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(62, 23);
            this.btnBrowser.TabIndex = 28;
            this.btnBrowser.Text = "Browser";
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(139, 37);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(204, 20);
            this.txtPath.TabIndex = 0;
            this.txtPath.Text = "Đường dẫn lưu cơ sở dữ liệu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Lưu trữ dữ liệu";
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Location = new System.Drawing.Point(320, 164);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Đóng";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(237, 164);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbDatabase
            // 
            this.cbDatabase.FormattingEnabled = true;
            this.cbDatabase.Location = new System.Drawing.Point(139, 102);
            this.cbDatabase.Name = "cbDatabase";
            this.cbDatabase.Size = new System.Drawing.Size(272, 21);
            this.cbDatabase.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Database";
            // 
            // cbServer
            // 
            this.cbServer.FormattingEnabled = true;
            this.cbServer.Location = new System.Drawing.Point(139, 69);
            this.cbServer.Name = "cbServer";
            this.cbServer.Size = new System.Drawing.Size(272, 21);
            this.cbServer.TabIndex = 1;
            this.cbServer.SelectedIndexChanged += new System.EventHandler(this.cbServer_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Server";
            // 
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 225);
            this.Controls.Add(this.tabMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(493, 264);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(493, 264);
            this.Name = "FrmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấu hình hệ thống";
            this.tabMain.ResumeLayout(false);
            this.tabServer.ResumeLayout(false);
            this.tabServer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog foderPath;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabServer;
        private DevComponents.DotNetBar.ButtonX btnAttach;
        private DevComponents.DotNetBar.ButtonX btnBrowser;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private System.Windows.Forms.ComboBox cbDatabase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbServer;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.ButtonX btnConnect;
    }
}