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
    public class KhoHangDAL
    {
        public List<KhoHang> LayDanhSachKhoHang()
        {
            List<KhoHang> dsKhoHang = new List<KhoHang>();
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM KhoHang", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    KhoHang kh = new KhoHang(
                        (int)reader["MaKhoHang"],
                        reader["TenKhoHang"].ToString(),
                        reader["ViTri"].ToString(),
                        (bool)reader["KhaDung"]
                    );
                    dsKhoHang.Add(kh);
                }
            }
            return dsKhoHang;
        }

        public bool ThemKhoHang(KhoHang kh)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string query = "INSERT INTO KhoHang (TenKhoHang, ViTri, KhaDung) " +
                               "VALUES (@TenKhoHang, @ViTri, @KhaDung)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenKhoHang", kh.TenKhoHang);
                cmd.Parameters.AddWithValue("@ViTri", kh.ViTri);
                cmd.Parameters.AddWithValue("@KhaDung", kh.KhaDung);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Các phương thức khác (Cập nhật, Xóa): Tương tự phương thức ThemKhoHang
        // ...
    }
}
