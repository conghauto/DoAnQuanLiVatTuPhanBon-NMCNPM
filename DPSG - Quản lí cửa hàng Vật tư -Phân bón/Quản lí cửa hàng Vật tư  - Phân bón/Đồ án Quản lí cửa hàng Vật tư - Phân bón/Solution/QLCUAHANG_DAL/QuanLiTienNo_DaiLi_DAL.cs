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
    public class QuanLiTienNo_DaiLi_DAL
    {
        public static DataTable dt;
        public static List<QuanLiTIenNo_DaiLi_DTO> ThongTinTienNoDL(string s)
        {
            List<QuanLiTIenNo_DaiLi_DTO> ds = new List<QuanLiTIenNo_DaiLi_DTO>();


            SqlConnection con = DataProvider.KetNoi();

            try
            {

                string query = string.Format("EXEC dbo.DSTIENNODL @MaDL = N'" + s + "'");
                dt = DataProvider.LayDataTable(query, con);
            }
            catch
            {
                return null;
            }

            if (dt.Rows.Count == 0)
                return null;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                QuanLiTIenNo_DaiLi_DTO thanhtoan = new QuanLiTIenNo_DaiLi_DTO();
                thanhtoan.MaTN = (dt.Rows[i]["MaTN"].ToString());
                thanhtoan.MaDL = (dt.Rows[i]["MaDL"].ToString());
                thanhtoan.NgayTra = Convert.ToDateTime(dt.Rows[i]["NgayTra"].ToString());
                thanhtoan.SoTienTra = Convert.ToDouble(dt.Rows[i]["SoTienTra"].ToString());

                ds.Add(thanhtoan);
            }
            DataProvider.DongKetNoi(con);


            return ds;
        }

        public static bool ThemThongTinTienNoDL(QuanLiTIenNo_DaiLi_DTO thanhtoan)
        {
            SqlConnection con = DataProvider.KetNoi();
            SqlCommand cmd = new SqlCommand("ThemThongTin_TienNoDL", con);
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@MaTN", thanhtoan.MaTN);
                cmd.Parameters.Add(p);

                p = new SqlParameter("@MaDL", thanhtoan.MaDL);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@NgayTra", thanhtoan.NgayTra);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@SoTienTra", thanhtoan.SoTienTra);
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

        public static bool XoaThongTinTienNoDL(QuanLiTIenNo_DaiLi_DTO thanhtoan)
        {
            SqlConnection con = DataProvider.KetNoi();
            SqlCommand cmd = new SqlCommand("XoaThongTinThanhToanDL", con);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@MaTN", thanhtoan.MaTN);
                cmd.Parameters.Add(p);

                cmd.ExecuteNonQuery();
                DataProvider.DongKetNoi(con);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DataProvider.DongKetNoi(con);
                return false;
            }
        }
    }
}
