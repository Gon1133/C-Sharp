using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21004063_PhanHoangHuy_T4
{
    public partial class bai11 : Form
    {
        public bai11()
        {
            InitializeComponent();
        }

        private void txt_nhapso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // nếu nhập có phím enter 
            {
                btn_nhap.PerformClick(); // kích hoạt chức năng click
                //e.Handled = true; // ngăn ko cho ký tự enter vào textbox
            }
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btn_nhap_Click(object sender, EventArgs e)
        {
            try
            {
                int so = int.Parse(txt_nhapso.Text);
                lbx_nhapso.Items.Add(so);
                txt_nhapso.Clear();
                txt_nhapso.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập số", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
                txt_nhapso.Focus();
            }
        }

        private void btn_ketthuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_tong_Click(object sender, EventArgs e)
        {
            long tong = 0;
            foreach (int item in lbx_nhapso.Items)
            {
                tong += item;
            }
            MessageBox.Show("Tổng các số trong list = "+tong.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            txt_nhapso.Focus();
        }

        private void btn_xoaDC_Click(object sender, EventArgs e)
        {
            if (lbx_nhapso.Items.Count >= 2)
            {
                lbx_nhapso.Items.RemoveAt(0);
                lbx_nhapso.Items.RemoveAt(lbx_nhapso.Items.Count - 1);
            }
            else
            {
                MessageBox.Show("Phải có ít nhất 2 số trong list !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nhapso.Focus();
            }

        }

        private void btn_xoadangchon_Click(object sender, EventArgs e)
        {
            if (lbx_nhapso.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn phần tử trong list !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = lbx_nhapso.SelectedItems.Count - 1; i >= 0; i--) // ko for xuôi đc mỗi vòng lặp sẽ reset selectitem
            {
                int selectIndex = lbx_nhapso.SelectedIndices[i];
                lbx_nhapso.Items.RemoveAt(selectIndex);
            }

        }


        private void btn_tang2_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < lbx_nhapso.Items.Count; i++) 
            {
                int temp = Convert.ToInt32(lbx_nhapso.Items[i]);
                temp += 2;
                lbx_nhapso.Items[i] = temp;
            }
        }

        private void btn_thayBP_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbx_nhapso.Items.Count; i++)
            {
                long temp = Convert.ToInt32(lbx_nhapso.Items[i]);
                temp *= temp;
                lbx_nhapso.Items[i] = temp;
            }
        }

        private void btn_chonC_Click(object sender, EventArgs e)
        {
            lbx_nhapso.SelectedItems.Clear();
            for (int i = 0; i <= lbx_nhapso.Items.Count - 1; i++)
            {
                long temp = Convert.ToInt32(lbx_nhapso.Items[i]);
                if (temp % 2 == 0)
                    lbx_nhapso.SetSelected(i, true);
            }

        }

        private void btn_chonL_Click(object sender, EventArgs e)
        {
            lbx_nhapso.SelectedItems.Clear();
            for (int i = 0; i <= lbx_nhapso.Items.Count - 1; i++)
            {
                long temp = Convert.ToInt32(lbx_nhapso.Items[i]);
                if (temp % 2 != 0)
                    lbx_nhapso.SetSelected(i, true);
            }
        }
    }
}
