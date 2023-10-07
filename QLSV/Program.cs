using System;
using QLSV.Views;
using System.Windows.Forms;
using DAL;

namespace QLSV
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IKetNoi kn = KetNoi.LayDoiTuong();
            kn.Key = Properties.Settings.Default.KeyDB.ToString();
            Application.Run(new FR_DANGNHAP(kn));
        }
    }
}
