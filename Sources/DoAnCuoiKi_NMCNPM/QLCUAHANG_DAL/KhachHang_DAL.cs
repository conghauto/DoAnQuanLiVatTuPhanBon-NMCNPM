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
   public class KhachHang_DAL
    {
        public static List<KhachHang_DTO> LoadListKhachHang()
        {
            SqlConnection con = DataProvider.KetNoi();

            DataTable dt = DataProvider.LayDataTable("DSKhachHang", con);

            List<KhachHang_DTO> dsKhachHang = new List<KhachHang_DTO>();

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHang_DTO kh = new KhachHang_DTO();
                kh.MaKH = dt.Rows[i]["MaKH"].ToString();
                kh.TenKH = dt.Rows[i]["TenKH"].ToString();
                kh.SoDT = dt.Rows[i]["SoDT"].ToString();
                kh.DiaChi = dt.Rows[i]["DiaChi"].ToString();

                dsKhachHang.Add(kh);
            }
            DataProvider.DongKetNoi(con);
            return dsKhachHang;
        }

        public static bool ThemKhachHang(KhachHang_DTO khachhang)
        {
            SqlConnection con = DataProvider.KetNoi();
            SqlCommand cmd = new SqlCommand("ThemKH", con);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@MaKH", khachhang.MaKH);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TenKH", khachhang.TenKH);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@DiaChi", khachhang.DiaChi);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@SoDT", khachhang.SoDT);
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

        public static bool SuaKhachHang(KhachHang_DTO khachhang)
        {
            SqlConnection con = DataProvider.KetNoi();
            SqlCommand cmd = new SqlCommand("SuaKH", con);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@MaKH", khachhang.MaKH);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TenKH", khachhang.TenKH);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@DiaChi", khachhang.DiaChi);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@SoDT", khachhang.SoDT);
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

        public static bool XoaKH(KhachHang_DTO khachhang)
        {
            SqlConnection con = DataProvider.KetNoi();
            SqlCommand cmd = new SqlCommand("XoaKH", con);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@MaKH", khachhang.MaKH);
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

        public static List<KhachHang_DTO> TimKiemKhachHang(string tuKhoa)
        {
            SqlConnection con = DataProvider.KetNoi();
            string query = string.Format("EXEC dbo.TimKiemKH @TuKhoa = N'%" + tuKhoa + "%'");
            DataTable dt = DataProvider.LayDataTable(query, con);
            if (dt.Rows.Count == 0)
                return null;

            List<KhachHang_DTO> listKhachHang = new List<KhachHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHang_DTO khachhang = new KhachHang_DTO();
                khachhang.MaKH = dt.Rows[i]["MaKH"].ToString();
                khachhang.TenKH = dt.Rows[i]["TenKH"].ToString();
                khachhang.DiaChi = dt.Rows[i]["DiaChi"].ToString();
                khachhang.SoDT = dt.Rows[i]["SoDT"].ToString();
                listKhachHang.Add(khachhang);
            }
            DataProvider.DongKetNoi(con);
            return listKhachHang;
        }

        public static List<KhachHang_DTO> TimKiemKhachHang2(string tuKhoa)
        {
            SqlConnection con = DataProvider.KetNoi();
            string query = string.Format("EXEC dbo.TimKiemKH2 @TuKhoa = N'%" + tuKhoa + "%'");
        
            DataTable dt = DataProvider.LayDataTable(query, con);
            if (dt.Rows.Count == 0)
                return null;

            List<KhachHang_DTO> listKhachHang = new List<KhachHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHang_DTO khachhang = new KhachHang_DTO();
                khachhang.MaKH = dt.Rows[i]["MaKH"].ToString();
                khachhang.TenKH = dt.Rows[i]["TenKH"].ToString();
                khachhang.DiaChi = dt.Rows[i]["DiaChi"].ToString();
                khachhang.SoDT = dt.Rows[i]["SoDT"].ToString();
                listKhachHang.Add(khachhang);
            }
            DataProvider.DongKetNoi(con);
            return listKhachHang;
        }
    }
}
