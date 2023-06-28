using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21004063_PhanHoangHuy_T8
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void xemDanhSáchSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_dsSanpham frm = new frm_dsSanpham();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
