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
        public List<NguyenVatLieu> LayDanhSachNguyenVatLieu()
        {
            List<NguyenVatLieu> dsNguyenVatLieu = new List<NguyenVatLieu>();
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM NguyenVatLieu", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    NguyenVatLieu nvl = new NguyenVatLieu(
                        (int)reader["MaNguyenVatLieu"],
                        reader["TenNguyenVatLieu"].ToString(),
                        (int)reader["MaLoaiNguyenVatLieu"],
                        (int)reader["SoLuong"],
                        (int)reader["MaKhoHang"],
                        (DateTime)reader["HanSuDung"],
                        reader["TinhTrang"].ToString(),
                        (int)reader["SoLuongHuHong"]
                    );
                    dsNguyenVatLieu.Add(nvl);
                }
            }
            return dsNguyenVatLieu;
        }

        public bool ThemNguyenVatLieu(NguyenVatLieu nvl)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string query = "INSERT INTO NguyenVatLieu (TenNguyenVatLieu, MaLoaiNguyenVatLieu, SoLuong, MaKhoHang, HanSuDung, TinhTrang, SoLuongHuHong) " +
                               "VALUES (@TenNguyenVatLieu, @MaLoaiNguyenVatLieu, @SoLuong, @MaKhoHang, @HanSuDung, @TinhTrang, @SoLuongHuHong)";
                SqlCommand cmd = new SqlCommand(query, conn);
                // ... (Thêm các tham số tương ứng từ nvl)
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Các phương thức khác (Cập nhật, Xóa): Tương tự phương thức ThemNguyenVatLieu
        // ...
    }
}
