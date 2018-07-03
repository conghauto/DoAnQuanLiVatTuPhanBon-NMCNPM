namespace QLCUAHANG_GUI
{
    partial class frmBaoCaoNoDaiLi
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
            this.VW_DAILIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new QLCUAHANG_GUI.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VW_DAILITableAdapter = new QLCUAHANG_GUI.DataSet1TableAdapters.VW_DAILITableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VW_DAILIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // VW_DAILIBindingSource
            // 
            this.VW_DAILIBindingSource.DataMember = "VW_DAILI";
            this.VW_DAILIBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.VW_DAILIBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLCUAHANG_GUI.rptBaoCaoNoDaiLi.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(774, 485);
            this.reportViewer1.TabIndex = 0;
            // 
            // VW_DAILITableAdapter
            // 
            this.VW_DAILITableAdapter.ClearBeforeFill = true;
            // 
            // frmBaoCaoNoDaiLi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 485);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmBaoCaoNoDaiLi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo nợ Đại lí";
            this.Load += new System.EventHandler(this.frmBaoCaoNoDaiLi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VW_DAILIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VW_DAILIBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.VW_DAILITableAdapter VW_DAILITableAdapter;
    }
}