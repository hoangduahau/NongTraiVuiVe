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
    public class NguoiDungDAL
    {
        public List<NguoiDung> LayDanhSachNguoiDung()
        {
            List<NguoiDung> dsNguoiDung = new List<NguoiDung>();
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM NguoiDung", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    NguoiDung nd = new NguoiDung(
                        (int)reader["MaNguoiDung"],
                        reader["TenDangNhap"].ToString(),
                        (byte[])reader["MatKhau"], // Lấy mật khẩu dưới dạng byte[]
                        (DateTime)reader["NgayTao"],
                        reader["HoTen"].ToString(),
                        reader["DiaChi"].ToString(),
                        reader["DienThoai"].ToString(),
                        reader["GioiTinh"].ToString(),
                        (DateTime)reader["NgaySinh"],
                        (DateTime)reader["NgayBatDauLamViec"],
                        (int)reader["GroupID"]
                    );
                    dsNguoiDung.Add(nd);
                }
            }
            return dsNguoiDung;
        }

        public bool ThemNguoiDung(NguoiDung nd)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string query = "INSERT INTO NguoiDung (TenDangNhap, MatKhau, NgayTao, HoTen, DiaChi, DienThoai, GioiTinh, NgaySinh, NgayBatDauLamViec, GroupID) " +
                               "VALUES (@TenDangNhap, @MatKhau, @NgayTao, @HoTen, @DiaChi, @DienThoai, @GioiTinh, @NgaySinh, @NgayBatDauLamViec, @GroupID)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenDangNhap", nd.TenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhau", nd.MatKhau); // Truyền mật khẩu đã băm (hashed)
                // ... (Thêm các tham số khác)
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Các phương thức khác (Cập nhật, Xóa): Tương tự phương thức ThemNguoiDung
        // ...
    }
}
