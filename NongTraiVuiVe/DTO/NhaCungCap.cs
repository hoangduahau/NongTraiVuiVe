using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NongTraiVuiVe.DTO
{
    public class NhaCungCap
    {
        public int MaNhaCungCap { get; set; }
        public string TenNhaCungCap { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }

        public NhaCungCap() { }

        public NhaCungCap(int maNhaCungCap, string tenNhaCungCap, string diaChi, string dienThoai, string email)
        {
            MaNhaCungCap = maNhaCungCap;
            TenNhaCungCap = tenNhaCungCap;
            DiaChi = diaChi;
            DienThoai = dienThoai;
            Email = email;
        }
    }
}
