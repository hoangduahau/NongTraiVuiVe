using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NongTraiVuiVe.DTO
{
    public class KhoHang
    {
        public int MaKhoHang { get; set; }
        public string TenKhoHang { get; set; }
        public string ViTri { get; set; }
        public bool? KhaDung { get; set; }

        public KhoHang() { }

        public KhoHang(int maKhoHang, string tenKhoHang, string viTri, bool khaDung)
        {
            MaKhoHang = maKhoHang;
            TenKhoHang = tenKhoHang;
            ViTri = viTri;
            KhaDung = khaDung;
        }
    }
}
