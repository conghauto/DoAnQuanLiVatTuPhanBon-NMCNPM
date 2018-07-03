using QLCUAHANG_DAL;
using QLCUAHANG_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCUAHANG_BUS
{
   public class QuanLi_TienNoKH_BUS
    {
       public static List<QuanLi_TienNoKH_DTO> ThongTinTienNo(string s)
        {
            return QuanLi_TienNoKH_DAL.ThongTinTienNo(s);
        }
        public static bool ThemThongTinTienNo(QuanLi_TienNoKH_DTO thanhtoan)
        {
            return QuanLi_TienNoKH_DAL.ThemThongTinTienNo(thanhtoan);
        }
        public static bool XoaThongTinTienNo(QuanLi_TienNoKH_DTO thanhtoan)
        {
            return QuanLi_TienNoKH_DAL.XoaThongTinTienNo(thanhtoan);
        }
    }
}
