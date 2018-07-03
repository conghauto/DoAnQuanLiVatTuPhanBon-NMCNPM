using QLCUAHANG_DAL;
using QLCUAHANG_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCUAHANG_BUS
{
   public class ChiTietHoaDonNhap_BUS
    {
        public static List<ChiTietHoaDonNhap_DTO> LoadChiTietPhieuNhap()
        {
            return ChiTietHoaDonNhap_DAL.LoadChiTietPhieuNhap();
        }
        public static bool ThemChiTietPHNhap(ChiTietHoaDonNhap_DTO phieu)
        {
            return ChiTietHoaDonNhap_DAL.ThemChiTietPHNhapHang(phieu);
        }

        public static bool XoaChiTietPHNhap(ChiTietHoaDonNhap_DTO phieunhap)
        {
            return ChiTietHoaDonNhap_DAL.XoaChiTietPhieuHangNhap(phieunhap);
        }

        public static bool SuaChiTietPHNhap(ChiTietHoaDonNhap_DTO phieu)
        {
            return ChiTietHoaDonNhap_DAL.SuaChiTietPhieuHangNhap(phieu);
        }
    }
}
