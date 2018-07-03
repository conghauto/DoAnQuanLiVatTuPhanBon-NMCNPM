namespace QLCUAHANG_GUI
{
    partial class frmBaoCaoDoanhThu
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet1 = new QLCUAHANG_GUI.DataSet1();
            this.DoanhThuTheoThangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DoanhThuTheoThangTableAdapter = new QLCUAHANG_GUI.DataSet1TableAdapters.DoanhThuTheoThangTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.btnSearchResult = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoanhThuTheoThangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearchResult);
            this.panel1.Controls.Add(this.txtMonth);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 63);
            this.panel1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.DoanhThuTheoThangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLCUAHANG_GUI.rptBaoCaoDoanhThu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 69);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(754, 312);
            this.reportViewer1.TabIndex = 1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DoanhThuTheoThangBindingSource
            // 
            this.DoanhThuTheoThangBindingSource.DataMember = "DoanhThuTheoThang";
            this.DoanhThuTheoThangBindingSource.DataSource = this.DataSet1;
            // 
            // DoanhThuTheoThangTableAdapter
            // 
            this.DoanhThuTheoThangTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tháng:";
            // 
            // txtMonth
            // 
            this.txtMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonth.Location = new System.Drawing.Point(215, 23);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(128, 22);
            this.txtMonth.TabIndex = 1;
            // 
            // btnSearchResult
            // 
            this.btnSearchResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchResult.Location = new System.Drawing.Point(349, 22);
            this.btnSearchResult.Name = "btnSearchResult";
            this.btnSearchResult.Size = new System.Drawing.Size(107, 23);
            this.btnSearchResult.TabIndex = 2;
            this.btnSearchResult.Text = "Tìm kiếm";
            this.btnSearchResult.UseVisualStyleBackColor = true;
            this.btnSearchResult.Click += new System.EventHandler(this.btnSearchResult_Click);
            // 
            // frmBaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 383);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "frmBaoCaoDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo Doanh thu theo tháng";
            this.Load += new System.EventHandler(this.frmBaoCaoDoanhThu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoanhThuTheoThangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DoanhThuTheoThangBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.DoanhThuTheoThangTableAdapter DoanhThuTheoThangTableAdapter;
        private System.Windows.Forms.Button btnSearchResult;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Label label1;
    }
}