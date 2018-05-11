using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCUAHANG_DTO
{
    public class ChiTietHoaDonNhap_DTO
    {
        private string maHDN;
        private string maSPDL;
        private int soLuong;

        public string MaHDN
        {
            get
            {
                return maHDN;
            }

            set
            {
                maHDN = value;
            }
        }

        public string MaSPDL
        {
            get
            {
                return maSPDL;
            }

            set
            {
                maSPDL = value;
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
    }
}
