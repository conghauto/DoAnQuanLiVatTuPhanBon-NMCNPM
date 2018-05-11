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
    public class HoaDonBanHang_DAL
    {
        private static SqlCommand cmd;
        private static DataTable dt;
        private static SqlDataAdapter da;
        public static bool ThemPHBanHang(HoaDonBanHang_DTO phieu)
        {
            SqlConnection con = DataProvider.KetNoi();
            cmd = new SqlCommand("ThemPHBan", con);

            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@MaHDB", phieu.MaHDB);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TenCH", phieu.TenCH);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@MaKH", phieu.MaKH);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TenKH", phieu.TenKH);
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

        public static List<HoaDonBanHang_DTO> LoadPhieuBan()
        {
            SqlConnection con = DataProvider.KetNoi();

            try
            {
                cmd = new SqlCommand("DSPhieuBan", con);
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

            List<HoaDonBanHang_DTO> dsPhieuNhap = new List<HoaDonBanHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDonBanHang_DTO phieuhang = new HoaDonBanHang_DTO();
                phieuhang.MaHDB = dt.Rows[i]["MaHDB"].ToString();
                phieuhang.MaKH = dt.Rows[i]["MaKH"].ToString();
                phieuhang.TenKH = dt.Rows[i]["TenKH"].ToString();
                phieuhang.NgayNhap = Convert.ToDateTime(dt.Rows[i]["NgayNhap"].ToString());
                phieuhang.TongTien =Convert.ToDouble(dt.Rows[i]["TongTien"].ToString());
                phieuhang.TongNo = Convert.ToDouble(dt.Rows[i]["TongNo"].ToString());

                phieuhang.TenCH = dt.Rows[i]["TenCH"].ToString();

                dsPhieuNhap.Add(phieuhang);
            }
            DataProvider.DongKetNoi(con);
            return dsPhieuNhap;
        }

        public static bool SuaPhieuBanHang(HoaDonBanHang_DTO phieuhang)
        {
            SqlConnection con = DataProvider.KetNoi();
            try
            {
                cmd = new SqlCommand("SuaPHBan", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@MaHDB", phieuhang.MaHDB);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@MaKH", phieuhang.MaKH);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TenKH", phieuhang.TenKH);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@NgayNhap", phieuhang.NgayNhap);
                cmd.Parameters.Add(p);

                p = new SqlParameter("@TongTien", phieuhang.TongTien);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TongNo", phieuhang.TongNo);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TenCH", phieuhang.TenCH);
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

        public static bool XoaPhieuBanHang(HoaDonBanHang_DTO phieuhang)
        {
            SqlConnection con = DataProvider.KetNoi();
            try
            {
                cmd = new SqlCommand("XoaPHBan", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@MaHDB", phieuhang.MaHDB);
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
