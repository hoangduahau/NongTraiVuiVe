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
    public class LoaiNguyenVatLieuDAL
    {
        public List<string> LayDanhSachTenLoaiNguyenVatLieu()
        {
            List<string> danhSachTenLoaiNguyenVatLieu = new List<string>();
            using (SqlConnection connection = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                connection.Open();
                string sql = "SELECT TenLoaiNguyenVatLieu FROM LoaiNguyenVatLieu"; 
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            danhSachTenLoaiNguyenVatLieu.Add(reader["TenLoaiNguyenVatLieu"].ToString());
                        }
                    }
                }
            }
            return danhSachTenLoaiNguyenVatLieu;
        }

        public int LayMaLoaiNguyenVatLieuTheoTen(string tenLoaiNguyenVatLieu)
        {
            using (SqlConnection connection = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                connection.Open();
                string sql = "SELECT MaLoaiNguyenVatLieu FROM LoaiNguyenVatLieu WHERE TenLoaiNguyenVatLieu = @TenLoaiNguyenVatLieu";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@TenLoaiNguyenVatLieu", tenLoaiNguyenVatLieu);
                    object result = command.ExecuteScalar();
                    return result != null ? (int)result : 0; 
                }
            }
        }
    }
}
