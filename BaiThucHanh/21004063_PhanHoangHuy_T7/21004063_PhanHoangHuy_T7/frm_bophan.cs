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
    public partial class frm_bophan : Form
    {
        public frm_bophan()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // tạo kết nối
            Connection conn = new Connection();
            // mở kết nối
            conn.openConn();
            // xử lý
            SqlDataReader drd = conn.executeSQL("SELECT MSBophan, TenBophan FROM Bophan");
            while (drd.Read())
            {
                string ms = drd["MSBophan"].ToString();
                string ten = drd["TenBophan"].ToString();
                // tạo cột trong datagridview trước khi add chuỗi
                dgv_bophan.Rows.Add(ms, ten);
            }
            // đóng DataReader
            drd.Close();
            // Đóng kết nối
            conn.closeConn();


        }
    }
}
