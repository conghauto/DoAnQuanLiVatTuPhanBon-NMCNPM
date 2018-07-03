using QLCUAHANG_DAL;
using QLCUAHANG_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCUAHANG_BUS
{
   public class ChiTietHoaDonBan_BUS
    {
        public static List<ChiTietHoaDonBan_DTO> LoadChiTietPhieuBan()
        {
            return ChiTietHoaDonBan_DAL.LoadChiTietPhieuBan();
        }
        public static bool ThemChiTietPHBan(ChiTietHoaDonBan_DTO phieu)
        {
            return ChiTietHoaDonBan_DAL.ThemChiTietPHBanHang(phieu);
        }

        public static bool XoaChiTietPHBan(ChiTietHoaDonBan_DTO phieunhap)
        {
            return ChiTietHoaDonBan_DAL.XoaChiTietPhieuBanHang(phieunhap);
        }

        public static bool SuaChiTietPHBan(ChiTietHoaDonBan_DTO phieu)
        {
            return ChiTietHoaDonBan_DAL.SuaChiTietPhieuBanHang(phieu);
        }
        public static string TimDonViSanPham(string t)
        {
            return ChiTietHoaDonBan_DAL.TimDonViSanPham(t);
        }
        public static string ThongSoMax(string t)
        {
            return ChiTietHoaDonBan_DAL.ThongSoMax(t);
        }
        public static string SoLuongMax(string t)
        {
            return ChiTietHoaDonBan_DAL.SoLuongMax(t);
        }
    }
}
