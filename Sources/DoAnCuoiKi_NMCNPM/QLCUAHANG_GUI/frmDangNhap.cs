using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLCUAHANG_GUI
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void hyperlinkLCRegister_Click(object sender, EventArgs e)
        {
            
            frmRegister registerAccount = new frmRegister();
            this.Hide();
            registerAccount.ShowDialog();
            this.Show();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr==DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}