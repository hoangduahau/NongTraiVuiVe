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
    public class CayTrongDAL
    {
        public List<CayTrong> LayDanhSachCayTrong()
        {
            List<CayTrong> dsCayTrong = new List<CayTrong>();
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString)) // Sử dụng DatabaseConnection
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM CayTrong", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    CayTrong ct = new CayTrong();
                    // ... (gán giá trị cho các thuộc tính của ct từ reader)
                    dsCayTrong.Add(ct);
                }
            }
            return dsCayTrong;
        }

        // Các phương thức khác: ThemCayTrong, CapNhatCayTrong, XoaCayTrong
        // ... (viết tương tự như LayDanhSachCayTrong)
    }
}
