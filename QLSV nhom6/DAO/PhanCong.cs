using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.GiaoVien;
using DAO.SinhVien;

namespace DAO
{
    public class PhanCong
    {
        private GiaoVien1 giaovien;

        public GiaoVien1 GiaoVien
        {
            get { return giaovien; }
            set { giaovien = value; }
        }

        private Lop lop;

        public Lop LopHoc
        {
            get { return lop; }
            set { lop = value; }
        }

        private Mon monhoc;

        public Mon MonHoc
        {
            get { return monhoc; }
            set { monhoc = value; }
        }

        private bool hocki;

        public bool HocKi
        {
            get { return hocki; }
            set { hocki = value; }
        }

        private DateTime namhoc;

        public DateTime NamHoc
        {
            get { return namhoc; }
            set { namhoc = value; }
        }

    }
}
