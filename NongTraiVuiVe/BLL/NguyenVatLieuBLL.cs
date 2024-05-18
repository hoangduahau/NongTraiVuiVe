using NongTraiVuiVe.DAL;
using NongTraiVuiVe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NongTraiVuiVe.BLL
{
    public class NguyenVatLieuBLL
    {
        private NguyenVatLieuDAL _nguyenVatLieuDAL;

        public NguyenVatLieuBLL()
        {
            _nguyenVatLieuDAL = new NguyenVatLieuDAL();
        }

        public DataTable LayDuLieuNguyenVatLieu()
        {
            return _nguyenVatLieuDAL.LayDuLieuNguyenVatLieu();
        }

        public bool ThemNguyenVatLieu(NguyenVatLieu nguyenVatLieu)
        {
            if (nguyenVatLieu == null)
                throw new ArgumentNullException(nameof(nguyenVatLieu), "Đối tượng nguyên vật liệu không được null.");

            // Kiểm tra dữ liệu đầu vào (ví dụ)
            if (string.IsNullOrEmpty(nguyenVatLieu.TenNguyenVatLieu))
                throw new ArgumentException("Tên nguyên vật liệu không được để trống.");
            if (!nguyenVatLieu.MaLoaiNguyenVatLieu.HasValue)
                throw new ArgumentException("Vui lòng chọn loại vật liệu.");
            if (!nguyenVatLieu.MaKhoHang.HasValue)
                throw new ArgumentException("Vui lòng chọn kho lưu trữ.");

            return _nguyenVatLieuDAL.ThemNguyenVatLieu(nguyenVatLieu);
        }

        public bool CapNhatNguyenVatLieu(NguyenVatLieu nguyenVatLieu)
        {
            if (nguyenVatLieu == null)
                throw new ArgumentNullException(nameof(nguyenVatLieu), "Đối tượng nguyên vật liệu không được null.");

            if (nguyenVatLieu.MaNguyenVatLieu == 0) 
                throw new ArgumentException("Mã nguyên vật liệu không hợp lệ.");

            if (string.IsNullOrEmpty(nguyenVatLieu.TenNguyenVatLieu))
                throw new ArgumentException("Tên nguyên vật liệu không được để trống.");
            if (!nguyenVatLieu.MaLoaiNguyenVatLieu.HasValue)
                throw new ArgumentException("Vui lòng chọn loại vật liệu.");
            if (!nguyenVatLieu.MaKhoHang.HasValue)
                throw new ArgumentException("Vui lòng chọn kho lưu trữ.");

            return _nguyenVatLieuDAL.CapNhatNguyenVatLieu(nguyenVatLieu); 
        }

        public bool XoaNguyenVatLieu(int maNguyenVatLieu)
        {

            return _nguyenVatLieuDAL.XoaNguyenVatLieu(maNguyenVatLieu); 
        }
    }
}
