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

        public List<LoaiNguyenVatLieu> LayDanhSachLoaiNguyenVatLieu()
        {
            return _loaiNguyenVatLieuDAL.LayDanhSachLoaiNguyenVatLieu();
        }

        public bool ThemLoaiNguyenVatLieu(LoaiNguyenVatLieu lnvl)
        {
            // Kiểm tra dữ liệu (ví dụ: lnvl có hợp lệ không?)
            // ... (Các logic nghiệp vụ khác)
            return _loaiNguyenVatLieuDAL.ThemLoaiNguyenVatLieu(lnvl);
        }

        // Các phương thức khác (Cập nhật, Xóa): Tương tự phương thức ThemLoaiNguyenVatLieu
        // ...
    }
}
