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
using System.Data.SqlClient;
using QLCUAHANG_DAL;

namespace QLCUAHANG_GUI
{
    public partial class frmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        static public string NameLog = Properties.Settings.Default.NameLog;
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text == string.Empty || txtOldPass.Text == string.Empty || txtRegisPass.Text == string.Empty)
                XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                if (txtOldPass.Text != Properties.Settings.Default.PassLog) lbOld.Text = "Mật khẩu cũ không chính xác";
            else
                if (txtNewPass.Text != txtRegisPass.Text) return;
            else
                if (txtOldPass.Text == txtNewPass.Text) return;
            else
            {
                try
                {
                    SqlConnection cnn = DataProvider.KetNoi();
                    SqlCommand cmd = new SqlCommand("users_updatepass", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = NameLog;
                    cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = txtNewPass.Text;
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    XtraMessageBox.Show("Đổi mật khẩu thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message,"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void txtRegisPass_TextChanged(object sender, EventArgs e)
        {
            if (txtNewPass.Text != txtRegisPass.Text)
            {
                lbNew.ForeColor = Color.Red;
                lbNew.Text = "Không khớp mật khẩu.";
            }
            else if (txtNewPass.Text == txtRegisPass.Text)
            {
                lbNew.Text = "Khớp mật khẩu.";
                lbNew.ForeColor = Color.Green;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {
            if (txtNewPass.Text == txtOldPass.Text) lbCheck.Text = "Không được trùng với mật khẩu cũ!";
            else
                lbCheck.Text = "";
            if (txtNewPass.Text != txtRegisPass.Text) lbNew.Text = "";
        }
    }
}