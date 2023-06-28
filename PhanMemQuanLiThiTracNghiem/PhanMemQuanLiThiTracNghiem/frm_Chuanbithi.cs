using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLiThiTracNghiem
{
    public partial class frm_Chuanbithi : Form
    {
        public frm_Chuanbithi()
        {
            InitializeComponent();
        }

        private void frm_Chuanbithi_Load(object sender, EventArgs e)
        {
            Ngayhientai();
        }

        
        public void LayThongTinSV(string uid)
        {
            using (SqlConnection sqlConnection = ConnectionData.GetSqlConnection())
            {
                sqlConnection.Open();
                string ht = "select MSSV, MALOP, HOTENSV from SINHVIEN where MSSV = '" + uid + "'";
                SqlCommand cmd = new SqlCommand(ht, sqlConnection);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    lab_baodanh.Text = rdr[0].ToString();
                    lab_lop.Text = rdr[1].ToString();
                    lab_hoten.Text = rdr[2].ToString();
                }
                rdr.Close();
            }

            DateTime now = DateTime.Now;
            string monthi = "select MONHOC.MAMON, MONHOC.TENMON, DETHI.SOLUONGCAUHOI, DETHI.THOIGIANTHI from MONHOC INNER JOIN LOPHP ON LOPHP.MAMON = MONHOC.MAMON INNER JOIN DETHI ON DETHI.MALOPHP = LOPHP.MALOPHP INNER JOIN COSINHVIEN ON COSINHVIEN.MALOPHP = LOPHP.MALOPHP where MSSV = '"+uid+"' AND NGAYTHI = '" + now.ToString("yyyy-MM-dd") + "' ";
            SqlDataAdapter da = new SqlDataAdapter(monthi, ConnectionData.GetSqlConnection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbb_monthi.DataSource = dt;
            cbb_monthi.ValueMember = "MAMON";
            cbb_monthi.DisplayMember = "TENMON";

        }
        Modify modify = new Modify();
        
        private void cbb_monthi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_monthi.SelectedIndex != -1)
            {
                DataRowView selectedRow = (DataRowView)cbb_monthi.SelectedItem;

                // Lấy giá trị từ cột DETHI.SOLUONGCAUHOI và DETHI.THOIGIANTHI của dòng được chọn trong ComboBox
                string soLuongCauHoi = selectedRow["SOLUONGCAUHOI"].ToString() + " câu";
                string thoiGianThi = selectedRow["THOIGIANTHI"].ToString()+ " phút";

                // Gán giá trị vào các label tương ứng
                lab_cauhoi.Text = soLuongCauHoi;
                lab_thoigianthi.Text = thoiGianThi;
            }
        }
        public void Ngayhientai()
        {
            DateTime date = DateTime.Now;
            string thu = date.ToString("dddd", new CultureInfo("vi-VN"));
            lab_hientai.Text = "Lịch thi ngày " + thu + ", " + date.ToString("dd/MM/yyyy");
        }



        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_DangNhap frm_DangNhap = new frm_DangNhap();
            frm_DangNhap.Show();
        }
    }
}
