using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class SqlConnectionData
    {
        //tạo chuỗi kết nối csdl
        public static SqlConnection Connect()
        {
            string strcon = @"Data Source=THIEN-AN;Initial Catalog=QUANLYSINHVIEN;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon);
            return conn;
        }
    }
    public class DatabaseAcess
    {
        public static string CheckLogicDTO(TaiKhoan taikhoan)
        {
            string user = null;
            SqlConnection conn  = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("proc_logic", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@user", taikhoan.Tendangnhap);
            command.Parameters.AddWithValue("@pass", taikhoan.Matkhau);
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if(reader.HasRows)
            {
                while (reader.Read())
                {
                    user = reader.GetString(0);
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return "Tài khoản hoặc mật khẩu không chính xác!";
            }
            return user;
        }
    }
}
