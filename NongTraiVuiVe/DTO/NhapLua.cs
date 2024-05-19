using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NongTraiVuiVe.DTO
{
    public class NhapLua
    {
        public int MaNhapLua { get; set; }
        public string TenCayTrong { get; set; }
        public int MaLoaiCayTrong { get; set; }
        public string Giong { get; set; }
        public string NguonGoc { get; set; }
        public int SoLuong { get; set; }
        public int MaNhaCungCap { get; set; }
        public DateTime Ngay { get; set; }
        public decimal GiaNhap { get; set; }
    }
}
