using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCUAHANG_GUI
{
    public partial class frmBaoCaoDoanhThu : Form
    {
        public frmBaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        private void frmBaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.DoanhThuTheoThang' table. You can move, or remove it, as needed.
         
        }

        private void btnSearchResult_Click(object sender, EventArgs e)
        {
            this.DoanhThuTheoThangTableAdapter.Fill(this.DataSet1.DoanhThuTheoThang, Convert.ToInt32(txtMonth.Text));

            this.reportViewer1.RefreshReport();
        }
    }
}
