﻿using System;
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
            Application.Run(new FR_DIEUHUONG());
        }
    }
}