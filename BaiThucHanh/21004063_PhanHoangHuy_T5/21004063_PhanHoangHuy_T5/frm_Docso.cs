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
    public partial class frm_Docso : Form
    {
        public frm_Docso()
        {
            InitializeComponent();
        }

        private void txt_nhapso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
            if (e.KeyChar == (char)Keys.Enter)
                btn_doc.PerformClick();
            if (txt_nhapso.Text.Length == 1)
                if (!char.IsControl(e.KeyChar))
                    e.Handled = true;
        }

        private void btn_doc_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txt_nhapso.Text);
            switch (n)
            {
                case 0: txt_chuso.Text = "Không"; break;
                case 1: txt_chuso.Text = "Một"; break;
                case 2: txt_chuso.Text = "Hai"; break;
                case 3: txt_chuso.Text = "Ba"; break;
                case 4: txt_chuso.Text = "Bốn"; break;
                case 5: txt_chuso.Text = "Năm"; break;
                case 6: txt_chuso.Text = "Sáu"; break;
                case 7: txt_chuso.Text = "Bảy"; break;
                case 8: txt_chuso.Text = "Tám"; break;
                case 9: txt_chuso.Text = "Chín"; break;
            }
        }
    }
}
