using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NongTraiVuiVe.DTO
{
    public class KhachHang
    {
        public int MaKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public DateTime? NgaySinh { get; set; }

        public KhachHang() { }

        public KhachHang(int maKhachHang, string tenKhachHang, string diaChi, string dienThoai, string email, DateTime ngaySinh)
        {
            MaKhachHang = maKhachHang;
            TenKhachHang = tenKhachHang;
            DiaChi = diaChi;
            DienThoai = dienThoai;
            Email = email;
            NgaySinh = ngaySinh;
        }
    }
}
