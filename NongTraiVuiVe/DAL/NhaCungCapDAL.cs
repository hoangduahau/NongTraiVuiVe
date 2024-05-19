using NongTraiVuiVe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace NongTraiVuiVe.DAL
{
    public class NhaCungCapDAL
    {
        public List<string> LayDanhSachTenNhaCungCap()
        {
            List<string> danhDanhSachTenNhaCungCap = new List<string>();
            using (SqlConnection connection = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                connection.Open();
                string sql = "SELECT TenNhaCungCap FROM NhaCungCap";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            danhDanhSachTenNhaCungCap.Add(reader["TenNhaCungCap"].ToString());
                        }
                    }
                }
            }
            return danhDanhSachTenNhaCungCap;
        }

        public int LayMaNhaCungCapTheoTen(string tenNhaCungCap)
        {
            using (SqlConnection connection = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                connection.Open();
                string sql = "SELECT MaNhaCungCap FROM NhaCungCap WHERE TenNhaCungCap = @TenNhaCungCap";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@TenNhaCungCap", tenNhaCungCap);
                    object result = command.ExecuteScalar();
                    return result != null ? (int)result : 0; // Trả về 0 nếu không tìm thấy
                }
            }
        }
        public DataTable LayDuLieuNhaCungCap()
        {
            DataTable dtNhaCungCap = new DataTable();

            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string query = "SELECT * FROM NhaCungCap";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                adapter.Fill(dtNhaCungCap);
            }

            return dtNhaCungCap;
        }

        public bool ThemNhaCungCap(NhaCungCap nhaCungCap)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string sql = @"INSERT INTO NhaCungCap 
                        (TenNhaCungCap, DiaChi, DienThoai, Email) 
                        VALUES (@TenNhaCungCap, @DiaChi, @DienThoai, @Email)";

                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@TenNhaCungCap", nhaCungCap.TenNhaCungCap);
                    command.Parameters.AddWithValue("@DiaChi", nhaCungCap.DiaChi);
                    command.Parameters.AddWithValue("@DienThoai", nhaCungCap.DienThoai);
                    command.Parameters.AddWithValue("@Email", nhaCungCap.Email);

                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.InsertCommand = command;
                        return adapter.InsertCommand.ExecuteNonQuery() > 0;
                    }
                }
            }
        }

        public bool CapNhatNhaCungCap(NhaCungCap nhaCungCap)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string sql = @"UPDATE NhaCungCap 
                       SET TenNhaCungCap = @TenNhaCungCap, 
                           DiaChi = @DiaChi,
                           DienThoai = @DienThoai,
                           Email = @Email
                       WHERE MaNhaCungCap = @MaNhaCungCap";

                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@MaNhaCungCap", nhaCungCap.MaNhaCungCap);
                    command.Parameters.AddWithValue("@TenNhaCungCap", nhaCungCap.TenNhaCungCap);
                    command.Parameters.AddWithValue("@DiaChi", nhaCungCap.DiaChi);
                    command.Parameters.AddWithValue("@DienThoai", nhaCungCap.DienThoai);
                    command.Parameters.AddWithValue("@Email", nhaCungCap.Email);

                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.UpdateCommand = command;
                        return adapter.UpdateCommand.ExecuteNonQuery() > 0;
                    }
                }
            }
        }

        public bool XoaNhaCungCap(int maNhaCungCap)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string sql = "DELETE FROM NhaCungCap WHERE MaNhaCungCap = @MaNhaCungCap";

                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@MaNhaCungCap", maNhaCungCap);

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
