using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NongTraiVuiVe.DTO
{
    public class XuatLua
    {
        public int MaXuatLua { get; set; }
        public int MaCayTrong { get; set; }
        public string TenCayTrong { get; set; }
        public int SoLuong { get; set; }
        public DateTime? Ngay { get; set; }
        public decimal GiaXuat { get; set; }
        public int MaKhachHang { get; set; }

        public XuatLua()
        {
        }

        public XuatLua(int maXuatLua, int maCayTrong, string tenCayTrong, int soLuong, DateTime ngay, decimal giaXuat, int maKhachHang)
        {
            MaXuatLua = maXuatLua;
            MaCayTrong = maCayTrong;
            TenCayTrong = tenCayTrong;
            SoLuong = soLuong;
            Ngay = ngay;
            GiaXuat = giaXuat;
            MaKhachHang = maKhachHang;
        }

        public XuatLua(int maCayTrong, string tenCayTrong, int soLuong, DateTime ngay, decimal giaXuat, int maKhachHang)
        {
            MaCayTrong = maCayTrong;
            TenCayTrong = tenCayTrong;
            SoLuong = soLuong;
            Ngay = ngay;
            GiaXuat = giaXuat;
            MaKhachHang = maKhachHang;
        }
    }
}
