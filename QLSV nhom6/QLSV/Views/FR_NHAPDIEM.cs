using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.GiaoVien;
using DAL;

namespace QLSV.Views
{
    public partial class FR_NHAPDIEM : Form
    {


        private NhapDiem_BLL nhapdiem_bll;
        private IKetNoi kn;
        public FR_NHAPDIEM(IKetNoi kn)
        {
            InitializeComponent();
            nhapdiem_bll = new NhapDiem_BLL(kn);
            this.kn = kn;
        }

        private void FR_NHAPDIEM_Load(object sender, EventArgs e)
        {
            LOAD();
        }
        private void LOAD(){
            dgv_nhapdiem.DataSource = kn.TruyVan<DAO.Diem>("select * from DIEM");
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            string masv = txt_masv.Text;
            string mamon = txt_mamon.Text;
            string diemtx = txt_diemtx.Text;
            string diemkt1 = txt_diem1.Text;
            string diemkt2 = txt_diem2.Text;
            string diemthi = txt_diemthi.Text;
            string diemtb = txt_diemtb.Text;


            nhapdiem_bll.themdiem(masv, mamon, diemtx, diemkt1, diemkt2, diemthi, diemtb);
            LOAD();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            string masv = txt_masv.Text;
            string mamon = txt_mamon.Text;

            nhapdiem_bll.xoadiem(masv, mamon);
            LOAD();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string masv = txt_masv.Text;
            string mamon = txt_mamon.Text;
            string diemtx = txt_diemtx.Text;
            string diemkt1 = txt_diem1.Text;
            string diemkt2 = txt_diem2.Text;
            string diemthi = txt_diemthi.Text;
            string diemtb = txt_diemtb.Text;

            nhapdiem_bll.suadiem( mamon,masv,diemtx, diemkt1, diemkt2, diemthi, diemtb);
        }
    }
}
