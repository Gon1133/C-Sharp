using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21004063_PhanHoangHuy_T5
{
    public partial class Bai12 : Form
    {
        public Bai12()
        {
            InitializeComponent();
        }

        private void Bai12_Load(object sender, EventArgs e)
        {
            
        }

        private void đọcSốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Docso docso = new frm_Docso();
            docso.MdiParent = this;
            docso.Show();
        }

        private void bảngCửuChươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_bangcuuchuong bcc = new frm_bangcuuchuong();
            bcc.MdiParent = this;
            bcc.Show();
        }

        private void tìmSốLớnNhấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_timmax tm = new frm_timmax();
            tm.MdiParent = this;
            tm.Show();
        }

        private void chẵnLẻÂmDươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_chanleamduong clam = new frm_chanleamduong();
            clam.MdiParent = this;
            clam.Show();
        }

        private void sốNguyênTốSốChínhPhươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ngtocp clam = new frm_ngtocp();
            clam.MdiParent = this;
            clam.Show();
        }

        private void tínhBCNNVàUCLNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_bcnnucln clam = new frm_bcnnucln();
            clam.MdiParent = this;
            clam.Show();
        }

        private void tínhToánTrênDãySốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_tinhtoan clam = new frm_tinhtoan();
            clam.MdiParent = this;
            clam.Show();
        }

        private void minMaxAvgVàAvgMulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_minmax clam = new frm_minmax();
            clam.MdiParent = this;
            clam.Show();
        }
    }
}
