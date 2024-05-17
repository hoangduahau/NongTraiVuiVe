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
        public List<LoaiNguyenVatLieu> LayDanhSachLoaiNguyenVatLieu()
        {
            List<LoaiNguyenVatLieu> dsLoaiNguyenVatLieu = new List<LoaiNguyenVatLieu>();
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM LoaiNguyenVatLieu", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LoaiNguyenVatLieu lnvl = new LoaiNguyenVatLieu(
                        (int)reader["MaLoaiNguyenVatLieu"],
                        reader["TenLoaiNguyenVatLieu"].ToString()
                    );
                    dsLoaiNguyenVatLieu.Add(lnvl);
                }
            }
            return dsLoaiNguyenVatLieu;
        }

        public bool ThemLoaiNguyenVatLieu(LoaiNguyenVatLieu lnvl)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string query = "INSERT INTO LoaiNguyenVatLieu (TenLoaiNguyenVatLieu) " +
                               "VALUES (@TenLoaiNguyenVatLieu)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenLoaiNguyenVatLieu", lnvl.TenLoaiNguyenVatLieu);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Các phương thức khác (Cập nhật, Xóa): Tương tự phương thức ThemLoaiNguyenVatLieu
        // ...
    }
}
