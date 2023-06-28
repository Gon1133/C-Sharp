using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21004063_PhanHoangHuy_T4
{
    public partial class bai8 : Form
    {
        public bai8()
        {
            InitializeComponent();
        }

        private void btn_timthu_Click(object sender, EventArgs e)
        {
            string date = txt_ngay.Text + "/" + txt_thang.Text + "/" + txt_nam.Text;
            try
            {
                DateTime dt = DateTime.Parse(date);
                string day = dt.ToString("dddd", new CultureInfo("vi-VN"));
                lbl_ketqua.Text = "Ngày "+txt_ngay.Text+" tháng "+txt_thang.Text+" năm "+txt_nam.Text+" là ngày thứ "+ day;
            }
            catch (Exception)
            {
                MessageBox.Show("nhap sai","thong bao",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            

        }

        private void txt_ngay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) )
                e.Handled = true;
            if (txt_ngay.Text.Length == 2)
                if (!char.IsControl(e.KeyChar))
                    e.Handled= true;

        }

        private void txt_thang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
            if (txt_thang.Text.Length == 2)
                if (!char.IsControl(e.KeyChar))
                    e.Handled = true;
        }

        private void txt_nam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
            if (txt_nam.Text.Length == 4)
                if (!char.IsControl(e.KeyChar))
                    e.Handled = true;
        }

        
    }
}
