namespace QLCUAHANG_GUI
{
    partial class uctThongKe
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            this.chartSell = new DevExpress.XtraCharts.ChartControl();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.btnMonth = new System.Windows.Forms.Button();
            this.chartRevenue = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.chartSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartSell
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartSell.Diagram = xyDiagram1;
            this.chartSell.Legend.Name = "Default Legend";
            this.chartSell.Location = new System.Drawing.Point(27, 72);
            this.chartSell.Name = "chartSell";
            series1.Name = "Tổng tiền";
            this.chartSell.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartSell.Size = new System.Drawing.Size(675, 403);
            this.chartSell.TabIndex = 0;
            chartTitle1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartTitle1.Text = "Thống kê Doanh thu bán từng Sản phẩm theo tháng";
            this.chartSell.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // txtMonth
            // 
            this.txtMonth.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonth.Location = new System.Drawing.Point(342, 22);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(264, 22);
            this.txtMonth.TabIndex = 3;
            this.txtMonth.Text = "Nhập tháng cần thống kê";
            this.txtMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonth_KeyPress);
            // 
            // btnMonth
            // 
            this.btnMonth.Location = new System.Drawing.Point(627, 22);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(75, 23);
            this.btnMonth.TabIndex = 4;
            this.btnMonth.Text = "Nhập tháng";
            this.btnMonth.UseVisualStyleBackColor = true;
            // 
            // chartRevenue
            // 
            this.chartRevenue.Legend.Name = "Default Legend";
            this.chartRevenue.Location = new System.Drawing.Point(730, 72);
            this.chartRevenue.Name = "chartRevenue";
            series2.Name = "Sản phẩm";
            series2.View = pieSeriesView1;
            this.chartRevenue.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chartRevenue.Size = new System.Drawing.Size(516, 403);
            this.chartRevenue.TabIndex = 5;
            chartTitle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartTitle2.Text = "Thống kê %  Sản phẩm bán theo doanh thu";
            this.chartRevenue.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle2});
            // 
            // uctThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.chartRevenue);
            this.Controls.Add(this.btnMonth);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.chartSell);
            this.Name = "uctThongKe";
            this.Size = new System.Drawing.Size(1274, 524);
            this.Load += new System.EventHandler(this.uctThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraCharts.ChartControl chartSell;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Button btnMonth;
        private DevExpress.XtraCharts.ChartControl chartRevenue;
    }
}
