using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21004063_PhanHoangHuy_T7
{
    internal class Connection
    {
        //properties
        private string strConn = @"server=HUYPR0V1P; database=QLNS_HUY; uid=sa; pwd=123456";
        
        public SqlConnection conn { get; set; }
        public SqlCommand cmd { get; set; }
        public SqlDataReader drd { get; set; }
        public SqlDataAdapter da { get; set; }

        //constructors
        public Connection()
        {
            conn = new SqlConnection(strConn);
            cmd = null;
            drd = null;
            da = null;
        }

        //method
        public bool openConn()
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

        public bool closeConn()
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

        // Mô hình kết nối
        // đọc dữ liệu từ CSDL -> DataReader -> Client đọc
        public SqlDataReader executeSQL(string sql)
        {
            cmd = new SqlCommand(sql,conn);
            drd = cmd.ExecuteReader();
            return drd;
            
        }

        // cập nhật dữ liệu
        public int executeUpdate(string sql)
        {
            cmd = new SqlCommand(sql, conn);
            return cmd.ExecuteNonQuery();
        }

        // mô hình ngắt kêt nối
        // đổ dữ liệu từ CSDL -> DataAdapter -> DataTable (DataSet - Client)
        public DataTable loadDataTable(string sql)
        {
            cmd = new SqlCommand(sql, conn);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        // cập nhật dữ liệu từ DataTable vào CSDL qua DataAdapter (Tương đồng bảng)
        public void UpdateTable(DataTable dt)
        {
            SqlCommandBuilder scb = new SqlCommandBuilder(da);
            da.Update(dt);
        }



    }
}
