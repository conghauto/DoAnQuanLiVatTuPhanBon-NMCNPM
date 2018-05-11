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
using DevExpress.XtraEditors;

namespace QLCUAHANG_GUI
{
    public partial class uctSearchKhachHang : UserControl
    {
        public uctSearchKhachHang()
        {
            InitializeComponent();
        }
        public void LoadControl()
        {
            cmbFindCustomer.Items.Clear();
            cmbFindCustomer.Items.Add("MaKH");
            cmbFindCustomer.Items.Add("Tên Khách hàng");
        }

        private void uctSearchKhachHang_Load(object sender, EventArgs e)
        {
            cmbFindCustomer.Text="MaKH";
            LoadControl();
        }

        private void btnSearchResult_Click(object sender, EventArgs e)
        {
            if (txtSearchCustomer.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập nội dung tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                List<KhachHang_DTO> listResult = new List<KhachHang_DTO>();
                if (cmbFindCustomer.Text == "Mã KH")
                {
                    string s = txtSearchCustomer.Text.ToString();
                    listResult = KhachHang_BUS.TimKiemKhachHang2(s);
                    if (listResult.Count>0)
                    {
                        XtraMessageBox.Show("Kết quả tìm thấy !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtgvListResultCustomer.DataSource = listResult;
                    }
                    else
                    {
                        XtraMessageBox.Show("Kết quả không tìm thấy !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    
                }
                else
                {
                    string s = txtSearchCustomer.Text.ToString();
                    listResult = KhachHang_BUS.TimKiemKhachHang(s);
                    if (listResult.Count>0)
                    {
                        XtraMessageBox.Show("Kết quả tìm thấy !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtgvListResultCustomer.DataSource = listResult;
                    }
                    else
                    {
                        XtraMessageBox.Show("Kết quả không tìm thấy !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                }
            }
        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            List<KhachHang_DTO> listResult = new List<KhachHang_DTO>();
            if (cmbFindCustomer.Text=="MaKH")
            {
                string s = txtSearchCustomer.Text.ToString();
                listResult = KhachHang_BUS.TimKiemKhachHang2(s);
                dtgvListResultCustomer.DataSource = listResult;
            }
            if (cmbFindCustomer.Text == "Tên Khách hàng")
            {
                string s = txtSearchCustomer.Text.ToString();
                listResult = KhachHang_BUS.TimKiemKhachHang(s);
                dtgvListResultCustomer.DataSource = listResult;
            }
        }
        private int i = 0;
        private static string txtMaKH;
        private static string txtTenKH;

        public static string TxtMaKH
        {
            get
            {
                return txtMaKH;
            }

            set
            {
                txtMaKH = value;
            }
        }

        public static string TxtTenKH
        {
            get
            {
                return txtTenKH;
            }

            set
            {
                txtTenKH = value;
            }
        }
        public void LoadDisplay()
        {
            dtgvListResultCustomer.CellClick += new DataGridViewCellEventHandler(dtgvListResultCustomer_CellClick);
        }
        private void dtgvListResultCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0&&e.ColumnIndex>=0)
            {
                dtgvListResultCustomer.CurrentRow.DefaultCellStyle.BackColor = Color.Orange;
                TxtMaKH = Convert.ToString(dtgvListResultCustomer.CurrentRow.Cells["MaKH"].Value);
                TxtTenKH = Convert.ToString(dtgvListResultCustomer.CurrentRow.Cells["TenKH"].Value);
                if ((MessageBox.Show("Bạn lựa chọn Khách hàng\nMã KH: "+txtMaKH+"\nTên KH: "+txtTenKH+"\nđiền vào Hóa đơn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK))
                {
                    i = 1;
                }
            }
            else
            {
                MessageBox.Show("Không có thông tin Khách hàng tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public int getTest()
        {
            return i;
        }
    }
}
