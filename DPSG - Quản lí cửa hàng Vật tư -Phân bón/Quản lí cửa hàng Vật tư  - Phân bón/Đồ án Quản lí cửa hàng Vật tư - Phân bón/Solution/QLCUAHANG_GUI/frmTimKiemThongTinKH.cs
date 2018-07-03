using QLCUAHANG_DTO;
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
    public partial class frmSearchInfoOfCustomer : Form
    {
        public frmSearchInfoOfCustomer()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSearchInfoOfCustomer_Load(object sender, EventArgs e)
        {
            uctSearchKhachHang1.LoadDisplay();
        }
    }
}
