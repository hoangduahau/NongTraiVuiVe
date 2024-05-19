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
    public class XuatLuaDAL
    {
        public DataTable LayDanhSachXuatLua()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string query = @"
                    SELECT 
                        xl.MaXuatLua,
                        xl.MaCayTrong,
                        xl.TenCayTrong,
                        ct.Giong, 
                        xl.SoLuong, 
                        xl.Ngay, 
                        xl.GiaXuat, 
                        kh.TenKhachHang
                    FROM XuatLua xl
                    INNER JOIN CayTrong ct ON xl.MaCayTrong = ct.MaCayTrong
                    INNER JOIN KhachHang kh ON xl.MaKhachHang = kh.MaKhachHang;
                ";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        public bool ThemPhieuXuat(XuatLua xuatLua)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string sql = @"
                    INSERT INTO XuatLua (MaCayTrong, TenCayTrong, SoLuong, Ngay, GiaXuat, MaKhachHang)
                    VALUES (@MaCayTrong, @TenCayTrong, @SoLuong, @Ngay, @GiaXuat, @MaKhachHang);
                ";
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@MaCayTrong", xuatLua.MaCayTrong);
                    command.Parameters.AddWithValue("@TenCayTrong", xuatLua.TenCayTrong);
                    command.Parameters.AddWithValue("@SoLuong", xuatLua.SoLuong);
                    command.Parameters.AddWithValue("@Ngay", xuatLua.Ngay);
                    command.Parameters.AddWithValue("@GiaXuat", xuatLua.GiaXuat);
                    command.Parameters.AddWithValue("@MaKhachHang", xuatLua.MaKhachHang);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool CapNhatXuatLua(XuatLua xuatLua)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string sql = @"
                    UPDATE XuatLua
                    SET TenCayTrong = @TenCayTrong,
                        SoLuong = @SoLuong,
                        Ngay = @Ngay,
                        GiaXuat = @GiaXuat,
                        MaKhachHang = @MaKhachHang
                    WHERE MaXuatLua = @MaXuatLua;
                ";
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@MaXuatLua", xuatLua.MaXuatLua);
                    command.Parameters.AddWithValue("@TenCayTrong", xuatLua.TenCayTrong);
                    command.Parameters.AddWithValue("@SoLuong", xuatLua.SoLuong);
                    command.Parameters.AddWithValue("@Ngay", xuatLua.Ngay);
                    command.Parameters.AddWithValue("@GiaXuat", xuatLua.GiaXuat);
                    command.Parameters.AddWithValue("@MaKhachHang", xuatLua.MaKhachHang);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool XoaPhieuXuat(int maPhieuXuat)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string sql = "DELETE FROM XuatLua WHERE MaXuatLua = @MaXuatLua";
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@MaXuatLua", maPhieuXuat);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}
