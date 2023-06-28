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
    public partial class bai10 : Form
    {
        public bai10()
        {
            InitializeComponent();
        }

        private void txt_nhapso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&& !char.IsControl(e.KeyChar))
                e.Handled=true;
        }
        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            try
            {
                int so = int.Parse(txt_nhapso.Text);
                foreach (int item in cbb_nhapso.Items)
                    if (item == so)
                    {
                        MessageBox.Show("Đã có số này, vui lòng nhập số khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_nhapso.Focus();
                        return;
                    }
                cbb_nhapso.Items.Add(so);
                cbb_nhapso.Text = so.ToString();

                txt_nhapso.Clear();
                txt_nhapso.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("hãy nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbb_nhapso_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbx_nhapso.Items.Clear();
            int so = int.Parse(cbb_nhapso.Text);
            for (int i = 1; i <= so; i++)
                if (so % i == 0)
                {
                    lbx_nhapso.Items.Add(i);
                }
        }

        private void btn_tong_Click(object sender, EventArgs e)
        {
            long tong = 0;
            foreach(int item in lbx_nhapso.Items)
            {
                tong += item;
            }
            MessageBox.Show("Tổng các ước số = " + tong.ToString(), "Tổng", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_demso_Click(object sender, EventArgs e)
        {
            int dem = 0;
            foreach (int item in lbx_nhapso.Items)
            {
                if (item % 2 ==0)
                    dem++;
            }
            MessageBox.Show("số lượng các ước số chẵn = " + dem.ToString(), "Đếm", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        public static Boolean KTSoNgTo(int n)
        {
            if (n < 2) 
                return false;
            for (int i = 2; i <= ((int)Math.Sqrt(n)); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        private void btn_demNT_Click(object sender, EventArgs e)
        {
            int dem = 0;
            foreach (int item in lbx_nhapso.Items)
            {
                if (KTSoNgTo(item))
                    dem++;
            }
            MessageBox.Show("số lượng các ước số nguyên tố = " + dem.ToString(), "Đếm", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}
