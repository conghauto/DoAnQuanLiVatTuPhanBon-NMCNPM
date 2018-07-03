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
using DevExpress.XtraEditors;

namespace QLCUAHANG_GUI
{
    public partial class uctSanPhamDL : UserControl
    {
        public uctSanPhamDL()
        {
            InitializeComponent();
            LoadDataSanPhamDL();
        }
     
        public static uctSanPhamDL uctSPDL = new uctSanPhamDL();

        #region Sản phẩm của Đại Lí
        private void LoadDataSanPhamDL()
        {
           
            LoadSanPhamDL();
            LoadCmbMaDL();
            btnAddProductAgency.Click += new EventHandler(btnAddProductAgency_Click);
            btnUpdateProductAgency.Click += new EventHandler(btnUpdateProductAgency_Click);
            dtgvProductListOfAgency.CellClick += new DataGridViewCellEventHandler(dtgvProductListOfAgency_CellClick);
            btnDeleteProductAgency.Click += new EventHandler(btnDeleteProductAgency_Click);

            txtPriceDL.KeyPress += new KeyPressEventHandler(txtPriceDL_KeyPress);

            ClearDisplay();
        }
  
        private void LoadSanPhamDL()
        {
            List<SanPhamDL_DTO> listSP = SanPhamDL_BUS.LoadSanPhamDL();
            dtgvProductListOfAgency.DataSource = listSP;
        }

        private void btnAddProductAgency_Click(object sender, EventArgs e)
        {
            
                if (txtIDProductDL.Text == "" || txtNameProductDL.Text == "" || cmbIDAgency.Text == "" || txtUnitDL.Text == "" || txtPriceDL.Text == "" || txtParameter.Text == "")
                {
                    XtraMessageBox.Show("Bạn phải điền đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay();
                    return;
                }
                SanPhamDL_DTO sanpham = new SanPhamDL_DTO();
                sanpham.MaSPDL = txtIDProductDL.Text;
                sanpham.TenSP = txtNameProductDL.Text;
                sanpham.MaDL = cmbIDAgency.SelectedValue.ToString();
                sanpham.DonVi = txtUnitDL.Text;
                sanpham.Gia = Double.Parse(txtPriceDL.Text.ToString());
                sanpham.ThongSo = txtParameter.Text.ToString();

            try
            {
                if (SanPhamDL_BUS.ThemSPDL(sanpham))
                {
                    XtraMessageBox.Show("Thêm Sản phẩm Đại Lí thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSanPhamDL();
                    uctSanPhamCH.uctSPCH.LoadSanPhamCH1();
                    ClearDisplay();

                    return;
                }
            }catch(Exception ex)
            {
                XtraMessageBox.Show("Thêm Sản phẩm Đại Lí thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    
        public void LoadCmbMaDL()
        {
            List<DaiLi_DTO> listDaiLi = DaiLi_BUS.LoadDaiLi();
            cmbIDAgency.DataSource = listDaiLi;
            cmbIDAgency.DisplayMember = "MaDL"; // Giá trị hiển thị
            cmbIDAgency.ValueMember = "MaDL";//Giá trị cần lấy
        }

        private void dtgvProductListOfAgency_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtIDProductDL.Text = Convert.ToString(dtgvProductListOfAgency.CurrentRow.Cells["MaSPDL"].Value);
                txtNameProductDL.Text = Convert.ToString(dtgvProductListOfAgency.CurrentRow.Cells["TenSP"].Value);
                cmbIDAgency.Text = Convert.ToString(dtgvProductListOfAgency.CurrentRow.Cells["MaDL"].Value);
                txtPriceDL.Text = Convert.ToString(dtgvProductListOfAgency.CurrentRow.Cells["Gia"].Value);
                txtUnitDL.Text = Convert.ToString(dtgvProductListOfAgency.CurrentRow.Cells["DonVi"].Value);
                txtParameter.Text= Convert.ToString(dtgvProductListOfAgency.CurrentRow.Cells["ThongSo"].Value);
                if (txtUnitDL.Text == "bao")
                    rbKg.Checked = true;
                else
                    rbMl.Checked = true;
            }
        }

        private void ClearDisplay()
        {
            txtIDProductDL.Text = DataProvider.ExcuteScalar(string.Format("SELECT MaSPDL=dbo.fcGetMaSP()"));
            txtNameProductDL.Text = "";
            cmbIDAgency.Text = "";
            txtUnitDL.Text = "";
            txtPriceDL.Text = "";
            txtParameter.Text = "";
        }
        private void btnUpdateProductAgency_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDProductDL.Text == "" || txtNameProductDL.Text == "" || cmbIDAgency.Text == "" || txtUnitDL.Text == "" || txtPriceDL.Text == "" || txtParameter.Text == "")
                {
                    XtraMessageBox.Show("Bạn phải điền đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay();
                    return;
                }

                SanPhamDL_DTO sanpham = new SanPhamDL_DTO();
                sanpham.MaSPDL = txtIDProductDL.Text;
                sanpham.TenSP = txtNameProductDL.Text;
                sanpham.MaDL = cmbIDAgency.SelectedValue.ToString();
                sanpham.DonVi = txtUnitDL.Text;
                sanpham.Gia = Double.Parse(txtPriceDL.Text.ToString());
                sanpham.ThongSo = txtParameter.Text;

                if (SanPhamDL_BUS.SuaSPDL(sanpham))
                {
                    XtraMessageBox.Show("Sửa thông tin Sản phẩm Đại Lí thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSanPhamDL();
                    uctSanPhamCH.uctSPCH.LoadSanPhamCH1();
                    ClearDisplay();

                    return;
                }
            }catch
            {
                XtraMessageBox.Show("Sửa thông tin Sản Phẩm Đại Lí thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        public void btnDeleteProductAgency_Click(object sender, EventArgs e)
        {
            try
            {
                SanPhamDL_DTO sanpham = new SanPhamDL_DTO();
                sanpham.MaSPDL = (string)dtgvProductListOfAgency.CurrentRow.Cells["MaSPDL"].Value;

                if (txtIDProductDL.Text == "" || txtNameProductDL.Text == "" || cmbIDAgency.Text == "" || txtUnitDL.Text == "" || txtPriceDL.Text == "")
                {
                    XtraMessageBox.Show("Bạn phải chọn Sản phẩm để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay();
                    return;
                }

                if (SanPhamDL_BUS.XoaSPDL(sanpham))
                {
                    LoadSanPhamDL();
                    XtraMessageBox.Show("Xóa Sản phẩm Đại lí thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearDisplay();
                    return;
                }
            }catch
            {
                XtraMessageBox.Show("Xóa Sản phẩm Đại lí thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtPriceDL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtAmountDL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        #endregion

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearDisplay();
        }

        private void txtParameter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
