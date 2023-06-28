using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21004063_PhanHoangHuy
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_tinh_Click(object sender, EventArgs e)
        {
            double r=0;
            try
            {
                r = Convert.ToDouble(txt_bankinh.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("không được nhập chữ cái", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_bankinh.Clear();
                txt_bankinh.Focus();
            }
                
            
            double cv = 2 * r * Math.PI ;
            double dt = Math.PI * r * r;
            txt_chuvi.Text = cv.ToString();
            txt_dientich.Text = dt.ToString();
        }

        private void txt_bankinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btn_tieptuc_Click(object sender, EventArgs e)
        {
            txt_bankinh.Clear();
            txt_chuvi.Clear();
            txt_dientich.Clear();
            txt_bankinh.Focus();
        }
    }
}
