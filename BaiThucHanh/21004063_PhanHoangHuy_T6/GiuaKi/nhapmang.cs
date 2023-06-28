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
    public partial class nhapmang : Form
    {
        private static int slptu;
        private static int[] mangtemp;
        int i;

        public static int Slptu { get => slptu; set => slptu = value; }
        public static int[] Mangtemp { get => mangtemp; set => mangtemp = value; }

        public nhapmang()
        {
            InitializeComponent();
        }

        private void nhapmang_Load(object sender, EventArgs e)
        {
            slptu = bai14.N;
            i = 0;
            lbl_i.Text = (i+1).ToString();
            txt_nhap.Focus();
            mangtemp = new int[slptu];
        }

        private void btn_nhap_Click(object sender, EventArgs e)
        {
            if (i <= slptu - 1)
            {
                //Còn nhập được
                try
                {
                    int value = int.Parse(txt_nhap.Text.Trim());
                    mangtemp[i] = value;
                    i++;
                    if (i == slptu)
                    {
                        //Trả mảng về cho form cha
                        bai14.Mangnhap = mangtemp;
                        this.Close();
                    }
                    lbl_i.Text = (i + 1).ToString();
                    txt_nhap.Clear();
                    txt_nhap.Focus();
                }
                catch
                {
                    txt_nhap.Clear();
                    txt_nhap.Focus();
                    MessageBox.Show("Dữ liệu nhập không hợp lệ");
                }
            }
            else
            {
                //Trả mảng về cho form cha
                bai14.Mangnhap = mangtemp;
                this.Close();
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_nhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char) Keys.Enter)
            {
                btn_nhap.PerformClick();
            }
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }
    }
}
