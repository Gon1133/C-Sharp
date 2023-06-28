using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21004063_PhanHoangHuy_T9
{
    public partial class frm_bophan : Form
    {
        public frm_bophan()
        {
            InitializeComponent();
        }

        ketnoi kn = new ketnoi();
        public int quyen;
        int idbp;
        string msold;


        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            frm_nhanvien frm = new frm_nhanvien();
            frm.quyen = quyen;
            frm.Show();
            this.Close();
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            frm_dangnhap frm = new frm_dangnhap();
            frm.Show();
            this.Close();
        }

        private void frm_bophan_Load(object sender, EventArgs e)
        {
            try
            {
                // mở kết nối
                kn.connOpen();
                string sql = "SELECT MSBophan, TenBophan FROM Bophan";
                SqlDataReader dr = kn.SelectSql(sql);
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgv_bophan.DataSource = dt;
                dr.Close();
                // dong ket noi
                kn.connClose();
            }
            catch (Exception)
            {
                MessageBox.Show("Khong ket noi duoc voi CSDL");
            }


           
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;

        }

        private void dgv_bophan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_bophan.Rows[e.RowIndex];
            txt_ms.Text = row.Cells[0].Value.ToString();
            msold = row.Cells[0].Value.ToString();
            txt_ten.Text = row.Cells[1].Value.ToString();
            kn.connOpen();
            string sql = "SELECT IDBophan FROM Bophan WHERE MSBophan = '"+msold+"' ";
            SqlDataReader dr = kn.SelectSql(sql);
            while (dr.Read())
            {
                idbp = int.Parse(dr["IDBophan"].ToString());
            }
            dr.Close();
            kn.connClose();

            txt_ms.Enabled = false;
            txt_ten.Enabled = false;
            btn_them.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;


        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            try
            {
                // mở kết nối
                kn.connOpen();
                string sql = "SELECT MSBophan, TenBophan FROM Bophan";
                SqlDataReader dr = kn.SelectSql(sql);
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgv_bophan.DataSource = dt;
                dr.Close();
                // dong ket noi
                kn.connClose();
            }
            catch (Exception)
            {
                MessageBox.Show("Khong ket noi duoc voi CSDL");
            }

            txt_ten.Clear();
            txt_ms.Clear();

            txt_ms.Enabled = true;
            txt_ten.Enabled = true;
            btn_them.Enabled = true;
            btn_sua.Enabled = false;
            btn_sua.Text = "Chỉnh sửa";
            btn_xoa.Enabled = false;


        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            kn.connOpen();
            string ms = txt_ms.Text;
            string ten = txt_ten.Text;
            try
            {
                // kiểm tra ms 
                string select = "SELECT MSBophan FROM Bophan WHERE MSBophan = '"+ms+"' ";
                SqlDataReader dr = kn.SelectSql(select);
                if (dr.Read())
                {
                    if (ms == dr["MSBophan"].ToString())
                    {
                        MessageBox.Show("Da ton tai ma so bo phan " + ms);
                        dr.Close();    
                    }
                }
                else
                {
                    // dong Reader
                    dr.Close();
                    // them du lieu moi
                    string sql = "INSERT INTO Bophan VALUES ('"+ms+"', N'"+ten+"') ";
                    int dl = kn.UpdateSql(sql);
                    if (dl > 0)
                    {
                        MessageBox.Show("Them thanh cong");
                        btn_lammoi.PerformClick();
                    }
                    else MessageBox.Show("Them that bai");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Da co loi xay ra");
            }
            kn.connClose();

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            kn.connOpen();
            string ms = txt_ms.Text;
            string ten = txt_ten.Text;

            DialogResult rs = MessageBox.Show("Ban chac chan xoa bo phan " + ten, "Thong bao",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                string sql = "DELETE FROM Bophan WHERE MSBophan = '"+ms+"'  ";
                int dl = kn.UpdateSql(sql);
                if (dl > 0)
                {
                    MessageBox.Show("Xoa thanh cong");
                    btn_lammoi.PerformClick();
                }
                else MessageBox.Show("Xoa that bai");
            }
            else
                return;
            kn.connClose();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (btn_sua.Text == "Chỉnh sửa")
            {
                txt_ms.Enabled = true;
                txt_ten.Enabled = true;
                btn_xoa.Enabled = false;

                btn_sua.Text = "Lưu";
            }
            else
            {
                string msnew = txt_ms.Text;
                string ten = txt_ten.Text;
                //B1: Tạo đối tượng thuộc lớp Connection
                //B2: Mở kết nối
                if (kn.connOpen())
                {
                    //B3: Xử lý dữ liệu
                    //-- Kiem tra rang buoc du lieu
                    if (msold == msnew)
                    {
                        string strUPDATE = "UPDATE Bophan SET MSBophan = '"+ msold +"', TenBophan = '"+ten+"' WHERE IDBophan = " + idbp;
                        int kq = kn.UpdateSql(strUPDATE);
                        if (kq > 0)
                        {
                            btn_lammoi.PerformClick();
                            MessageBox.Show("Cập nhật thành công");
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật không thành công");
                            MessageBox.Show("UPDATE Bophan SET MSBophan = '" + msold + "', TenBophan = '" + ten + "' WHERE IDBophan = " + idbp);
                        }
                    }
                    else
                    {
                        string strSELECT = "SELECT IDBophan FROM Bophan WHERE " +
                         "MSBophan='" + msnew + "'";
                        SqlDataReader dr = kn.SelectSql(strSELECT);
                        if (dr.Read())
                        {
                            MessageBox.Show("Mã số bộ phận mới đã tồn tại");
                            dr.Close();
                        }
                        else
                        {
                            dr.Close();
                            string strUPDATE = "UPDATE Bophan SET MSBophan = '" + msnew + "', TenBophan = '" + ten + "' WHERE IDBophan = " + idbp;
                            int kq = kn.UpdateSql(strUPDATE);
                            if (kq > 0)
                            {
                                btn_lammoi.PerformClick();
                                MessageBox.Show("Cập nhật thành công");
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật không thành công");
                                MessageBox.Show("UPDATE Bophan SET MSBophan = '" + msnew + "', TenBophan = '" + ten + "' WHERE IDBophan = " + idbp);
                            }
                        }
                    }

                    //B4: Đóng kết nối
                    kn.connClose();
                    
                }
                else
                    MessageBox.Show("Không thể kết nối CSDL");
            }
        }
    }
}
