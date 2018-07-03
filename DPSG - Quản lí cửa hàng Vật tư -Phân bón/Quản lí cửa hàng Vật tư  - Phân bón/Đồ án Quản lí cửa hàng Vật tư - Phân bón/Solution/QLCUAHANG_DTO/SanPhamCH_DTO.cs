using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace QLCUAHANG_DTO
{

    public class SanPhamCH_DTO
    {
        private string maSPCH;
        private string tenSP;
        private double gia;
        private string donVi;
        private int soLuong;
        private string hinhAnh;
        private string thongSo;
        private int banLe;
        private int soLuongLe;

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

        public string HinhAnh
        {
            get
            {
                return hinhAnh;
            }

            set
            {
                hinhAnh = value;
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

        public int BanLe
        {
            get
            {
                return banLe;
            }

            set
            {
                banLe = value;
            }
        }

        public int SoLuongLe
        {
            get
            {
                return soLuongLe;
            }

            set
            {
                soLuongLe = value;
            }
        }
    }
}
