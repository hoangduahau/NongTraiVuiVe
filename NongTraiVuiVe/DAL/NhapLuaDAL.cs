using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using NongTraiVuiVe.DTO;

namespace NongTraiVuiVe.DAL
{
    public class NhapLuaDAL
    {
        public DataTable LayDanhSachNhapLua()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string query = @"
            SELECT 
                nl.MaNhapLua, 
                nl.TenCayTrong, 
                lct.TenLoaiCayTrong, 
                nl.Giong, 
                nl.NguonGoc, 
                nl.SoLuong, 
                nc.TenNhaCungCap, 
                nl.Ngay, 
                nl.GiaNhap 
            FROM NhapLua nl
            INNER JOIN LoaiCayTrong lct ON nl.MaLoaiCayTrong = lct.MaLoaiCayTrong
            INNER JOIN NhaCungCap nc ON nl.MaNhaCungCap = nc.MaNhaCungCap";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }


        public bool ThemPhieuNhap(NhapLua nhapLua)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
                {
                    conn.Open();
                    CayTrongDAL cayTrongDAL = new CayTrongDAL();
                    if (!cayTrongDAL.KiemTraTonTaiTenCayTrong(nhapLua.TenCayTrong))
                    {
                        bool result = cayTrongDAL.ThemCayTrongMoiTuPhieuNhap(nhapLua.TenCayTrong, nhapLua.MaLoaiCayTrong, nhapLua.Giong, nhapLua.NguonGoc, nhapLua.SoLuong);
                        if (!result)
                        {
                            throw new Exception("Failed to add new plant.");
                        }
                    }

                    string sql = @"
              INSERT INTO NhapLua (TenCayTrong, MaLoaiCayTrong, Giong, NguonGoc, SoLuong, MaNhaCungCap, Ngay, GiaNhap)
              VALUES (@TenCayTrong, @MaLoaiCayTrong, @Giong, @NguonGoc, @SoLuong, @MaNhaCungCap, @Ngay, @GiaNhap);
            ";

                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@TenCayTrong", nhapLua.TenCayTrong);
                        command.Parameters.AddWithValue("@MaLoaiCayTrong", nhapLua.MaLoaiCayTrong);
                        command.Parameters.AddWithValue("@Giong", nhapLua.Giong);
                        command.Parameters.AddWithValue("@NguonGoc", nhapLua.NguonGoc);
                        command.Parameters.AddWithValue("@SoLuong", nhapLua.SoLuong);
                        command.Parameters.AddWithValue("@MaNhaCungCap", nhapLua.MaNhaCungCap);
                        command.Parameters.AddWithValue("@Ngay", nhapLua.Ngay);
                        command.Parameters.AddWithValue("@GiaNhap", nhapLua.GiaNhap);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"Error adding new purchase order: {ex.Message}");
                return false;
            }
        }

        public bool SuaPhieuNhap(NhapLua nhapLua)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string sql = @"
            UPDATE NhapLua 
            SET TenCayTrong = @TenCayTrong,
                MaLoaiCayTrong = @MaLoaiCayTrong,
                Giong = @Giong,
                NguonGoc = @NguonGoc,
                SoLuong = @SoLuong,
                MaNhaCungCap = @MaNhaCungCap,
                Ngay = @Ngay,
                GiaNhap = @GiaNhap
            WHERE MaNhapLua = @MaNhapLua;
        ";

                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@MaNhapLua", nhapLua.MaNhapLua); // Thêm tham số MaNhapLua
                    command.Parameters.AddWithValue("@TenCayTrong", nhapLua.TenCayTrong);
                    command.Parameters.AddWithValue("@MaLoaiCayTrong", nhapLua.MaLoaiCayTrong);
                    command.Parameters.AddWithValue("@Giong", nhapLua.Giong);
                    command.Parameters.AddWithValue("@NguonGoc", nhapLua.NguonGoc);
                    command.Parameters.AddWithValue("@SoLuong", nhapLua.SoLuong);
                    command.Parameters.AddWithValue("@MaNhaCungCap", nhapLua.MaNhaCungCap);
                    command.Parameters.AddWithValue("@Ngay", nhapLua.Ngay);
                    command.Parameters.AddWithValue("@GiaNhap", nhapLua.GiaNhap);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool XoaPhieuNhap(int maPhieuNhap)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string sql = "DELETE FROM NhapLua WHERE MaNhapLua = @MaPhieuNhap";
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@MaPhieuNhap", maPhieuNhap);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0; 
                }
            }
        }
    }
}
