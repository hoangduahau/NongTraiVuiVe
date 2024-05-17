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
    public class ChamSocCayTrongDAL
    {
        public List<ChamSocCayTrong> LayDanhSachChamSocCayTrong()
        {
            List<ChamSocCayTrong> dsChamSoc = new List<ChamSocCayTrong>();
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ChamSocCayTrong", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ChamSocCayTrong csct = new ChamSocCayTrong(
                        (int)reader["MaCayTrong"],
                        reader["LoaiChamSoc"].ToString(),
                        reader["MoTa"].ToString(),
                        (int)reader["NguoiChamSoc"],
                        (DateTime)reader["Ngay"]
                    );
                    dsChamSoc.Add(csct);
                }
            }
            return dsChamSoc;
        }

        public bool ThemChamSocCayTrong(ChamSocCayTrong csct)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string query = "INSERT INTO ChamSocCayTrong (MaCayTrong, LoaiChamSoc, MoTa, NguoiChamSoc, Ngay) " +
                               "VALUES (@MaCayTrong, @LoaiChamSoc, @MoTa, @NguoiChamSoc, @Ngay)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaCayTrong", csct.MaCayTrong);
                cmd.Parameters.AddWithValue("@LoaiChamSoc", csct.LoaiChamSoc);
                cmd.Parameters.AddWithValue("@MoTa", csct.MoTa);
                cmd.Parameters.AddWithValue("@NguoiChamSoc", csct.NguoiChamSoc);
                cmd.Parameters.AddWithValue("@Ngay", csct.Ngay);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Các phương thức khác (Cập nhật, Xóa): Tương tự phương thức thêm 
        // ...
    }
}
