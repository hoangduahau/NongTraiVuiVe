using NongTraiVuiVe.DAL;
using NongTraiVuiVe.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NongTraiVuiVe.BLL
{
    public class LoaiCayTrongBLL
    {
        private LoaiCayTrongDAL _loaiCayTrongDAL;

        public LoaiCayTrongBLL()
        {
            _loaiCayTrongDAL = new LoaiCayTrongDAL();
        }

        public List<LoaiCayTrong> LayDanhSachLoaiCayTrong()
        {
            return _loaiCayTrongDAL.LayDanhSachLoaiCayTrong();
        }

        public bool ThemLoaiCayTrong(LoaiCayTrong lct)
        {
            // Kiểm tra dữ liệu (ví dụ: lct có hợp lệ không?)
            // ... (Các logic nghiệp vụ khác)
            return _loaiCayTrongDAL.ThemLoaiCayTrong(lct);
        }

        // Các phương thức khác (Cập nhật, Xóa): Tương tự phương thức ThemLoaiCayTrong
        // ...
    }
}
