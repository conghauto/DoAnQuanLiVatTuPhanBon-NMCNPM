using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCUAHANG_DTO
{
   public  class QuanLi_TienNoKH_DTO
    {
        private string maTT;
        private string maKH;
        private DateTime ngayTra;
        private double soTienTra;
        private int tinhTrang;

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

        public DateTime NgayTra
        {
            get
            {
                return ngayTra;
            }

            set
            {
                ngayTra = value;
            }
        }

        public string MaTT
        {
            get
            {
                return maTT;
            }

            set
            {
                maTT = value;
            }
        }

        public double SoTienTra
        {
            get
            {
                return soTienTra;
            }

            set
            {
                soTienTra = value;
            }
        }

        public int TinhTrang
        {
            get
            {
                return tinhTrang;
            }

            set
            {
                tinhTrang = value;
            }
        }
    }
}
