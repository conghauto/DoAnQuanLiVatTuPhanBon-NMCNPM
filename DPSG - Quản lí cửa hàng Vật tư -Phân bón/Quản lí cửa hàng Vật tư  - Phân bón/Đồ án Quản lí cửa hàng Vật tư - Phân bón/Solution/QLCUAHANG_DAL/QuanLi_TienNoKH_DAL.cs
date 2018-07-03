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
    public class QuanLi_TienNoKH_DAL
    {
        public static DataTable dt;
        public static List<QuanLi_TienNoKH_DTO> ThongTinTienNo(string s)
        {
            List<QuanLi_TienNoKH_DTO> ds = new List<QuanLi_TienNoKH_DTO>();


            SqlConnection con = DataProvider.KetNoi();

            try
            {

                string query = string.Format("EXEC dbo.DSTIENNOKH @MaKH = N'" + s + "'");
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
                QuanLi_TienNoKH_DTO thanhtoan = new QuanLi_TienNoKH_DTO();
                thanhtoan.MaTT= (dt.Rows[i]["MaTT"].ToString());
                thanhtoan.MaKH = (dt.Rows[i]["MaKH"].ToString());
                thanhtoan.NgayTra = Convert.ToDateTime(dt.Rows[i]["NgayTra"].ToString());
                thanhtoan.SoTienTra = Convert.ToDouble(dt.Rows[i]["SoTienTra"].ToString());
                thanhtoan.TinhTrang = Convert.ToInt32(dt.Rows[i]["TinhTrang"].ToString());

                ds.Add(thanhtoan);
            }
            DataProvider.DongKetNoi(con);


            return ds;
        }

        public static bool ThemThongTinTienNo(QuanLi_TienNoKH_DTO thanhtoan)
        {
            SqlConnection con = DataProvider.KetNoi();
            SqlCommand cmd = new SqlCommand("ThemThongTin_TienNoKH", con);
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@MaTT", thanhtoan.MaTT);
                cmd.Parameters.Add(p);

                p = new SqlParameter("@MaKH", thanhtoan.MaKH);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@NgayTra", thanhtoan.NgayTra);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@SoTienTra", thanhtoan.SoTienTra);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TinhTrang", thanhtoan.TinhTrang);
                cmd.Parameters.Add(p);

                cmd.ExecuteNonQuery();
                DataProvider.DongKetNoi(con);
                return true;
            }
            catch(Exception ex)
            {
                DataProvider.DongKetNoi(con);
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool XoaThongTinTienNo(QuanLi_TienNoKH_DTO thanhtoan)
        {
            SqlConnection con = DataProvider.KetNoi();
            SqlCommand cmd = new SqlCommand("XoaThongTinThanhToan", con);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@MaTT", thanhtoan.MaTT);
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