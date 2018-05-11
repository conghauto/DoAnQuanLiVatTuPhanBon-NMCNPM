using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCUAHANG_DAL
{
    public class DataProvider
    {
        private static string sChuoiKetNoi = ConfigurationManager.ConnectionStrings["connectionString"].ToString();

        public static SqlConnection KetNoi()
        {
             SqlConnection con = new SqlConnection(sChuoiKetNoi);
             con.Open();
             return con;
        }
        public static void DongKetNoi(SqlConnection con)
        {
            con.Close();
        }

        public static DataTable LayDataTable(string query, SqlConnection con)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public static void ThucThiTruyVanNonQuery(string query, SqlConnection con)
        {
            SqlCommand cm = new SqlCommand(query, con);
            cm.ExecuteNonQuery();
        }

        public static string ExcuteScalar(string stringSQL)
        {
            string giaTri = "";
            try
            {
                SqlConnection sqlconn = KetNoi();
                SqlCommand cmd = new SqlCommand(stringSQL, sqlconn);
                giaTri = cmd.ExecuteScalar().ToString();
            }
            catch { }
            return giaTri;
        }
    }
}
