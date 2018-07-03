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
using System.IO;
using QLCUAHANG_DAL;
using System.Data.SqlClient;
using QLCUAHANG_GUI.Properties;
using System.Web;
using System.Drawing.Imaging;
using DevExpress.XtraEditors;

namespace QLCUAHANG_GUI
{
    public partial class uctSanPhamCH : UserControl
    {
        public uctSanPhamCH()
        {
            InitializeComponent();
        }

        public static uctSanPhamCH uctSPCH = new uctSanPhamCH();
        private void LoadDataStore()
        {
            LoadSanPhamCH1();
            btnUpdateProductStore.Click += new EventHandler(btnUpdateProductStore_Click);
            dtgvProductListOfStore.CellClick += new DataGridViewCellEventHandler(dtgvProductListOfStore_CellClick);
            btnDeleteProductStore.Click += new EventHandler(btnDeleteProductStore_Click);
            Display();
            txtAmountOfProductCH.KeyPress += new KeyPressEventHandler(txtAmountOfProductCH_KeyPress);
            txtPriceCH.KeyPress += new KeyPressEventHandler(txtPriceCH_KeyPress);
        }

        private DataTable dt;
        public void LoadSanPhamCH1()
        {

            try
            {
                SqlConnection con = DataProvider.KetNoi();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("DSSanPhamCH", con);
                dt = new DataTable();
                adapter.Fill(dt);
                dtgvProductListOfStore.DataSource = dt;
                return;
            }
            catch
            {
                return;
            }

        }
        int imageIndex = 0;
        private void Display()
        {
            imageIndex = 0;
            if (dt.Rows.Count != 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                        Image image;    
                        if (dt.Rows[i]["HinhAnh"].ToString() == "" || dt.Rows[i]["HinhAnh"].ToString() == null)
                        {
                            image = Resources.noimage;
                        }
                        else
                        {
                            image = Image.FromFile(dt.Rows[i]["HinhAnh"].ToString());
                        }
                        imageList.Images.Add(image);
                        var viewItem = new ListViewItem(dt.Rows[i][1].ToString());
                        { };

                        viewItem.ImageIndex = imageIndex;
                        lvListImageProduct.Items.Add(viewItem);

                        imageIndex++;
                    }
            }
        }

        private void ClearDisplay()
        {
            txtIDProductCH.Text = "";
            txtNameProductCH.Text = "";
            pictureBox.BackgroundImage = null;
            txtUnitCH.Text = "";
            txtPriceCH.Text = "";
            txtAmountOfProductCH.Text = "";
            pictureBox.Image = null;
            txtParameter.Text = "";
            txtAmonutRetail.Text = "";
            cbRetail.Checked = false;
        }
        private void dtgvProductListOfStore_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtIDProductCH.Text = Convert.ToString(dtgvProductListOfStore.CurrentRow.Cells["MaSPCH"].Value);
                txtNameProductCH.Text = Convert.ToString(dtgvProductListOfStore.CurrentRow.Cells["TenSP"].Value);

                txtPriceCH.Text = Convert.ToString(dtgvProductListOfStore.CurrentRow.Cells["Gia"].Value);
                txtUnitCH.Text = Convert.ToString(dtgvProductListOfStore.CurrentRow.Cells["DonVi"].Value);
                txtAmountOfProductCH.Text = Convert.ToString(dtgvProductListOfStore.CurrentRow.Cells["SoLuong"].Value);
                string s = string.Format(dtgvProductListOfStore.CurrentRow.Cells["HinhAnh"].Value.ToString());

                if (Convert.ToInt32(dtgvProductListOfStore.CurrentRow.Cells["BanLe"].Value) == 1)
                {
                    cbRetail.Checked = true;
                    txtAmonutRetail.Text = dtgvProductListOfStore.CurrentRow.Cells["SoLuongLe"].Value.ToString();
                }
                else
                {
                    cbRetail.Checked = false;
                    txtAmonutRetail.Text = "0";
                    txtAmonutRetail.Enabled = false;
                }
                try
                {
                    if (s == "" || s == null)
                        pictureBox.Image = Resources.noimage;
                    else
                        pictureBox.Image = Image.FromFile(s);
                }
                catch
                {
                    pictureBox.Image = Resources.noimage;
                }

                if (txtUnitCH.Text == "bao")
                    rbKg.Checked = true;
                else
                    rbMl.Checked = true;

                imageLocation = s;
                txtParameter.Text = dtgvProductListOfStore.CurrentRow.Cells["ThongSo"].Value.ToString();
            }
        }

      

        private string imageLocation = "";
       

        private void btnUpdateProductStore_Click(object sender, EventArgs e)
        {
            if (txtIDProductCH.Text == "" || txtNameProductCH.Text == "" || txtUnitCH.Text == "" || txtPriceCH.Text == "" || txtAmountOfProductCH.Text == "")
            {
                XtraMessageBox.Show("Bạn phải điền đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearDisplay();
                return;
            }
            try
            {

                SanPhamCH_DTO sanpham = new SanPhamCH_DTO();
                sanpham.MaSPCH = txtIDProductCH.Text;
                sanpham.TenSP = txtNameProductCH.Text;

                sanpham.DonVi = txtUnitCH.Text;
                sanpham.Gia = Double.Parse(txtPriceCH.Text.ToString());
                sanpham.SoLuong = Int32.Parse(txtAmountOfProductCH.Text.ToString());
                sanpham.HinhAnh = imageLocation;
                sanpham.ThongSo = txtParameter.Text;

                if (cbRetail.Checked == true)
                {
                    sanpham.BanLe = 1;
                    sanpham.SoLuongLe = Convert.ToInt32(txtAmonutRetail.Text);
                }
                else
                {
                    sanpham.BanLe = 0;
                    sanpham.SoLuongLe = 0;
                }


                if (SanPhamCH_BUS.SuaSPCH(sanpham))
                {
                    XtraMessageBox.Show("Sửa thông tin Sản phẩm trong Cửa hàng thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSanPhamCH1();

                    lvListImageProduct.Items.Clear();
                    imageList.Images.Clear();
                    Display();
                    ClearDisplay();

                    return;
                }
            }catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void btnDeleteProductStore_Click(object sender, EventArgs e)
        {

            if (txtIDProductCH.Text == "" || txtNameProductCH.Text == "" || txtUnitCH.Text == "" || txtPriceCH.Text == "" || txtAmountOfProductCH.Text == "")
            {
                XtraMessageBox.Show("Bạn phải chọn Sản phẩm để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearDisplay();
                return;
            }
            try
            {
                SanPhamCH_DTO sanpham = new SanPhamCH_DTO();
                sanpham.MaSPCH = txtIDProductCH.Text;
                if (SanPhamCH_BUS.XoaSPCH(sanpham))
                {
                    LoadSanPhamCH1();
                    XtraMessageBox.Show("Xóa Sản phẩm trong Cửa hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lvListImageProduct.Items.Clear();
                    imageList.Images.Clear();
                    Display();
                    ClearDisplay();
                    return;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void txtAmountOfProductCH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPriceCH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            lvListImageProduct.Items.Clear();
            imageList.Images.Clear();
            LoadSanPhamCH1();
            Display();

            ClearDisplay();
        }

        private void txtAmonutRetail_Click(object sender, EventArgs e)
        {
            txtAmonutRetail.Text = "";
        }
        private void txtAmountOfProductCH_Click(object sender, EventArgs e)
        {
            txtAmountOfProductCH.Text = "";
        }
        private void cbRetail_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRetail.Checked == true)
            {
                txtAmonutRetail.Enabled = true;
            }
            else
            {
                txtAmonutRetail.Enabled = false;
            }
        }

        private void lvListImageProduct_Click(object sender, EventArgs e)
        {
            var firstSelectedItem = lvListImageProduct.SelectedItems[0];
            string s = firstSelectedItem.SubItems[0].Text;
            DataGridView d = new DataGridView();

            SanPhamCH_DTO sanpham = SanPhamCH_BUS.TimKiemTenSP(s);

            try
            {
                txtIDProductCH.Text = sanpham.MaSPCH;
                txtNameProductCH.Text = sanpham.TenSP;
                txtPriceCH.Text = sanpham.Gia.ToString();
                txtUnitCH.Text = sanpham.DonVi;
                txtAmountOfProductCH.Text = sanpham.SoLuong.ToString();
                txtParameter.Text = sanpham.ThongSo.ToString();
                if (sanpham.BanLe == 1)
                {
                    txtAmonutRetail.Text = sanpham.SoLuongLe.ToString();
                    cbRetail.Checked = true;
                }
                else
                {
                    cbRetail.Checked = false;
                    txtAmonutRetail.Enabled = false;
                    txtAmonutRetail.Text = "";
                }
                string str = sanpham.HinhAnh.ToString();

                imageLocation = str;
                if (str == "" || str == null)
                    pictureBox.Image = Resources.noimage;
                else
                    pictureBox.Image = Image.FromFile(str);
            }
            catch
            {
                return;
            }

        }
        private void cmbListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbListView.Text == "LargeIcon")
            {
                lvListImageProduct.View = View.LargeIcon;

            }
            else if (cmbListView.Text == "SmallIcon")
            {
                lvListImageProduct.View = View.SmallIcon;
            }
            else if (cmbListView.Text == "Tile")
            {
                lvListImageProduct.View = View.Tile;
            }
            else if (cmbListView.Text == "Details")
                lvListImageProduct.View = View.Details;
        }
        private void btnBrowseSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.Title = "Chọn Picture";
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox.ImageLocation = openFile.FileName;
                imageLocation = openFile.FileName.ToString();
            }
        }
        private void uctSanPhamCH_Load(object sender, EventArgs e)
        {
            cmbListView.Text = "LargeIcon";
            lvListImageProduct.View = View.LargeIcon;
            LoadDataStore();
        }

        private void txtParameter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtAmonutRetail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}