using QLCUAHANG_DAL;
using QLCUAHANG_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCUAHANG_BUS
{
    public class QuanLiTienNo_DaiLi_BUS
    {
        public static List<QuanLiTIenNo_DaiLi_DTO> ThongTinTienNoDL(string s)
        {
            return QuanLiTienNo_DaiLi_DAL.ThongTinTienNoDL(s);
        }
        public static bool ThemThongTinTienNoDL(QuanLiTIenNo_DaiLi_DTO thanhtoan)
        {
            return QuanLiTienNo_DaiLi_DAL.ThemThongTinTienNoDL(thanhtoan);
        }
        public static bool XoaThongTinTienNoDL(QuanLiTIenNo_DaiLi_DTO thanhtoan)
        {
            return QuanLiTienNo_DaiLi_DAL.XoaThongTinTienNoDL(thanhtoan);
        }
    }
}
