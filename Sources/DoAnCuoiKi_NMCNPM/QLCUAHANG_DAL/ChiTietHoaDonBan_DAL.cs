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
   public class ChiTietHoaDonBan_DAL
    {
        private static SqlCommand cmd;
        private static DataTable dt;
        private static SqlDataAdapter da;
        public static bool ThemChiTietPHBanHang(ChiTietHoaDonBan_DTO phieu)
        {
            SqlConnection con = DataProvider.KetNoi();
            cmd = new SqlCommand("ThemChiTietPHBan", con);

            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@phieu.MaHDB", phieu.MaHDB);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@MaSPCH", phieu.MaSPCH);
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
            catch
            {
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

        public static bool XoaChiTietPhieuBanHang(ChiTietHoaDonBan_DTO phieuhang)
        {
            SqlConnection con = DataProvider.KetNoi();
            try
            {
                cmd = new SqlCommand("XoaChiTietPHBan", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@MaSPCH", phieuhang.MaSPCH);
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
