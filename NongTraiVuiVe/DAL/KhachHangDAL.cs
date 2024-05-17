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
    public class KhachHangDAL
    {
        public List<KhachHang> LayDanhSachKhachHang()
        {
            List<KhachHang> dsKhachHang = new List<KhachHang>();
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM KhachHang", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    KhachHang kh = new KhachHang(
                        (int)reader["MaKhachHang"],
                        reader["TenKhachHang"].ToString(),
                        reader["DiaChi"].ToString(),
                        reader["DienThoai"].ToString(),
                        reader["Email"].ToString(),
                        (DateTime)reader["NgaySinh"]
                    );
                    dsKhachHang.Add(kh);
                }
            }
            return dsKhachHang;
        }

        public bool ThemKhachHang(KhachHang kh)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string query = "INSERT INTO KhachHang (TenKhachHang, DiaChi, DienThoai, Email, NgaySinh) " +
                               "VALUES (@TenKhachHang, @DiaChi, @DienThoai, @Email, @NgaySinh)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenKhachHang", kh.TenKhachHang);
                cmd.Parameters.AddWithValue("@DiaChi", kh.DiaChi);
                cmd.Parameters.AddWithValue("@DienThoai", kh.DienThoai);
                cmd.Parameters.AddWithValue("@Email", kh.Email);
                cmd.Parameters.AddWithValue("@NgaySinh", kh.NgaySinh);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Các phương thức khác (Cập nhật, Xóa): Tương tự phương thức ThemKhachHang
        // ...
    }
}
