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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ht = txt_hoten.Text;
            string ns = txt_ngaysinh.Text;
            string st = txt_sothich.Text;
            string[] text = st.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            string ST = "\n";
            foreach (string s in text)
                ST = ST + "\t" +  s + "\n";
            MessageBox.Show("Tôi tên là: " + ht + "\n" + "Sinh ngày: " + ns + "\n" + "Sở thích: " + ST);
        }

        private void txt_sothich_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
