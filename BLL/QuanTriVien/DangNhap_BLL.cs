using DAL;
using DAO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.QuanTriVien
{
   public class DangNhap_BLL
    {
        private IKetNoi kn;
        public DangNhap_BLL(IKetNoi kn)
        {
            this.kn = kn;
        }
        public bool KiemTraTaiKhoan(string tk,string mk,ref string matk,ref string pq) 
        {

           List<TAIKHOAN> ds= kn.TruyVan<TAIKHOAN>($"SELECT MaTk,PhanLoai FROM TAIKHOAN WHERE TaiKhoan='{tk.Trim()}' AND MatKhau='{mk.Trim()}'");
         
            if (ds.Count>0) 
            {
                matk = ds[0].MaTk.ToString();
                pq = ds[0].PhanLoai.ToString();
                return true;
            }
            return false;
        }
    }
}
