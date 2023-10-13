using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.GiaoVien
{
   public class GiaoVien
    {
        private string magv;

        public string MaGV
        {
            get { return magv; }
            set { magv = value; }
        }
        private string tengv;

        public string TenGV
        {
            get { return tengv; }
            set { tengv = value; }
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

        private Khoa khoa;

        public Khoa Khoa1
        {
            get { return khoa; }
            set { khoa = value; }
        }

        private TAIKHOAN tk;

        public TAIKHOAN Tk
        {
            get { return tk; }
            set { tk = value; }
        }

    }
}
