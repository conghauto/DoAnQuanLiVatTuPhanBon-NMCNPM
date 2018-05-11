using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCUAHANG_BUS;
using QLCUAHANG_DTO;
using QLCUAHANG_DAL;

namespace QLCUAHANG_GUI
{
    public partial class uctKhachHang : UserControl
    {
        public uctKhachHang()
        {
            InitializeComponent();

        }
        public static uctKhachHang uctKH = new uctKhachHang();
        private void LoadKhachHang()
        {
            List<KhachHang_DTO> dsKhachHang = KhachHang_BUS.LoadDSKhachHang();
            dtgvCustomersListOfStore.DataSource = dsKhachHang;

        }
        private void ClearDisplay()
        {
            txtIDCustomer.Text = DataProvider.ExcuteScalar(string.Format("Select MaKH=dbo.fcGetMaKH()"));
            txtNameCustomer.Text = "";
            txtAddressCustomer.Text = "";
            txtNumberPhone.Text = "";
        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (txtIDCustomer.Text == "" || txtNameCustomer.Text == "" || txtNumberPhone.Text == "" || txtAddressCustomer.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearDisplay();
                return;
            }

            KhachHang_DTO khachhang = new KhachHang_DTO();
            khachhang.MaKH = txtIDCustomer.Text;
            khachhang.TenKH = txtNameCustomer.Text;
            khachhang.DiaChi = txtAddressCustomer.Text;
            khachhang.SoDT = txtNumberPhone.Text;

            if (KhachHang_BUS.ThemKhachHang(khachhang))
            {
                MessageBox.Show("Thêm thông tin khách hàng thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKhachHang();
                ClearDisplay();
                return;
            }
            MessageBox.Show("Thêm thông tin khách hàng thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtgvCustomersListOfStore_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtIDCustomer.Text = Convert.ToString(dtgvCustomersListOfStore.CurrentRow.Cells["MaKH"].Value);
                txtNameCustomer.Text = Convert.ToString(dtgvCustomersListOfStore.CurrentRow.Cells["TenKH"].Value);
                txtAddressCustomer.Text = Convert.ToString(dtgvCustomersListOfStore.CurrentRow.Cells["DiaChi"].Value);
                txtNumberPhone.Text = Convert.ToString(dtgvCustomersListOfStore.CurrentRow.Cells["SoDT"].Value);
            }
        }
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (txtIDCustomer.Text == "")
            {
                MessageBox.Show("Bạn phải lựa chọn khách hàng cần xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearDisplay();
                return;
            }

            KhachHang_DTO khachhang = new KhachHang_DTO();
            khachhang.MaKH = (string)dtgvCustomersListOfStore.CurrentRow.Cells["MaKH"].Value;

            if (KhachHang_BUS.XoaKH(khachhang))
            {
                LoadKhachHang();
                MessageBox.Show("Xóa thông tin khách hàng thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearDisplay();
                return;
            }
            MessageBox.Show("Xóa thông tin khách hàng thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (txtIDCustomer.Text == "")
            {
                MessageBox.Show("Bạn phải lựa chọn khách hàng cần sửa thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearDisplay();
                return;
            }

            KhachHang_DTO khachhang = new KhachHang_DTO();
            khachhang.MaKH = (string)dtgvCustomersListOfStore.CurrentRow.Cells["MaKH"].Value;
            khachhang.TenKH = txtNameCustomer.Text;
            khachhang.DiaChi = txtAddressCustomer.Text;
            khachhang.SoDT = txtNumberPhone.Text;

            if (KhachHang_BUS.SuaKH(khachhang))
            {
                LoadKhachHang();
                ClearDisplay();
                MessageBox.Show("Sửa thông tin khách hàng thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Sửa thông tin khách hàng thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtNumberPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
 
        private void uctKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
            btnAddCustomer.Click += new EventHandler(btnAddCustomer_Click);
            dtgvCustomersListOfStore.CellClick += new DataGridViewCellEventHandler(dtgvCustomersListOfStore_CellClick);

            btnDeleteCustomer.Click += new EventHandler(btnDeleteCustomer_Click);
            btnUpdateCustomer.Click += new EventHandler(btnUpdateCustomer_Click);
            txtIDCustomer.Text = DataProvider.ExcuteScalar(string.Format("Select MaKH=dbo.fcGetMaKH()"));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            uctSearchKhachHang uctKH = new uctSearchKhachHang();
            nhung(uctKH);

        }

        private void nhung(Control ctr)
        {
            pnlListCustomer.Controls.Clear();
            pnlListCustomer.BorderStyle = BorderStyle.Fixed3D;
            ctr.Dock = DockStyle.Fill;
            pnlListCustomer.Controls.Add(ctr);
            pnlListCustomer.Show();
        }

        private void btnHideList_Click(object sender, EventArgs e)
        {
            pnlListCustomer.Controls.Clear();
            pnlListCustomer.BorderStyle = BorderStyle.None;
        }

    }
}
