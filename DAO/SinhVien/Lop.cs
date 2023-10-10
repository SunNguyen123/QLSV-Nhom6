using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.SinhVien
{
    public class Lop
    {
        private string malop;

        public string MaLop
        {
            get { return malop; }
            set { malop = value; }
        }

        private string tenlop;

        public string TenLop
        {
            get { return tenlop; }
            set { tenlop = value; }
        }

        private int sosv;

        public int SoSV
        {
            get { return sosv; }
            set { sosv = value; }
        }

        private Khoa khoa;

        public Khoa Khoa1
        {
            get { return khoa; }
            set { khoa = value; }
        }



    }


}
