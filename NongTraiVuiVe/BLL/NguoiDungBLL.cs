using NongTraiVuiVe.DAL;
using NongTraiVuiVe.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NongTraiVuiVe.BLL
{
    public class NguoiDungBLL
    {
        private NguoiDungDAL _nguoiDungDAL;

        public NguoiDungBLL()
        {
            _nguoiDungDAL = new NguoiDungDAL();
        }

        public List<NguoiDung> LayDanhSachNguoiDung()
        {
            return _nguoiDungDAL.LayDanhSachNguoiDung();
        }

        public bool ThemNguoiDung(NguoiDung nd)
        {
            // Thêm logic kiểm tra dữ liệu (ví dụ: kiểm tra trùng lặp tên đăng nhập, ...)

            // Băm (hash) mật khẩu trước khi lưu vào cơ sở dữ liệu (sử dụng thư viện băm như BCrypt)
            // ...

            return _nguoiDungDAL.ThemNguoiDung(nd);
        }

        // Các phương thức khác (Cập nhật, Xóa, Đăng nhập, ...): Tương tự phương thức ThemNguoiDung
        // ...
    }
}
