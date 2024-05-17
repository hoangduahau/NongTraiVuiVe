using NongTraiVuiVe.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace NongTraiVuiVe.DAL
{
    public class KhuVucDAL
    {
        public bool KiemTraTonTaiMaKhuVuc(int maKhuVuc)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM KhuVuc WHERE MaKhuVuc = @MaKhuVuc";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaKhuVuc", maKhuVuc);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
        public List<KhuVuc> LayDanhSachKhuVuc()
        {
            List<KhuVuc> dsKhuVuc = new List<KhuVuc>();
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM KhuVuc", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    KhuVuc kv = new KhuVuc(
                        (int)reader["MaKhuVuc"],
                        reader["TenKhuVuc"].ToString(),
                        (bool)reader["KhaDung"]
                    );
                    dsKhuVuc.Add(kv);
                }
            }
            return dsKhuVuc;
        }

        public bool ThemKhuVuc(KhuVuc kv)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string query = "INSERT INTO KhuVuc (TenKhuVuc, KhaDung) " +
                               "VALUES (@TenKhuVuc, @KhaDung)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenKhuVuc", kv.TenKhuVuc);
                cmd.Parameters.AddWithValue("@KhaDung", kv.KhaDung);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Các phương thức khác (Cập nhật, Xóa): Tương tự phương thức ThemKhuVuc
        // ...
    }
}
