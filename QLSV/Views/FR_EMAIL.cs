using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV.Views
{
    public partial class FR_EMAIL : Form
    {
        public FR_EMAIL()
        {
            InitializeComponent();
        }

        private void FR_EMAIL_Load(object sender, EventArgs e)
        {
            pn_NhapMa.Visible = false;
        }

        private void bt_GuiMa_Click(object sender, EventArgs e)
        {
            pn_NhapMa.Visible = true;
        }
    }
}
