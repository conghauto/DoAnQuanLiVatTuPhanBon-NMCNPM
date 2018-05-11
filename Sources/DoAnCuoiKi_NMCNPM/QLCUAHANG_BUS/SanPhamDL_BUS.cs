using QLCUAHANG_DAL;
using QLCUAHANG_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCUAHANG_BUS
{
    public class SanPhamDL_BUS
    {
        public static List<SanPhamDL_DTO> LoadSanPhamDL()
        {
            return SanPhamDL_DAL.LoadSanPhamDL();
        }
        public static bool ThemSPDL(SanPhamDL_DTO sanpham)
        {
            return SanPhamDL_DAL.ThemSanPhamDL(sanpham);
        }

        public static bool SuaSPDL(SanPhamDL_DTO sanpham)
        {
            return SanPhamDL_DAL.SuaSanPhamDL(sanpham);
        }
        public static bool XoaSPDL(SanPhamDL_DTO sanpham)
        {
            return SanPhamDL_DAL.XoaSPDL(sanpham);
        }
    }
}
