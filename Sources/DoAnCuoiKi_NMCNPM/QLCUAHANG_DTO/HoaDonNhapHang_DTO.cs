using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCUAHANG_DTO
{
    public class HoaDonNhapHang_DTO
    {
        private string maHDN;
        private string maDL;
        private string tenDL;
        private DateTime ngayNhap;
        private double tongTien;
        private double tongNo;

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

        public string MaDL
        {
            get
            {
                return maDL;
            }

            set
            {
                maDL = value;
            }
        }

        public string TenDL
        {
            get
            {
                return tenDL;
            }

            set
            {
                tenDL = value;
            }
        }

        public DateTime NgayNhap
        {
            get
            {
                return ngayNhap;
            }

            set
            {
                ngayNhap = value;
            }
        }

        public double TongTien
        {
            get
            {
                return tongTien;
            }

            set
            {
                tongTien = value;
            }
        }

        public double TongNo
        {
            get
            {
                return tongNo;
            }

            set
            {
                tongNo = value;
            }
        }
    }
}
