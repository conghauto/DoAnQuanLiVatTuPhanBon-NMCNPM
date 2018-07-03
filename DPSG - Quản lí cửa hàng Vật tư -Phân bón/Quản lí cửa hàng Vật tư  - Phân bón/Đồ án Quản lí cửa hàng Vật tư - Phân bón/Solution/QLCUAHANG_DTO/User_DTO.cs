using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCUAHANG_DTO
{
   public  class User_DTO
    {
        private int iD;
        private string userName;
        private string chucVu;
        private string diaChi;
        private string soDT;

        public int ID
        {
            get
            {
                return iD;
            }

            set
            {
                iD = value;
            }
        }

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public string ChucVu
        {
            get
            {
                return chucVu;
            }

            set
            {
                chucVu = value;
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
