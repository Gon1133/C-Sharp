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
    public partial class frm_bangcuuchuong : Form
    {
        public frm_bangcuuchuong()
        {
            InitializeComponent();
        }

        private void txt_nhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
            if (e.KeyChar == (char)Keys.Enter)
                btn_thuchien.PerformClick();
            if (txt_nhap.Text.Length == 2)
                if (char.IsControl(e.KeyChar))
                    e.Handled = true;
        }

        private void btn_thuchien_Click(object sender, EventArgs e)
        {
            
            /*int n = Convert.ToInt32(txt_nhap.Text);
            int tong;
            string ketqua;
            int width = 
            for (int i=1; i<10; i++)
            {
                tong = n * i;
                ketqua = n.ToString() + " x " + i.ToString() + " = " + tong.ToString();
                lst_cuuchuong.Items.Add(ketqua);
            }*/
            
        }
    }
}
