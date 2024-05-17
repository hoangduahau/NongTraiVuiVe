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
    public class LoaiCayTrongDAL
    {
        public bool KiemTraTonTaiMaLoaiCayTrong(int maLoaiCayTrong)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM LoaiCayTrong WHERE MaLoaiCayTrong = @MaLoaiCayTrong";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaLoaiCayTrong", maLoaiCayTrong);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
        


        // Các phương thức khác (Cập nhật, Xóa): Tương tự phương thức ThemLoaiCayTrong
        // ...
    }
}
