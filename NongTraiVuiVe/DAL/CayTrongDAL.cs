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
    public class CayTrongDAL
    {
        public bool KiemTraTonTaiTenCayTrong(string tenCayTrong)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM CayTrong WHERE TenCayTrong = @TenCayTrong";
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@TenCayTrong", tenCayTrong);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public bool ThemCayTrongMoiTuPhieuNhap(string tenCayTrong, int maLoaiCayTrong, string giong, string nguonGoc, int soLuong)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
                {
                    conn.Open();
                    string sql = @"
            INSERT INTO CayTrong (TenCayTrong, MaLoaiCayTrong, Giong, NguonGoc, SoLuong, NgayGieoTrong) 
            VALUES (@TenCayTrong, @MaLoaiCayTrong, @Giong, @NguonGoc, @SoLuong, GETDATE());
          ";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@TenCayTrong", tenCayTrong);
                        command.Parameters.AddWithValue("@MaLoaiCayTrong", maLoaiCayTrong);
                        command.Parameters.AddWithValue("@Giong", giong);
                        command.Parameters.AddWithValue("@NguonGoc", nguonGoc);
                        command.Parameters.AddWithValue("@SoLuong", soLuong);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"Error adding new plant: {ex.Message}");
                return false;
            }
        }

        public int LayMaCayTrongTheoTen(string tenCayTrong)
        {
            using (SqlConnection connection = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                connection.Open();
                string sql = "SELECT MaCayTrong FROM CayTrong WHERE TenCayTrong = @TenCayTrong";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@TenCayTrong", tenCayTrong);
                    object result = command.ExecuteScalar();
                    return result != null ? (int)result : 0; 
                }
            }
        }
        public DataTable LayDuLieuCayTrong()
        {
            DataTable dtCayTrong = new DataTable();

            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string query = @"
                                SELECT 
                                ct.MaCayTrong, 
                                ct.TenCayTrong, 
                                lct.TenLoaiCayTrong, 
                                ct.Giong, 
                                ct.NguonGoc,
                                ct.SoLuong, 
                                ct.NgayGieoTrong, 
                                ct.NgayThuHoachDuKien,
                                ct.NgayThuHoachThucTe,
                                kv.TenKhuVuc,
                                ct.TinhTrang
                            FROM CayTrong ct
                            LEFT JOIN LoaiCayTrong lct ON ct.MaLoaiCayTrong = lct.MaLoaiCayTrong
                            LEFT JOIN KhuVuc kv ON ct.MaKhuVuc = kv.MaKhuVuc;";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                adapter.Fill(dtCayTrong);
            }

            return dtCayTrong;
        }

        public bool ThemCayTrong(CayTrong cayTrong)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string sql = @"INSERT INTO CayTrong 
                                (TenCayTrong, MaLoaiCayTrong, Giong, NguonGoc, SoLuong, NgayGieoTrong, NgayThuHoachDuKien, NgayThuHoachThucTe, MaKhuVuc, TinhTrang) 
                                VALUES (@TenCayTrong, @MaLoaiCayTrong, @GiongCay, @NguonGoc, @SoLuong, @NgayGieoTrong, @NgayThuHoachDuKien, @NgayThuHoachThucTe, @MaKhuVuc, @TinhTrang)";

                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@TenCayTrong", cayTrong.TenCayTrong);
                    command.Parameters.AddWithValue("@MaLoaiCayTrong", cayTrong.MaLoaiCayTrong);
                    command.Parameters.AddWithValue("@GiongCay", cayTrong.Giong ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@NguonGoc", cayTrong.NguonGoc ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@SoLuong", cayTrong.SoLuong);
                    command.Parameters.AddWithValue("@NgayGieoTrong", cayTrong.NgayGieoTrong ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@NgayThuHoachDuKien", cayTrong.NgayThuHoachDuKien ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@NgayThuHoachThucTe", cayTrong.NgayThuHoachThucTe ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@MaKhuVuc", cayTrong.MaKhuVuc);
                    command.Parameters.AddWithValue("@TinhTrang", cayTrong.TinhTrang);

                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.InsertCommand = command;
                        return adapter.InsertCommand.ExecuteNonQuery() > 0;
                    }
                }
            }
        }

        public bool CapNhatCayTrong(CayTrong cayTrong)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string sql = @"UPDATE CayTrong 
                       SET TenCayTrong = @TenCayTrong, 
                           MaLoaiCayTrong = @MaLoaiCayTrong, 
                           Giong = @GiongCay, 
                           NguonGoc = @NguonGoc, 
                           SoLuong = @SoLuong, 
                           NgayGieoTrong = @NgayGieoTrong, 
                           NgayThuHoachDuKien = @NgayThuHoachDuKien, 
                           NgayThuHoachThucTe = @NgayThuHoachThucTe, 
                           MaKhuVuc = @MaKhuVuc, 
                           TinhTrang = @TinhTrang
                       WHERE MaCayTrong = @MaCayTrong"; 

                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@MaCayTrong", cayTrong.MaCayTrong);
                    command.Parameters.AddWithValue("@TenCayTrong", cayTrong.TenCayTrong);
                    command.Parameters.AddWithValue("@MaLoaiCayTrong", cayTrong.MaLoaiCayTrong);
                    command.Parameters.AddWithValue("@GiongCay", cayTrong.Giong ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@NguonGoc", cayTrong.NguonGoc ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@SoLuong", cayTrong.SoLuong);
                    command.Parameters.AddWithValue("@NgayGieoTrong", cayTrong.NgayGieoTrong ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@NgayThuHoachDuKien", cayTrong.NgayThuHoachDuKien ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@NgayThuHoachThucTe", cayTrong.NgayThuHoachThucTe ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@MaKhuVuc", cayTrong.MaKhuVuc);
                    command.Parameters.AddWithValue("@TinhTrang", cayTrong.TinhTrang);

                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.UpdateCommand = command; 
                        return adapter.UpdateCommand.ExecuteNonQuery() > 0;
                    }
                }
            }
        }

        public bool XoaCayTrong(int maCayTrong)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string sql = "DELETE FROM CayTrong WHERE MaCayTrong = @MaCayTrong";

                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@MaCayTrong", maCayTrong);

                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.DeleteCommand = command;
                        return adapter.DeleteCommand.ExecuteNonQuery() > 0;
                    }
                }
            }
        }

        public List<string> LayDanhSachTenCayTrong()
        {
            List<string> danhDanhSachTenCayTrong = new List<string>();
            using (SqlConnection connection = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                connection.Open();
                string sql = "SELECT TenCayTrong FROM CayTrong";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            danhDanhSachTenCayTrong.Add(reader["TenCayTrong"].ToString());
                        }
                    }
                }
            }
            return danhDanhSachTenCayTrong;
        }

        // Các phương thức khác: ThemCayTrong, CapNhatCayTrong, XoaCayTrong
        // ... (viết tương tự như LayDanhSachCayTrong)
    }
}
