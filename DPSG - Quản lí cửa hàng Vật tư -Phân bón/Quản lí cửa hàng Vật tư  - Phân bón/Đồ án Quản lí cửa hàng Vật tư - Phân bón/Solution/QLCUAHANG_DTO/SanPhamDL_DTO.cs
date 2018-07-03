using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCUAHANG_DTO
{
    public class SanPhamDL_DTO
    {
        private string maSPDL;
        private string tenSP;
        private string maDL;
        private double gia;
        private string donVi;
        private string thongSo;

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

        public string TenSP
        {
            get
            {
                return tenSP;
            }

            set
            {
                tenSP = value;
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

        public double Gia
        {
            get
            {
                return gia;
            }

            set
            {
                gia = value;
            }
        }

        public string DonVi
        {
            get
            {
                return donVi;
            }

            set
            {
                donVi = value;
            }
        }
        public string ThongSo
        {
            get
            {
                return thongSo;
            }

            set
            {
                thongSo = value;
            }
        }
    }
}
