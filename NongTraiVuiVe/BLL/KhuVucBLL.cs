using NongTraiVuiVe.DAL;
using NongTraiVuiVe.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NongTraiVuiVe.BLL
{
    public class KhuVucBLL
    {
        private KhuVucDAL _khuVucDAL;

        public KhuVucBLL()
        {
            _khuVucDAL = new KhuVucDAL();
        }

        public List<KhuVuc> LayDanhSachKhuVuc()
        {
            return _khuVucDAL.LayDanhSachKhuVuc();
        }

        public bool ThemKhuVuc(KhuVuc kv)
        {
            // Kiểm tra dữ liệu (ví dụ: kv có hợp lệ không?)
            // ... (Các logic nghiệp vụ khác)
            return _khuVucDAL.ThemKhuVuc(kv);
        }

        // Các phương thức khác (Cập nhật, Xóa): Tương tự phương thức ThemKhuVuc
        // ...
    }
}
