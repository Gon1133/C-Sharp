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
    public partial class cau9 : Form
    {
        public cau9()
        {
            InitializeComponent();
            
        }
        

        private void txt_toan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;

        }
        private void txt_ly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txt_hoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txt_diemchuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btn_tieptuc_Click(object sender, EventArgs e)
        {
            txt_diemchuan.Clear();
            txt_hoa.Clear();
            txt_ketqua.Clear();
            txt_ly.Clear();
            txt_toan.Clear();
            txt_tongdiem.Clear();
            txt_toan.Focus();
        }

        
        private void btn_tinhtong_Click(object sender, EventArgs e)
        {
            try
            {
                int toan = Convert.ToInt32(txt_toan.Text);
                int ly = int.Parse(txt_ly.Text);
                int hoa = int.Parse(txt_hoa.Text);
                int tong = toan + ly + hoa;
                if (toan > 10)
                {
                    MessageBox.Show("Bạn đã nhập sai điểm, mời bạn nhập lại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_toan.Focus();
                }
                else if (ly > 10)
                {
                    MessageBox.Show("Bạn đã nhập sai điểm, mời bạn nhập lại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_ly.Focus();
                }
                else if (hoa > 10)
                {
                    MessageBox.Show("Bạn đã nhập sai điểm, mời bạn nhập lại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_hoa.Focus();
                }
                txt_tongdiem.Text = tong.ToString();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Hãy nhập điểm","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void btn_ketqua_Click(object sender, EventArgs e)
        {
            btn_tinhtong_Click(sender, e);
            try
            {
                int diemchuan = int.Parse(txt_diemchuan.Text);
                int tongdiem = int.Parse(txt_tongdiem.Text);
                if (diemchuan < tongdiem)
                    txt_ketqua.Text = "Đậu";
                else
                    txt_ketqua.Text = "Rớt";
            }
            catch (Exception)
            {

                MessageBox.Show("Hãy nhập điểm chuẩn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }
    }
}
