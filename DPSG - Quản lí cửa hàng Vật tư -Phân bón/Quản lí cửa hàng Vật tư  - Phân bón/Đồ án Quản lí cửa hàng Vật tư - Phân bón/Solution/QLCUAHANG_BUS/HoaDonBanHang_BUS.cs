using QLCUAHANG_DAL;
using QLCUAHANG_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCUAHANG_BUS
{
    public class HoaDonBanHang_BUS
    {
        public static List<HoaDonBanHang_DTO> LoadPhieuBan()
        {
            return HoaDonBanHang_DAL.LoadPhieuBan();
        }
        public static bool ThemPHBan(HoaDonBanHang_DTO phieu)
        {
            return HoaDonBanHang_DAL.ThemPHBanHang(phieu);
        }
        public static List<string> LoadDS_MaHDB(string s)
        {
            return HoaDonBanHang_DAL.LoadDS_MaHDB(s);
        }

        public static bool XoaPHBan(HoaDonBanHang_DTO phieunhap)
        {
            return HoaDonBanHang_DAL.XoaPhieuBanHang(phieunhap);
        }

        public static bool SuaPHBan(HoaDonBanHang_DTO phieu)
        {
            return HoaDonBanHang_DAL.SuaPhieuBanHang(phieu);
        }

        public static List<HoaDonBanHang_DTO> DS_KHNoTien()
        {
            return HoaDonBanHang_DAL.DS_KHNoTien();
        }
        public static List<string> DS_TongNo(string s)
        {
            return HoaDonBanHang_DAL.DS_TongNo(s);
        }
    }
}
