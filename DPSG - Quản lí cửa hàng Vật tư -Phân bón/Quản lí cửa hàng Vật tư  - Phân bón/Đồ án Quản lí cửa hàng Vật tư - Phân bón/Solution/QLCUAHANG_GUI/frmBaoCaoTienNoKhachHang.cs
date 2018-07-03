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
    public partial class frmBaoCaoTienNoKhachHang : Form
    {
        public frmBaoCaoTienNoKhachHang()
        {
            InitializeComponent();
        }

        private void frmBaoCaoTienNoKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.VW_KHACHHANG' table. You can move, or remove it, as needed.
            this.VW_KHACHHANGTableAdapter.Fill(this.DataSet1.VW_KHACHHANG);

            this.reportViewer1.RefreshReport();
        }
    }
}
