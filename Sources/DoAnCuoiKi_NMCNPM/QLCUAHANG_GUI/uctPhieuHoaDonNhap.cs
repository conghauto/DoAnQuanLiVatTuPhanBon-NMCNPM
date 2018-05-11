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
using System.Data.SqlClient;

namespace QLCUAHANG_GUI
{
    public partial class uctPhieuHoaDonNhap : UserControl
    {
        public uctPhieuHoaDonNhap()
        {
            InitializeComponent();
        }
        public static uctPhieuHoaDonNhap uctPHN = new uctPhieuHoaDonNhap();
        private void uctPhieuHoaDonNhap_Load(object sender, EventArgs e)
        {
            LoadDataBillImport();
            LoadDataBillDetailImport();
        }

        #region Hóa đơn nhập hàng
        private void LoadDataBillImport()
        {
            btnAddImportBill.Click += new EventHandler(btnAddImportBill_Click);
            dtgvInfoListOfBillImport.CellClick += new DataGridViewCellEventHandler(dtgvInfoListOfBillImport_CellClick);
            btnUpdateBillImport.Click += new EventHandler(btnUpdateBillImport_Click);
            btnDeleteBillImport.Click += new EventHandler(btnDeleteBillImport_Click);
            LoadMaDL();

            LoadPhieuNhapHang();
            txtTotalDebt.KeyPress += new KeyPressEventHandler(txtTotalDebt_KeyPress);
            txtTotalPay.KeyPress += new KeyPressEventHandler(txtTotalPay_KeyPress);

            txtIDBillImport.Text = DataProvider.ExcuteScalar(string.Format("SELECT MaHDN=dbo.fcGetMaHDN()"));
            txtTotalDebt.Text = "0";
            txtTotalPay.Text = "0";
        }
        private void LoadPhieuNhapHang()
        {
            List<HoaDonNhapHang_DTO> listPhieuNhap = HoaDonNhapHang_BUS.LoadPhieuNhap();
            dtgvInfoListOfBillImport.DataSource = listPhieuNhap;
        }
        private void LoadMaDL()
        {
            List<DaiLi_DTO> daili = DaiLi_BUS.LoadDaiLi();
            cmbIDAgency.DataSource = daili;

            cmbIDAgency.ValueMember = "MaDL";
            cmbIDAgency.DisplayMember = "MaDL";
        }


        private void btnAddImportBill_Click(object sender, EventArgs e)
        {
            if (txtIDBillImport.Text == "" || txtNameAgency.Text == "" || txtTotalPay.Text == "" ||
                txtTotalDebt.Text == "" || cmbIDAgency.Text == "")
            {
                MessageBox.Show("Bạn phải điền đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            HoaDonNhapHang_DTO phieunhap = new HoaDonNhapHang_DTO();
            phieunhap.MaHDN = txtIDBillImport.Text;
            phieunhap.MaDL = cmbIDAgency.Text.ToString();
            phieunhap.NgayNhap = Convert.ToDateTime(dtpkDateTimeImport.Text.ToString());
            phieunhap.TenDL = txtNameAgency.Text;
            phieunhap.TongTien = Convert.ToDouble(txtTotalPay.Text.ToString());
            phieunhap.TongNo = Convert.ToDouble(txtTotalDebt.Text.ToString());

            if (HoaDonNhapHang_BUS.ThemPHNhap(phieunhap))
            {
                MessageBox.Show("Thêm hóa đơn nhập hàng thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearDisplay();
                LoadPhieuNhapHang();
                return;
            }
            MessageBox.Show("Thêm hóa đơn nhập hàng thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dtgvInfoListOfBillImport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                txtIDBillImport.Text = Convert.ToString(dtgvInfoListOfBillImport.CurrentRow.Cells["MaHDN"].Value);
                txtNameAgency.Text = Convert.ToString(dtgvInfoListOfBillImport.CurrentRow.Cells["TenDL"].Value);
                cmbIDAgency.Text = Convert.ToString(dtgvInfoListOfBillImport.CurrentRow.Cells["MaDL"].Value);
                txtTotalDebt.Text = Convert.ToString(dtgvInfoListOfBillImport.CurrentRow.Cells["TongNo"].Value);
                txtTotalPay.Text = Convert.ToString(dtgvInfoListOfBillImport.CurrentRow.Cells["TongTien"].Value);
                dtpkDateTimeImport.Text = Convert.ToString(dtgvInfoListOfBillImport.CurrentRow.Cells["NgayNhap"].Value);
                cmbIDBillImportDetail.Text = txtIDBillImport.Text;
            }
        }

        private void btnUpdateBillImport_Click(object sender, EventArgs e)
        {
            if (txtIDBillImport.Text == "")
            {
                MessageBox.Show("Bạn phải chọn phiếu cần chỉnh sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            HoaDonNhapHang_DTO phieunhap = new HoaDonNhapHang_DTO();
            phieunhap.MaHDN = (string)dtgvInfoListOfBillImport.CurrentRow.Cells["MaHDN"].Value;
            phieunhap.MaDL = cmbIDAgency.Text.ToString();
            phieunhap.NgayNhap = Convert.ToDateTime(dtpkDateTimeImport.Text.ToString());
            phieunhap.TenDL = txtNameAgency.Text;
            phieunhap.TongTien = Convert.ToDouble(txtTotalPay.Text.ToString());
            phieunhap.TongNo = Convert.ToDouble(txtTotalDebt.Text.ToString());

            if (HoaDonNhapHang_BUS.SuaPHNhap(phieunhap))
            {
                LoadPhieuNhapHang();
                MessageBox.Show("Phiếu nhập hàng cập nhật thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearDisplay();
                return;
            }
            MessageBox.Show("Phiếu nhập hàng cập nhật thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDeleteBillImport_Click(object sender, EventArgs e)
        {
            if (txtIDBillImport.Text == "")
            {
                MessageBox.Show("Bạn phải chọn phiếu cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            HoaDonNhapHang_DTO phieunhap = new HoaDonNhapHang_DTO();
            phieunhap.MaHDN = (string)dtgvInfoListOfBillImport.CurrentRow.Cells["MaHDN"].Value;

            try
            {
                if (HoaDonNhapHang_BUS.XoaPHNhap(phieunhap))
                {
                    LoadPhieuNhapHang();
                    MessageBox.Show("Phiếu nhập hàng xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearDisplay();
                    return;
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearDisplay()
        {
            txtIDBillImport.Text = DataProvider.ExcuteScalar(string.Format("SELECT MaHDN=dbo.fcGetMaHDN()"));
            txtNameAgency.Text = "";
            txtTotalPay.Text = "";
            txtTotalDebt.Text = "";
            txtNameAgency.Text = "";
            cmbIDAgency.Text = "";
        }
        private void txtTotalPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtTotalDebt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void cmbIDAgency_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = DataProvider.KetNoi();
                string query = string.Format("EXEC dbo.TimTenDL @MaDL = N'" + cmbIDAgency.Text + "'");
                DataTable dt = DataProvider.LayDataTable(query, con);
                if (dt.Rows.Count == 0)
                    txtNameAgency.Text = "";
                else
                    txtNameAgency.Text = dt.Rows[0]["TenDL"].ToString();
                return;
            }
            catch
            {
                return;
            }
        }
        #endregion

        #region Chi tiết hóa đơn nhập
        private void LoadDataBillDetailImport()
        {
            btnAddProductImportDetail.Click += new EventHandler(btnAddProductImportDetail_Click);
            dtgvListOfDetailProductImport.CellClick += new DataGridViewCellEventHandler(dtgvListOfDetailProductImport_CellClick);
            btnUpdateProductImportDetail.Click += new EventHandler(btnUpdateProductImportDetail_Click);
            btnDeleteProductImportDetail.Click += new EventHandler(btnDeleteProductImportDetail_Click);
            txtAmountOfProductImportDetail.KeyPress += new KeyPressEventHandler(txtAmountOfProductImportDetail_KeyPress);

            LoadMaSP();
            LoadMaHD();
            LoadChiTietPhieuNhapHang();
        }
        private void LoadChiTietPhieuNhapHang()
        {
            List<ChiTietHoaDonNhap_DTO> listChiTietPhieuNhap = ChiTietHoaDonNhap_BUS.LoadChiTietPhieuNhap();
            dtgvListOfDetailProductImport.DataSource = listChiTietPhieuNhap;
        }
        private void LoadMaHD()
        {
            List<HoaDonNhapHang_DTO> hoadon = HoaDonNhapHang_BUS.LoadPhieuNhap();

            cmbIDBillImportDetail.DataSource = hoadon;
            cmbIDBillImportDetail.ValueMember = "MaHDN";
            cmbIDBillImportDetail.DisplayMember = "MaHDN";

        }
        private void LoadMaSP()
        {
            List<SanPhamDL_DTO> sanpham = SanPhamDL_BUS.LoadSanPhamDL();

            cmbIDProductDetailStore.DataSource = sanpham;
            cmbIDProductDetailStore.ValueMember = "MaSPDL";
            cmbIDProductDetailStore.DisplayMember = "MaSPDL";
        }

        private void btnAddProductImportDetail_Click(object sender, EventArgs e)
        {
            if (cmbIDBillImportDetail.Text == "" || cmbIDProductDetailStore.Text == "" || txtAmountOfProductImportDetail.Text == "")
            {
                MessageBox.Show("Bạn phải điền đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ChiTietHoaDonNhap_DTO phieunhap = new ChiTietHoaDonNhap_DTO();
            phieunhap.MaHDN = cmbIDBillImportDetail.Text;
            phieunhap.MaSPDL = cmbIDProductDetailStore.Text;
            phieunhap.SoLuong = Convert.ToInt32(txtAmountOfProductImportDetail.Text.ToString());
           
                if (ChiTietHoaDonNhap_BUS.ThemChiTietPHNhap(phieunhap))
                {
                    MessageBox.Show("Thêm chi tiết phiếu nhập hàng thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadChiTietPhieuNhapHang();
                    LoadPhieuNhapHang();
                    return;
                }

            MessageBox.Show("Sản phẩm đã tồn tại trong Hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;

        }

        private void dtgvListOfDetailProductImport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbIDProductDetailStore.Text = "";
            cmbIDProductDetailStore.Text = "";
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                cmbIDBillImportDetail.Text = Convert.ToString(dtgvListOfDetailProductImport.CurrentRow.Cells["MaHDN1"].Value.ToString());
                cmbIDProductDetailStore.Text = Convert.ToString(dtgvListOfDetailProductImport.CurrentRow.Cells["MaSPDL"].Value.ToString());
                txtAmountOfProductImportDetail.Text = Convert.ToString(dtgvListOfDetailProductImport.CurrentRow.Cells["SoLuong"].Value);
            }
        }

        private void btnUpdateProductImportDetail_Click(object sender, EventArgs e)
        {
            if (cmbIDBillImportDetail.Text == "")
            {
                MessageBox.Show("Bạn phải chọn chi tiết phiếu cần chỉnh sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

                ChiTietHoaDonNhap_DTO phieunhap = new ChiTietHoaDonNhap_DTO();
                phieunhap.MaHDN = (string)dtgvListOfDetailProductImport.CurrentRow.Cells["MaHDN1"].Value;
                phieunhap.MaSPDL = cmbIDProductDetailStore.Text;
                phieunhap.SoLuong = Convert.ToInt32(txtAmountOfProductImportDetail.Text.ToString());


                if (ChiTietHoaDonNhap_BUS.SuaChiTietPHNhap(phieunhap))
                {
                    LoadPhieuNhapHang();
                    LoadChiTietPhieuNhapHang();
                    MessageBox.Show("Chi tiết phiếu nhập hàng cập nhật thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearDisplay1();
                    return;
                }
   
                MessageBox.Show("Cập nhật Chi tiết hóa đơn thất bại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
        }

        private void btnDeleteProductImportDetail_Click(object sender, EventArgs e)
        {
            if (cmbIDBillImportDetail.Text == ""||txtAmountOfProductImportDetail.Text==""||cmbIDProductDetailStore.Text=="")
            {
                MessageBox.Show("Bạn phải chọn chi tiết phiếu cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ChiTietHoaDonNhap_DTO phieunhap = new ChiTietHoaDonNhap_DTO();
            phieunhap.MaHDN = (string)dtgvListOfDetailProductImport.CurrentRow.Cells["MaSPDL"].Value;


            if (ChiTietHoaDonNhap_BUS.XoaChiTietPHNhap(phieunhap))
            {
                LoadPhieuNhapHang();
                LoadChiTietPhieuNhapHang();
                MessageBox.Show("Chi tiết hóa đơn xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearDisplay1();
                return;
            }

            MessageBox.Show("Xóa chi tiết hóa đơn thất bại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;

        }
        private void ClearDisplay1()
        {
            cmbIDProductDetailStore.Text = "";
            txtAmountOfProductImportDetail.Text = "";
        }

        private void txtAmountOfProductImportDetail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion

    }
}