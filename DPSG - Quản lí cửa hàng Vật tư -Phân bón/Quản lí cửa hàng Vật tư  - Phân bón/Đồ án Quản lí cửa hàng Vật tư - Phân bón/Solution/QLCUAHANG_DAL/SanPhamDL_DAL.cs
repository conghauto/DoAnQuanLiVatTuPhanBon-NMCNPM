using DevExpress.XtraEditors;
using QLCUAHANG_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCUAHANG_DAL
{
    public class SanPhamDL_DAL
    {
        public static List<SanPhamDL_DTO> LoadSanPhamDL()
        {
            // 1. Tạo chuối kết nối
            SqlConnection con = DataProvider.KetNoi();

            // 2. Tạo chuối truy vấn và thực thi truy vấn
            SqlCommand cmd = new SqlCommand("DSSanPhamDL", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            // 3. Đổ dữ liệu lên DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
                return null;
            // 4. Đỏ dữ liệu lên List
            List<SanPhamDL_DTO> listSP = new List<SanPhamDL_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SanPhamDL_DTO sanpham = new SanPhamDL_DTO();
                sanpham.MaSPDL = dt.Rows[i]["MaSPDL"].ToString();
                sanpham.TenSP = dt.Rows[i]["TenSP"].ToString();
                sanpham.MaDL = dt.Rows[i]["MaDL"].ToString();
                sanpham.Gia =Double.Parse(dt.Rows[i]["Gia"].ToString());
                sanpham.DonVi = dt.Rows[i]["DonVi"].ToString();
                sanpham.ThongSo= dt.Rows[i]["ThongSo"].ToString();

                listSP.Add(sanpham);
            }

            DataProvider.DongKetNoi(con);
            return listSP;
        }

        public static bool ThemSanPhamDL(SanPhamDL_DTO sanpham)
        {
            SqlConnection con = DataProvider.KetNoi();
            SqlCommand cmd = new SqlCommand("ThemSPDL", con);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@MaSPDL", sanpham.MaSPDL);
                cmd.Parameters.Add(p);

                p = new SqlParameter("@TenSP", sanpham.TenSP);
                cmd.Parameters.Add(p);

                p = new SqlParameter("@MaDL", sanpham.MaDL);
                cmd.Parameters.Add(p);

                p = new SqlParameter("@Gia", sanpham.Gia);
                cmd.Parameters.Add(p);

                p = new SqlParameter("@DonVi", sanpham.DonVi);
                cmd.Parameters.Add(p);

                p = new SqlParameter("@ThongSo", sanpham.ThongSo);
                cmd.Parameters.Add(p);

                cmd.ExecuteNonQuery();

                DataProvider.DongKetNoi(con);
                return true;
            }
            catch (Exception ex)
            {
                DataProvider.DongKetNoi(con);
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool SuaSanPhamDL(SanPhamDL_DTO sanpham)
        {
            SqlConnection con = DataProvider.KetNoi();
            SqlCommand cmd = new SqlCommand("SuaSPDL", con);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@MaSPDL", sanpham.MaSPDL);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TenSP", sanpham.TenSP);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@MaDL", sanpham.MaDL);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@DonVi", sanpham.DonVi);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@Gia", sanpham.Gia);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@ThongSo", sanpham.ThongSo);
                cmd.Parameters.Add(p);

                cmd.ExecuteNonQuery();

                DataProvider.DongKetNoi(con);
                return true;
            }
            catch (Exception ex)
            {
                DataProvider.DongKetNoi(con);
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static bool XoaSPDL(SanPhamDL_DTO sanpham)
        {
            SqlConnection con = DataProvider.KetNoi();
            SqlCommand cmd = new SqlCommand("XoaSPDL", con);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@MaSPDL", sanpham.MaSPDL);
                cmd.Parameters.Add(p);

                cmd.ExecuteNonQuery();

                DataProvider.DongKetNoi(con);
                return true;
            }
            catch (Exception ex)
            {
                DataProvider.DongKetNoi(con);
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
