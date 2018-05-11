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

namespace QLCUAHANG_GUI
{
    public partial class uctPhieuHoaDonBan : UserControl
    {
        public uctPhieuHoaDonBan()
        {
            InitializeComponent();
        }
        public static uctPhieuHoaDonBan uctPHDB = new uctPhieuHoaDonBan();

        private void uctPhieuHoaDonBan_Load(object sender, EventArgs e)
        {
            DataHoaDonBan();
            DataChiTietHoaDonBan();
        }

        #region Hóa đơn bán

        private void DataHoaDonBan()
        {
            btnAddBillExport.Click += new EventHandler(btnAddBillExport_Click);
            dtgvInfoListOfBillExport.CellClick += new DataGridViewCellEventHandler(dtgvInfoListOfBillExport_CellClick);
            btnUpdateBillExport.Click += new EventHandler(btnUpdateBillExport_Click);
            btnDeleteBillExport.Click += new EventHandler(btnDeleteBillExport_Click);

            txtTotalDebtExport.KeyPress += new KeyPressEventHandler(txtTotalDebtExport_KeyPress);
            txtTotalPayExport.KeyPress += new KeyPressEventHandler(txtTotalPayExport_KeyPress);

            txtIDBillExport.Text = DataProvider.ExcuteScalar(string.Format("SELECT MaHDB=dbo.fcGetMaHDB()"));
            LoadPhieuBanHang();
            ClearDisplay();
        }
        private void LoadPhieuBanHang()
        {
            List<HoaDonBanHang_DTO> listPhieuBan = HoaDonBanHang_BUS.LoadPhieuBan();
            dtgvInfoListOfBillExport.DataSource = listPhieuBan;
        }

        private void btnAddBillExport_Click(object sender, EventArgs e)
        {
            if (txtIDBillExport.Text == "" || txtNameStore.Text == "" || txtTotalPayExport.Text == "" ||
                txtTotalDebtExport.Text == "" || txtIDCustomer.Text == "")
            {
                MessageBox.Show("Bạn phải điền đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearDisplay();
                return;
            }

            HoaDonBanHang_DTO phieuban = new HoaDonBanHang_DTO();
            phieuban.MaHDB = txtIDBillExport.Text;
            phieuban.MaKH = txtIDCustomer.Text.ToString();
            phieuban.TenKH = txtNameCustomer.Text.ToString();
            phieuban.NgayNhap = Convert.ToDateTime(dtpkDateTimeExport.Text.ToString());
            phieuban.TenCH = txtNameStore.Text;
            phieuban.TongTien =Convert.ToDouble(txtTotalPayExport.Text.ToString());
            phieuban.TongNo =Convert.ToDouble(txtTotalDebtExport.Text.ToString());

            if (HoaDonBanHang_BUS.ThemPHBan(phieuban))
            {
                MessageBox.Show("Thêm Hóa đơn bán hàng thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPhieuBanHang();
                ClearDisplay();
                return;
            }
            MessageBox.Show("Thêm Hóa đơn bán hàng thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtgvInfoListOfBillExport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                txtIDBillExport.Text = Convert.ToString(dtgvInfoListOfBillExport.CurrentRow.Cells["MaHDB"].Value);
                txtNameStore.Text = Convert.ToString(dtgvInfoListOfBillExport.CurrentRow.Cells["TenCH"].Value);
                txtIDCustomer.Text = Convert.ToString(dtgvInfoListOfBillExport.CurrentRow.Cells["MaKH"].Value);
                txtNameCustomer.Text = Convert.ToString(dtgvInfoListOfBillExport.CurrentRow.Cells["TenKH"].Value);

                txtTotalDebtExport.Text = Convert.ToString(dtgvInfoListOfBillExport.CurrentRow.Cells["TongNo"].Value);
                txtTotalPayExport.Text = Convert.ToString(dtgvInfoListOfBillExport.CurrentRow.Cells["TongTien"].Value);
                dtpkDateTimeExport.Text = Convert.ToString(dtgvInfoListOfBillExport.CurrentRow.Cells["NgayNhap"].Value);
            }
        }

        private void btnUpdateBillExport_Click(object sender, EventArgs e)
        {
            if (txtIDBillExport.Text == "")
            {
                MessageBox.Show("Bạn phải chọn Hóa đơn cần chỉnh sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearDisplay();
                return;
            }
            HoaDonBanHang_DTO phieunhap = new HoaDonBanHang_DTO();
            phieunhap.MaHDB = (string)dtgvInfoListOfBillExport.CurrentRow.Cells["MaHDB"].Value;
            phieunhap.MaKH = txtIDCustomer.Text.ToString();
            phieunhap.TenKH = txtNameCustomer.Text.ToString();

            phieunhap.NgayNhap= Convert.ToDateTime(dtpkDateTimeExport.Text.ToString());
            phieunhap.TenCH = txtNameStore.Text;
            phieunhap.TongTien =Convert.ToDouble(txtTotalPayExport.Text.ToString());
            phieunhap.TongNo =Convert.ToDouble(txtTotalDebtExport.Text.ToString());

            if (HoaDonBanHang_BUS.SuaPHBan(phieunhap))
            {
                LoadPhieuBanHang();
                MessageBox.Show("Hóa đơn bán hàng cập nhật thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearDisplay();
                return;
            }
            MessageBox.Show("Hóa đơn bán hàng cập nhật thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnDeleteBillExport_Click(object sender, EventArgs e)
        {
            if (txtIDBillExport.Text == "")
            {
                MessageBox.Show("Bạn phải chọn Hóa đơn cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 ClearDisplay();
                return;
            }

            HoaDonBanHang_DTO phieuhang = new HoaDonBanHang_DTO();
            phieuhang.MaHDB = (string)dtgvInfoListOfBillExport.CurrentRow.Cells["MaHDB"].Value;
            if (HoaDonBanHang_BUS.XoaPHBan(phieuhang))
            {
                LoadPhieuBanHang();
                MessageBox.Show("Hóa đơn bán hàng xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearDisplay();
                return;
            }
            MessageBox.Show("Hóa đơn bán hàng xóa thất bại !\nBạn phải xóa Chi tiết Phiếu bán hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ClearDisplay()
        {
            txtIDBillExport.Text = DataProvider.ExcuteScalar(string.Format("SELECT MaHDB=dbo.fcGetMaHDB()"));
            txtNameStore.Text = "";
            txtNameCustomer.Text = "";
            txtTotalPayExport.Text = "";
            txtTotalDebtExport.Text = "";
            txtIDCustomer.Text = DataProvider.ExcuteScalar(string.Format("Select MaKH=dbo.fcGetMaKH()"));
        }
        private void txtTotalPayExport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void txtTotalDebtExport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void cbCheckInfoCustomer_Click(object sender, EventArgs e)
        {
            if (cbCheckInfoCustomer.Checked == true)
            {
                frmSearchInfoOfCustomer infoCutomer = new frmSearchInfoOfCustomer();
                infoCutomer.ShowDialog();
                txtIDCustomer.Text = uctSearchKhachHang.TxtMaKH;
                txtNameCustomer.Text = uctSearchKhachHang.TxtTenKH;
            }
            else
            {
                txtIDCustomer.Text = DataProvider.ExcuteScalar(string.Format("Select MaKH=dbo.fcGetMaKH()"));
            }

            if(txtIDCustomer.Text=="")
            {
                cbCheckInfoCustomer.Checked = false;
                txtIDCustomer.Text = DataProvider.ExcuteScalar(string.Format("Select MaKH=dbo.fcGetMaKH()"));
            }
        }

        private void lkbClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearDisplay();
        }

        #endregion

        #region Chi tiết Hóa đơn bán
        private void DataChiTietHoaDonBan()
        {

        }
        //private void LoadChiTietHoaDonBan()
        //{
        //    btnAddProductExportDetail.Click += new EventHandler(btnAddProductExportDetail_Click);
        //    dtgvListOfDetailProductExport.CellClick += new DataGridViewCellEventHandler(dtgvListOfDetailProductExport_CellClick);
        //    btnUpdateProductExportDetail.Click += new EventHandler(btnUpdateProductExportDetail_Click);
        //    btnDeleteProductExportDetail.Click += new EventHandler(btnDeleteProductExportDetail_Click);

        //    LoadMaSP();
        //    LoadChiTietPhieuBanHang();
        //}
        //private void LoadChiTietPhieuBanHang()
        //{
        //    List<ChiTietPhieuBan_DTO> listChiTietPhieuBan = ChiTietPhieuBan_BUS.LoadChiTietPhieuBan();
        //    dtgvListOfDetailProductExport.DataSource = listChiTietPhieuBan;
        //}
        //private void LoadMaSP()
        //{
        //    List<SanPhamCH_DTO> sanpham = SanPhamCH_BUS.LoadSanPhamCH();

        //    cmbIDProductDetailStore.DataSource = sanpham;
        //    cmbIDProductDetailStore.ValueMember = "MaSPCH";
        //    cmbIDProductDetailStore.DisplayMember = "MaSPCH";
        //}

        //private void btnAddProductExportDetail_Click(object sender, EventArgs e)
        //{
        //    if (txtIDBillExportDetail.Text == "" || cmbIDProductDetailStore.Text == "" || txtAmountOfProductExportDetail.Text == "")
        //    {
        //        MessageBox.Show("Bạn phải điền đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }

        //    ChiTietPhieuBan_DTO phieunhap = new ChiTietPhieuBan_DTO();
        //    phieunhap.MaPHBan = txtIDBillExportDetail.Text;
        //    phieunhap.MaSP = cmbIDProductDetailStore.Text;
        //    phieunhap.SoLuong = Convert.ToInt32(txtAmountOfProductExportDetail.Text.ToString());

        //    if (ChiTietPhieuBan_BUS.ThemChiTietPHBan(phieunhap))
        //    {
        //        MessageBox.Show("Thêm chi tiết phiếu Bán hàng thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        LoadChiTietPhieuBanHang();
        //        return;
        //    }
        //    MessageBox.Show("Thêm chi tiết phiếu Bán hàng thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //}

        //private void dtgvListOfDetailProductExport_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
        //    {
        //        txtIDBillExportDetail.Text = Convert.ToString(dtgvListOfDetailProductExport.CurrentRow.Cells["MaPHBan"].Value);
        //        cmbIDProductDetailStore.Text = Convert.ToString(dtgvListOfDetailProductExport.CurrentRow.Cells["MaSP"].Value);
        //        txtAmountOfProductExportDetail.Text = Convert.ToString(dtgvListOfDetailProductExport.CurrentRow.Cells["SoLuong"].Value);
        //    }
        //}

        //private void btnUpdateProductExportDetail_Click(object sender, EventArgs e)
        //{
        //    if (txtIDBillExportDetail.Text == "")
        //    {
        //        MessageBox.Show("Bạn phải chọn chi tiết phiếu cần chỉnh sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;
        //    }
        //    ChiTietPhieuBan_DTO phieunhap = new ChiTietPhieuBan_DTO();
        //    phieunhap.MaPHBan = (string)dtgvListOfDetailProductExport.CurrentRow.Cells["MaPHBan"].Value;
        //    phieunhap.MaSP = cmbIDProductDetailStore.Text;
        //    phieunhap.SoLuong = Convert.ToInt32(txtAmountOfProductExportDetail.Text.ToString());


        //    if (ChiTietPhieuBan_BUS.SuaChiTietPHBan(phieunhap))
        //    {
        //        LoadChiTietPhieuBanHang();
        //        MessageBox.Show("Chi tiết phiếu Bán hàng cập nhật thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        ClearDisplay();
        //        return;
        //    }
        //    MessageBox.Show("Chi tiết phiếu Bán hàng cập nhật thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

        //private void btnDeleteProductExportDetail_Click(object sender, EventArgs e)
        //{
        //    if (txtIDBillExportDetail.Text == "")
        //    {
        //        MessageBox.Show("Bạn phải chọn chi tiết phiếu cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;
        //    }

        //    ChiTietPhieuBan_DTO phieunhap = new ChiTietPhieuBan_DTO();
        //    phieunhap.MaSP = (string)dtgvListOfDetailProductExport.CurrentRow.Cells["MaSP"].Value;


        //    if (ChiTietPhieuBan_BUS.XoaChiTietPHBan(phieunhap))
        //    {
        //        LoadChiTietPhieuBanHang();
        //        MessageBox.Show("Chi tiết phiếu Bán hàng xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        ClearDisplay();
        //        return;
        //    }
        //    StringBuilder sError = new StringBuilder();
        //    sError.AppendLine("Chi tiết Phiếu Bán hàng xóa thất bại !");
        //    if (ChiTietPhieuBan_BUS.LoadChiTietPhieuBan().Count == 1)
        //    {
        //        sError.AppendLine("\nMỗi Phiếu bán hàng phải có ít nhất một Chi tiết Phiếu bán.");
        //    }

        //    MessageBox.Show(sError.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //}

        //private void ClearDisplay()
        //{
        //    txtIDBillExportDetail.Text = "";
        //    txtAmountOfProductExportDetail.Text = "";
        //}

        //private void txtAmountOfProductExportDetail_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        //    {
        //        e.Handled = true;
        //    }
        //}

        //private void frmDetailOfBillExport_Leave(object sender, EventArgs e)
        //{
        //    StringBuilder sLoi = new StringBuilder();

        //    if (string.IsNullOrEmpty(txtAmountOfProductExportDetail.Text.Trim()))
        //    {
        //        sLoi.AppendLine("Bạn chưa nhập số lượng sản phẩm");
        //        txtAmountOfProductExportDetail.Focus();
        //    }
        //    decimal newSoLuong;
        //    if (!Decimal.TryParse(txtAmountOfProductExportDetail.Text.Trim().ToString(), out newSoLuong) || newSoLuong <= 0)
        //    {
        //        sLoi.AppendLine("Số Lượng sản phẩm phải lớn hơn 0");
        //        txtAmountOfProductExportDetail.Focus();
        //    }

        //    if (!string.IsNullOrEmpty(sLoi.ToString()))
        //    {
        //        MessageBox.Show(sLoi.ToString());
        //    }
        //}

        #endregion
    }
}
