using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.SinhVien
{
    public class SinhVien
    {


        private string masv;

        public string MaSV
        {
            get { return masv; }
            set { masv = value; }
        }

        private string tensv;

        public string TenSV
        {
            get { return tensv; }
            set { tensv = value; }
        }

        private DateTime ngaysinh;

        public DateTime NgaySinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }

        private bool gioitinh;

        public bool GioiTinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }

        private string diachi;

        public string DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }

        private int sdt;

        public int SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }


    }
}
