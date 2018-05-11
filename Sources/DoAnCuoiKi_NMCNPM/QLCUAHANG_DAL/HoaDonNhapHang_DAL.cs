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
   public class HoaDonNhapHang_DAL
    {

        private static SqlCommand cmd;
        private static DataTable dt;
        private static SqlDataAdapter da;
        public static bool ThemPHNhapHang(HoaDonNhapHang_DTO phieu)
        {
            SqlConnection con = DataProvider.KetNoi();
            cmd = new SqlCommand("ThemPHNhap", con);

            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@MaHDN", phieu.MaHDN);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TenDL", phieu.TenDL);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@MaDL", phieu.MaDL);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@NgayNhap", phieu.NgayNhap);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TongTien", phieu.TongTien);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TongNo", phieu.TongNo);
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

        public static List<HoaDonNhapHang_DTO> LoadPhieuNhap()
        {
            SqlConnection con = DataProvider.KetNoi();

            try
            {
                cmd = new SqlCommand("DSPhieuNhap", con);
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

            List<HoaDonNhapHang_DTO> dsPhieuNhap = new List<HoaDonNhapHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDonNhapHang_DTO phieuhang = new HoaDonNhapHang_DTO();
                phieuhang.MaHDN = dt.Rows[i]["MaHDN"].ToString();
                phieuhang.MaDL = dt.Rows[i]["MaDL"].ToString();

                phieuhang.NgayNhap = Convert.ToDateTime(dt.Rows[i]["NgayNhap"].ToString());
                phieuhang.TongTien = Convert.ToDouble(dt.Rows[i]["TongTien"].ToString());
                phieuhang.TongNo = Convert.ToDouble(dt.Rows[i]["TongNo"].ToString());

                phieuhang.TenDL = dt.Rows[i]["TenDL"].ToString();

                dsPhieuNhap.Add(phieuhang);
            }
            DataProvider.DongKetNoi(con);
            return dsPhieuNhap;
        }

        public static bool SuaPhieuHangNhap(HoaDonNhapHang_DTO phieuhang)
        {
            SqlConnection con = DataProvider.KetNoi();
            try
            {
                cmd = new SqlCommand("SuaPHNhap", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@MaHDN", phieuhang.MaHDN);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@MaDL", phieuhang.MaDL);
                cmd.Parameters.Add(p);

                p = new SqlParameter("@NgayNhap", phieuhang.NgayNhap);
                cmd.Parameters.Add(p);

                p = new SqlParameter("@TongTien", phieuhang.TongTien);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TongNo", phieuhang.TongNo);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TenDL", phieuhang.TenDL);
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

        public static bool XoaPhieuHangNhap(HoaDonNhapHang_DTO phieuhang)
        {
            SqlConnection con = DataProvider.KetNoi();
            try
            {
                cmd = new SqlCommand("XoaPHNhap", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@MaHDN", phieuhang.MaHDN);
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
