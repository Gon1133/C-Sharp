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
    public partial class frm_bcnnucln : Form
    {
        public frm_bcnnucln()
        {
            InitializeComponent();
        }

        private void txt_m_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_n_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        public int UCLN(int n, int m)
        {
            if (m == 0) return n;
            return UCLN(m, n % m);
        }

        public int BCNN(int n, int m)
        {
            return (n*m)/UCLN(n, m);
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txt_n.Text);
            int m = Convert.ToInt32(txt_m.Text);
            txt_bcnn.Text = BCNN(n, m).ToString();
            txt_ucln.Text = UCLN(n, m).ToString();
        }
    }
}
