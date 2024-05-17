using NongTraiVuiVe.DAL;
using NongTraiVuiVe.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NongTraiVuiVe.BLL
{
    public class ChamSocCayTrongBLL
    {
        private ChamSocCayTrongDAL _chamSocCayTrongDAL;

        public ChamSocCayTrongBLL()
        {
            _chamSocCayTrongDAL = new ChamSocCayTrongDAL();
        }

        public List<ChamSocCayTrong> LayDanhSachChamSocCayTrong()
        {
            return _chamSocCayTrongDAL.LayDanhSachChamSocCayTrong();
        }

        public bool ThemChamSocCayTrong(ChamSocCayTrong csct)
        {
            // Kiểm tra dữ liệu (ví dụ: csct có hợp lệ không?)
            // ...

            return _chamSocCayTrongDAL.ThemChamSocCayTrong(csct);
        }

        // Các phương thức khác (Cập nhật, Xóa): Tương tự phương thức thêm
        // ...
    }
}
