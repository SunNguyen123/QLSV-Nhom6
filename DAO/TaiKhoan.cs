using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
   public class TAIKHOAN
    {
        private string _maTK;

        public string MaTk
        {
            get { return _maTK; }
            set { _maTK = value; }
        }
        private string _taiKhoan;

        public string TaiKhoan
        {
            get { return _taiKhoan; }
            set { _taiKhoan = value; }
        }
        private string _matKhau;

        public string MatKhau
        {
            get { return _matKhau; }
            set { _matKhau = value; }
        }
        private string _phanLoai;

        public string PhanLoai
        {
            get { return _phanLoai; }
            set { _phanLoai = value; }
        }


    }
}
