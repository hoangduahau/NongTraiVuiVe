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
        public bool KiemTraTonTaiMaKhoHang(int maKhoHang)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM KhoHang WHERE MaKhoHang = @MaKhoHang";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaKhoHang", maKhoHang);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        public DataTable LayDuLieuKhoHang()
        {
            DataTable dtKhoHang = new DataTable();

            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string query = "SELECT * FROM KhoHang";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                adapter.Fill(dtKhoHang);
            }

            return dtKhoHang;
        }

        public bool ThemKhoHang(KhoHang khoHang)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string sql = @"INSERT INTO KhoHang 
                            (TenKhoHang, ViTri, KhaDung) 
                            VALUES (@TenKhoHang, @ViTri, @KhaDung)";

                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@TenKhoHang", khoHang.TenKhoHang);
                    command.Parameters.AddWithValue("@ViTri", khoHang.ViTri);
                    command.Parameters.AddWithValue("@KhaDung", khoHang.KhaDung);

                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.InsertCommand = command;
                        return adapter.InsertCommand.ExecuteNonQuery() > 0;
                    }
                }
            }
        }

        public bool CapNhatKhoHang(KhoHang khoHang)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string sql = @"UPDATE KhoHang 
                       SET TenKhoHang = @TenKhoHang, 
                           ViTri = @ViTri,
                           KhaDung = @KhaDung 
                       WHERE MaKhoHang = @MaKhoHang";

                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@MaKhoHang", khoHang.MaKhoHang);
                    command.Parameters.AddWithValue("@TenKhoHang", khoHang.TenKhoHang);
                    command.Parameters.AddWithValue("@ViTri", khoHang.ViTri);
                    command.Parameters.AddWithValue("@KhaDung", khoHang.KhaDung);

                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.UpdateCommand = command;
                        return adapter.UpdateCommand.ExecuteNonQuery() > 0;
                    }
                }
            }
        }

        public bool XoaKhoHang(int maKhoHang)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string sql = "DELETE FROM KhoHang WHERE MaKhoHang = @MaKhoHang";

                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@MaKhoHang", maKhoHang);

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
