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
            txtAmountOfProductCH.KeyPress += new KeyPressEventHandler(txtAmountOfProductCH_KeyPress);
            txtPriceCH.KeyPress += new KeyPressEventHandler(txtPriceCH_KeyPress);
        }
        private DataTable dt;
        private void LoadSanPhamCH()
        {
            cmbListView.Text = "LargeIcon";
            lvListImageProduct.View = View.LargeIcon;
            //List<SanPhamCH_DTO> listSP = SanPhamCH_BUS.LoadSanPhamCH();
            //dtgvProductListOfStore.DataSource = listSP;
            try
            {
                SqlConnection con = DataProvider.KetNoi();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("DSSanPhamCH", con);
                dt = new DataTable();
                adapter.Fill(dt);
                dtgvProductListOfStore.DataSource = dt;

                int imageIndex = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    imageList.Images.Add(byteArrayToImage((byte[])dt.Rows[i][5]));
                    var viewItem = new ListViewItem(dt.Rows[i][1].ToString());
                    { };
                    viewItem.ImageIndex = imageIndex;
                    lvListImageProduct.Items.Add(viewItem);
                    imageIndex++;
                }
            }
            catch
            {
                return;
            }
        }
        bool deleteData=true;
        private void LoadSanPhamCH1()
        {
            cmbListView.Text = "LargeIcon";
            lvListImageProduct.View = View.LargeIcon;
            //List<SanPhamCH_DTO> listSP = SanPhamCH_BUS.LoadSanPhamCH();
            //dtgvProductListOfStore.DataSource = listSP;
            try
            {
                SqlConnection con = DataProvider.KetNoi();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("DSSanPhamCH", con);
                dt = new DataTable();
                adapter.Fill(dt);
                dtgvProductListOfStore.DataSource = dt;

                int imageIndex = 0;
                if (deleteData)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        imageList.Images.Add(byteArrayToImage((byte[])dt.Rows[i][5]));
                        var viewItem = new ListViewItem(dt.Rows[i][1].ToString());
                        { };
                        viewItem.ImageIndex = imageIndex;
                        lvListImageProduct.Items.Add(viewItem);
                        imageIndex++;
                    }
                }
            }
            catch
            {
                return;
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

                if (dtgvProductListOfStore.CurrentRow.Cells["HinhAnh"].Value.ToString()=="")
                {
                    pictureBox.Image = Image.FromFile(Application.StartupPath + "\\Resources\\no-image.png");
                }
                else
                {
                    pictureBox.Image = byteArrayToImage((byte[])dtgvProductListOfStore.CurrentRow.Cells["HinhAnh"].Value);
                }
            }
        }
        private void btnUpdateProductStore_Click(object sender, EventArgs e)
        {
            if (txtIDProductCH.Text == "" || txtNameProductCH.Text == "" || txtUnitCH.Text == "" || txtPriceCH.Text == "" || txtAmountOfProductCH.Text == "")
            {
                MessageBox.Show("Bạn phải điền đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearDisplay();
                return;
            }


            SanPhamCH_DTO sanpham = new SanPhamCH_DTO();
            sanpham.MaSPCH = txtIDProductCH.Text;
            sanpham.TenSP = txtNameProductCH.Text;

            sanpham.DonVi = txtUnitCH.Text;
            sanpham.Gia = Double.Parse(txtPriceCH.Text.ToString());
            sanpham.SoLuong = Int32.Parse(txtAmountOfProductCH.Text.ToString());
            sanpham.HinhAnh = convertImageToBytes();


            if (SanPhamCH_BUS.SuaSPCH(sanpham))
            {
                MessageBox.Show("Sửa thông tin Sản phẩm trong Cửa hàng thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSanPhamCH();
                ClearDisplay();

                return;
            }
            MessageBox.Show("Sửa thông tin Sản Phẩm trong Cửa hàng thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void btnDeleteProductStore_Click(object sender, EventArgs e)
        {

            if (txtIDProductCH.Text == "")
            {
                MessageBox.Show("Bạn phải chọn Sản phẩm để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearDisplay();
                return;
            }
            try
            {
                SanPhamCH_DTO sanpham = new SanPhamCH_DTO();
                sanpham.MaSPCH = (string)dtgvProductListOfStore.CurrentRow.Cells["MaSPCH"].Value;
                if (SanPhamCH_BUS.XoaSPCH(sanpham))
                {
                    LoadSanPhamCH();
                    MessageBox.Show("Xóa Sản phẩm trong Cửa hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearDisplay();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void uctSanPhamCH_Load(object sender, EventArgs e)
        {
            LoadDataStore();
        }

        private string imageLocation = "";
        private void btnBrowseSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.Title = "Chọn Picture";
            openFile.RestoreDirectory = true;
            if(openFile.ShowDialog()==DialogResult.OK)
            {
                pictureBox.ImageLocation =openFile.FileName;
                imageLocation = openFile.FileName.ToString();
            }
        }
        private byte[]convertImageToBytes()
        {
            FileStream fs;
            fs = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }
        public Image byteArrayToImage(byte[] bytesArr)
        {
            MemoryStream memstr = new MemoryStream(bytesArr);
            Image img = Image.FromStream(memstr);
            return img;
        }

        private void lvListImageProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = DataProvider.KetNoi();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("Select*from SanPhamCH", con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dtgvProductListOfStore.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbListView.Text=="LargeIcon")
            {
                lvListImageProduct.View=View.LargeIcon;
            }
            else if(cmbListView.Text == "SmallIcon")
            {
                lvListImageProduct.View = View.SmallIcon;
            }
            else if(cmbListView.Text == "Tile")
            {
                lvListImageProduct.View = View.Tile;
            }
            else
                lvListImageProduct.View = View.Details;
        }

        private void lvListImageProduct_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            txtIDProductCH.Text = Convert.ToString(dtgvProductListOfStore.CurrentRow.Cells["MaSPCH"].Value);
            txtNameProductCH.Text = Convert.ToString(dtgvProductListOfStore.CurrentRow.Cells["TenSP"].Value);

            txtPriceCH.Text = Convert.ToString(dtgvProductListOfStore.CurrentRow.Cells["Gia"].Value);
            txtUnitCH.Text = Convert.ToString(dtgvProductListOfStore.CurrentRow.Cells["DonVi"].Value);
            txtAmountOfProductCH.Text = Convert.ToString(dtgvProductListOfStore.CurrentRow.Cells["SoLuong"].Value);

            if (dtgvProductListOfStore.CurrentRow.Cells["HinhAnh"].Value.ToString() == "")
            {
                pictureBox.Image = Image.FromFile(Application.StartupPath + "no-image.png");
            }
            else
            {
                pictureBox.Image = byteArrayToImage((byte[])dtgvProductListOfStore.CurrentRow.Cells["HinhAnh"].Value);
            }
        }

        private void lvListImageProduct_Click(object sender, EventArgs e)
        {
            var firstSelectedItem = lvListImageProduct.SelectedItems[0];
            txtIDProductCH.Text = Convert.ToString(dtgvProductListOfStore.CurrentRow.Cells["MaSPCH"].Value);
            txtNameProductCH.Text = Convert.ToString(dtgvProductListOfStore.CurrentRow.Cells["TenSP"].Value);

            txtPriceCH.Text = Convert.ToString(dtgvProductListOfStore.CurrentRow.Cells["Gia"].Value);
            txtUnitCH.Text = Convert.ToString(dtgvProductListOfStore.CurrentRow.Cells["DonVi"].Value);
            txtAmountOfProductCH.Text = Convert.ToString(dtgvProductListOfStore.CurrentRow.Cells["SoLuong"].Value);

            if (dtgvProductListOfStore.CurrentRow.Cells["HinhAnh"].Value.ToString() == "")
            {
                pictureBox.Image = Image.FromFile(Application.StartupPath + "\\Resources\\no-image.png");
            }
            else
            {
                pictureBox.Image = byteArrayToImage((byte[])dtgvProductListOfStore.CurrentRow.Cells["HinhAnh"].Value);
            }
        }
    }
}
