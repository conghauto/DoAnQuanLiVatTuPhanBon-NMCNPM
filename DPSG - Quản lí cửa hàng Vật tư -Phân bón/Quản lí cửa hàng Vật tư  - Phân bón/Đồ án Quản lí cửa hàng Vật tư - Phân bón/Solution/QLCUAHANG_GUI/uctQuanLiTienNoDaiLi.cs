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
    public partial class uctQuanLiTienNoDaiLi : UserControl
    {
        public uctQuanLiTienNoDaiLi()
        {
            InitializeComponent();
        }
        public static uctQuanLiTienNoDaiLi uctQLTienNoDL = new uctQuanLiTienNoDaiLi();

        public void Load_DSNoDaiLi()
        {
            List<HoaDonNhapHang_DTO> ds =HoaDonNhapHang_BUS.DSNoTienDaiLi();
            dtgvListAgency.DataSource = ds;
            if (dtgvListAgency.Rows.Count == 0)
            {
                dtgvListAgency.ColumnCount = 2;
                dtgvListAgency.ColumnHeadersVisible = true;
                dtgvListAgency.Columns[0].Name = "MaDL";
                dtgvListAgency.Columns[1].Name = "TenDL";

                dtgvListAgency.Columns[0].DataPropertyName = "MaDL";
                dtgvListAgency.Columns[1].DataPropertyName = "TenDL";

                dtgvListAgency.Columns[0].HeaderText = "Mã DL";
                dtgvListAgency.Columns[1].HeaderText = "Tên đại lí";

                dtgvListAgency.Columns[0].Width = 150;
                dtgvListAgency.Columns[1].Width = 150;
            }
        }

        private void uctQuanLiTienNoDaiLi_Load(object sender, EventArgs e)
        {
            Load_DSNoDaiLi();
        }

        private void dtgvListAgency_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPayAgency.Text = "";
            try
            {
                lbListBillOfAgency.Items.Clear();
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    txtIDAgency.Text = dtgvListAgency.CurrentRow.Cells["MaDL"].Value.ToString();
                    txtNameAgency.Text = dtgvListAgency.CurrentRow.Cells["TenDL"].Value.ToString();

                    List<string> dsMaHDN = HoaDonNhapHang_BUS.LoadDS_MaHDNhap(txtIDAgency.Text.ToString());
                    if (dsMaHDN == null)
                        return;
                    else
                    {
                        foreach (string item in dsMaHDN)
                        {
                            lbListBillOfAgency.Items.Add(item);
                        }
                    }

                    string arr = HoaDonNhapHang_BUS.TongNoDaiLi(txtIDAgency.Text);
                    txtTotalDebt.Text = arr;

                    txtIDPayOfAgency.Text = DataProvider.ExcuteScalar(string.Format("SELECT MaTN=dbo.fcGetMaTTDL()"));
                    LoadThongTin_ThanhToanDL(txtIDAgency.Text);

                    return;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void LoadThongTin_ThanhToanDL(string s)
        {
            List<QuanLiTIenNo_DaiLi_DTO> ds = QuanLiTienNo_DaiLi_BUS.ThongTinTienNoDL(s);
            dtgvListPayOfAgency.DataSource = ds;
            if (dtgvListPayOfAgency.Rows.Count == 0)
            {
                dtgvListPayOfAgency.ColumnCount = 4;
                dtgvListPayOfAgency.ColumnHeadersVisible = true;
                dtgvListPayOfAgency.Columns[0].Name = "MaTN";
                dtgvListPayOfAgency.Columns[1].Name = "MaDL";
                dtgvListPayOfAgency.Columns[2].Name = "NgayTra";
                dtgvListPayOfAgency.Columns[3].Name = "SoTienTra";

                dtgvListPayOfAgency.Columns[0].DataPropertyName = "MaTN";
                dtgvListPayOfAgency.Columns[1].DataPropertyName = "MaDL";
                dtgvListPayOfAgency.Columns[2].DataPropertyName = "NgayTra";
                dtgvListPayOfAgency.Columns[3].DataPropertyName = "SoTienTra";;

                dtgvListPayOfAgency.Columns[0].HeaderText = "Mã TT";
                dtgvListPayOfAgency.Columns[1].HeaderText = "Mã DL";
                dtgvListPayOfAgency.Columns[2].HeaderText = "Ngày trả";
                dtgvListPayOfAgency.Columns[3].HeaderText = "Số tiền trả";

                dtgvListPayOfAgency.Columns[0].Width = 100;
                dtgvListPayOfAgency.Columns[1].Width = 105;
                dtgvListPayOfAgency.Columns[2].Width = 115;
                dtgvListPayOfAgency.Columns[3].Width = 115;
            }
        }

        private void lbClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtPayAgency.Text = "";
            txtIDPayOfAgency.Text = DataProvider.ExcuteScalar(string.Format("SELECT MaTN=dbo.fcGetMaTTDL()"));
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (txtPayAgency.Text == "")
            {
                XtraMessageBox.Show("Bạn phải điền đầy đủ thông tin  !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            QuanLiTIenNo_DaiLi_DTO thanhtoan = new QuanLiTIenNo_DaiLi_DTO();
            thanhtoan.MaTN = txtIDPayOfAgency.Text;
            thanhtoan.MaDL = txtIDAgency.Text;
            thanhtoan.NgayTra = Convert.ToDateTime(dtpDatePay.Text);
            thanhtoan.SoTienTra = Convert.ToDouble(txtPayAgency.Text);
            try
            {
                if (QuanLiTienNo_DaiLi_BUS.ThemThongTinTienNoDL(thanhtoan))
                {
                    LoadThongTin_ThanhToanDL(txtIDAgency.Text.ToString());

                    txtIDPayOfAgency.Text = DataProvider.ExcuteScalar(string.Format("SELECT MaTN=dbo.fcGetMaTTDL()"));
                    string arr = HoaDonNhapHang_BUS.TongNoDaiLi(txtIDAgency.Text);
                    txtTotalDebt.Text = arr;
                    txtPayAgency.Text = "";
                    XtraMessageBox.Show("Thêm thông tin thanh toán thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnDeletePay_Click(object sender, EventArgs e)
        {
            if (txtPayAgency.Text == "")
            {
                XtraMessageBox.Show("Bạn phải điền đầy đủ thông tin  !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            QuanLiTIenNo_DaiLi_DTO thanhtoan = new QuanLiTIenNo_DaiLi_DTO();
            thanhtoan.MaTN = txtIDPayOfAgency.Text;

            try
            {
                if (QuanLiTienNo_DaiLi_BUS.XoaThongTinTienNoDL(thanhtoan))
                {
                    Load_DSNoDaiLi();
                    LoadThongTin_ThanhToanDL(txtIDAgency.Text.ToString());

                    txtIDPayOfAgency.Text = DataProvider.ExcuteScalar(string.Format("SELECT MaTN=dbo.fcGetMaTTDL()"));
                    string arr = HoaDonNhapHang_BUS.TongNoDaiLi(txtIDAgency.Text);
                    txtTotalDebt.Text = arr;
                    txtPayAgency.Text = "";
                    XtraMessageBox.Show("Xóa thông tin thanh toán thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dtgvListPayOfAgency_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    txtIDPayOfAgency.Text = dtgvListPayOfAgency.CurrentRow.Cells["MaTN"].Value.ToString();
                    txtPayAgency.Text = dtgvListPayOfAgency.CurrentRow.Cells["SoTienTra"].Value.ToString();
                    dtpDatePay.Text = dtgvListPayOfAgency.CurrentRow.Cells["NgayTra"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtTotalDebt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtPayAgency_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
