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
    public class NguoiDungDAL
    {
        public NguoiDung GetNguoiDungByTenDangNhap(string tenDangNhap)
        {
            NguoiDung nguoiDung = null;
            string query = "SELECT MaNguoiDung, TenDangNhap, MatKhau, HoTen, MaNhomNguoiDung FROM NguoiDung WHERE TenDangNhap = @TenDangNhap";

            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    nguoiDung = new NguoiDung
                    {
                        MaNguoiDung = reader.GetInt32(0),
                        TenDangNhap = reader.GetString(1),
                        MatKhau = (byte[])reader.GetValue(2),
                        HoTen = reader.GetString(3),
                        MaNhomNguoiDung = reader.GetInt32(4)
                    };
                }
            }

            return nguoiDung;
        }
    }
}
