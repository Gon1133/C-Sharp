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
    public partial class frm_chanleamduong : Form
    {
        public frm_chanleamduong()
        {
            InitializeComponent();
        }

        private void txt_nhapso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-')
                e.Handled = true;
            
        }

        private void btn_kiemtra_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(txt_nhapso.Text);
                if (n == 0) MessageBox.Show("0 là số không âm không dương không chẵn không lẻ", "thông báo");
                else if (n < 0)
                {
                    if (n % 2 == 0)
                        MessageBox.Show(n.ToString() + " Là số chẵn âm", "thông báo");
                    else MessageBox.Show(n.ToString() + " Là số lẻ âm", "thông báo");
                }
                else if (n > 0)
                {
                    if (n % 2 == 0)
                        MessageBox.Show(n.ToString() + " Là số chẵn dương", "thông báo");
                    else MessageBox.Show(n.ToString() + " Là số lẻ dương", "thông báo");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
