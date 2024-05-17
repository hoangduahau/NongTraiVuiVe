using NongTraiVuiVe.DAL;
using NongTraiVuiVe.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NongTraiVuiVe.BLL
{
    public class KhoHangBLL
    {
        private KhoHangDAL _khoHangDAL;

        public KhoHangBLL()
        {
            _khoHangDAL = new KhoHangDAL();
        }

        public List<KhoHang> LayDanhSachKhoHang()
        {
            return _khoHangDAL.LayDanhSachKhoHang();
        }

        public bool ThemKhoHang(KhoHang kh)
        {
            // Kiểm tra dữ liệu (ví dụ: kh có hợp lệ không?)
            // ... (Các logic nghiệp vụ khác)
            return _khoHangDAL.ThemKhoHang(kh);
        }

        // Các phương thức khác (Cập nhật, Xóa): Tương tự phương thức ThemKhoHang
        // ...
    }
}
