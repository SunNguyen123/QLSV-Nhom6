using System;
using QLSV.Views;
using System.Windows.Forms;

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
            FR_DANGNHAP fr_DangNhap = new FR_DANGNHAP();
            if(fr_DangNhap.ShowDialog()==DialogResult.OK) Application.Run(new FR_DIEUHUONG());
        }
    }
}
