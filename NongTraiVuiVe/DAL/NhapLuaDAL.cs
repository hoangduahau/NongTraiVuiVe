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
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();

                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        CayTrongDAL cayTrongDAL = new CayTrongDAL();
                        if (!cayTrongDAL.KiemTraTonTaiTenCayTrong(nhapLua.TenCayTrong))
                        {
                            bool result = cayTrongDAL.ThemCayTrongMoiTuPhieuNhap(nhapLua.TenCayTrong, nhapLua.MaLoaiCayTrong, nhapLua.Giong, nhapLua.NguonGoc, nhapLua.SoLuong);
                            if (!result)
                            {
                                throw new Exception("Failed to add new plant.");
                            }
                        }

                        string insertNhapLuaSql = @"
                    INSERT INTO NhapLua (TenCayTrong, MaLoaiCayTrong, Giong, NguonGoc, SoLuong, MaNhaCungCap, Ngay, GiaNhap)
                    VALUES (@TenCayTrong, @MaLoaiCayTrong, @Giong, @NguonGoc, @SoLuong, @MaNhaCungCap, @Ngay, @GiaNhap);
                ";
                        using (SqlCommand insertNhapLuaCommand = new SqlCommand(insertNhapLuaSql, conn, transaction))
                        {
                            insertNhapLuaCommand.Parameters.AddWithValue("@TenCayTrong", nhapLua.TenCayTrong);
                            insertNhapLuaCommand.Parameters.AddWithValue("@MaLoaiCayTrong", nhapLua.MaLoaiCayTrong);
                            insertNhapLuaCommand.Parameters.AddWithValue("@Giong", nhapLua.Giong);
                            insertNhapLuaCommand.Parameters.AddWithValue("@NguonGoc", nhapLua.NguonGoc);
                            insertNhapLuaCommand.Parameters.AddWithValue("@SoLuong", nhapLua.SoLuong);
                            insertNhapLuaCommand.Parameters.AddWithValue("@MaNhaCungCap", nhapLua.MaNhaCungCap);
                            insertNhapLuaCommand.Parameters.AddWithValue("@Ngay", nhapLua.Ngay);
                            insertNhapLuaCommand.Parameters.AddWithValue("@GiaNhap", nhapLua.GiaNhap);

                            int rowsAffected = insertNhapLuaCommand.ExecuteNonQuery();
                            if (rowsAffected <= 0)
                            {
                                throw new Exception("Failed to insert NhapLua record.");
                            }
                        }

                        string insertChiTieuSql = @"
                    INSERT INTO ChiTieu (LoaiChiTieu, ChiPhi, NgayChiTieu, MaNguoiThucHien)
                    VALUES (@LoaiChiTieu, @ChiPhi, @NgayChiTieu, @MaNguoiThucHien);
                ";
                        using (SqlCommand insertChiTieuCommand = new SqlCommand(insertChiTieuSql, conn, transaction))
                        {
                            insertChiTieuCommand.Parameters.AddWithValue("@LoaiChiTieu", "Nhập giống cây trồng");
                            insertChiTieuCommand.Parameters.AddWithValue("@ChiPhi", nhapLua.GiaNhap);
                            insertChiTieuCommand.Parameters.AddWithValue("@NgayChiTieu", nhapLua.Ngay);
                            insertChiTieuCommand.Parameters.AddWithValue("@MaNguoiThucHien", CurrentUser.MaNguoiDung); // Assuming CurrentUser.MaNguoiDung is available

                            int rowsAffected = insertChiTieuCommand.ExecuteNonQuery();
                            if (rowsAffected <= 0)
                            {
                                throw new Exception("Failed to insert ChiTieu record.");
                            }
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine($"Error adding new purchase order: {ex.Message}");
                        return false;
                    }
                }
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
