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
    public class DaiLi_DAL
    {
        public static List<DaiLi_DTO> LoadDaiLi()
        {
            List<DaiLi_DTO> listDaiLi = new List<DaiLi_DTO>();
            SqlConnection con = DataProvider.KetNoi();

            SqlCommand cmd = new SqlCommand("DSDAILI", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
                return null;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DaiLi_DTO daili = new DaiLi_DTO();
                daili.MaDL = dt.Rows[i]["MaDL"].ToString();
                daili.TenDL = dt.Rows[i]["TenDL"].ToString();
                daili.DiaChi = dt.Rows[i]["DiaChi"].ToString();
                daili.SoDT = dt.Rows[i]["SoDT"].ToString();
                listDaiLi.Add(daili);
            }
            DataProvider.DongKetNoi(con);

            return listDaiLi;
        }

        public static bool ThemDaiLi(DaiLi_DTO daili)
        {
            SqlConnection con = DataProvider.KetNoi();
            SqlCommand cmd = new SqlCommand("ThemDaiLi", con);
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@MaDL", daili.MaDL);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TenDL", daili.TenDL);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@DiaChi", daili.DiaChi);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@SoDT", daili.SoDT);
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

        public static bool SuaDaiLi(DaiLi_DTO daili)
        {
            SqlConnection con = DataProvider.KetNoi();
            SqlCommand cmd = new SqlCommand("SuaDaiLi", con);
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@MaDL", daili.MaDL);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TenDL", daili.TenDL);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@DiaChi", daili.DiaChi);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@SoDT", daili.SoDT);
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

        public static bool XoaDaiLi(DaiLi_DTO daili)
        {
            SqlConnection con = DataProvider.KetNoi();
            SqlCommand cmd = new SqlCommand("XoaDL", con);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@MaDL", daili.MaDL);
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
