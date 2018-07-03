using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCUAHANG_DTO
{
    public class ChiTietHoaDonBan_DTO
    {
        private string maHDB;
        private string maSPCH;
        private int soLuong;
        private string donViTinh;
        private int hinhThucBan;
        private int soLuongMuaLe;
       

        public string MaHDB
        {
            get
            {
                return maHDB;
            }

            set
            {
                maHDB = value;
            }
        }

        public string MaSPCH
        {
            get
            {
                return maSPCH;
            }

            set
            {
                maSPCH = value;
            }
        }

        public int SoLuong
        {
            get
            {
                return soLuong;
            }

            set
            {
                soLuong = value;
            }
        }

        public string DonViTinh
        {
            get
            {
                return donViTinh;
            }

            set
            {
                donViTinh = value;
            }
        }

        public int HinhThucBan
        {
            get
            {
                return hinhThucBan;
            }

            set
            {
                hinhThucBan = value;
            }
        }

        public int SoLuongMuaLe
        {
            get
            {
                return soLuongMuaLe;
            }

            set
            {
                soLuongMuaLe = value;
            }
        }
    }
}
