using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NongTraiVuiVe.DTO
{
    public class NguyenVatLieu
    {
        public int MaNguyenVatLieu { get; set; }
        public string TenNguyenVatLieu { get; set; }
        public int MaLoaiNguyenVatLieu { get; set; }
        public int SoLuong { get; set; }
        public int MaKhoHang { get; set; }
        public DateTime HanSuDung { get; set; }
        public string TinhTrang { get; set; }
        public int SoLuongHuHong { get; set; } 

        public NguyenVatLieu() { }

        public NguyenVatLieu(int maNguyenVatLieu, string tenNguyenVatLieu, int maLoaiNguyenVatLieu, int soLuong, int maKhoHang,
                             DateTime hanSuDung, string tinhTrang, int soLuongHuHong)
        {
            MaNguyenVatLieu = maNguyenVatLieu;
            TenNguyenVatLieu = tenNguyenVatLieu;
            MaLoaiNguyenVatLieu = maLoaiNguyenVatLieu;
            SoLuong = soLuong;
            MaKhoHang = maKhoHang;
            HanSuDung = hanSuDung;
            TinhTrang = tinhTrang;
            SoLuongHuHong = soLuongHuHong;
        }
    }
}
