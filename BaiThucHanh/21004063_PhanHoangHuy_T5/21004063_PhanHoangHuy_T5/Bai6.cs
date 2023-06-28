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
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }

        private void txt_a_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            //cho phep nhap 1 lan '.'
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txt_b_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            //cho phep nhap 1 lan '.'
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void btn_tinh_Click(object sender, EventArgs e)
        {
            double a = 0,b = 0;
            try
            {
                a = Convert.ToDouble(txt_a.Text.Trim());
                b = Convert.ToDouble(txt_b.Text.Trim());
            }
            catch (Exception)
            {
                MessageBox.Show("không được nhập 2 lần ký tự '-' và '.'","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            

            if (rad_cong.Checked)
            {
                txt_ketqua.Text = (a + b).ToString();
            }
            else if (rad_tru.Checked)
            {
                txt_ketqua.Text = (a - b).ToString();
            }
            else if (rad_nhan.Checked)
            {
                txt_ketqua.Text = (a * b).ToString();
            }
            else if (rad_chia.Checked)
            {
                if (b==0)
                    MessageBox.Show("không thể chia cho 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    txt_ketqua.Text = (a / b).ToString();
            }
            else MessageBox.Show("người dùng chưa chọn phép tính","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_a.Clear();
            txt_b.Text = "";
            txt_ketqua.Text = "";
            rad_cong.Checked = false;
            rad_tru.Checked = false;
            rad_nhan.Checked = false;
            rad_chia.Checked = false;

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
