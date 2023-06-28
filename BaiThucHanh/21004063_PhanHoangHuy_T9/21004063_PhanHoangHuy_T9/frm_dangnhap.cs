using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21004063_PhanHoangHuy_T9
{
    public partial class frm_dangnhap : Form
    {
        public frm_dangnhap()
        {
            InitializeComponent();
        }

        ketnoi kn = new ketnoi();

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_dangnhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        string ms;
        int quyen;

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            ms = txt_dangnhap.Text;
            string mk = txt_matkhau.Text;
            string sql = "SELECT Matkhau, Quyen FROM Nhanvien WHERE MSNhanvien = '"+ms+"' ";
            // mở kết nối
            if (kn.connOpen())
            {
                SqlDataReader dr = kn.SelectSql(sql);
                if (dr.Read())
                {
                    if (mk == dr["Matkhau"].ToString())
                    {
                        quyen = int.Parse(dr["Quyen"].ToString());
                        frm_nhanvien nv = new frm_nhanvien();
                        nv.quyen = quyen;
                        nv.Show();
                        this.Hide();

                        // nêu mỗi quyền mở 1 form khác nhau
                        /*if (quyen == "1")
                        {
                            frm_nhanvien nv = new frm_nhanvien();
                            nv.Show();
                            this.Hide();
                        }
                        else if (quyen == "2")
                        {
                            frm_nhanvien nv = new frm_nhanvien();
                            nv.Show();
                            this.Hide();
                        }
                        else
                        {
                            frm_nhanvien nv = new frm_nhanvien();
                            nv.Show();
                            this.Hide();
                        }*/

                    }
                    else
                        MessageBox.Show("Bạn nhập sai mật khẩu!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                    MessageBox.Show("Tài khoản không tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dr.Close();

            }
            else
                MessageBox.Show("Không kết nối được đến CSDL!!!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            kn.connClose();


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_matkhau.PasswordChar = '\0';// Ký tự null để hiển thị mật khẩu thường
            }
            else
            {
                // Ẩn mật khẩu
                txt_matkhau.PasswordChar = '$'; // Hoặc bất kỳ ký tự khác bạn muốn sử dụng
            }

}
    }
}
