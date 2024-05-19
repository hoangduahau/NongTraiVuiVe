using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NongTraiVuiVe.DTO
{
    public class ChiTieu
    {
        public int MaChiTieu { get; set; }
        public string? LoaiChiTieu { get; set; }
        public decimal ChiPhi { get; set; }
        public DateTime NgayChiTieu { get; set; }
        public int MaNguoiThucHien { get; set; }

        public ChiTieu() { }

        public ChiTieu(string loaiChiTieu, decimal chiPhi, DateTime ngayChiTieu, int maNguoiThucHien)
        {
            LoaiChiTieu = loaiChiTieu;
            ChiPhi = chiPhi;
            NgayChiTieu = ngayChiTieu;
            MaNguoiThucHien = maNguoiThucHien;
        }
    }
}
