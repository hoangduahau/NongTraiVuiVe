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
        //public List<KhuVuc> LayDanhSachKhuVuc()
        //{
        //    List<KhuVuc> dsKhuVuc = new List<KhuVuc>();
        //    using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
        //    {
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand("SELECT * FROM KhuVuc", conn);
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            KhuVuc kv = new KhuVuc(
        //                (int)reader["MaKhuVuc"],
        //                reader["TenKhuVuc"].ToString(),
        //                (bool)reader["KhaDung"]
        //            );
        //            dsKhuVuc.Add(kv);
        //        }
        //    }
        //    return dsKhuVuc;
        //}

        public DataTable LayDuLieuKhuVuc()
        {
            DataTable dtKhuVuc = new DataTable();

            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string query = "SELECT * FROM KhuVuc";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                adapter.Fill(dtKhuVuc);
            }

            return dtKhuVuc;
        }

        //public bool ThemCayTrong(CayTrong cayTrong)
        //{
        //    using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
        //    {
        //        conn.Open();
        //        string sql = @"INSERT INTO CayTrong 
        //                        (TenCayTrong, MaLoaiCayTrong, Giong, NguonGoc, SoLuong, NgayGieoTrong, NgayThuHoachDuKien, NgayThuHoachThucTe, MaKhuVuc, TinhTrang) 
        //                        VALUES (@TenCayTrong, @MaLoaiCayTrong, @GiongCay, @NguonGoc, @SoLuong, @NgayGieoTrong, @NgayThuHoachDuKien, @NgayThuHoachThucTe, @MaKhuVuc, @TinhTrang)";

        //        using (SqlCommand command = new SqlCommand(sql, conn))
        //        {
        //            command.Parameters.AddWithValue("@TenCayTrong", cayTrong.TenCayTrong);
        //            command.Parameters.AddWithValue("@MaLoaiCayTrong", cayTrong.MaLoaiCayTrong);
        //            command.Parameters.AddWithValue("@GiongCay", cayTrong.Giong ?? (object)DBNull.Value);
        //            command.Parameters.AddWithValue("@NguonGoc", cayTrong.NguonGoc ?? (object)DBNull.Value);
        //            command.Parameters.AddWithValue("@SoLuong", cayTrong.SoLuong);
        //            command.Parameters.AddWithValue("@NgayGieoTrong", cayTrong.NgayGieoTrong ?? (object)DBNull.Value);
        //            command.Parameters.AddWithValue("@NgayThuHoachDuKien", cayTrong.NgayThuHoachDuKien ?? (object)DBNull.Value);
        //            command.Parameters.AddWithValue("@NgayThuHoachThucTe", cayTrong.NgayThuHoachThucTe ?? (object)DBNull.Value);
        //            command.Parameters.AddWithValue("@MaKhuVuc", cayTrong.MaKhuVuc);
        //            command.Parameters.AddWithValue("@TinhTrang", cayTrong.TinhTrang);

        //            using (SqlDataAdapter adapter = new SqlDataAdapter())
        //            {
        //                adapter.InsertCommand = command;
        //                return adapter.InsertCommand.ExecuteNonQuery() > 0;
        //            }
        //        }
        //    }
        //}

        //public bool CapNhatCayTrong(CayTrong cayTrong)
        //{
        //    using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
        //    {
        //        conn.Open();
        //        string sql = @"UPDATE CayTrong 
        //               SET TenCayTrong = @TenCayTrong, 
        //                   MaLoaiCayTrong = @MaLoaiCayTrong, 
        //                   Giong = @GiongCay, 
        //                   NguonGoc = @NguonGoc, 
        //                   SoLuong = @SoLuong, 
        //                   NgayGieoTrong = @NgayGieoTrong, 
        //                   NgayThuHoachDuKien = @NgayThuHoachDuKien, 
        //                   NgayThuHoachThucTe = @NgayThuHoachThucTe, 
        //                   MaKhuVuc = @MaKhuVuc, 
        //                   TinhTrang = @TinhTrang
        //               WHERE MaCayTrong = @MaCayTrong";

        //        using (SqlCommand command = new SqlCommand(sql, conn))
        //        {
        //            command.Parameters.AddWithValue("@MaCayTrong", cayTrong.MaCayTrong);
        //            command.Parameters.AddWithValue("@TenCayTrong", cayTrong.TenCayTrong);
        //            command.Parameters.AddWithValue("@MaLoaiCayTrong", cayTrong.MaLoaiCayTrong);
        //            command.Parameters.AddWithValue("@GiongCay", cayTrong.Giong ?? (object)DBNull.Value);
        //            command.Parameters.AddWithValue("@NguonGoc", cayTrong.NguonGoc ?? (object)DBNull.Value);
        //            command.Parameters.AddWithValue("@SoLuong", cayTrong.SoLuong);
        //            command.Parameters.AddWithValue("@NgayGieoTrong", cayTrong.NgayGieoTrong ?? (object)DBNull.Value);
        //            command.Parameters.AddWithValue("@NgayThuHoachDuKien", cayTrong.NgayThuHoachDuKien ?? (object)DBNull.Value);
        //            command.Parameters.AddWithValue("@NgayThuHoachThucTe", cayTrong.NgayThuHoachThucTe ?? (object)DBNull.Value);
        //            command.Parameters.AddWithValue("@MaKhuVuc", cayTrong.MaKhuVuc);
        //            command.Parameters.AddWithValue("@TinhTrang", cayTrong.TinhTrang);

        //            using (SqlDataAdapter adapter = new SqlDataAdapter())
        //            {
        //                adapter.UpdateCommand = command;
        //                return adapter.UpdateCommand.ExecuteNonQuery() > 0;
        //            }
        //        }
        //    }
        //}

        //public bool XoaCayTrong(int maCayTrong)
        //{
        //    using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
        //    {
        //        conn.Open();
        //        string sql = "DELETE FROM CayTrong WHERE MaCayTrong = @MaCayTrong";

        //        using (SqlCommand command = new SqlCommand(sql, conn))
        //        {
        //            command.Parameters.AddWithValue("@MaCayTrong", maCayTrong);

        //            using (SqlDataAdapter adapter = new SqlDataAdapter())
        //            {
        //                adapter.DeleteCommand = command;
        //                return adapter.DeleteCommand.ExecuteNonQuery() > 0;
        //            }
        //        }
        //    }
        //}

        // Các phương thức khác (Cập nhật, Xóa): Tương tự phương thức ThemKhuVuc
        // ...
    }
}
