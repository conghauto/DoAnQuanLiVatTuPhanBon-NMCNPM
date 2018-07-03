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
    public partial class frmRegister : DevExpress.XtraEditors.XtraForm
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPassword.Text == "" || textEdit2.Text == " ") XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtPassword.Text != textEdit2.Text) XtraMessageBox.Show("Mật khẩu không trùng khớp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                SqlConnection cnn =DataProvider.KetNoi();
                var cmd = new SqlCommand("users_checkname", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtUser.Text;
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    XtraMessageBox.Show("Tên tài khoản đã tồn tại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cnn.Close();
                }
                else
                {
                    cnn.Close();
                    try
                    {
                        cnn.Open();
                        var cmdd = new SqlCommand("USERS_INSERT", cnn);
                        cmdd.CommandType = CommandType.StoredProcedure;
                        cmdd.Parameters.Add("@name", SqlDbType.Text).Value = txtUser.Text;
                        cmdd.Parameters.Add("@pass", SqlDbType.Text).Value = txtPassword.Text;
                        cmdd.ExecuteNonQuery();
                        XtraMessageBox.Show("Tạo tài khoản thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        cnn.Close();
                    }
                    catch
                    {
                        XtraMessageBox.Show("Tạo tài khoản thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
        }
    }
}