using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCUAHANG_DTO
{
    public class QuanLiTIenNo_DaiLi_DTO
    {
        private string maTN;
        private string maDL;
        private DateTime ngayTra;
        private double soTienTra;

        public string MaTN
        {
            get
            {
                return maTN;
            }

            set
            {
                maTN = value;
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
    }
}
