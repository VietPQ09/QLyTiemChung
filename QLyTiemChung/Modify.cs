using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLyTiemChung
{
    internal class Modify
    {
        public Modify() { }
        SqlCommand sqlCommand; // dung de truy van cac cau lenh insert, update
        SqlDataReader dataReader; // doc data trong table
        public List<TaiKhoan> TaiKhoans(string query)
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                sqlCommand = new SqlCommand(query, conn);
                dataReader = sqlCommand.ExecuteReader();
                while(dataReader.Read())
                {
                    taiKhoans.Add(new TaiKhoan(dataReader.GetString(0), dataReader.GetString(1)));
                }
                conn.Close();
            }
            return taiKhoans;
        }
        public void Command(string query) // dung de dang ky tai khoan
        {
            using(SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                sqlCommand = new SqlCommand(query, conn);
                sqlCommand.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
