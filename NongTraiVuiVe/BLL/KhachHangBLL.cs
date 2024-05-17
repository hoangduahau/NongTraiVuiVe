using NongTraiVuiVe.DAL;
using NongTraiVuiVe.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NongTraiVuiVe.BLL
{
    public class KhachHangBLL
    {
        private KhachHangDAL _khachHangDAL;

        public KhachHangBLL()
        {
            _khachHangDAL = new KhachHangDAL();
        }

        public List<KhachHang> LayDanhSachKhachHang()
        {
            return _khachHangDAL.LayDanhSachKhachHang();
        }

        public bool ThemKhachHang(KhachHang kh)
        {
            // Kiểm tra dữ liệu (ví dụ: kh có hợp lệ không?)
            // ... (Các logic nghiệp vụ khác)
            return _khachHangDAL.ThemKhachHang(kh);
        }

        // Các phương thức khác (Cập nhật, Xóa): Tương tự phương thức ThemKhachHang
        // ...
    }
}
