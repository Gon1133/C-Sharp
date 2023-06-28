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
using System.Windows.Forms.VisualStyles;

namespace _21004063_PhanHoangHuy_T9
{
    public partial class frm_nhanvien : Form
    {
        public frm_nhanvien()
        {
            InitializeComponent();
        }

        ketnoi kn = new ketnoi();

        public int quyen;
        int idnv;
        string msold;
        string sql;

        public void Giamdoc()
        {
            MessageBox.Show("Xin chao Giam doc");
            foreach (Control c in this.Controls)
            {
                c.Enabled = false;
            }
            //groupBox1.Enabled = true;
            cbb_bophan.Enabled = true;
            btn_bophan.Enabled = true;
            btn_dangxuat.Enabled = true;
        }

        public void Truongphong()
        {
            btn_bophan.Enabled = false;
        }

        private void frm_nhanvien_Load(object sender, EventArgs e)
        {

            kn.connOpen();
            try
            {
                sql = "SELECT IDBophan, MSBophan + ' - ' + TenBophan AS hienthi FROM Bophan";
                SqlDataReader dr = kn.SelectSql(sql);
                DataTable dt = new DataTable();
                dt.Load(dr);
                // tạo hàng đầu cho datatable 
                DataRow item = dt.NewRow();
                item["IDBophan"] = 0;
                item["hienthi"] = "Chọn bộ phận";
                dt.Rows.InsertAt(item, 0);
                // đổ dữ liệu vào combobox
                cbb_bophan.DataSource = dt;
                cbb_bophan.ValueMember = "IDBophan";
                cbb_bophan.DisplayMember = "hienthi";
                dr.Close();
            }
            catch (Exception)
            {

            }
            kn.connClose();
            btn_lammoi.PerformClick();

            // phân quyền
            if (quyen == 1)
                Giamdoc();
            else if (quyen == 2)
                Truongphong();
            //else Nhanvien();



        }

        private void cbb_bophan_SelectedIndexChanged(object sender, EventArgs e)
        {
            kn.connOpen();
            try
            {
                sql = "SELECT MSNhanvien, Hoten, Ngaysinh, Gioitinh, Quyen FROM Nhanvien WHERE IDBophan = '" + cbb_bophan.SelectedValue + "' ";
                SqlDataReader dr = kn.SelectSql(sql);
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgv_nhanvien.DataSource = dt;
                dr.Close();

            }
            catch (Exception)
            {

            }
            kn.connClose();

        }
        private void dgv_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (kn.connOpen() )
            {
                try
                {
                    DataGridViewRow row = dgv_nhanvien.Rows[e.RowIndex];
                    string ms = row.Cells[0].Value.ToString();
                    msold = ms;
                    txt_ms.Text = ms;
                    txt_hoten.Text = row.Cells[1].Value.ToString();
                    dtp_ns.Text = row.Cells[2].Value.ToString();
                    Boolean gt = Boolean.Parse(row.Cells[3].Value.ToString());
                    if (gt)
                        rad_nu.Checked = true;
                    else rad_nam.Checked = true;
                    quyen = int.Parse(row.Cells[4].Value.ToString());
                    if (quyen == 1)
                        rad_giamdoc.Checked = true;
                    else if (quyen == 2)
                        rad_truongphong.Checked = true;
                    else rad_nhanvien.Checked = true;

                    sql = "SELECT IDNhanvien, Matkhau FROM Nhanvien WHERE MSNhanvien = '" + ms + "'";
                    SqlDataReader dr = kn.SelectSql(sql);
                    while (dr.Read())
                    {
                        idnv = int.Parse(dr["IDNhanvien"].ToString());
                        txt_matkhau.Text = dr["Matkhau"].ToString();
                    }
                    kn.connClose();

                }
                catch (Exception)
                {

                }

            }


            btn_them.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            

        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_dangnhap frm = new frm_dangnhap();
            frm.Show();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            kn.connOpen();
            try
            {
                sql = "SELECT MSNhanvien, Hoten, Ngaysinh, Gioitinh, Quyen FROM Nhanvien WHERE IDBophan = '" + cbb_bophan.SelectedValue + "' ";
                SqlDataReader dr = kn.SelectSql(sql);
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgv_nhanvien.DataSource = dt;
                dr.Close();
            }
            catch (Exception)
            {

            }
            kn.connClose();
            //cbb_bophan.SelectedIndex = 0;

            foreach(Control c in this.Controls)
            {
                if (c is TextBox || c is DateTimePicker || c is RadioButton)
                    c.Enabled = false;
                if (c is TextBox || c is DateTimePicker)
                    c.ResetText();
            }
            //
            groupBox2.Enabled = false;
            btn_them.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_sua.Text = "Chỉnh sửa";
            
        }

        private void btn_bophan_Click(object sender, EventArgs e)
        {
            frm_bophan frm = new frm_bophan();
            frm.quyen = quyen;
            frm.Show();
            this.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (kn.connOpen())
            {
                int bp = int.Parse(cbb_bophan.SelectedValue.ToString());
                string ms = txt_ms.Text;
                string ht = txt_hoten.Text;
                string ns = dtp_ns.Value.ToString("yyyy-MM-dd");
                int gt;
                if (rad_nam.Checked)
                    gt = 0;
                else gt = 1;
                int q;
                if (rad_giamdoc.Checked)
                    q = 1;
                else if (rad_truongphong.Checked)
                    q = 2;
                else q = 3;
                string mk = txt_matkhau.Text;
                try
                {
                    // kiểm tra MSNV có tồn tại hay chưa
                    string select = "SELECT MSNhanvien FROM Nhanvien WHERE MSNhanvien = '"+ms+"' ";
                    string msold="";
                    bool flag = false;
                    SqlDataReader dr = kn.SelectSql(select);
                    while (dr.Read())
                    {
                        msold = dr["MSNhanvien"].ToString();
                    }
                    dr.Close();
                    if (ms != msold)
                        flag = true;
                    else flag = false;
                    // thêm nhân viên
                    if (flag)
                    {
                        sql = "INSERT INTO Nhanvien(MSNhanvien, Hoten, Ngaysinh, Gioitinh, Quyen, Matkhau, IDBophan) VALUES ('" + ms + "', N'" + ht + "', '" + ns + "', " + gt + ", " + q + ", '" + mk + "', " + bp + ")";
                        int dl = kn.UpdateSql(sql);
                        if (dl > 0)
                        {
                            btn_lammoi.PerformClick();
                            MessageBox.Show("Them thanh cong");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Da ton tai nhan vien "+msold);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Da co loi xay ra");
                }
                kn.connClose();
            }
            else
                MessageBox.Show("Da co loi xay ra!!!", "Loi!",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string ms = txt_ms.Text;
            DialogResult result = MessageBox.Show("Ban chac chan muon xoa nhan vien " + ms,"Thong bao", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (kn.connOpen())
                {
                    try
                    {
                        sql = "DELETE FROM Nhanvien WHERE IDNhanvien = '" + idnv + "'  ";
                        int dl = kn.UpdateSql(sql);
                        if (dl > 0)
                        {
                            btn_lammoi.PerformClick();
                            MessageBox.Show("Xoa thanh cong");
                        }
                        else
                            MessageBox.Show("Xoa that bai");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("khong the xoa");
                    }

                }
                else
                    MessageBox.Show("Da co loi xay ra!!!", "Loi!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else return;

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (btn_sua.Text == "Chỉnh sửa")
            {
                btn_sua.Text = "Lưu";
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox || c is DateTimePicker || c is RadioButton)
                        c.Enabled = true;
                }
                groupBox2.Enabled = true;
                btn_them.Enabled = false;
                btn_xoa.Enabled = false;
            }
            else
            {
                try
                {
                    int bp = int.Parse(cbb_bophan.SelectedValue.ToString());
                    string msnew = txt_ms.Text;
                    string ht = txt_hoten.Text;
                    string ns = dtp_ns.Value.ToString("yyyy-MM-dd");
                    int gt;
                    if (rad_nam.Checked)
                        gt = 0;
                    else gt = 1;
                    int q;
                    if (rad_giamdoc.Checked)
                        q = 1;
                    else if (rad_truongphong.Checked)
                        q = 2;
                    else q = 3;
                    string mk = txt_matkhau.Text;
                    // mở kết nối
                    kn.connOpen();
                    // kiểm tra MSNV có tồn tại hay chưa
                    if (msold != msnew)
                    {
                        string select = "SELECT IDNhanvien FROM Nhanvien WHERE MSNhanvien = '"+msnew+"'";
                        SqlDataReader dr = kn.SelectSql(select);
                        if (dr.Read())
                        {
                            MessageBox.Show("Ma so nhan vien " + msnew + " da ton tai");
                            dr.Close();
                        }
                        else
                        {
                            dr.Close();
                            sql = "UPDATE Nhanvien SET MSNhanvien = '" + msnew + "', Hoten = N'" + ht + "', Ngaysinh = '" + ns + "', Gioitinh = " + gt + ", Quyen = " + q + ", Matkhau = '" + mk + "', IDBophan = " + bp + " WHERE IDNhanvien = '" + idnv + "'";
                            int dl = kn.UpdateSql(sql);
                            if (dl > 0)
                            {
                                MessageBox.Show("Cap nhat thanh cong");
                                btn_lammoi.PerformClick();

                            }
                            else
                                MessageBox.Show("Cap nhat khong thanh cong");
                        }

                    }
                    else
                    {
                        sql = "UPDATE Nhanvien SET MSNhanvien = '" + msnew + "', Hoten = N'" + ht + "', Ngaysinh = '" + ns + "', Gioitinh = " + gt + ", Quyen = " + q + ", Matkhau = '" + mk + "', IDBophan = " + bp + " WHERE IDNhanvien = '" + idnv + "'";
                        int dl = kn.UpdateSql(sql);
                        if (dl > 0)
                        {
                            MessageBox.Show("Cap nhat thanh cong");
                            btn_lammoi.PerformClick();

                        }
                        else
                            MessageBox.Show("Cap nhat khong thanh cong");
                    }

                    // đóng kết nối
                    kn.connClose();
                }

                catch (Exception)
                {
                    MessageBox.Show("Da co loi xay ra");

                }


            }



        }
    }
}
