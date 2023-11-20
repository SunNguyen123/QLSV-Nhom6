using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.SinhVien;
namespace DAO
{
   public class Diem
    {
        private string sinhvien;

        public string MaSV
        {
            get { return sinhvien; }
            set { sinhvien = value; }
        }

        private string mon;

        public string MaMon
        {
            get { return mon; }
            set { mon = value; }
        }
        private float diemtx;

        public float DiemTX
        {
            get { return diemtx; }
            set { diemtx = value; }
        }

        private float diemkt1;

        public float DiemKT1
        {
            get { return diemkt1; }
            set { diemkt1 = value; }
        }

        private float diemkt2;

        public float DiemKT2
        {
            get { return diemkt2; }
            set { diemkt2 = value; }
        }

        private float diemthi;

        public float DiemThi
        {
            get { return diemthi; }
            set { diemthi = value; }
        }

        private float diemtb;

        public float DiemTB
        {
            get { return diemtb; }
            set { diemtb = value; }
        }

        private string trangthai;

        public string TrangThai
        {
            get { return trangthai; }
            set { trangthai = value; }
        }

        private string ghichu;

        public string GhiChu
        {
            get { return ghichu; }
            set { ghichu = value; }
        }

    }
}
