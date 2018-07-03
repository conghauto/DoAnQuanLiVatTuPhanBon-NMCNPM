using DevExpress.XtraEditors;
using QLCUAHANG_DAL;
using QLCUAHANG_DTO;
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
    public partial class frmQuanLiTaiKhoan : Form
    {
        public frmQuanLiTaiKhoan()
        {
            InitializeComponent();
        }
        private void frmQuanLiTaiKhoan_Load(object sender, EventArgs e)
        {
            string s = "Admin";
            try
            {
                SqlConnection con = DataProvider.KetNoi();
                string query = string.Format("EXEC dbo.users_loadinfo @UserName = " + s + "");
                DataTable dt = DataProvider.LayDataTable(query, con);
                if (dt.Rows.Count == 0)
                    return;

                txtUser.Text = "Admin";
                txtPosition.Text = dt.Rows[0]["ChucVu"].ToString();
                txtAddress.Text = dt.Rows[0]["DiaChi"].ToString();
                txtNumberPhone.Text = dt.Rows[0]["SoDT"].ToString();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoadData();

        }
        private void LoadData()
        {
            try
            {
                SqlConnection con = DataProvider.KetNoi();

                DataTable dt = DataProvider.LayDataTable("users_list", con);

                List<User_DTO> dsUser = new List<User_DTO>();

                if (dt.Rows.Count == 0)
                {
                    return;
                }

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    User_DTO us = new User_DTO();
                    us.ID = Convert.ToInt32(dt.Rows[i]["ID"].ToString());
                    us.UserName = dt.Rows[i]["UserName"].ToString();
                    us.ChucVu = dt.Rows[i]["ChucVu"].ToString();
                    us.DiaChi = dt.Rows[i]["DiaChi"].ToString();
                    us.SoDT = dt.Rows[i]["SoDT"].ToString();

                    dsUser.Add(us);
                }
                DataProvider.DongKetNoi(con);
                dtgvListUser.DataSource = dsUser;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void linkClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearDisplay();
        }
        private void ClearDisplay()
        {
            txtUser.Text = "";
            txtPosition.Text = "";
            txtAddress.Text = "";
            txtNumberPhone.Text = "";
        }
        private void dtgvListUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtUser.Text = Convert.ToString(dtgvListUser.CurrentRow.Cells["UserName"].Value);
                txtPosition.Text = Convert.ToString(dtgvListUser.CurrentRow.Cells["ChucVu"].Value);
                txtAddress.Text = Convert.ToString(dtgvListUser.CurrentRow.Cells["DiaChi"].Value);
                txtNumberPhone.Text = Convert.ToString(dtgvListUser.CurrentRow.Cells["SoDT"].Value);
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                XtraMessageBox.Show("Bạn chưa lụa chọn tên cần xóa ?", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection con = DataProvider.KetNoi();
            SqlCommand cmd = new SqlCommand("users_update", con);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@name",txtUser.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@ChucVu",txtPosition.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@DiaChi",txtAddress.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@SoDT",txtNumberPhone.Text);
                cmd.Parameters.Add(p);

                cmd.ExecuteNonQuery();

                DataProvider.DongKetNoi(con);
                XtraMessageBox.Show("Cập nhật thông tin tài khoản thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearDisplay();
                return;
            }
            catch(Exception ex)
            {
                DataProvider.DongKetNoi(con);
                XtraMessageBox.Show(ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if(txtUser.Text=="")
            {
                XtraMessageBox.Show("Bạn chưa lụa chọn tên cần xóa ?", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection con = DataProvider.KetNoi();
            SqlCommand cmd = new SqlCommand("users_delete", con);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@name",txtUser.Text);
                cmd.Parameters.Add(p);

                cmd.ExecuteNonQuery();

                DataProvider.DongKetNoi(con);
                XtraMessageBox.Show("Xóa tài khoản thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearDisplay();
                return;
            }
            catch(Exception ex)
            {
                DataProvider.DongKetNoi(con);
                XtraMessageBox.Show(ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
