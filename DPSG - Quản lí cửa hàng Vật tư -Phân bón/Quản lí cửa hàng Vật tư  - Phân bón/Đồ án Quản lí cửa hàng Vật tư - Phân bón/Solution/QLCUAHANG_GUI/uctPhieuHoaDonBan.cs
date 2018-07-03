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
            LoadPhieuBanHang();
            btnAddBillExport.Click += new EventHandler(btnAddBillExport_Click);
            dtgvInfoListOfBillExport.CellClick += new DataGridViewCellEventHandler(dtgvInfoListOfBillExport_CellClick);
            btnUpdateBillExport.Click += new EventHandler(btnUpdateBillExport_Click);
            btnDeleteBillExport.Click += new EventHandler(btnDeleteBillExport_Click);

            txtTotalDebtExport.KeyPress += new KeyPressEventHandler(txtTotalDebtExport_KeyPress);
            txtTotalPayExport.KeyPress += new KeyPressEventHandler(txtTotalPayExport_KeyPress);

            txtIDBillExport.Text = DataProvider.ExcuteScalar(string.Format("SELECT MaHDB=dbo.fcGetMaHDB()"));
            txtIDCustomer.Text = DataProvider.ExcuteScalar(string.Format("Select MaKH=dbo.fcGetMaKH()"));
           
            txtNameStore.Text = "Vật tư tổng hợp";
            txtTotalDebtExport.Text = "0";
            txtTotalPayExport.Text = "0";
        }
        private void LoadPhieuBanHang()
        {
            List<HoaDonBanHang_DTO> listPhieuBan = HoaDonBanHang_BUS.LoadPhieuBan();
            dtgvInfoListOfBillExport.DataSource = listPhieuBan;
        }

        private void btnAddBillExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDBillExport.Text == "" || txtNameStore.Text == "" || txtTotalPayExport.Text == "" ||
                    txtTotalDebtExport.Text == "" || txtIDCustomer.Text == "")
                {
                    XtraMessageBox.Show("Bạn phải điền đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                HoaDonBanHang_DTO phieuban = new HoaDonBanHang_DTO();
                phieuban.MaHDB = txtIDBillExport.Text;
                phieuban.MaKH = txtIDCustomer.Text.ToString();
                phieuban.TenKH = txtNameCustomer.Text.ToString();
                phieuban.NgayNhap = Convert.ToDateTime(dtpkDateTimeExport.Text.ToString());
                phieuban.TenCH = txtNameStore.Text;
                phieuban.TongTien = Convert.ToDouble(txtTotalPayExport.Text.ToString());
                phieuban.TongNo = Convert.ToDouble(txtTotalDebtExport.Text.ToString());
                phieuban.GhiChu = txtNote.Text;

                if (HoaDonBanHang_BUS.ThemPHBan(phieuban))
                {
                    uctKhachHang.uctKH.LoadKhachHang();
                    LoadPhieuBanHang();
                    LoadHoaDonBan();
                    cmbIDBillExportDetail.Text = txtIDBillExport.Text;
                    uctQuanLiTienNoKhachHang.uctQLTienNoKH.LoadDSKH_NoTien();
                    ClearDisplay();

                    XtraMessageBox.Show("Thêm Hóa đơn bán hàng thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }
            }catch
            {
                XtraMessageBox.Show("Thêm Hóa đơn bán hàng thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dtgvInfoListOfBillExport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
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
                    cmbIDBillExportDetail.Text = txtIDBillExport.Text;
                    txtNote.Text= Convert.ToString(dtgvInfoListOfBillExport.CurrentRow.Cells["GhiChu"].Value);
                }
                else
                    return;
            }
            catch
            {
                return;
            }
        }

        private void btnUpdateBillExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDBillExport.Text == "" || txtNameStore.Text == "" || txtTotalPayExport.Text == "" ||
                    txtTotalDebtExport.Text == "" || txtIDCustomer.Text == "")
                {
                    XtraMessageBox.Show("Bạn phải chọn Hóa đơn cần chỉnh sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay();
                    return;
                }
                HoaDonBanHang_DTO phieunhap = new HoaDonBanHang_DTO();
                phieunhap.MaHDB = (string)dtgvInfoListOfBillExport.CurrentRow.Cells["MaHDB"].Value;
                phieunhap.MaKH = txtIDCustomer.Text.ToString();
                phieunhap.TenKH = txtNameCustomer.Text.ToString();

                phieunhap.NgayNhap = Convert.ToDateTime(dtpkDateTimeExport.Text.ToString());
                phieunhap.TenCH = txtNameStore.Text;
                phieunhap.TongTien = Convert.ToDouble(txtTotalPayExport.Text.ToString());
                phieunhap.TongNo = Convert.ToDouble(txtTotalDebtExport.Text.ToString());
                phieunhap.GhiChu = txtNote.Text;

                if (HoaDonBanHang_BUS.SuaPHBan(phieunhap))
                {
                    LoadPhieuBanHang();
                    uctKhachHang.uctKH.LoadKhachHang();
                    LoadHoaDonBan();
                    uctQuanLiTienNoKhachHang.uctQLTienNoKH.LoadDSKH_NoTien();
                    XtraMessageBox.Show("Hóa đơn bán hàng cập nhật thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearDisplay();
                    return;
                }
            }catch
            {
                XtraMessageBox.Show("Hóa đơn bán hàng cập nhật thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void btnDeleteBillExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDBillExport.Text == "" || txtNameStore.Text == "" || txtTotalPayExport.Text == "" ||
                    txtTotalDebtExport.Text == "" || txtIDCustomer.Text == "")
                {
                    XtraMessageBox.Show("Bạn phải chọn Hóa đơn cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay();
                    return;
                }

                HoaDonBanHang_DTO phieuhang = new HoaDonBanHang_DTO();
                phieuhang.MaHDB = txtIDBillExport.Text;
                if (HoaDonBanHang_BUS.XoaPHBan(phieuhang))
                {
                    LoadPhieuBanHang();
                    LoadHoaDonBan();

                    uctKhachHang.uctKH.LoadKhachHang();
                    uctQuanLiTienNoKhachHang.uctQLTienNoKH.LoadDSKH_NoTien();
                    ClearDisplay();
                    XtraMessageBox.Show("Hóa đơn bán hàng xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }
            }
            catch
            {
                XtraMessageBox.Show("Hóa đơn bán hàng xóa thất bại !\nBạn phải xóa Chi tiết Phiếu bán hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
        }
        private void ClearDisplay()
        {
            txtIDBillExport.Text = DataProvider.ExcuteScalar(string.Format("SELECT MaHDB=dbo.fcGetMaHDB()"));
            txtNameStore.Text = "Vật tư tổng hợp";
            txtNameCustomer.Text = "";
            txtTotalPayExport.Text = "";
            txtTotalDebtExport.Text = "";
            cbCheckInfoCustomer.Checked = false;
            txtIDCustomer.Text = DataProvider.ExcuteScalar(string.Format("Select MaKH=dbo.fcGetMaKH()"));
            txtNote.Text = "";
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

            if (txtIDCustomer.Text == "")
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
            LoadChiTietHoaDonBan();
        }
        private void LoadChiTietHoaDonBan()
        {
            btnAddProductExportDetail.Click += new EventHandler(btnAddProductExportDetail_Click);

            btnUpdateProductExportDetail.Click += new EventHandler(btnUpdateProductExportDetail_Click);
            btnDeleteProductExportDetail.Click += new EventHandler(btnDeleteProductExportDetail_Click);
            txtAmountOfProductExportDetail.KeyPress += new KeyPressEventHandler(txtAmountOfProductExportDetail_KeyPress);

            LoadChiTietPhieuBanHang();
            LoadMaSP();
            LoadHoaDonBan();
            txtRetail.Text = "0";
            txtAmountOfProductExportDetail.Text = "0";

            if (cbRetail.Checked ==false)
            {
                txtRetail.Enabled = false;
                txtRetail.Text = "0";

            }
        }
        private void LoadChiTietPhieuBanHang()
        {
            List<ChiTietHoaDonBan_DTO> listChiTietPhieuBan = ChiTietHoaDonBan_BUS.LoadChiTietPhieuBan();
            dtgvDetailBillSale.DataSource = listChiTietPhieuBan;
        }
        private void LoadHoaDonBan()
        {
            List<HoaDonBanHang_DTO> hd = HoaDonBanHang_BUS.LoadPhieuBan();
            cmbIDBillExportDetail.DataSource = hd;
            cmbIDBillExportDetail.ValueMember = "MaHDB";
            cmbIDBillExportDetail.DisplayMember = "MaHDB";
        }
        private void LoadMaSP()
        {
            List<SanPhamCH_DTO> sanpham = SanPhamCH_BUS.LoadSanPHamCH();

            cmbIDProductDetailStore.DataSource = sanpham;
            cmbIDProductDetailStore.ValueMember = "MaSPCH";
            cmbIDProductDetailStore.DisplayMember = "MaSPCH";
        }

        private void btnAddProductExportDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbIDBillExportDetail.Text == "" || cmbIDProductDetailStore.Text == "" || txtAmountOfProductExportDetail.Text == "")
            {
                XtraMessageBox.Show("Bạn phải điền đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ChiTietHoaDonBan_DTO phieunhap = new ChiTietHoaDonBan_DTO();
            phieunhap.MaHDB = cmbIDBillExportDetail.Text;
            phieunhap.MaSPCH = cmbIDProductDetailStore.Text;
            if (txtAmountOfProductExportDetail.Text == "")
                phieunhap.SoLuong = 0;
            else
                phieunhap.SoLuong = Convert.ToInt32(txtAmountOfProductExportDetail.Text.ToString());

            phieunhap.DonViTinh = cmbUnitCalculator.Text;
            phieunhap.SoLuongMuaLe = Convert.ToInt32(txtRetail.Text.ToString());
            if (cbRetail.Checked == true)
            {
                phieunhap.HinhThucBan = 1;
            }
            else
                phieunhap.HinhThucBan = 0;

            
                if (ChiTietHoaDonBan_BUS.ThemChiTietPHBan(phieunhap))
                {
                   LoadPhieuBanHang();
                   LoadChiTietPhieuBanHang();
                    uctSanPhamCH.uctSPCH.LoadSanPhamCH1();
                    XtraMessageBox.Show("Thêm chi tiết hóa đơn bán hàng thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearDisplay1();
                    return;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnUpdateProductExportDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbIDBillExportDetail.Text == "" || cmbIDProductDetailStore.Text == "" || txtAmountOfProductExportDetail.Text == "")
                {
                    XtraMessageBox.Show("Bạn phải chọn chi tiết phiếu cần chỉnh sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbIDBillExportDetail.Text != (string)dtgvDetailBillSale.CurrentRow.Cells["MaHDB1"].Value || cmbIDProductDetailStore.Text != (string)dtgvDetailBillSale.CurrentRow.Cells["MaSPCH"].Value)
                {
                    XtraMessageBox.Show("Chi tiết hóa đơn bán hàng cập nhật thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ChiTietHoaDonBan_DTO phieunhap = new ChiTietHoaDonBan_DTO();
                phieunhap.MaHDB = (string)dtgvDetailBillSale.CurrentRow.Cells["MaHDB1"].Value;
                phieunhap.MaSPCH = (string)dtgvDetailBillSale.CurrentRow.Cells["MaSPCH"].Value;

                phieunhap.SoLuong = Convert.ToInt32(txtAmountOfProductExportDetail.Text.ToString());
                phieunhap.DonViTinh = cmbUnitCalculator.Text;


                if (cbRetail.Checked == true)
                {
                    phieunhap.HinhThucBan = 1;
                    phieunhap.SoLuongMuaLe = Convert.ToInt32(txtRetail.Text.ToString());
                }
                else
                {
                    phieunhap.HinhThucBan = 0;
                    phieunhap.SoLuongMuaLe = 0;
                }

                if (ChiTietHoaDonBan_BUS.SuaChiTietPHBan(phieunhap))
                {
                    LoadPhieuBanHang();
                    LoadChiTietPhieuBanHang();
                    uctSanPhamCH.uctSPCH.LoadSanPhamCH1();
                    XtraMessageBox.Show("Chi tiết hóa đơn bán hàng cập nhật thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearDisplay1();
                    return;
                }
            }catch
            {
                XtraMessageBox.Show("Chi tiết hóa đơn bán hàng cập nhật thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnDeleteProductExportDetail_Click(object sender, EventArgs e)
        {
            try {
            if (cmbIDBillExportDetail.Text == ""||cmbIDProductDetailStore.Text==""||txtAmountOfProductExportDetail.Text=="")
            {
                XtraMessageBox.Show("Bạn phải chọn chi tiết phiếu cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
                ChiTietHoaDonBan_DTO phieunhap = new ChiTietHoaDonBan_DTO();
                phieunhap.MaHDB = (string)dtgvDetailBillSale.CurrentRow.Cells["MaHDB1"].Value;
                phieunhap.MaSPCH = cmbIDProductDetailStore.Text;

                if (ChiTietHoaDonBan_BUS.XoaChiTietPHBan(phieunhap))
                {
                    LoadPhieuBanHang();
                    LoadChiTietPhieuBanHang();
                    uctSanPhamCH.uctSPCH.LoadSanPhamCH1();
                    XtraMessageBox.Show("Chi tiết phiếu Bán hàng xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearDisplay1();
                    if(dtgvDetailBillSale.Rows.Count==0)
                    {
                        dtgvDetailBillSale.ColumnCount = 6;
                        dtgvDetailBillSale.ColumnHeadersVisible = true;
                        dtgvDetailBillSale.Columns[0].Name = "MaHDB1";
                        dtgvDetailBillSale.Columns[1].Name = "MaSPCH";
                        dtgvDetailBillSale.Columns[2].Name = "SoLuong";
                        dtgvDetailBillSale.Columns[3].Name = "DonViTinh";
                        dtgvDetailBillSale.Columns[4].Name = "HinhThucBan";
                        dtgvDetailBillSale.Columns[5].Name = "SoLuongMuaLe";

                        dtgvDetailBillSale.Columns[0].DataPropertyName = "MaHDB";
                        dtgvDetailBillSale.Columns[1].DataPropertyName = "MaSPCH";
                        dtgvDetailBillSale.Columns[2].DataPropertyName = "SoLuong";
                        dtgvDetailBillSale.Columns[3].DataPropertyName = "DonViTinh";
                        dtgvDetailBillSale.Columns[4].DataPropertyName = "HinhThucBan";
                        dtgvDetailBillSale.Columns[5].DataPropertyName = "SoLuongMuaLe";

                        dtgvDetailBillSale.Columns[0].HeaderText = "Mã HDB";
                        dtgvDetailBillSale.Columns[1].HeaderText = "Mã SPCH";
                        dtgvDetailBillSale.Columns[2].HeaderText = "Số lượng";
                        dtgvDetailBillSale.Columns[3].HeaderText = "Đơn vị tính";
                        dtgvDetailBillSale.Columns[4].HeaderText = "Hình thức bán";
                        dtgvDetailBillSale.Columns[5].HeaderText = "Số lượng mua lẻ";

                        dtgvDetailBillSale.Columns[0].Width =75;
                        dtgvDetailBillSale.Columns[1].Width = 80;
                        dtgvDetailBillSale.Columns[2].Width = 75;
                        dtgvDetailBillSale.Columns[3].Width =85;
                        dtgvDetailBillSale.Columns[4].Width = 100;
                        dtgvDetailBillSale.Columns[5].Width = 120;
                    }
                    return;
                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void ClearDisplay1()
        {
            cmbIDProductDetailStore.Text = "";
            txtAmountOfProductExportDetail.Text = "0";
            cmbUnitCalculator.Text = "";
            cbRetail.Checked = false;
            txtRetail.Text = "0";
        }

        private void txtAmountOfProductExportDetail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void dtgvDetailBillSale_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    cmbIDBillExportDetail.Text = (string)dtgvDetailBillSale.CurrentRow.Cells["MaHDB1"].Value;
                    cmbIDProductDetailStore.Text = dtgvDetailBillSale.CurrentRow.Cells["MaSPCH"].Value.ToString();
                    txtAmountOfProductExportDetail.Text = dtgvDetailBillSale.CurrentRow.Cells["SoLuong"].Value.ToString();
                    cmbUnitCalculator.Text= dtgvDetailBillSale.CurrentRow.Cells["DonViTinh"].Value.ToString();
                    if (dtgvDetailBillSale.CurrentRow.Cells["HinhThucBan"].Value.ToString() == "1")
                    {
                        txtRetail.Enabled = true;
                        cbRetail.Checked = true;
                    }
                    else
                    {
                        txtRetail.Text = "0";
                        txtRetail.Enabled =false;
                        cbRetail.Checked =false;
                       
                    }
                        
                    if (cbRetail.Checked==true)
                    {
                        txtRetail.Text = dtgvDetailBillSale.CurrentRow.Cells["SoLuongMuaLe"].Value.ToString();
                    }
                        
                }
                else
                    return;
            }
            catch
            {
                return;
            }
        }

        private void cbRetail_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRetail.Checked == true)
            {
                txtRetail.Text = "0";
                txtRetail.Enabled = true;
            }

            else
            {
                txtRetail.Text = "0";
               txtRetail.Enabled = false;
            }
        }

        private void cbRetail_Click(object sender, EventArgs e)
        {
            txtRetail.Text = "";
        }

        private void txtAmountOfProductExportDetail_Click(object sender, EventArgs e)
        {
            txtAmountOfProductExportDetail.Text = "";
        }

        private void cmbIDProductDetailStore_TextChanged_1(object sender, EventArgs e)
        {
            cmbUnitCalculator.Text = ChiTietHoaDonBan_BUS.TimDonViSanPham(cmbIDProductDetailStore.Text.ToString());

        }

        private void txtAmountOfProductExportDetail_TextChanged(object sender, EventArgs e)
        {
            int num;
            if (txtAmountOfProductExportDetail.Text == "")
                num = 0;
            else
                num = Convert.ToInt32(txtAmountOfProductExportDetail.Text.ToString());
            int num1 = Convert.ToInt32(ChiTietHoaDonBan_BUS.SoLuongMax(cmbIDProductDetailStore.Text.ToString()));
            if (num < 0)
                XtraMessageBox.Show("Số lượng sản phẩm nhỏ hơn 0 !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (num > num1)
                XtraMessageBox.Show("Sản phẩm trong Cửa hàng không đủ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }


        #endregion

        private void txtRetail_Click(object sender, EventArgs e)
        {
            txtRetail.Text = "";
        }

        private void txtTotalDebtExport_Click(object sender, EventArgs e)
        {
            txtTotalDebtExport.Text = "";
        }

        private void lkbClear1_Click(object sender, EventArgs e)
        {
            ClearDisplay1();
        }

        private void txtTotalPayExport_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtAmountOfProductExportDetail_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtRetail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
