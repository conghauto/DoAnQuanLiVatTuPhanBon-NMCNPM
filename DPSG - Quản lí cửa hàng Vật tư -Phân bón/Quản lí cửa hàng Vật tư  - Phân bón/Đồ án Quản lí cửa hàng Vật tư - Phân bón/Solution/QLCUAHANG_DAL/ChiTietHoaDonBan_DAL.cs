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
   public class ChiTietHoaDonBan_DAL
    {
        private static SqlCommand cmd;
        private static DataTable dt;
        private static SqlDataAdapter da;
        public static bool ThemChiTietPHBanHang(ChiTietHoaDonBan_DTO phieu)
        {
            SqlConnection con = DataProvider.KetNoi();
            try
            {

                
                cmd = new SqlCommand("ThemChiTietPHBan", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@MaHDB", phieu.MaHDB);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@MaSPCH", phieu.MaSPCH);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@SoLuong", phieu.SoLuong);
                cmd.Parameters.Add(p);

                p = new SqlParameter("@DonViTinh", phieu.DonViTinh);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@HinhThucBan", phieu.HinhThucBan);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@SoLuongMuaLe", phieu.SoLuongMuaLe);
                cmd.Parameters.Add(p);

                cmd.ExecuteNonQuery();

                DataProvider.DongKetNoi(con);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DataProvider.DongKetNoi(con);
                return false;
            }
        }

        public static List<ChiTietHoaDonBan_DTO> LoadChiTietPhieuBan()
        {
            SqlConnection con = DataProvider.KetNoi();

            try
            {
                cmd = new SqlCommand("DSChiTietPhieuBan", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();

                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            if (dt.Rows.Count == 0)
                return null;

            List<ChiTietHoaDonBan_DTO> dsChiTietPhieuBan = new List<ChiTietHoaDonBan_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChiTietHoaDonBan_DTO phieuhang = new ChiTietHoaDonBan_DTO();
                phieuhang.MaHDB = dt.Rows[i]["MaHDB"].ToString();
                phieuhang.MaSPCH = dt.Rows[i]["MaSPCH"].ToString();
                phieuhang.SoLuong = Convert.ToInt32(dt.Rows[i]["SoLuong"].ToString());

                phieuhang.DonViTinh = dt.Rows[i]["DonViTinh"].ToString();
                phieuhang.HinhThucBan = Convert.ToInt32(dt.Rows[i]["HinhThucBan"].ToString());
                phieuhang.SoLuongMuaLe = Convert.ToInt32(dt.Rows[i]["SoLuongMuaLe"].ToString());


                dsChiTietPhieuBan.Add(phieuhang);
            }
            DataProvider.DongKetNoi(con);
            return dsChiTietPhieuBan;
        }

        public static bool SuaChiTietPhieuBanHang(ChiTietHoaDonBan_DTO phieuhang)
        {
            SqlConnection con = DataProvider.KetNoi();
            try
            {
                cmd = new SqlCommand("SuaChiTietPHBan", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@MaHDB", phieuhang.MaHDB);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@MaSPCH", phieuhang.MaSPCH);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@SoLuong", phieuhang.SoLuong);
                cmd.Parameters.Add(p);

                p = new SqlParameter("@DonViTinh", phieuhang.DonViTinh);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@HinhThucBan", phieuhang.HinhThucBan);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@SoLuongMuaLe", phieuhang.SoLuongMuaLe);
                cmd.Parameters.Add(p);


                cmd.ExecuteNonQuery();

                DataProvider.DongKetNoi(con);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DataProvider.DongKetNoi(con);
                return false;
            }
        }
        public static string TimDonViSanPham(string t)
        {
            SqlConnection con = DataProvider.KetNoi();
            string query = string.Format("EXEC dbo.DonViSanPham @MaSPCH = N'" + t + "'");
            DataTable dt = DataProvider.LayDataTable(query, con);
            if (dt.Rows.Count == 0)
                return null;
            string s = dt.Rows[0]["DonVi"].ToString();

            DataProvider.DongKetNoi(con);
            return s;
        }
        public static string ThongSoMax(string t)
        {
            SqlConnection con = DataProvider.KetNoi();
            string query = string.Format("EXEC dbo.DonViSanPham @MaSPCH = N'" + t + "'");
            DataTable dt = DataProvider.LayDataTable(query, con);
            if (dt.Rows.Count == 0)
                return null;
            string s = dt.Rows[0]["SoLuongLe"].ToString();

            DataProvider.DongKetNoi(con);
            return s;
        }
        public static string SoLuongMax(string t)
        {
            SqlConnection con = DataProvider.KetNoi();
            string query = string.Format("EXEC dbo.DonViSanPham @MaSPCH = N'" + t + "'");
            DataTable dt = DataProvider.LayDataTable(query, con);
            if (dt.Rows.Count == 0)
                return null;
            string s = dt.Rows[0]["SoLuong"].ToString();

            DataProvider.DongKetNoi(con);
            return s;
        }
       
        public static bool XoaChiTietPhieuBanHang(ChiTietHoaDonBan_DTO phieuhang)
        {
            SqlConnection con = DataProvider.KetNoi();
            try
            {
                cmd = new SqlCommand("XoaChiTietPHBan", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@MaHDB", phieuhang.MaHDB);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@MaSPCH", phieuhang.MaSPCH);
                cmd.Parameters.Add(p);

                cmd.ExecuteNonQuery();

                DataProvider.DongKetNoi(con);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DataProvider.DongKetNoi(con);
                return false;
            }
        }
    }
}
