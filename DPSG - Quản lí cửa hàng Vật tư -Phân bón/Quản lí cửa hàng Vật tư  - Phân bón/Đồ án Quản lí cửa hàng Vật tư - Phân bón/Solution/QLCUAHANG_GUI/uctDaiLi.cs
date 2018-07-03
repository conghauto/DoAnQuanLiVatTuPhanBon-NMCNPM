using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCUAHANG_DTO;
using QLCUAHANG_BUS;
using QLCUAHANG_DAL;
using DevExpress.XtraEditors;

namespace QLCUAHANG_GUI
{
    public partial class uctDaiLi : UserControl
    {
        public uctDaiLi()
        {
            InitializeComponent();
        }
        public static uctDaiLi uctDL = new uctDaiLi();
        

        private void uctDaiLi_Load(object sender, EventArgs e)
        {
            DataDaili();
        }

        #region Đại Lí
        private void DataDaili()
        {
            LoadListDaiLi();
            dtgvAgencyInfoList.CellClick += new DataGridViewCellEventHandler(dtgvAgencyInfoList_CellClick);
            //dtgvAgencyInfoList.Click += new EventHandler(dtgvAgencyInfoList_Click);
            btnAddAgency.Click += new EventHandler(btnAddAgency_Click);
            btnUpdateAgency.Click += new EventHandler(btnUpdateAgency_Click);
            btnDeleteAgency.Click += new EventHandler(btnDeleteAgency_Click);
            txtIDAgency.Text = DataProvider.ExcuteScalar(string.Format("SELECT MaDL=dbo.fcGetMaDL()"));
        }
        private void dtgvAgencyInfoList_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dtgvAgencyInfoList.SelectedRows[0];
            txtIDAgency.Text = Convert.ToString(dr.Cells["MaDL"].Value);
            txtNameAgency.Text = Convert.ToString(dr.Cells["TenDL"].Value);
            txtAddressOfAgency.Text = Convert.ToString(dr.Cells["DiaChi"].Value);
            txtNumberPhone.Text = Convert.ToString(dr.Cells["SoDT"].Value);
            txtTotalDebtOfAgency.Text = Convert.ToString(dr.Cells["TongNo"].Value);
        }
        private void dtgvAgencyInfoList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtIDAgency.Text = Convert.ToString(dtgvAgencyInfoList.CurrentRow.Cells["MaDL"].Value);
                txtNameAgency.Text = Convert.ToString(dtgvAgencyInfoList.CurrentRow.Cells["TenDL"].Value);
                txtAddressOfAgency.Text = Convert.ToString(dtgvAgencyInfoList.CurrentRow.Cells["DiaChi"].Value);
                txtNumberPhone.Text = Convert.ToString(dtgvAgencyInfoList.CurrentRow.Cells["SoDT"].Value);
                txtTotalDebtOfAgency.Text = Convert.ToString(dtgvAgencyInfoList.CurrentRow.Cells["TongNo"].Value);
            }
        }

        public void LoadListDaiLi()
        {
            List<DaiLi_DTO> daiLi = DaiLi_BUS.LoadDaiLi();
            dtgvAgencyInfoList.DataSource = daiLi;
        }

        private void btnAddAgency_Click(object sender, EventArgs e)
        {
            try
            {
                DaiLi_DTO daili = new DaiLi_DTO();
                daili.MaDL = txtIDAgency.Text;
                daili.TenDL = txtNameAgency.Text;
                daili.DiaChi = txtAddressOfAgency.Text;
                daili.SoDT = txtNumberPhone.Text;
                daili.TongNo = Convert.ToDouble(txtTotalDebtOfAgency.Text);
                if (txtIDAgency.Text == "" || txtNameAgency.Text == "" || txtAddressOfAgency.Text == "" || txtNumberPhone.Text == "")
                {
                    XtraMessageBox.Show("Bạn phải nhập đầy đủ thông tin Đại lí !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay();
                    return;
                }
                if (DaiLi_BUS.ThemDaiLi(daili))
                {
                    XtraMessageBox.Show("Đại lí được thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListDaiLi();
                    ClearDisplay();
                    return;
                }
            }catch
            {
                XtraMessageBox.Show("Đại lí thêm thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnUpdateAgency_Click(object sender, EventArgs e)
        {
            try
            {

                DaiLi_DTO daili = new DaiLi_DTO();
            daili.MaDL = dtgvAgencyInfoList.CurrentRow.Cells["MaDL"].Value.ToString();
            daili.TenDL = txtNameAgency.Text;
            daili.DiaChi = txtAddressOfAgency.Text;
            daili.SoDT = txtNumberPhone.Text;
            daili.TongNo = Convert.ToDouble(txtTotalDebtOfAgency.Text);
            if (txtIDAgency.Text == "" || txtNameAgency.Text == "" || txtAddressOfAgency.Text == "" || txtNumberPhone.Text == "")
            {
                XtraMessageBox.Show("Bạn phải chọn Đại lí cần sửa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearDisplay();
                return;
            }
            if (DaiLi_BUS.SuaDaiLi(daili))
            {
                XtraMessageBox.Show("Cập nhật Thông tin Đại lí thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListDaiLi();
                ClearDisplay();
                return;
            }
            }
            catch
            {
                XtraMessageBox.Show("Cập nhật Thông tin Đại lí thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void btnDeleteAgency_Click(object sender, EventArgs e)
        {
            try
            {
                DaiLi_DTO daili = new DaiLi_DTO();
                daili.MaDL = dtgvAgencyInfoList.CurrentRow.Cells["MaDL"].Value.ToString();
                daili.TenDL = txtNameAgency.Text;
                if (txtIDAgency.Text == "" || txtNameAgency.Text == "" || txtAddressOfAgency.Text == "" || txtNumberPhone.Text == "")
                {
                    XtraMessageBox.Show("Bạn phải chọn Đại lí cần xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay();
                    return;
                }
                if (DaiLi_BUS.XoaDaiLi(daili))
                {
                    LoadListDaiLi();
                    XtraMessageBox.Show("Xóa Thông Đại lí thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearDisplay();
                    return;
                }
            }catch
            {
                XtraMessageBox.Show("Xóa Thông tin Đại lí thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void ClearDisplay()
        {
            txtIDAgency.Text = DataProvider.ExcuteScalar(string.Format("SELECT MaDL=dbo.fcGetMaDL()"));
            txtNameAgency.Text = "";
            txtAddressOfAgency.Text = "";
            txtNumberPhone.Text = "";
           
        }
        #endregion

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearDisplay();
            txtTotalDebtOfAgency.Text = "";
        }

        private void txtTotalDebtOfAgency_Click(object sender, EventArgs e)
        {
            txtTotalDebtOfAgency.Text = "";
        }

        private void txtNumberPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtTotalDebtOfAgency_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
