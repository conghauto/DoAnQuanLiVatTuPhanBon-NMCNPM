using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCUAHANG_DTO
{
   public class DaiLi_DTO
    {
        private string maDL;
        private string tenDL;
        private string diaChi;
        private string soDT;
        private double tongNo;
        public string MaDL
        {
            get
            {
                return maDL;
            }

            set
            {
                maDL= value;
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
