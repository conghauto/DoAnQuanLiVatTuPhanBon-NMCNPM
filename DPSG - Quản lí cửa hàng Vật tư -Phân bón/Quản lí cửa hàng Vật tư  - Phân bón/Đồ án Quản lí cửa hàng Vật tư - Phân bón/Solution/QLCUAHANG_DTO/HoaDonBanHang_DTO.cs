using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCUAHANG_DTO
{
    public class HoaDonBanHang_DTO
    {
        private string maHDB;
        private string tenCH;
        private string maKH;
        private string tenKH;
        private DateTime ngayNhap;
        private double tongTien;
        private double tongNo;
        private string ghiChu;

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

        public string TenCH
        {
            get
            {
                return tenCH;
            }

            set
            {
                tenCH = value;
            }
        }

        public string MaKH
        {
            get
            {
                return maKH;
            }

            set
            {
                maKH = value;
            }
        }

        public string TenKH
        {
            get
            {
                return tenKH;
            }

            set
            {
                tenKH = value;
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

        public string GhiChu
        {
            get
            {
                return ghiChu;
            }

            set
            {
                ghiChu = value;
            }
        }
    }
}
