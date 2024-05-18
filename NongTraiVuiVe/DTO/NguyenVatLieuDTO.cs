using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NongTraiVuiVe.DTO
{
    public class NguyenVatLieuDTO
    {
        public int MaNguyenVatLieu { get; set; }
        public string TenNguyenVatLieu { get; set; }
        public string TenLoaiNguyenVatLieu { get; set; } 
        public int SoLuong { get; set; }
        public string TenKhoHang { get; set; } 
        public DateTime HanSuDung { get; set; }
        public string TinhTrang { get; set; }
        public int SoLuongHuHong { get; set; }

        public NguyenVatLieuDTO() { }

        public NguyenVatLieuDTO(int maNguyenVatLieu, string tenNguyenVatLieu, string tenLoaiNguyenVatLieu, int soLuong, string tenKhoHang,
                             DateTime hanSuDung, string tinhTrang, int soLuongHuHong)
        {
            MaNguyenVatLieu = maNguyenVatLieu;
            TenNguyenVatLieu = tenNguyenVatLieu;
            TenLoaiNguyenVatLieu = tenLoaiNguyenVatLieu;
            SoLuong = soLuong;
            TenKhoHang = tenKhoHang;
            HanSuDung = hanSuDung;
            TinhTrang = tinhTrang;
            SoLuongHuHong = soLuongHuHong;
        }
    }
}
