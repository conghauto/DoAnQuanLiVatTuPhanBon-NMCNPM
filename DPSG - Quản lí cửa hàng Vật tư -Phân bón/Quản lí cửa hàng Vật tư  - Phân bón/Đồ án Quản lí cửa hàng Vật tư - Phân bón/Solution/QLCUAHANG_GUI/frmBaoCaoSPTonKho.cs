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
    public partial class frmBaoCaoSPTonKho : Form
    {
        public frmBaoCaoSPTonKho()
        {
            InitializeComponent();
        }

        private void frmBaoCaoSPTonKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.VW_SANPHAMCH' table. You can move, or remove it, as needed.
            this.VW_SANPHAMCHTableAdapter.Fill(this.DataSet1.VW_SANPHAMCH);

            this.reportViewer1.RefreshReport();
        }
    }
}
