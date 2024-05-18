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
    public class NguyenVatLieuDAL
    {
        public DataTable LayDuLieuNguyenVatLieu()
        {
            DataTable dtNguyenVatLieu = new DataTable();

            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string query = @"SELECT nv.MaNguyenVatLieu, nv.TenNguyenVatLieu, l.TenLoaiNguyenVatLieu, nv.SoLuong, k.TenKhoHang, 
                       nv.HanSuDung, nv.TinhTrang, nv.SoLuongHuHong
                       FROM NguyenVatLieu nv
                       INNER JOIN LoaiNguyenVatLieu l ON nv.MaLoaiNguyenVatLieu = l.MaLoaiNguyenVatLieu
                       INNER JOIN KhoHang k ON nv.MaKhoHang = k.MaKhoHang";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                adapter.Fill(dtNguyenVatLieu);
            }

            return dtNguyenVatLieu;
        }

        public bool ThemNguyenVatLieu(NguyenVatLieu nguyenVatLieu)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string sql = @"INSERT INTO NguyenVatLieu 
                                (TenNguyenVatLieu, MaLoaiNguyenVatLieu, SoLuong, MaKhoHang, HanSuDung, TinhTrang, SoLuongHuHong) 
                                VALUES (@TenNguyenVatLieu, @MaLoaiNguyenVatLieu, @SoLuong, @MaKhoHang, @HanSuDung, @TinhTrang, @SoLuongHuHong)";

                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@TenNguyenVatLieu", nguyenVatLieu.TenNguyenVatLieu);
                    command.Parameters.AddWithValue("@MaLoaiNguyenVatLieu", nguyenVatLieu.MaLoaiNguyenVatLieu);
                    command.Parameters.AddWithValue("@SoLuong", nguyenVatLieu.SoLuong);
                    command.Parameters.AddWithValue("@MaKhoHang", nguyenVatLieu.MaKhoHang);
                    //command.Parameters.AddWithValue("@HanSuDung", nguyenVatLieu.HanSuDung);
                    if (nguyenVatLieu.HanSuDung.HasValue)
                    {
                        command.Parameters.AddWithValue("@HanSuDung", nguyenVatLieu.HanSuDung.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@HanSuDung", DBNull.Value);
                    }
                    command.Parameters.AddWithValue("@TinhTrang", nguyenVatLieu.TinhTrang);
                    command.Parameters.AddWithValue("@SoLuongHuHong", nguyenVatLieu.SoLuongHuHong);

                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.InsertCommand = command;
                        return adapter.InsertCommand.ExecuteNonQuery() > 0;
                    }
                }
            }
        }

        public bool CapNhatNguyenVatLieu(NguyenVatLieu nguyenVatLieu)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string sql = @"UPDATE NguyenVatLieu 
                       SET TenNguyenVatLieu = @TenNguyenVatLieu, 
                           MaLoaiNguyenVatLieu = @MaLoaiNguyenVatLieu,
                           SoLuong = @SoLuong, 
                           MaKhoHang = @MaKhoHang, 
                           HanSuDung = @HanSuDung, 
                           TinhTrang = @TinhTrang, 
                           SoLuongHuHong = @SoLuongHuHong
                       WHERE MaNguyenVatLieu = @MaNguyenVatLieu"; 

                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@MaNguyenVatLieu", nguyenVatLieu.MaNguyenVatLieu);
                    command.Parameters.AddWithValue("@TenNguyenVatLieu", nguyenVatLieu.TenNguyenVatLieu);
                    command.Parameters.AddWithValue("@MaLoaiNguyenVatLieu", nguyenVatLieu.MaLoaiNguyenVatLieu);
                    command.Parameters.AddWithValue("@SoLuong", nguyenVatLieu.SoLuong);
                    command.Parameters.AddWithValue("@MaKhoHang", nguyenVatLieu.MaKhoHang);
                    if (nguyenVatLieu.HanSuDung.HasValue)
                    {
                        command.Parameters.AddWithValue("@HanSuDung", nguyenVatLieu.HanSuDung.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@HanSuDung", DBNull.Value);
                    }
                    command.Parameters.AddWithValue("@TinhTrang", nguyenVatLieu.TinhTrang);
                    command.Parameters.AddWithValue("@SoLuongHuHong", nguyenVatLieu.SoLuongHuHong);

                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.UpdateCommand = command; 
                        return adapter.UpdateCommand.ExecuteNonQuery() > 0;
                    }
                }
            }
        }

        public bool XoaNguyenVatLieu(int maNguyenVatLieu)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string sql = "DELETE FROM NguyenVatLieu WHERE MaNguyenVatLieu = @MaNguyenVatLieu";

                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@MaNguyenVatLieu", maNguyenVatLieu);

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
