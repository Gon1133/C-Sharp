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

namespace _21004063_PhanHoangHuy
{
    public partial class Bai8 : Form
    {
        public Bai8()
        {
            InitializeComponent();
        }
        
        private void txt_ngay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_thang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_nam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btn_timthu_Click(object sender, EventArgs e)
        {
            int ngay, thang, nam;
            try
            {
                ngay = Convert.ToInt32(txt_ngay.Text);
                thang = Convert.ToInt32(txt_thang.Text);
                nam = Convert.ToInt32(txt_nam.Text);
                lbl_ketqua.Text = "Ngày " + ngay + " tháng " + thang + " năm " + nam + " là ngày ";
                DateTime date = new DateTime();
                if (nam == 0)
                    MessageBox.Show("Nhập sai năm", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (thang == 0 || thang > 12)
                    MessageBox.Show("Nhập sai tháng", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (thang == 1 || thang == 3 || thang == 5 || thang == 7 || thang == 8 || thang == 10 || thang == 12)
                {
                    if (ngay == 0 || ngay > 31)
                        MessageBox.Show("Nhập sai ngày", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        date = new DateTime(nam, thang, ngay);

                        lbl_ketqua.Text += date.ToString("dddd", new CultureInfo("vi-VN"));
                    }


                }
                else if (thang == 4 || thang == 6 || thang == 9 || thang == 11)
                {
                    if (ngay == 0 || ngay > 30)
                        MessageBox.Show("Nhập sai ngày", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        date = new DateTime(nam, thang, ngay);

                        lbl_ketqua.Text += date.ToString("dddd", new CultureInfo("vi-VN"));
                    }
                }
                else if (thang == 2)
                    if (nam % 4 == 0)
                    {
                        if (ngay == 0 || ngay > 29)
                            MessageBox.Show("Nhập sai ngày", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            date = new DateTime(nam, thang, ngay);
                            lbl_ketqua.Text += date.ToString("dddd", new CultureInfo("vi-VN"));
                        }
                    }
                    else
                    {
                        if (ngay == 0 || ngay > 28)
                            MessageBox.Show("Nhập sai ngày", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            date = new DateTime(nam, thang, ngay);
                            lbl_ketqua.Text += date.ToString("dddd", new CultureInfo("vi-VN"));
                        }
                    }
            }
            catch (Exception)
            {
                MessageBox.Show("Không được bỏ trống", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }
    }
}
