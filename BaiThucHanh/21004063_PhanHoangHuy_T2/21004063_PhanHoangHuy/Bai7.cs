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
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
        }

        private void txt_gio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ':')
                e.Handled = true;
            //cho phep nhap 1 lan ':'
            if (e.KeyChar == ':' && (sender as TextBox).Text.IndexOf(':') > -1)
            {
                e.Handled = true;
            }
        }

        private void btn_chao_Click(object sender, EventArgs e)
        {
            
            string[] time = txt_gio.Text.Split(':');
            int h = Convert.ToInt32(time[0]);
            int m=0;
            try
            {
                m = Convert.ToInt32(time[1]); 
            }
            catch (Exception)
            {

                
            }

            if (h >= 25 || m >= 60)
                MessageBox.Show("Nhập sai giá trị", "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (h >= 5 && h < 12)
                    MessageBox.Show("Good Morning", "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (h >= 12 && h < 18)
                    MessageBox.Show("Good Afternoon", "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (h >= 18 && h < 22)
                    MessageBox.Show("Good Evening", "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (h >= 22 || h < 4)
                    MessageBox.Show("Good Night", "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            


        }
    }
}
