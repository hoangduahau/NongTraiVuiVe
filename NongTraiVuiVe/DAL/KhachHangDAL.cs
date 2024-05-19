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

        public List<string> LayDanhSachTenKhachHang()
        {
            List<string> danhDanhSachTenKhachHang = new List<string>();
            using (SqlConnection connection = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                connection.Open();
                string sql = "SELECT TenKhachHang FROM KhachHang";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            danhDanhSachTenKhachHang.Add(reader["TenKhachHang"].ToString());
                        }
                    }
                }
            }
            return danhDanhSachTenKhachHang;
        }

        public int LayMaKhachHangTheoTen(string tenKhachHang)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string sql = "SELECT MaKhachHang FROM KhachHang WHERE TenKhachHang = @TenKhachHang";
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@TenKhachHang", tenKhachHang);
                    object result = command.ExecuteScalar();
                    return result != null ? (int)result : 0; // Trả về 0 nếu không tìm thấy
                }
            }
        }
        public DataTable LayDuLieuKhachHang()
        {
            DataTable dtKhachHang = new DataTable();

            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string query = "SELECT * FROM KhachHang";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                adapter.Fill(dtKhachHang);
            }

            return dtKhachHang;
        }

        public bool ThemKhachHang(KhachHang khachHang)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string sql = @"INSERT INTO KhachHang 
                        (TenKhachHang, DiaChi, DienThoai, Email, NgaySinh) 
                        VALUES (@TenKhachHang, @DiaChi, @DienThoai, @Email, @NgaySinh)";

                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@TenKhachHang", khachHang.TenKhachHang);
                    command.Parameters.AddWithValue("@DiaChi", khachHang.DiaChi);
                    command.Parameters.AddWithValue("@DienThoai", khachHang.DienThoai);
                    command.Parameters.AddWithValue("@Email", khachHang.Email);

                    if (khachHang.NgaySinh.HasValue && khachHang.NgaySinh.Value >= new DateTime(1753, 1, 1))
                    {
                        command.Parameters.AddWithValue("@NgaySinh", khachHang.NgaySinh.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@NgaySinh", DBNull.Value);
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.InsertCommand = command;
                        return adapter.InsertCommand.ExecuteNonQuery() > 0;
                    }
                }
            }
        }

        public bool CapNhatKhachHang(KhachHang khachHang)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string sql = @"UPDATE KhachHang 
                       SET TenKhachHang = @TenKhachHang, 
                           DiaChi = @DiaChi,
                           DienThoai = @DienThoai,
                           Email = @Email,
                           NgaySinh = @NgaySinh
                       WHERE MaKhachHang = @MaKhachHang";

                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@MaKhachHang", khachHang.MaKhachHang);
                    command.Parameters.AddWithValue("@TenKhachHang", khachHang.TenKhachHang);
                    command.Parameters.AddWithValue("@DiaChi", khachHang.DiaChi);
                    command.Parameters.AddWithValue("@DienThoai", khachHang.DienThoai);
                    command.Parameters.AddWithValue("@Email", khachHang.Email);

                    if (khachHang.NgaySinh.HasValue && khachHang.NgaySinh.Value >= new DateTime(1753, 1, 1))
                    {
                        command.Parameters.AddWithValue("@NgaySinh", khachHang.NgaySinh.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@NgaySinh", DBNull.Value);
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.UpdateCommand = command;
                        return adapter.UpdateCommand.ExecuteNonQuery() > 0;
                    }
                }
            }
        }

        public bool XoaKhachHang(int maKhachHang)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string sql = "DELETE FROM KhachHang WHERE MaKhachHang = @MaKhachHang";

                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@MaKhachHang", maKhachHang);

                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.DeleteCommand = command;
                        return adapter.DeleteCommand.ExecuteNonQuery() > 0;
                    }
                }
            }
        }
    }
}
