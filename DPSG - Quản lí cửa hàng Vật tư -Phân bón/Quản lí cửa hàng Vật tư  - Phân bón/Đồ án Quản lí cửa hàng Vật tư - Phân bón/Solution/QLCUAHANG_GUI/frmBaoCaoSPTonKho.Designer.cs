namespace QLCUAHANG_GUI
{
    partial class frmBaoCaoSPTonKho
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet1 = new QLCUAHANG_GUI.DataSet1();
            this.VW_SANPHAMCHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VW_SANPHAMCHTableAdapter = new QLCUAHANG_GUI.DataSet1TableAdapters.VW_SANPHAMCHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VW_SANPHAMCHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.VW_SANPHAMCHBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLCUAHANG_GUI.rptBaoCaoSanPhamTonKho.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(732, 295);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VW_SANPHAMCHBindingSource
            // 
            this.VW_SANPHAMCHBindingSource.DataMember = "VW_SANPHAMCH";
            this.VW_SANPHAMCHBindingSource.DataSource = this.DataSet1;
            // 
            // VW_SANPHAMCHTableAdapter
            // 
            this.VW_SANPHAMCHTableAdapter.ClearBeforeFill = true;
            // 
            // frmBaoCaoSPTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 295);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmBaoCaoSPTonKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo sản phẩm tồn kho";
            this.Load += new System.EventHandler(this.frmBaoCaoSPTonKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VW_SANPHAMCHBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VW_SANPHAMCHBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.VW_SANPHAMCHTableAdapter VW_SANPHAMCHTableAdapter;
    }
}