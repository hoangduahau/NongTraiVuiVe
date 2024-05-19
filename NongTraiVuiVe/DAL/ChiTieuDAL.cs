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
    public class ChiTieuDAL
    {
        public DataTable LayDuLieuChiTieu()
        {
            DataTable dtChiTieu = new DataTable();

            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string query = @"
            SELECT 
                ct.MaChiTieu, 
                ct.LoaiChiTieu, 
                ct.ChiPhi, 
                ct.NgayChiTieu, 
                nd.HoTen AS TenNguoiThucHien,
                ct.MaNguoiThucHien
            FROM ChiTieu ct
            INNER JOIN NguoiDung nd ON ct.MaNguoiThucHien = nd.MaNguoiDung;"; 

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dtChiTieu);
            }

            return dtChiTieu;
        }

        public bool ThemChiTieu(ChiTieu chiTieu) 
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string sql = @"
                INSERT INTO ChiTieu (LoaiChiTieu, ChiPhi, NgayChiTieu, MaNguoiThucHien)
                VALUES (@LoaiChiTieu, @ChiPhi, @NgayChiTieu, @MaNguoiThucHien);
            ";
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@LoaiChiTieu", chiTieu.LoaiChiTieu);
                    command.Parameters.AddWithValue("@ChiPhi", chiTieu.ChiPhi);
                    command.Parameters.AddWithValue("@NgayChiTieu", chiTieu.NgayChiTieu);
                    command.Parameters.AddWithValue("@MaNguoiThucHien", chiTieu.MaNguoiThucHien);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool CapNhatChiTieu(ChiTieu chiTieu)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string sql = @"
                            UPDATE ChiTieu 
                            SET LoaiChiTieu = @LoaiChiTieu, 
                                ChiPhi = @ChiPhi, 
                                NgayChiTieu = @NgayChiTieu, 
                                MaNguoiThucHien = @MaNguoiThucHien
                            WHERE MaChiTieu = @MaChiTieu;";
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@MaChiTieu", chiTieu.MaChiTieu); 
                    command.Parameters.AddWithValue("@LoaiChiTieu", chiTieu.LoaiChiTieu);
                    command.Parameters.AddWithValue("@ChiPhi", chiTieu.ChiPhi);
                    command.Parameters.AddWithValue("@NgayChiTieu", chiTieu.NgayChiTieu);
                    command.Parameters.AddWithValue("@MaNguoiThucHien", chiTieu.MaNguoiThucHien);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool XoaChiTieu(int maChiTieu)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string sql = "DELETE FROM ChiTieu WHERE MaChiTieu = @MaChiTieu";
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@MaChiTieu", maChiTieu);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0; 
                }
            }
        }
    }
}
