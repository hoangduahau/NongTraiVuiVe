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
    public class KhuVucDAL
    {
        public bool KiemTraTonTaiMaKhuVuc(int maKhuVuc)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM KhuVuc WHERE MaKhuVuc = @MaKhuVuc";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaKhuVuc", maKhuVuc);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        public DataTable LayDuLieuKhuVuc()
        {
            DataTable dtKhuVuc = new DataTable();

            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string query = "SELECT * FROM KhuVuc";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                adapter.Fill(dtKhuVuc);
            }

            return dtKhuVuc;
        }

        public bool ThemKhuVuc(KhuVuc khuVuc)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string sql = @"INSERT INTO KhuVuc 
                            (TenKhuVuc, KhaDung) 
                            VALUES (@TenKhuVuc, @KhaDung)";

                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@TenKhuVuc", khuVuc.TenKhuVuc);
                    command.Parameters.AddWithValue("@KhaDung", khuVuc.KhaDung);

                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.InsertCommand = command;
                        return adapter.InsertCommand.ExecuteNonQuery() > 0;
                    }
                }
            }
        }

        public bool CapNhatKhuVuc(KhuVuc khuVuc)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                string sql = @"UPDATE KhuVuc 
                       SET TenKhuVuc = @TenKhuVuc, 
                           KhaDung = @KhaDung 
                       WHERE MaKhuVuc = @MaKhuVuc"; 

                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@MaKhuVuc", khuVuc.MaKhuVuc);
                    command.Parameters.AddWithValue("@TenKhuVuc", khuVuc.TenKhuVuc);
                    command.Parameters.AddWithValue("@KhaDung", khuVuc.KhaDung);

                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.UpdateCommand = command; 
                        return adapter.UpdateCommand.ExecuteNonQuery() > 0;
                    }
                }
            }
        }

        //public bool XoaCayTrong(int maCayTrong)
        //{
        //    using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
        //    {
        //        conn.Open();
        //        string sql = "DELETE FROM CayTrong WHERE MaCayTrong = @MaCayTrong";

        //        using (SqlCommand command = new SqlCommand(sql, conn))
        //        {
        //            command.Parameters.AddWithValue("@MaCayTrong", maCayTrong);

        //            using (SqlDataAdapter adapter = new SqlDataAdapter())
        //            {
        //                adapter.DeleteCommand = command;
        //                return adapter.DeleteCommand.ExecuteNonQuery() > 0;
        //            }
        //        }
        //    }
        //}

        // Các phương thức khác (Cập nhật, Xóa): Tương tự phương thức ThemKhuVuc
        // ...
    }
}
