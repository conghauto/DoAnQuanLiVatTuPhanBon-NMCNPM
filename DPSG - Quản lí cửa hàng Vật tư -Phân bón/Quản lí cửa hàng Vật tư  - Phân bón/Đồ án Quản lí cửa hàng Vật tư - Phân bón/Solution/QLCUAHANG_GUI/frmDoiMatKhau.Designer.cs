namespace QLCUAHANG_GUI
{
    partial class frmDoiMatKhau
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtOldPass = new DevExpress.XtraEditors.TextEdit();
            this.txtNewPass = new DevExpress.XtraEditors.TextEdit();
            this.txtRegisPass = new DevExpress.XtraEditors.TextEdit();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.lbOld = new DevExpress.XtraEditors.LabelControl();
            this.lbCheck = new DevExpress.XtraEditors.LabelControl();
            this.lbNew = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegisPass.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(33, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Mật khẩu cũ:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(33, 94);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Mật khẩu mới: ";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(33, 151);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(108, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Nhập lại mật khẩu mới:";
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(155, 38);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Properties.PasswordChar = '*';
            this.txtOldPass.Size = new System.Drawing.Size(166, 20);
            this.txtOldPass.TabIndex = 1;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(155, 91);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Properties.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(166, 20);
            this.txtNewPass.TabIndex = 2;
            this.txtNewPass.TabStop = false;
            this.txtNewPass.TextChanged += new System.EventHandler(this.txtNewPass_TextChanged);
            // 
            // txtRegisPass
            // 
            this.txtRegisPass.Location = new System.Drawing.Point(155, 148);
            this.txtRegisPass.Name = "txtRegisPass";
            this.txtRegisPass.Properties.PasswordChar = '*';
            this.txtRegisPass.Size = new System.Drawing.Size(166, 20);
            this.txtRegisPass.TabIndex = 3;
            this.txtRegisPass.TabStop = false;
            this.txtRegisPass.TextChanged += new System.EventHandler(this.txtRegisPass_TextChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(155, 203);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(63, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Location = new System.Drawing.Point(261, 203);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(60, 23);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lbOld
            // 
            this.lbOld.Location = new System.Drawing.Point(155, 65);
            this.lbOld.Name = "lbOld";
            this.lbOld.Size = new System.Drawing.Size(0, 13);
            this.lbOld.TabIndex = 3;
            // 
            // lbCheck
            // 
            this.lbCheck.Location = new System.Drawing.Point(155, 117);
            this.lbCheck.Name = "lbCheck";
            this.lbCheck.Size = new System.Drawing.Size(0, 13);
            this.lbCheck.TabIndex = 4;
            // 
            // lbNew
            // 
            this.lbNew.Location = new System.Drawing.Point(155, 174);
            this.lbNew.Name = "lbNew";
            this.lbNew.Size = new System.Drawing.Size(0, 13);
            this.lbNew.TabIndex = 5;
            // 
            // frmDoiMatKhau
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnHuy;
            this.ClientSize = new System.Drawing.Size(377, 235);
            this.Controls.Add(this.lbNew);
            this.Controls.Add(this.lbCheck);
            this.Controls.Add(this.lbOld);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtRegisPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtOldPass);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.MinimizeBox = false;
            this.Name = "frmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegisPass.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtOldPass;
        private DevExpress.XtraEditors.TextEdit txtNewPass;
        private DevExpress.XtraEditors.TextEdit txtRegisPass;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.LabelControl lbOld;
        private DevExpress.XtraEditors.LabelControl lbCheck;
        private DevExpress.XtraEditors.LabelControl lbNew;
    }
}