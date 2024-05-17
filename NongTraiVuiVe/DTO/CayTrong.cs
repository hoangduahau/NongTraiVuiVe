using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NongTraiVuiVe.DTO
{
    public class CayTrong
    {
        public int MaCayTrong { get; set; }
        public string TenCayTrong { get; set; }
        public int? MaLoaiCayTrong { get; set; }
        public string Giong { get; set; }
        public string NguonGoc { get; set; }
        public int SoLuong { get; set; }
        public DateTime? NgayGieoTrong { get; set; }
        public DateTime? NgayThuHoachDuKien { get; set; }
        public DateTime? NgayThuHoachThucTe { get; set; }
        public int? MaKhuVuc { get; set; }
        public string TinhTrang { get; set; }

        public CayTrong() { }

        // Constructor (có tham số)
        public CayTrong(int maCayTrong, string tenCayTrong, int maLoaiCayTrong, string giong, string nguonGoc, int soLuong, DateTime ngayGieoTrong,
                        DateTime? ngayThuHoachDuKien, DateTime? ngayThuHoachThucTe, int maKhuVuc, string tinhTrang)
        {
            MaCayTrong = maCayTrong;
            TenCayTrong = tenCayTrong;
            MaLoaiCayTrong = maLoaiCayTrong;
            Giong = giong;
            NguonGoc = nguonGoc;
            SoLuong = soLuong;
            NgayGieoTrong = ngayGieoTrong;
            NgayThuHoachDuKien = ngayThuHoachDuKien;
            NgayThuHoachThucTe = ngayThuHoachThucTe;
            MaKhuVuc = maKhuVuc;
            TinhTrang = tinhTrang;
        }
    }
}
