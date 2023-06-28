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
    public partial class frm_ngtocp : Form
    {
        public frm_ngtocp()
        {
            InitializeComponent();
        }

        private void txt_nhapso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        public Boolean Ngto(int n)
        {
            if (n == 0 || n == 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
                
            }
            return true;
            

        }


        private void txt_kiemtra_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txt_nhapso.Text);
            if (Ngto(n))
                MessageBox.Show(n.ToString() + " là số nguyên tố.");
            else
                MessageBox.Show(n.ToString() + " không phải số nguyên tố.");

            if (n == 0 || n == 1)
            {
                MessageBox.Show(n.ToString() + " không là số chính phương.");
                return;
            }
            if (Math.Sqrt(n) == (int)Math.Sqrt(n))
            {
                MessageBox.Show(n.ToString() + " là số chính phương.");
            }
            else MessageBox.Show(n.ToString() + " không là số chính phương.");

        }
    }
}
