using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCUAHANG_DAL;
using System.Data.SqlClient;
using DevExpress.XtraEditors;

namespace QLCUAHANG_GUI
{
    public partial class uctThongKe : UserControl
    {
        public uctThongKe()
        {
            InitializeComponent();
        }
        public static uctThongKe uctthongke = new uctThongKe();
        private void uctThongKe_Load(object sender, EventArgs e)
        {
            btnMonth.Click += new EventHandler(btnMonth_Click);
            txtMonth.Click += new EventHandler(txtMonth_Click);
        }
        private void LoadData1()
        {
           
            SqlConnection con = DataProvider.KetNoi();
            string query = string.Format("EXEC dbo.ThongKe_SP @Month = N'" + Convert.ToInt32(txtMonth.Text.ToString()) + "'");
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, con);

            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string s1 = dt.Rows[i]["TenSP"].ToString();
                double d = Convert.ToDouble(dt.Rows[i]["TongTien"].ToString());

                chartRevenue.Series["Sản phẩm"].Points.AddPoint(s1, d);
            }

            DataProvider.DongKetNoi(con);
        }
        private void LoadData()
        {
            SqlConnection con=DataProvider.KetNoi();
            string query = string.Format("EXEC dbo.ThongKe_SP @Month = N'" + Convert.ToInt32(txtMonth.Text.ToString()) + "'");
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query,con);
            
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string s1 = dt.Rows[i]["TenSP"].ToString();
                double d= Convert.ToDouble(dt.Rows[i]["TongTien"].ToString());
                
                chartSell.Series["Tổng tiền"].Points.AddPoint(s1,d);
            }

            DataProvider.DongKetNoi(con);
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            if (txtMonth.Text == "")
            {
                XtraMessageBox.Show("Bạn chưa nhập tháng cần Thống kê?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
             
                LoadData();
                LoadData1();
                txtMonth.Text = "";
            }
           catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtMonth_Click(object sender, EventArgs e)
        {
            chartSell.Series["Tổng tiền"].Points.Clear();
            txtMonth.Text = "";
           chartRevenue.Series["Sản phẩm"].Points.Clear();
        }

        private void txtMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
