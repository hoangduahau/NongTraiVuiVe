using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NongTraiVuiVe.DTO
{
    public class LoaiNguyenVatLieu
    {
        public int MaLoaiNguyenVatLieu { get; set; }
        public string TenLoaiNguyenVatLieu { get; set; }

        public LoaiNguyenVatLieu() { } 

        public LoaiNguyenVatLieu(int maLoaiNguyenVatLieu, string tenLoaiNguyenVatLieu)
        {
            MaLoaiNguyenVatLieu = maLoaiNguyenVatLieu;
            TenLoaiNguyenVatLieu = tenLoaiNguyenVatLieu;
        }
    }
}
