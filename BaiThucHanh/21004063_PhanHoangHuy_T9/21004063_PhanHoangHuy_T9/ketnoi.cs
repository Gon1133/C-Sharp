using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21004063_PhanHoangHuy_T9
{
    internal class ketnoi
    {
        private string strKetnoi = @"server=HUYPR0V1P; database=QLNS; uid=sa; pwd=123456";
        private SqlConnection conn { get; set; }
        private SqlCommand cmd { get; set; }
        private SqlDataReader dr { get; set; }

        private SqlDataAdapter da { get; set; }

        public ketnoi()
        {
            conn = new SqlConnection(strKetnoi);
            cmd = null;
            dr = null;
            da = null;
        }
        // mở kết nối
        public bool connOpen()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        // đóng kết nối
        public bool connClose()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        // truy vấn dữ liệu
        public SqlDataReader SelectSql(string sql)
        {
            cmd = new SqlCommand(sql, conn);
            dr = cmd.ExecuteReader();
            return dr;
        }
        // cập nhật dữ liệu
        public int UpdateSql(string sql)
        {
            cmd = new SqlCommand(sql,conn);
            int kq = cmd.ExecuteNonQuery();
            return kq;
        }


    }
}
