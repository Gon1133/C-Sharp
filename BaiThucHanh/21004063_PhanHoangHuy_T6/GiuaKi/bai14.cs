using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiuaKi
{
    public partial class bai14 : Form
    {
        public bai14()
        {
            InitializeComponent();
            
        }
        public void bai14_Load(object sender, EventArgs e)
        {

        }
        private static int n;
        private static int[] mangnhap;

        public static int N { get => n; set => n = value; }
        public static int[] Mangnhap { get => mangnhap; set => mangnhap = value; }

        private void txt_nhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_phatsinh.PerformClick();
            }
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)){
                e.Handled = true;
            }
            
        }

        private void txt_nhapmang_TextChanged(object sender, EventArgs e)
        {
            if (txt_nhapmang.Text.Length != 0)
            {
                btn_phatsinh.Enabled = true;
            }
            else
                btn_phatsinh.Enabled = false;
            try
            {
                n = Convert.ToInt32(txt_nhapmang.Text);
            }
            catch
            {
            }
        }

        

        private void btn_phatsinh_Click(object sender, EventArgs e)
        {
            nhapmang formnhapmang = new nhapmang();
            nhapmang.Slptu = n;
            formnhapmang.ShowDialog();
            //Nhận mảng trả về
            if (mangnhap.Length > 0)
            {
                string hienthi = "";
                foreach (int item in mangnhap)
                {
                    hienthi += item + " ";
                }
                txt_mang.Text = hienthi;
                btn_giamdan.Enabled = true;
                btn_tangdan.Enabled = true;
                btn_sua.Enabled = true;
                txt_cu.Enabled = true;
                txt_moi.Enabled = true;
            }
        }

        private void btn_tangdan_Click(object sender, EventArgs e)
        {
            for (int i=0; i<mangnhap.Length-2;i++)
            {
                for (int j = i + 1; j < mangnhap.Length - 1; j++)
                    if (mangnhap[i] > mangnhap[j])
                    {
                        int t = mangnhap[i];
                        mangnhap[i] = mangnhap[j];
                        mangnhap[j] = t;
                    }
            }
            string hienthi = "";
            foreach (int item in mangnhap)
            {
                hienthi += item + " ";
            }
            txt_mang.Text = hienthi;

        }

        private void btn_giamdan_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < mangnhap.Length - 1; i++)
            {
                for (int j = i + 1; j < mangnhap.Length; j++)
                    if (mangnhap[i] < mangnhap[j])
                    {
                        int t = mangnhap[i];
                        mangnhap[i] = mangnhap[j];
                        mangnhap[j] = t;
                    }
            }
            string hienthi = "";
            foreach (int item in mangnhap)
            {
                hienthi += item + " ";
            }
            txt_mang.Text = hienthi;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            int cu = Convert.ToInt32(txt_cu.Text);
            int moi = Convert.ToInt32(txt_moi.Text);

            bool flag = false;
            foreach (int item in mangnhap)
            {
                if (item == cu)
                    flag = true;
            }
            if (flag)
            {
                for (int i = 0; i < mangnhap.Length; i++)
                {
                    if (mangnhap[i] == cu)
                    {
                        mangnhap[i] = moi;
                    }
                }
                MessageBox.Show("hoàn thành sửa đổi", "thông báo");
            }
            else MessageBox.Show("không có giá trị " + cu + " trong mang","thông báo");


            string hienthi = "";
            foreach (int item in mangnhap)
            {
                hienthi += item + " ";
            }
            txt_mang.Text = hienthi;

        }

        private void txt_cu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }

        }

        private void txt_moi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void btn_lamlai_Click(object sender, EventArgs e)
        {
            txt_nhapmang.Clear();
            btn_phatsinh.Enabled = false;
            txt_mang.Clear();
            txt_mang.Enabled = false;
            txt_cu.Clear();
            txt_moi.Clear();

        }
    }
}
