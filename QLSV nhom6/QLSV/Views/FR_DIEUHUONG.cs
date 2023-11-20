using System;
using System.Windows.Forms;
using DAL;
namespace QLSV.Views

{
    public partial class FR_DIEUHUONG : Form
    {
        private string matk;
        private string pq;
        public FR_DIEUHUONG(string matk, string pq)
        {
            InitializeComponent();
            this.matk = matk;
            this.pq = pq;

        }
        private KetNoi kn = KetNoi.LayDoiTuong();
        private void iconMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void iconMenuItem3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FR_DIEUHUONG_Load(object sender, EventArgs e)
        {
            switch (pq) 
            {
                case "GV":
                    mn_SV.Visible = false;
                    mn_GV.Visible = false;
                    mn_Khoa.Visible = false;
                    mn_Mon.Visible = false;
                    mn_Lop.Visible = false;
                    break;
                case "SV":
                    mn_SV.Visible = false;
                    mn_GV.Visible = false;
                    mn_Khoa.Visible = false;
                    mn_Mon.Visible = false;
                    mn_QlDiem.Visible = false;
                    break;
                default:
                    break;

            
            }
        }

        private void mn_Napdl_Click(object sender, EventArgs e)
        {

        }

        private void iconMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void nhậpĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FR_NHAPDIEM fr = new FR_NHAPDIEM(kn);
            fr.MdiParent = this;
            fr.Show();
        }
    }
}
