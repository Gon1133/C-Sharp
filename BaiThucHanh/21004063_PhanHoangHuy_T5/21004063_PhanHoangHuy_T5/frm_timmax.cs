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
    public partial class frm_timmax : Form
    {
        public frm_timmax()
        {
            InitializeComponent();
        }

        private void txt_a_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_b_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt_a.Text);
            int b = Convert.ToInt32(txt_b.Text);
            
            if (a > b) txt_max.Text = a.ToString();
            else txt_max.Text = b.ToString();

        }

        private void btn_tieptuc_Click(object sender, EventArgs e)
        {
            txt_max.Clear();
            txt_a.Clear();
            txt_b.Clear();
            txt_a.Focus();
        }
    }
}
