using QLCUAHANG_DAL;
using QLCUAHANG_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCUAHANG_BUS
{
    public class HoaDonNhapHang_BUS
    {
        public static List<HoaDonNhapHang_DTO> LoadPhieuNhap()
        {
            return HoaDonNhapHang_DAL.LoadPhieuNhap();
        }
        public static bool ThemPHNhap(HoaDonNhapHang_DTO phieu)
        {
            return HoaDonNhapHang_DAL.ThemPHNhapHang(phieu);
        }

        public static bool XoaPHNhap(HoaDonNhapHang_DTO phieunhap)
        {
            return HoaDonNhapHang_DAL.XoaPhieuHangNhap(phieunhap);
        }

        public static bool SuaPHNhap(HoaDonNhapHang_DTO phieu)
        {
            return HoaDonNhapHang_DAL.SuaPhieuHangNhap(phieu);
        }

        public static List<HoaDonNhapHang_DTO>DSNoTienDaiLi()
        {
            return HoaDonNhapHang_DAL.DSNoTienDaiLi();
        }
        public static string TongNoDaiLi(string s)
        {
            return HoaDonNhapHang_DAL.TongNoDaiLi(s);
        }

        public static List<string> LoadDS_MaHDNhap(string s)
        {
            return HoaDonNhapHang_DAL.LoadDS_MaHDNhap(s);
        }
    }
}
