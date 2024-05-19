using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NongTraiVuiVe.DTO
{
    public class NguoiDung
    {
        public int MaNguoiDung { get; set; }
        public string TenDangNhap { get; set; }
        public byte[] MatKhau { get; set; }
        public DateTime NgayTao { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public DateTime NgayBatDauLamViec { get; set; }
        public int MaNhomNguoiDung { get; set; }

        public NguoiDung() { }

        public NguoiDung(int maNguoiDung, string tenDangNhap, byte[] matKhau, DateTime ngayTao, string hoTen, string diaChi,
                         string dienThoai, string gioiTinh, DateTime ngaySinh, DateTime ngayBatDauLamViec, int maNhomNguoiDung)
        {
            MaNguoiDung = maNguoiDung;
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
            NgayTao = ngayTao;
            HoTen = hoTen;
            DiaChi = diaChi;
            DienThoai = dienThoai;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            NgayBatDauLamViec = ngayBatDauLamViec;
            MaNhomNguoiDung = maNhomNguoiDung;
        }
    }
}
