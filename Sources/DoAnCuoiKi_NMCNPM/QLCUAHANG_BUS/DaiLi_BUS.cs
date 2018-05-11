using QLCUAHANG_DAL;
using QLCUAHANG_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCUAHANG_BUS
{
    public class DaiLi_BUS
    {
        public static List<DaiLi_DTO> LoadDaiLi()
        {
            return DaiLi_DAL.LoadDaiLi();
        }
        public static bool ThemDaiLi(DaiLi_DTO daili)
        {
            return DaiLi_DAL.ThemDaiLi(daili);
        }
        public static bool SuaDaiLi(DaiLi_DTO daili)
        {
            return DaiLi_DAL.SuaDaiLi(daili);
        }

        public static bool XoaDaiLi(DaiLi_DTO daili)
        {
            return DaiLi_DAL.XoaDaiLi(daili);
        }
    }
}
