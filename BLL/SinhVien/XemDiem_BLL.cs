using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAO;

namespace BLL.SinhVien
{
    public class XemDiem_BLL
    {
        private IKetNoi kn;

        public XemDiem_BLL(IKetNoi kn)
        {
            this.kn = kn;
        }

        public bool tracuudiem(string masv, string mammon)
        {
            return false;
        }

    }
}
