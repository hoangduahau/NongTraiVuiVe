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
        public DataTable LayDuLieuCayTrong()
        {
            DataTable dtCayTrong = new DataTable();

            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string query = "SELECT * FROM CayTrong";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                adapter.Fill(dtCayTrong);
            }

            return dtCayTrong;
        }

        // Các phương thức khác: ThemCayTrong, CapNhatCayTrong, XoaCayTrong
        // ... (viết tương tự như LayDanhSachCayTrong)
    }
}
