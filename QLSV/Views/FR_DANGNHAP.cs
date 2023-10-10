using System;
using QLSV.Views;
using System.Windows.Forms;
using BLL.QuanTriVien;
using DAL;
using System.Threading.Tasks;

namespace QLSV.Views
{
    public partial class FR_DANGNHAP : Form
    {
        private DangNhap_BLL dangNhap_bll; 
       

        public FR_DANGNHAP(IKetNoi kn)
        {
            InitializeComponent();           
            dangNhap_bll = new DangNhap_BLL(kn);
         
        }
        private FR_EMAIL fr_Email = null;
        private void LayLaiMatKhau_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fr_Email = new FR_EMAIL();
            fr_Email.ShowDialog();
        }
        private string[] PhanQuyen = { "Quản trị viên","Giáo Viên","Sinh Viên" };
        private string matk = "";
        private string phanquyen = "";
        private  void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked) 
            {
                Properties.Settings.Default.TK = textBox1.Text.Trim();
                Properties.Settings.Default.MK = textBox2.Text.Trim();
                Properties.Settings.Default.Save();
            }
            else 
            {
                Properties.Settings.Default.TK = "";
                Properties.Settings.Default.MK = "";
                Properties.Settings.Default.Save();
            }
            bool kq = dangNhap_bll.KiemTraTaiKhoan(textBox1.Text, textBox2.Text, ref matk, ref phanquyen);
            if (kq) 
            { 
            
            FR_DIEUHUONG fr_dieuhuong = new FR_DIEUHUONG(matk,phanquyen);
            this.Visible = false;
            fr_dieuhuong.ShowDialog();
            this.Visible = true;
            }
            else 
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu sai!","Thông báo!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void FR_DANGNHAP_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.TK.ToString();
            textBox2.Text = Properties.Settings.Default.MK.ToString();

        }
    }
}
