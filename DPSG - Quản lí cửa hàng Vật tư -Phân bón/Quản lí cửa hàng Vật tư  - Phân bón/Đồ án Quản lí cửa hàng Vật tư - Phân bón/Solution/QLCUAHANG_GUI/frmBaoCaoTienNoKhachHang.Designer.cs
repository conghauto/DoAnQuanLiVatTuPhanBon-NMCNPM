﻿namespace QLCUAHANG_GUI
{
    partial class frmBaoCaoTienNoKhachHang
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet1 = new QLCUAHANG_GUI.DataSet1();
            this.VW_KHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VW_KHACHHANGTableAdapter = new QLCUAHANG_GUI.DataSet1TableAdapters.VW_KHACHHANGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VW_KHACHHANGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.VW_KHACHHANGBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLCUAHANG_GUI.rptBaoCaoTienNoKhachHang.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(795, 366);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VW_KHACHHANGBindingSource
            // 
            this.VW_KHACHHANGBindingSource.DataMember = "VW_KHACHHANG";
            this.VW_KHACHHANGBindingSource.DataSource = this.DataSet1;
            // 
            // VW_KHACHHANGTableAdapter
            // 
            this.VW_KHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // frmBaoCaoTienNoKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 366);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmBaoCaoTienNoKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo tiền nợ Khách hàng";
            this.Load += new System.EventHandler(this.frmBaoCaoTienNoKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VW_KHACHHANGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VW_KHACHHANGBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.VW_KHACHHANGTableAdapter VW_KHACHHANGTableAdapter;
    }
}