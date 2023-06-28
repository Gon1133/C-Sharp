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
    public partial class frm_minmax : Form
    {
        public frm_minmax()
        {
            InitializeComponent();
        }
        private void frm_minmax_Load(object sender, EventArgs e)
        {

        }
        private void txt_nhapso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        List<int> list = new List<int>();
        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(txt_nhapso.Text);
                lbx_dayso.Items.Add(n);
            }
            catch (Exception)
            {
                
            }
            
            txt_nhapso.Clear();
            txt_nhapso.Focus();
        }

        private void btn_tinh_Click(object sender, EventArgs e)
        {
            int max = (int)lbx_dayso.Items[0];
            int min = (int)lbx_dayso.Items[0];
            int tong = 0, d = 0;
            long tich = 1;
            for (int i=0; i<lbx_dayso.Items.Count; i++)
            {
                if (max < (int)lbx_dayso.Items[i])
                    max = (int)lbx_dayso.Items[i];
                if (min > (int)lbx_dayso.Items[i])
                    min = (int)lbx_dayso.Items[i];
                tong += (int)lbx_dayso.Items[i];
                tich *= (int)lbx_dayso.Items[i];
                d++;
            }
            double tbc = (tong / d), tbn = Math.Pow(tich, 1 / d);

            txt_max.Text = max.ToString();
            txt_min.Text = min.ToString();
            txt_tbc.Text = tbc.ToString();
            txt_tbn.Text = tbn.ToString();
        }
    }
}
