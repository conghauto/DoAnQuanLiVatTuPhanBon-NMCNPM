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
    public partial class uctQuanLiTienNoKhachHang : UserControl
    {
        public uctQuanLiTienNoKhachHang()
        {
            InitializeComponent();
        }
        public static uctQuanLiTienNoKhachHang uctQLTienNoKH = new uctQuanLiTienNoKhachHang();

        private void btnAddPayout_Click(object sender, EventArgs e)
        {
            if(txtPay.Text=="")
            {
                XtraMessageBox.Show("Bạn phải điền đầy đủ thông tin  !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            QuanLi_TienNoKH_DTO thanhtoan = new QuanLi_TienNoKH_DTO();
            thanhtoan.MaTT= txtIDPay.Text;
            thanhtoan.MaKH = txtIDCustomer.Text;
            thanhtoan.NgayTra = Convert.ToDateTime(dateTimePicker1.Text);
            thanhtoan.SoTienTra = Convert.ToDouble(txtPay.Text);
            thanhtoan.TinhTrang = 0;
            try
            {
                if(QuanLi_TienNoKH_BUS.ThemThongTinTienNo(thanhtoan))
                {
                    LoadThongTin_ThanhToanKH(txtIDCustomer.Text.ToString());
                   
                    txtIDPay.Text = DataProvider.ExcuteScalar(string.Format("SELECT MaTT=dbo.fcGetMaTT()"));
                    sum = ((double)sum - Double.Parse(txtPay.Text.ToString()));
                    txtTotalDebtOfPay.Text = sum.ToString();
                    XtraMessageBox.Show("Thêm thông tin thanh toán thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private double sum=0;
        public void LoadDSKH_NoTien()
        {
            List<HoaDonBanHang_DTO> khachhang = HoaDonBanHang_BUS.DS_KHNoTien();
            dtgvListCustomer.DataSource = khachhang;
            if (dtgvListCustomer.Rows.Count == 0)
            {
                dtgvListCustomer.ColumnCount = 2;
                dtgvListCustomer.ColumnHeadersVisible = true;
                dtgvListCustomer.Columns[0].Name = "MaKH";
                dtgvListCustomer.Columns[1].Name = "TenKH";

                dtgvListCustomer.Columns[0].DataPropertyName = "MaKH";
                dtgvListCustomer.Columns[1].DataPropertyName = "TenKH";

                dtgvListCustomer.Columns[0].HeaderText = "Mã KH";
                dtgvListCustomer.Columns[1].HeaderText = "Tên khách hàng";

                dtgvListCustomer.Columns[0].Width = 150;
                dtgvListCustomer.Columns[1].Width = 150;
            }
        }

        private void uctQuanLiTienNoKhachHang_Load(object sender, EventArgs e)
        {
            LoadDSKH_NoTien();
            dtgvListCustomer.CellClick += new DataGridViewCellEventHandler(dtgvListCustomer_CellClick);
            txtIDPay.Text = DataProvider.ExcuteScalar(string.Format("SELECT MaTT=dbo.fcGetMaTT()"));
        }

        private void LoadThongTin_ThanhToanKH(string s)
        {
            List<QuanLi_TienNoKH_DTO> ds = QuanLi_TienNoKH_BUS.ThongTinTienNo(s);
            dtgvListPay.DataSource = ds;
            if (dtgvListPay.Rows.Count == 0)
            {
                dtgvListPay.ColumnCount = 5;
                dtgvListPay.ColumnHeadersVisible = true;
                dtgvListPay.Columns[0].Name = "MaTT";
                dtgvListPay.Columns[1].Name = "MaKH";
                dtgvListPay.Columns[2].Name = "NgayTra";
                dtgvListPay.Columns[3].Name = "SoTienTra";
                dtgvListPay.Columns[4].Name = "TinhTrang";

                dtgvListPay.Columns[0].DataPropertyName = "MaTT";
                dtgvListPay.Columns[1].DataPropertyName = "MaKH";
                dtgvListPay.Columns[2].DataPropertyName = "NgayTra";
                dtgvListPay.Columns[3].DataPropertyName = "SoTienTra";
                dtgvListPay.Columns[4].DataPropertyName = "TinhTrang";

                dtgvListPay.Columns[0].HeaderText = "Mã TT";
                dtgvListPay.Columns[1].HeaderText = "Mã KH";
                dtgvListPay.Columns[2].HeaderText = "Ngày trả";
                dtgvListPay.Columns[3].HeaderText = "Số tiền trả";
                dtgvListPay.Columns[4].HeaderText = "Tình trạng";

                dtgvListPay.Columns[0].Width =100;
                dtgvListPay.Columns[1].Width =100;
                dtgvListPay.Columns[2].Width =100;
                dtgvListPay.Columns[3].Width = 100;
                dtgvListPay.Columns[4].Width = 100;
            }
        }
        private void dtgvListCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPay.Text = "";
            try
            {
                lbListBill.Items.Clear();
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    txtIDCustomer.Text = dtgvListCustomer.CurrentRow.Cells["MaKH"].Value.ToString();
                    txtNameCustomer.Text = dtgvListCustomer.CurrentRow.Cells["TenKH"].Value.ToString();

                    List<string> dsMaHDB = HoaDonBanHang_BUS.LoadDS_MaHDB(txtIDCustomer.Text.ToString());
                    if (dsMaHDB == null)
                        return;
                    else
                    {
                        foreach (string item in dsMaHDB)
                        {
                            lbListBill.Items.Add(item);
                        }
                    }
                   
                    string[] arr = HoaDonBanHang_BUS.DS_TongNo(txtIDCustomer.Text).ToArray();
                    txtTotalDebt.Text = arr[0];
                  
                    txtIDPay.Text = DataProvider.ExcuteScalar(string.Format("SELECT MaTT=dbo.fcGetMaTT()"));
                    LoadThongTin_ThanhToanKH(txtIDCustomer.Text.ToString());
                    sum = Convert.ToDouble(txtTotalDebt.Text.ToString());
                    txtTotalDebtOfPay.Text = "";
                    // UpdateTotalDebt();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void UpdateTotalDebt()
        {
                if (txtPay.Text != null)
                {
                    double temp = 0;

                    temp = Double.Parse(txtPay.ToString());
                    sum = sum - temp;
                    txtTotalDebtOfPay.Text = sum.ToString();
                }
    }
        private void btnDeletePay_Click(object sender, EventArgs e)
        {

            if (txtPay.Text == "")
            {
                XtraMessageBox.Show("Bạn phải điền đầy đủ thông tin  !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            QuanLi_TienNoKH_DTO thanhtoan = new QuanLi_TienNoKH_DTO();
            thanhtoan.MaTT = txtIDPay.Text;

            try
            {
                if (QuanLi_TienNoKH_BUS.XoaThongTinTienNo(thanhtoan))
                {
                    LoadDSKH_NoTien();
                    LoadThongTin_ThanhToanKH(txtIDCustomer.Text.ToString());
                  
                    txtIDPay.Text = DataProvider.ExcuteScalar(string.Format("SELECT MaTT=dbo.fcGetMaTT()"));
                    sum = ((double)sum + Double.Parse(txtPay.Text.ToString()));
                    txtTotalDebtOfPay.Text = sum.ToString();

                    txtPay.Text = "";
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

        private void dtgvListPay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    txtIDPay.Text= dtgvListPay.CurrentRow.Cells["MaTT"].Value.ToString();
                    txtPay.Text = dtgvListPay.CurrentRow.Cells["SoTienTra"].Value.ToString();
                    dateTimePicker1.Text = dtgvListPay.CurrentRow.Cells["NgayTra"].Value.ToString();
                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          
        }

        private void lbClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtPay.Text = "";
            txtIDPay.Text = DataProvider.ExcuteScalar(string.Format("SELECT MaTT=dbo.fcGetMaTT()"));
            txtTotalDebtOfPay.Text = "";
        }

      

        private void btnUpdateTotalDebt_Click(object sender, EventArgs e)
        {
            SqlConnection con = DataProvider.KetNoi();
            SqlCommand cmd = new SqlCommand("CAPNHAT_TIENNOKH", con);
            SqlCommand cmd1 =new SqlCommand("CAPNHAT_TINHTRANGKH", con);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd1.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@MaKH", txtIDCustomer.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TongNo", Convert.ToDouble(txtTotalDebtOfPay.Text));
                cmd.Parameters.Add(p);

                cmd.ExecuteNonQuery();
               

                SqlParameter p1 = new SqlParameter("@MaKH", txtIDCustomer.Text);
                cmd1.Parameters.Add(p1);
                cmd1.ExecuteNonQuery();

                DataProvider.DongKetNoi(con);
                XtraMessageBox.Show("Tổng nợ của khách hàng cập nhập thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                uctKhachHang.uctKH.LoadKhachHang();
                LoadDSKH_NoTien();
                LoadThongTin_ThanhToanKH(txtIDCustomer.Text.ToString());

                txtIDCustomer.Text = dtgvListCustomer.CurrentRow.Cells["MaKH"].Value.ToString();
                txtNameCustomer.Text = dtgvListCustomer.CurrentRow.Cells["TenKH"].Value.ToString();
                   
                // Load Data

                string[] arr = HoaDonBanHang_BUS.DS_TongNo(txtIDCustomer.Text).ToArray();
                txtTotalDebt.Text = arr[0];
                txtPay.Text = "";
                txtTotalDebtOfPay.Text = "";
                return;
            }
            catch
            {
                XtraMessageBox.Show("Tổng nợ của khách hàng cập nhập thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtPay_Click(object sender, EventArgs e)
        {
            txtPay.Text = "";
        }

        private void txtTotalDebt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void txtTotalDebtOfPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
