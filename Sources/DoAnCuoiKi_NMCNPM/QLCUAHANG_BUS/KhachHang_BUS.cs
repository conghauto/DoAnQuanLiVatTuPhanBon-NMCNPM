using QLCUAHANG_DAL;
using QLCUAHANG_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCUAHANG_BUS
{
    public class KhachHang_BUS
    {
        public static List<KhachHang_DTO> LoadDSKhachHang()
        {
            return KhachHang_DAL.LoadListKhachHang();
        }

        public static bool ThemKhachHang(KhachHang_DTO khachhang)
        {
            return KhachHang_DAL.ThemKhachHang(khachhang);
        }
        public static bool SuaKH(KhachHang_DTO khachhang)
        {
            return KhachHang_DAL.SuaKhachHang(khachhang);
        }

        public static bool XoaKH(KhachHang_DTO khachhang)
        {
            return KhachHang_DAL.XoaKH(khachhang);
        }

        public static List<KhachHang_DTO> TimKiemKhachHang(string tuKhoa)
        {
            return KhachHang_DAL.TimKiemKhachHang(tuKhoa);
        }
        public static List<KhachHang_DTO> TimKiemKhachHang2(string tuKhoa)
        {
            return KhachHang_DAL.TimKiemKhachHang2(tuKhoa);
        }
    }
}
