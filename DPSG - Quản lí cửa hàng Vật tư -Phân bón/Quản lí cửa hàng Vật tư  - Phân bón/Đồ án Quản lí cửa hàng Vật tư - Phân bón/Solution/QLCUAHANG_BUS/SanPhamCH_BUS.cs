using QLCUAHANG_DAL;
using QLCUAHANG_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCUAHANG_BUS
{
   public  class SanPhamCH_BUS
    {
        public static List<SanPhamCH_DTO> LoadSanPHamCH()
        {
            return SanPhamCH_DAL.LoadSanPhamCH();
        }
        public static SanPhamCH_DTO TimKiemTenSP(string t) {
            return SanPhamCH_DAL.TimKiemTenSP(t);
        }
       
        public static bool SuaSPCH(SanPhamCH_DTO sanpham)
        {
            return SanPhamCH_DAL.SuaSanPhamCH(sanpham);
        }
        public static bool XoaSPCH(SanPhamCH_DTO sanpham)
        {
            return SanPhamCH_DAL.XoaSPCH(sanpham);
        }
    }
}
