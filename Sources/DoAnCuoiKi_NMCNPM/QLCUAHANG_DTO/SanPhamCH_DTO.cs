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
        private byte[] hinhAnh;

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

        public byte[] HinhAnh
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
    }
}
