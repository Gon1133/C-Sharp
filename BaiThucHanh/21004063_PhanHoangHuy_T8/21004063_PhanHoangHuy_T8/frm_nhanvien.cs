using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21004063_PhanHoangHuy_T8
{
    public partial class frm_nhanvien : Form
    {
        public frm_nhanvien()
        {
            InitializeComponent();
        }
        LINQConnection conn = new LINQConnection();

        private void frm_nhanvien_Load(object sender, EventArgs e)
        {
            var dsBophan = conn.db.Bophans;
            // Nạp dữ liệu cho combobox bộ phận
            cbb_bophan.DataSource = dsBophan.Select(bp => new { bp.IDBophan, Display = bp.MSBophan + " - " + bp.TenBophan });
            cbb_bophan.ValueMember = "IDBophan";
            cbb_bophan.DisplayMember = "Display";
            // Gọi bộ xử lý sự kiện cbb_bophan_SelectionChangeCommitted 
            // để nạp dữ liệu cho dgv nhân viên theo bộ phận
            cbb_bophan_SelectionChangeCommitted(cbb_bophan, EventArgs.Empty);
        }

        
        private void dgv_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgv_nhanvien.CurrentRow;
            string ms = row.Cells[0].Value.ToString();
            Nhanvien nv = conn.db.Nhanviens.Where(o => o.MSNhanvien == ms).FirstOrDefault();
            if (nv != null)
            {
                txt_msnv.Text = nv.MSNhanvien.ToString();
                txt_hoten.Text = nv.Hoten.ToString();
                dtp_ns.Value =DateTime.Parse(nv.Ngaysinh.ToString());
                if (nv.Gioitinh == true)
                    rad_nu.Checked = true;
                else rad_nam.Checked = true;
                txt_email.Text = nv.Email.ToString();
                txt_diachi.Text = nv.Diachi.ToString();
                txt_sdt.Text = nv.SDT.ToString();

                btn_them.Enabled = false;
                btn_chinhsua.Text = "Chỉnh sửa";
                btn_xoa.Enabled = true;
                foreach (Control c in Controls)
                    if (c is TextBox || c is DateTimePicker || c is RadioButton)
                        c.Enabled = false;
            }

        }

        private void cbb_bophan_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadNhanvien();
        }

        private void loadNhanvien()
        {
            var dsNVbophan = conn.db.Nhanviens.Where(nv => nv.IDBophan == Convert.ToInt32(cbb_bophan.SelectedValue)).Select(nv => new { nv.MSNhanvien, nv.Hoten, nv.Ngaysinh, nv.Gioitinh });
            dgv_nhanvien.DataSource = dsNVbophan;
            dgv_nhanvien.AutoGenerateColumns = false;
        }

        private void btn_lamlai_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox || c is DateTimePicker || c is RadioButton)
                    c.Enabled = true;
                if (c is TextBox || c is DateTimePicker)
                    c.ResetText();
            }
            rad_nam.Checked = true;
            cbb_bophan.SelectedIndex = 0;
            btn_them.Enabled = true;
            btn_xoa.Enabled = true;
            btn_chinhsua.Text = "Chỉnh sửa";
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                // kiểm tra mã số nhân viên đã có trong csdl chưa
                Nhanvien old = conn.db.Nhanviens.Where(o => o.MSNhanvien == txt_msnv.Text).FirstOrDefault();

                if (old == null)
                {
                    // tạo đối tượng mới từ lớp nhân viên
                    // (một lớp trong mô hình đối tượng QLNS_HUY.dbml)
                    Nhanvien nv = new Nhanvien();
                    nv.MSNhanvien = txt_msnv.Text;
                    nv.Hoten = txt_hoten.Text;
                    nv.Ngaysinh = dtp_ns.Value;
                    nv.Gioitinh = rad_nu.Checked;
                    nv.Email = txt_email.Text;
                    nv.Diachi = txt_diachi.Text;
                    nv.SDT = txt_sdt.Text;
                    nv.IDBophan = Convert.ToInt32(cbb_bophan.SelectedValue);
                    // Thêm đối tượng mới tạo vào cơ sở dữ liệu (conn.db)
                    conn.db.Nhanviens.InsertOnSubmit(nv);
                    // Lưu thay đổi vào cơ sở dữ liệu vật lý
                    conn.db.SubmitChanges();
                    MessageBox.Show("Thêm thông tin nhân viên thành công");
                    cbb_bophan_SelectionChangeCommitted(cbb_bophan, EventArgs.Empty);
                    btn_lamlai.PerformClick();
                }
                else MessageBox.Show("Mã số nhân viên đã tồn tại");
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể thêm thông tin nhân viên");
            }
        }

        private void btn_chinhsua_Click(object sender, EventArgs e)
        {
            if (btn_chinhsua.Text == "Chỉnh sửa")
            {
                foreach (Control c in Controls)
                    if (c is TextBox && c != txt_msnv || c is DateTimePicker || c is RadioButton)
                        c.Enabled = true;
                btn_xoa.Enabled = false;
                btn_chinhsua.Text = "Lưu";
            }
            else if (btn_chinhsua.Text == "Lưu")
            {
                // kiểm tra đã có nhân viên trong csdl chưa
                Nhanvien nv = conn.db.Nhanviens.Where(o => o.MSNhanvien == txt_msnv.Text).FirstOrDefault();

                if (nv != null)
                {
                    // nếu đã có nhân viên thì cập nhật lại các thuộc tính theo dữ liệu mới
                    nv.MSNhanvien = txt_msnv.Text;
                    nv.Hoten = txt_hoten.Text;
                    nv.Ngaysinh = dtp_ns.Value;
                    nv.Gioitinh = rad_nu.Checked;
                    nv.Email = txt_email.Text;
                    nv.Diachi = txt_diachi.Text;
                    nv.SDT = txt_sdt.Text;
                    nv.IDBophan = Convert.ToInt32(cbb_bophan.SelectedValue);
                    // Lưu thay đổi vào cơ sở dữ liệu vật lý
                    conn.db.SubmitChanges();
                    // Cập nhật lại frm_nhanvien
                    MessageBox.Show("Chỉnh sửa thông tin nhân viên thành công");
                    cbb_bophan_SelectionChangeCommitted(cbb_bophan, EventArgs.Empty);
                    btn_lamlai.PerformClick();
                }
                else MessageBox.Show("Không tìm thấy nhân viên với mã số là "+txt_msnv.Text);
            }


        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn muốn xóa thông tin " +
                "nhân viên với MSNV là "+txt_msnv.Text,"Xóa thông tin nhân viên",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                // kiểm tra xem nv có trong csdl ko
                Nhanvien nv = conn.db.Nhanviens.Where(o => o.MSNhanvien == txt_msnv.Text).FirstOrDefault();
                if (nv != null)
                {
                    // xóa nhân viên 
                    conn.db.Nhanviens.DeleteOnSubmit(nv);
                    // lưu lại thay đổi
                    conn.db.SubmitChanges();
                    MessageBox.Show("Xóa thông tin nhân viên thành công");
                    cbb_bophan_SelectionChangeCommitted(cbb_bophan, EventArgs.Empty);
                    btn_lamlai.PerformClick();
                }
                else MessageBox.Show("Không tìm thấy thông tin nhân viên có MSNV là "+txt_msnv.Text);
            }
        }
    }
}
