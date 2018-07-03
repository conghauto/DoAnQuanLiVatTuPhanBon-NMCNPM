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
    public partial class frmThongTinTaiKhoan : Form
    {
        public frmThongTinTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = DataProvider.KetNoi();
                string query = string.Format("EXEC dbo.users_loadinfo @UserName = '" + frmLogin.UserName + "'");
                DataTable dt = DataProvider.LayDataTable(query, con);
                if (dt.Rows.Count == 0)
                    return;

                txtUser.Text = dt.Rows[0]["UserName"].ToString();
                txtPosition.Text = dt.Rows[0]["ChucVu"].ToString();
                txtAddress.Text = dt.Rows[0]["DiaChi"].ToString();
                txtNumberPhone.Text = dt.Rows[0]["SoDT"].ToString();
            }catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            SqlConnection con = DataProvider.KetNoi();
            SqlCommand cmd = new SqlCommand("users_updateinfo", con);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@Name", txtUser.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@ChucVu", txtPosition.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@DiaChi", txtAddress.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@SoDT", txtNumberPhone.Text);
                cmd.Parameters.Add(p);

                cmd.ExecuteNonQuery();

                DataProvider.DongKetNoi(con);
                XtraMessageBox.Show("Cập nhật thông tin thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            catch (Exception ex)
            {
                DataProvider.DongKetNoi(con);
                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
