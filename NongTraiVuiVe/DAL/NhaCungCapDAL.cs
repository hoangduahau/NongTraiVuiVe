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
