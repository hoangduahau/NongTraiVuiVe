using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
    }
}
