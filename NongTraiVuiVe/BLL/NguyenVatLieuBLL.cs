using NongTraiVuiVe.DAL;
using NongTraiVuiVe.DTO;
using System;
using System.Collections.Generic;
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

        public List<NguyenVatLieu> LayDanhSachNguyenVatLieu()
        {
            return _nguyenVatLieuDAL.LayDanhSachNguyenVatLieu();
        }

        public bool ThemNguyenVatLieu(NguyenVatLieu nvl)
        {
            // Kiểm tra dữ liệu (ví dụ: nvl có hợp lệ không?)
            // ... (Các logic nghiệp vụ khác)
            return _nguyenVatLieuDAL.ThemNguyenVatLieu(nvl);
        }

        // Các phương thức khác (Cập nhật, Xóa): Tương tự phương thức ThemNguyenVatLieu
        // ...
    }
}
