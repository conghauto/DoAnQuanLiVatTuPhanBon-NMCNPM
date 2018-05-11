using QLCUAHANG_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCUAHANG_DAL
{
   public  class ChiTietHoaDonNhap_DAL
    {
        private static SqlCommand cmd;
        private static DataTable dt;
        private static SqlDataAdapter da;
        public static bool ThemChiTietPHNhapHang(ChiTietHoaDonNhap_DTO phieu)
        {
            SqlConnection con = DataProvider.KetNoi();
            cmd = new SqlCommand("ThemChiTietPHNhap", con);

            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@MaHDN", phieu.MaHDN);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@MaSPDL", phieu.MaSPDL);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@SoLuong", phieu.SoLuong);
                cmd.Parameters.Add(p);

                cmd.ExecuteNonQuery();

                DataProvider.DongKetNoi(con);
                return true;
            }
            catch
            {
                DataProvider.DongKetNoi(con);
                return false;
            }
        }

        public static List<ChiTietHoaDonNhap_DTO> LoadChiTietPhieuNhap()
        {
            SqlConnection con = DataProvider.KetNoi();

            try
            {
                cmd = new SqlCommand("DSChiTietPhieuNhap", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();

                da.Fill(dt);

            }
            catch
            {
                return null;
            }

            if (dt.Rows.Count == 0)
                return null;

            List<ChiTietHoaDonNhap_DTO> dsChiTietPhieuNhap = new List<ChiTietHoaDonNhap_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChiTietHoaDonNhap_DTO phieuhang = new ChiTietHoaDonNhap_DTO();
                phieuhang.MaHDN = dt.Rows[i]["MaHDN"].ToString();
                phieuhang.MaSPDL = dt.Rows[i]["MaSPDL"].ToString();
                phieuhang.SoLuong = Convert.ToInt32(dt.Rows[i]["SoLuong"].ToString());

                dsChiTietPhieuNhap.Add(phieuhang);
            }
            DataProvider.DongKetNoi(con);
            return dsChiTietPhieuNhap;
        }

        public static bool SuaChiTietPhieuHangNhap(ChiTietHoaDonNhap_DTO phieuhang)
        {
            SqlConnection con = DataProvider.KetNoi();
            try
            {
                cmd = new SqlCommand("SuaChiTietPHNhap", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@MaHDN", phieuhang.MaHDN);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@MaSPDL", phieuhang.MaSPDL);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@SoLuong", phieuhang.SoLuong);
                cmd.Parameters.Add(p);

                cmd.ExecuteNonQuery();

                DataProvider.DongKetNoi(con);
                return true;
            }
            catch
            {
                DataProvider.DongKetNoi(con);
                return false;
            }
        }

        public static bool XoaChiTietPhieuHangNhap(ChiTietHoaDonNhap_DTO phieuhang)
        {
            SqlConnection con = DataProvider.KetNoi();
            try
            {
                cmd = new SqlCommand("XoaChiTietPHNhap", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@MaSPDL", phieuhang.MaHDN);
                cmd.Parameters.Add(p);

                cmd.ExecuteNonQuery();

                DataProvider.DongKetNoi(con);
                return true;
            }
            catch
            {
                DataProvider.DongKetNoi(con);
                return false;
            }
        }
    }
}
