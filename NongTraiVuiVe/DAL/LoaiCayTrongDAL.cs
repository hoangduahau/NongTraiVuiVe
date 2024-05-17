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
        public List<LoaiCayTrong> LayDanhSachLoaiCayTrong()
        {
            List<LoaiCayTrong> dsLoaiCayTrong = new List<LoaiCayTrong>();
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM LoaiCayTrong", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LoaiCayTrong lct = new LoaiCayTrong(
                        (int)reader["MaLoaiCayTrong"],
                        reader["TenLoaiCayTrong"].ToString(),
                        reader["MoTa"].ToString()
                    );
                    dsLoaiCayTrong.Add(lct);
                }
            }
            return dsLoaiCayTrong;
        }

        public bool ThemLoaiCayTrong(LoaiCayTrong lct)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string query = "INSERT INTO LoaiCayTrong (TenLoaiCayTrong, MoTa) " +
                               "VALUES (@TenLoaiCayTrong, @MoTa)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenLoaiCayTrong", lct.TenLoaiCayTrong);
                cmd.Parameters.AddWithValue("@MoTa", lct.MoTa);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Các phương thức khác (Cập nhật, Xóa): Tương tự phương thức ThemLoaiCayTrong
        // ...
    }
}
