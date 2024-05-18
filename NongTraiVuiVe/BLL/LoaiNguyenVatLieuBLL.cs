using NongTraiVuiVe.DAL;
using NongTraiVuiVe.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NongTraiVuiVe.BLL
{
    public class LoaiNguyenVatLieuBLL
    {
        private LoaiNguyenVatLieuDAL _loaiNguyenVatLieuDAL;

        public LoaiNguyenVatLieuBLL()
        {
            _loaiNguyenVatLieuDAL = new LoaiNguyenVatLieuDAL();
        }

        public List<string> LayDanhSachTenLoaiNguyenVatLieu()
        {
            return _loaiNguyenVatLieuDAL.LayDanhSachTenLoaiNguyenVatLieu();
        }

        public int LayMaLoaiNguyenVatLieuTheoTen(string tenLoaiNguyenVatLieu)
        {
            return _loaiNguyenVatLieuDAL.LayMaLoaiNguyenVatLieuTheoTen(tenLoaiNguyenVatLieu);
        }
    }
}
