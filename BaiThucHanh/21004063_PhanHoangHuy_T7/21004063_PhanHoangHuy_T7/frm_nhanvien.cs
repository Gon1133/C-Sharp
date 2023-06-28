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

namespace _21004063_PhanHoangHuy_T7
{
    public partial class frm_nhanvien : Form
    {
        public frm_nhanvien()
        {
            InitializeComponent();
        }
        // tạo kết nối
        Connection conn = new Connection();
        bool flag ;
        

        private void frm_nhanvien_Load(object sender, EventArgs e)
        {

            // mô hình ngắt kết nối
            conn.openConn();
            //load combobox
            string sql = "SELECT IDBophan, MSBophan + ' - ' + TenBophan " +
                            "AS hienthi FROM Bophan";
            DataTable dt = conn.loadDataTable(sql);
            cbb_bophan.DataSource = dt;
            cbb_bophan.ValueMember = "IDBophan";
            cbb_bophan.DisplayMember = "hienthi";
            // Load datagridview
            sql = "SELECT MSNhanvien, Hoten, Ngaysinh, Gioitinh FROM Nhanvien " +
                "WHERE IDBophan = '" + cbb_bophan.SelectedValue + "'";
            DataTable dt2 = conn.loadDataTable(sql);
            dgv_nhanvien.DataSource = dt2;
            // Đóng kết nối
            conn.closeConn();
            flag = true;

            btn_chinhsua.Enabled = false;
            btn_xoa.Enabled = false;

        }
        private void cbb_bophan_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }
        private void cbb_bophan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                // mở
                string sql = "SELECT MSNhanvien, Hoten, Ngaysinh, Gioitinh FROM Nhanvien WHERE IDBophan = " + cbb_bophan.SelectedValue.ToString();
                DataTable dt = conn.loadDataTable(sql);
                dgv_nhanvien.DataSource = dt;
                
            }
            
        }
        private void dgv_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_nhanvien.Rows[e.RowIndex];
            // mở kết nối
            txt_msnv.Text = row.Cells[0].Value.ToString();
            txt_hoten.Text = row.Cells[1].Value.ToString();
            dtp_ns.Value = DateTime.Parse(row.Cells[2].Value.ToString());
            if (bool.Parse(row.Cells[3].Value.ToString()))
                rad_nam.Checked = true;
            else    rad_nu.Checked = true;

            // ngắt kết nối
            string ms = txt_msnv.Text;
            conn.openConn();
            string s = "select Email, Diachi, SDT from Nhanvien where MSNhanvien = '"+ms+"'";
            SqlDataReader dr = conn.executeSQL(s);
            while(dr.Read())
            {
                txt_email.Text = dr["Email"].ToString();
                txt_diachi.Text = dr["Diachi"].ToString();
                txt_sdt.Text = dr["SDT"].ToString();
            }
            dr.Close();
            conn.closeConn();

            btn_chinhsua.Enabled = true;
            txt_msnv.Enabled = false;
            txt_hoten.Enabled = false;
            dtp_ns.Enabled = false;
            rad_nam.Enabled = false;
            rad_nu.Enabled = false;
            txt_email.Enabled = false;
            txt_diachi.Enabled = false;
            txt_sdt.Enabled = false;

            btn_them.Enabled = false;
            btn_xoa.Enabled = true;


        }

        private void btn_lamlai_Click(object sender, EventArgs e)
        {
            conn.openConn();
            string sql = "SELECT MSNhanvien, Hoten, Ngaysinh, Gioitinh FROM Nhanvien " +
                "WHERE IDBophan = '" + cbb_bophan.SelectedValue + "'";
            DataTable dt2 = conn.loadDataTable(sql);
            dgv_nhanvien.DataSource = dt2;
            conn.closeConn();

            txt_msnv.Clear();
            txt_hoten.Clear();
            dtp_ns.Value = DateTime.Now;
            rad_nam.Checked = false;
            rad_nu.Checked = false;
            txt_email.Clear();
            txt_diachi.Clear();
            txt_sdt.Clear();
            txt_msnv.Enabled = true;
            txt_hoten.Enabled = true;
            dtp_ns.Enabled = true;
            rad_nam.Enabled = true;
            rad_nu.Enabled = true;
            txt_email.Enabled = true;
            txt_diachi.Enabled = true;
            txt_sdt.Enabled = true;

            btn_chinhsua.Enabled = false;
            btn_them.Enabled = true;
            btn_xoa.Enabled = false;

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            
            string ms = txt_msnv.Text.Trim();
            string ht = txt_hoten.Text.Trim();
            string ns = dtp_ns.Value.ToString("yyyy-MM-dd");
            string gt = "";
            if (rad_nam.Checked)
            {
                gt = "1";
            }
            else if (rad_nu.Checked)
                gt = "0";
            string email = txt_email.Text.Trim();
            string diachi = txt_diachi.Text.Trim();
            string sdt = txt_sdt.Text.Trim();
            string bp = cbb_bophan.SelectedValue.ToString();
            try
            {
                conn.openConn();
                bool flag = false;

                string sql = "select MSNhanvien from Nhanvien";
                SqlDataReader dr = conn.executeSQL(sql);
                while (dr.Read())
                {
                    if (dr["MSNhanvien"].ToString() == ms)
                    {
                        MessageBox.Show("Đã tồn tại nhân viên " + ms);
                        return;
                    }
                    flag = true;
                }
                dr.Close();

                if (flag)
                {
                    sql = "INSERT INTO Nhanvien VALUES ('" + ms + "', N'" + ht + "', '" + ns + "', " + gt + ", '" + email + "', N'" + diachi + "', '" + sdt + "', " + bp + ") ";
                    int data = conn.executeUpdate(sql);
                    btn_lamlai.PerformClick();
                    MessageBox.Show("Đã thêm " + data + " nhân viên vào danh sách");
                }

                conn.closeConn();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Nhập sai thông tin !","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string ms = txt_msnv.Text.Trim();
                int data = 0;

                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa nhân viên " + ms + "", "Lưu ý !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    conn.openConn();
                    string sql = "delete from Nhanvien where MSNhanvien = '" + ms + "'";
                    data = conn.executeUpdate(sql);
                    conn.closeConn();
                    btn_lamlai.PerformClick();

                    MessageBox.Show("Bạn đã xóa " + data + " nhân viên.");
                }
                else return;

            }
            catch (Exception)
            {
                MessageBox.Show("Không xóa được thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_chinhsua_Click(object sender, EventArgs e)
        {
            try
            {
                if (btn_chinhsua.Text == "Chỉnh sửa")
                {
                    txt_msnv.Enabled = false;
                    txt_hoten.Enabled = true;
                    dtp_ns.Enabled = true;
                    rad_nam.Enabled = true;
                    rad_nu.Enabled = true;
                    txt_email.Enabled = true;
                    txt_diachi.Enabled = true;
                    txt_sdt.Enabled = true;

                    btn_chinhsua.Text = "Lưu";
                }
                else if (btn_chinhsua.Text == "Lưu")
                {
                    conn.openConn();
                    string ms = txt_msnv.Text.Trim();
                    string ht = txt_hoten.Text.Trim();
                    string ns = dtp_ns.Value.ToString("yyyy-MM-dd");
                    string gt = "";
                    if (rad_nam.Checked)
                    {
                        gt = "1";
                    }
                    else if (rad_nu.Checked)
                        gt = "0";
                    string email = txt_email.Text.Trim();
                    string diachi = txt_diachi.Text.Trim();
                    string sdt = txt_sdt.Text.Trim();
                    string bp = cbb_bophan.SelectedValue.ToString();
                    string sql = "UPDATE Nhanvien SET Hoten = N'"+ht+"', Ngaysinh = '"+ns+"', Gioitinh = '"+gt+"', Email = '"+email+"', Diachi = '"+diachi+"', SDT = '"+sdt+"', IDBophan = '"+bp+"' WHERE MSNhanvien = '"+ms+"'  ";
                    
                    int kq = conn.executeUpdate(sql);
                    btn_lamlai.PerformClick();
                    if (kq > 0)
                    {
                        MessageBox.Show("Chỉnh sửa thông tin nhân viên thành công");
                        btn_chinhsua.Text = "Chỉnh sửa";

                    } else MessageBox.Show("Không tìm thấy nhân viên với MSNV là "+ms);
                    


                    conn.closeConn();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không chỉnh sửa được thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
