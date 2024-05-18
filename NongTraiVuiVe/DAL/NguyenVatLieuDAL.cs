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
    }
}
