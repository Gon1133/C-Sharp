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
    public partial class Bai5 : Form
    {
        List<TextBox> txt = new List<TextBox>();
        public Bai5()
        {
            InitializeComponent();
            txt.Add(txt_khachhang);
            txt.Add(txt_csc);
            txt.Add(txt_csm);
            txt.Add(txt_dongia);
            txt.Add(txt_thanhtien);
        }
        

        private void Bai5_Load(object sender, EventArgs e)
        {
            lbl_ngaythu.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private void txt_csc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void txt_csm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void txt_dongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        public void btn_tinhtien_Click(object sender, EventArgs e)
        {
            double csc = Convert.ToDouble(txt_csc.Text);
            double csm = Convert.ToDouble(txt_csm.Text);
            double dongia = Convert.ToDouble(txt_dongia.Text);
            if (csc > csm)
            {
                MessageBox.Show("chỉ số mới không được nhỏ hơn chỉ số cũ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_csm.Focus();
            }
            else
            {
                txt_thanhtien.Text = ((csm - csc)*dongia).ToString();
                foreach (TextBox t in txt)
                {
                    t.Enabled = false;
                }
            }

        }
        
        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            foreach(TextBox t in txt)
            {
                t.Clear();
                t.Enabled = true;
            }
            txt_thanhtien.Enabled = false;
            txt_khachhang.Focus();
        }
    }
}
