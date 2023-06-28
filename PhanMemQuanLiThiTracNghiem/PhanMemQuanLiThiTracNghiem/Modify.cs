using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Data.Common;

namespace PhanMemQuanLiThiTracNghiem
{
    class Modify
    {
        public Modify()
        {
        }
        SqlCommand sqlCommand;      //Dùng để truy vấn
        SqlDataReader dataReader;   //Dùng để đọc dữ liệu trong bảng

        //Hàm truy vấn theo câu query truyền vào và trả về 1 List các đối tượng là UserAccount
        public List<UserAccount> Accounts(string query)
        {
            //string query: là câu truy vấn (SELECT ...)
            List<UserAccount> accounts = new List<UserAccount>();
            //Khởi tạo kết nối -- dùng xong sẽ bị xóa
            using (SqlConnection sqlConnection = ConnectionData.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    accounts.Add(new UserAccount(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetBoolean(3)));
                }
                sqlConnection.Close();
            }
            return accounts;
        }

        public List<Khoa> ThongTinKhoa(string query)
        {
            List<Khoa> khoas = new List<Khoa>();
            //Khởi tạo kết nối -- dùng xong sẽ bị xóa
            using (SqlConnection sqlConnection = ConnectionData.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    khoas.Add(new Khoa(dataReader.GetString(0), dataReader.GetString(1)));
                }
                sqlConnection.Close();
            }
            return khoas;
        }

        public List<Giangvien> ThongTinGiangVien(string query)
        {
            List<Giangvien> giangviens = new List<Giangvien>();
            //Khởi tạo kết nối -- dùng xong sẽ bị xóa
            using (SqlConnection sqlConnection = ConnectionData.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    giangviens.Add(new Giangvien(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetBoolean(4), dataReader.GetDateTime(5), dataReader.GetString(6), dataReader.GetString(7), dataReader.GetBoolean(8)));
                }
                sqlConnection.Close();
            }

            return giangviens;
        }

        public List<Sinhvien> ThongTinSinhVien(string query)
        {
            List<Sinhvien> sinhviens = new List<Sinhvien>();
            //Khởi tạo kết nối -- dùng xong sẽ bị xóa
            using (SqlConnection sqlConnection = ConnectionData.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    sinhviens.Add(new Sinhvien(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetBoolean(5), dataReader.GetDateTime(6), dataReader.GetString(7), dataReader.GetBoolean(8)));
                }
                sqlConnection.Close();
            }
            return sinhviens;
        }


        public bool KiemtraTontai(string sql) // kiểm tra đối tượng có liên kết khóa ngoại hay không để thực hiện xóa thông tin
        {
            using (SqlConnection sqlConnection= ConnectionData.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(sql, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    return true;
                }
                sqlConnection.Close();
            }
            return false;


        }


        public void ChinhSuaDuLieu(string query) 
        {
            using (SqlConnection sqlConnection = ConnectionData.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteReader();
                sqlConnection.Close();
            }
        }

        public string ThongTinDangChuoi(string query)
        {
            string hoTen = "NULL";
            //Khởi tạo kết nối -- dùng xong sẽ bị xóa
            using (SqlConnection sqlConnection = ConnectionData.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    hoTen = dataReader.GetString(0);
                }
                sqlConnection.Close();
            }
            return hoTen;
        }

        public DataTable XuatpdfGV(string MK)
        {
            DataTable dt = new DataTable();

            using (SqlConnection sqlConnection = ConnectionData.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "DSGV";
                sqlCommand.Parameters.Clear();
                sqlCommand.Parameters.AddWithValue("@MK", MK);
                sqlCommand.Connection = sqlConnection;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = sqlCommand;
                da.Fill(dt);
                sqlConnection.Close();
            }
            return dt;
        }

        public DataTable XuatpdfSV(string MK)
        {
            DataTable dt = new DataTable();

            using (SqlConnection sqlConnection = ConnectionData.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "DSSV";
                sqlCommand.Parameters.Clear();
                sqlCommand.Parameters.AddWithValue("@MK", MK);
                sqlCommand.Connection = sqlConnection;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = sqlCommand;
                da.Fill(dt);
                sqlConnection.Close();
            }
            return dt;
        }

    }
}