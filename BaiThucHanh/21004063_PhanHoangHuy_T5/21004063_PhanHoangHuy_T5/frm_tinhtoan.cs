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
    public partial class frm_tinhtoan : Form
    {
        public frm_tinhtoan()
        {
            InitializeComponent();
        }

        
        private void frm_tinhtoan_Load(object sender, EventArgs e)
        {
            
        }

        private void txt_nhapso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txt_ketthuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        List<int> arr = new List<int>();
        
            
        

        private void btn_tong_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt_nhapso.Text);
            int b = Convert.ToInt32(txt_ketthuc.Text);
            if (a > b)
            {
                MessageBox.Show("Số kết thúc không được nhỏ hơn số bắt đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = a; i <= b; i++)
            {
                arr.Add(i);
            }

            int tong = 0;
            foreach (int i in arr)
                tong += i;
            txt_tong.Text = tong.ToString();
        }

        private void btn_tich_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt_nhapso.Text);
            int b = Convert.ToInt32(txt_ketthuc.Text);
            if (a > b)
            {
                MessageBox.Show("Số kết thúc không được nhỏ hơn số bắt đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = a; i <= b; i++)
            {
                arr.Add(i);
            }

            long tich = 1;
            foreach (int i in arr)
                tich *= i;
            txt_tich.Text = tich.ToString();
        }

        private void btn_tongchan_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt_nhapso.Text);
            int b = Convert.ToInt32(txt_ketthuc.Text);
            if (a > b)
            {
                MessageBox.Show("Số kết thúc không được nhỏ hơn số bắt đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = a; i <= b; i++)
            {
                arr.Add(i);
            }

            int tong = 0;
            foreach (int i in arr)
                if (i % 2 == 0)
                    tong += i;
            txt_tongchan.Text = tong.ToString();
        }

        private void btn_tongle_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt_nhapso.Text);
            int b = Convert.ToInt32(txt_ketthuc.Text);
            if (a > b)
            {
                MessageBox.Show("Số kết thúc không được nhỏ hơn số bắt đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = a; i <= b; i++)
            {
                arr.Add(i);
            }

            int tong = 0;
            foreach (int i in arr)
                if (i % 2 != 0)
                    tong += i;
            txt_tongle.Text = tong.ToString();

        }
    }
}
