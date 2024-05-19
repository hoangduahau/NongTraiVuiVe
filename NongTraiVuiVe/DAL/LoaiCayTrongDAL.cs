using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using NongTraiVuiVe.DTO;

namespace NongTraiVuiVe.DAL
{
    public class LoaiCayTrongDAL
    {
        public bool KiemTraTonTaiMaLoaiCayTrong(int maLoaiCayTrong)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM LoaiCayTrong WHERE MaLoaiCayTrong = @MaLoaiCayTrong";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaLoaiCayTrong", maLoaiCayTrong);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }


        public List<string> LayDanhSachTenLoaiCayTrong()
        {
            List<string> danhSachTenLoaiCayTrong = new List<string>();
            using (SqlConnection connection = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                connection.Open();
                string sql = "SELECT TenLoaiCayTrong FROM LoaiCayTrong";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            danhSachTenLoaiCayTrong.Add(reader["TenLoaiCayTrong"].ToString());
                        }
                    }
                }
            }
            return danhSachTenLoaiCayTrong;
        }

        public int LayMaLoaiCayTrongTheoTen(string tenLoaiCayTrong)
        {
            using (SqlConnection connection = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                connection.Open();
                string sql = "SELECT MaLoaiCayTrong FROM LoaiCayTrong WHERE TenLoaiCayTrong = @TenLoaiCayTrong";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@TenLoaiCayTrong", tenLoaiCayTrong);
                    object result = command.ExecuteScalar();
                    return result != null ? (int)result : 0;
                }
            }
        }



        // Các phương thức khác (Cập nhật, Xóa): Tương tự phương thức ThemLoaiCayTrong
        // ...
    }
}
