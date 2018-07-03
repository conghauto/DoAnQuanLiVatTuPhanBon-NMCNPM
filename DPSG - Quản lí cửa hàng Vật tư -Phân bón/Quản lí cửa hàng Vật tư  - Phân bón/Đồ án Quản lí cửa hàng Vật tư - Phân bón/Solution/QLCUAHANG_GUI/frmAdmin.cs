using DevExpress.XtraEditors;
using QLCUAHANG_DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCUAHANG_GUI
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtNameAdmin.Text=="")
            {
                XtraMessageBox.Show("Bạn chưa nhập Tên đăng nhập ?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPassAdmin.Text == "")
            {
                XtraMessageBox.Show("Bạn chưa nhập Mật khẩu ?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

             try
                {
                    SqlConnection cnn = DataProvider.KetNoi();
                    var cmd = new SqlCommand("users_getid1", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtNameAdmin.Text;
                    cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = txtPassAdmin.Text;
                    SqlDataReader dt = cmd.ExecuteReader();
                    if (dt.Read() == true)
                    {
                        cnn.Close();
                        XtraMessageBox.Show("Đăng nhập thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        frmQuanLiTaiKhoan account = new frmQuanLiTaiKhoan();
                        account.ShowDialog();
                        this.Show();
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cnn.Close();
                    }
                }
            catch
            {
                XtraMessageBox.Show("Đăng nhập thất bại ?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
