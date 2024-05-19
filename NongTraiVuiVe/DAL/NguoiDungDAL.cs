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

        public bool DoiMatKhau(int maNguoiDung, string matKhauCu, string matKhauMoi)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_DoiMatKhau", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaNguoiDung", maNguoiDung);
                cmd.Parameters.AddWithValue("@MatKhauCu", matKhauCu);
                cmd.Parameters.AddWithValue("@MatKhauMoi", matKhauMoi);

                // Thêm tham số output
                SqlParameter resultParam = new SqlParameter("@Result", SqlDbType.Int);
                resultParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(resultParam);

                cmd.ExecuteNonQuery();
                int result = (int)resultParam.Value; // Lấy giá trị từ tham số output

                return result > 0;
            }
        }

        public DataTable LayDuLieuNguoiDung()
        {
            DataTable dtNguoiDung = new DataTable();

            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string query = "SELECT * FROM NguoiDung";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                adapter.Fill(dtNguoiDung);
                dtNguoiDung.Columns.Add("Password", typeof(string));

                foreach (DataRow row in dtNguoiDung.Rows)
                {
                    byte[] hashedPassword = (byte[])row["MatKhau"];
                    row["Password"] = new string('*', hashedPassword.Length);
                }

                dtNguoiDung.Columns.Remove("MatKhau");
            }

            return dtNguoiDung;
        }

        public bool KiemTraTonTaiTenDangNhap(string tenDangNhap)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM NguoiDung WHERE TenDangNhap = @TenDangNhap";
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    int count = (int)command.ExecuteScalar();
                    return count > 0; 
                }
            }
        }

        public int LayMaNguoiDungTheoTenDangNhap(string tenDangNhap)
        {
            using (SqlConnection connection = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                connection.Open();
                string sql = "SELECT MaNguoiDung FROM NguoiDung WHERE TenDangNhap = @TenDangNhap";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    object result = command.ExecuteScalar();
                    return result != null ? (int)result : 0;
                }
            }
        }

        public bool ThemNguoiDung(NguoiDung nguoiDung)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string sql = @"INSERT INTO NguoiDung 
                (TenDangNhap, MatKhau, NgayTao, HoTen, DiaChi, DienThoai, GioiTinh, NgaySinh, NgayBatDauLamViec, MaNhomNguoiDung) 
                VALUES (@TenDangNhap, @MatKhau, @NgayTao, @HoTen, @DiaChi, @DienThoai, @GioiTinh, @NgaySinh, @NgayBatDauLamViec, @MaNhomNguoiDung)";

                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@TenDangNhap", nguoiDung.TenDangNhap);
                    command.Parameters.AddWithValue("@MatKhau", nguoiDung.MatKhau);
                    command.Parameters.AddWithValue("@NgayTao", nguoiDung.NgayTao);
                    command.Parameters.AddWithValue("@HoTen", nguoiDung.HoTen);
                    command.Parameters.AddWithValue("@DiaChi", nguoiDung.DiaChi);
                    command.Parameters.AddWithValue("@DienThoai", nguoiDung.DienThoai);
                    command.Parameters.AddWithValue("@GioiTinh", nguoiDung.GioiTinh);
                    command.Parameters.AddWithValue("@NgaySinh", nguoiDung.NgaySinh);
                    command.Parameters.AddWithValue("@NgayBatDauLamViec", nguoiDung.NgayBatDauLamViec);
                    command.Parameters.AddWithValue("@MaNhomNguoiDung", nguoiDung.MaNhomNguoiDung);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool CapNhatNguoiDung(NguoiDung nguoiDung)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string sql = @"UPDATE NguoiDung 
               SET TenDangNhap = @TenDangNhap, 
                   MatKhau = @MatKhau,
                   NgayTao = @NgayTao,
                   HoTen = @HoTen,
                   DiaChi = @DiaChi,
                   DienThoai = @DienThoai,
                   GioiTinh = @GioiTinh,
                   NgaySinh = @NgaySinh,
                   NgayBatDauLamViec = @NgayBatDauLamViec,
                   MaNhomNguoiDung = @MaNhomNguoiDung
               WHERE MaNguoiDung = @MaNguoiDung";

                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@MaNguoiDung", nguoiDung.MaNguoiDung);
                    command.Parameters.AddWithValue("@TenDangNhap", nguoiDung.TenDangNhap);
                    command.Parameters.AddWithValue("@MatKhau", nguoiDung.MatKhau);
                    command.Parameters.AddWithValue("@NgayTao", nguoiDung.NgayTao);
                    command.Parameters.AddWithValue("@HoTen", nguoiDung.HoTen);
                    command.Parameters.AddWithValue("@DiaChi", nguoiDung.DiaChi);
                    command.Parameters.AddWithValue("@DienThoai", nguoiDung.DienThoai);
                    command.Parameters.AddWithValue("@GioiTinh", nguoiDung.GioiTinh);
                    command.Parameters.AddWithValue("@NgaySinh", nguoiDung.NgaySinh);
                    command.Parameters.AddWithValue("@NgayBatDauLamViec", nguoiDung.NgayBatDauLamViec);
                    command.Parameters.AddWithValue("@MaNhomNguoiDung", nguoiDung.MaNhomNguoiDung);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool XoaNguoiDung(int maNguoiDung)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string sql = "DELETE FROM NguoiDung WHERE MaNguoiDung = @MaNguoiDung";

                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@MaNguoiDung", maNguoiDung);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public List<string> LayDanhSachTenNguoiDung()
        {
            List<string> danhSachTenNguoiDung = new List<string>();

            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string sql = "SELECT HoTen FROM NguoiDung";
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            danhSachTenNguoiDung.Add(reader["HoTen"].ToString());
                        }
                    }
                }
            }

            return danhSachTenNguoiDung;
        }

        public DataTable LayThongTinCobanNguoiDung()
        {
            DataTable dtNguoiDung = new DataTable();

            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string query = "SELECT MaNguoiDung, HoTen, TenDangNhap FROM NguoiDung"; // Lấy thêm cột TenDangNhap
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                adapter.Fill(dtNguoiDung);
            }

            return dtNguoiDung;
        }
    }
}
