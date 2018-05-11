using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCUAHANG_DTO
{
    public class KhachHang_DTO
    {
        private string maKH;
        private string tenKH;
        private string diaChi;
        private string soDT;

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
        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        public string SoDT
        {
            get
            {
                return soDT;
            }

            set
            {
                soDT = value;
            }
        }

       
    }
}
