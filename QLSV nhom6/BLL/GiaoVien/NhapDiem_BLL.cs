using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAO;
using System.Data.SqlClient;


 namespace BLL.GiaoVien
{
    public class NhapDiem_BLL
    {
        private IKetNoi kn;

        public NhapDiem_BLL(IKetNoi kn)
        {
            this.kn = kn;
        }
        public void themdiem(string masv, string mamon, string diemtx, string diemkt1, string diemkt2, string diemtb, string diemthi)
        {
            kn.ThucThi($"insert into DIEM values('{masv}','{mamon}',{diemtx},{diemkt1},{diemkt2},{diemthi},{diemtb},'A',NULL)");
        }
        public void xoadiem(string masv,string mamon)
        {
            kn.ThucThi($"delete from DIEM where MaSV='{masv}' and MaMon='{mamon}'");
        }
        
        public void suadiem(string masv, string mamon, string diemtx, string diemkt1, string diemkt2, string diemtb, string diemthi)
        {
            kn.ThucThi($"update DIEM set DiemTX={diemtx},DiemKT1={diemkt1},DiemKT2={diemkt2},DiemTB={diemtb},DiemThi={diemthi} where MaSV='{masv}' and MaMon='{mamon}'");
        }
    }
}
