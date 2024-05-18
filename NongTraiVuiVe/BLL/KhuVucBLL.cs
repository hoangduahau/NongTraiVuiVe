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
    public class KhuVucBLL
    {
        private KhuVucDAL _khuVucDAL;

        public KhuVucBLL()
        {
            _khuVucDAL = new KhuVucDAL();
        }

        public DataTable LayDuLieuKhuVuc()
        {
            return _khuVucDAL.LayDuLieuKhuVuc();
        }

        public bool ThemKhuVuc(KhuVuc khuVuc)
        {
            if (khuVuc == null)
                throw new ArgumentNullException(nameof(khuVuc), "Đối tượng khu vực không được null.");

            if (string.IsNullOrEmpty(khuVuc.TenKhuVuc))
                throw new ArgumentException("Tên khu vực không được để trống.");
            if (!khuVuc.KhaDung.HasValue)
                throw new ArgumentException("Vui lòng cho biết khu đất có còn trống hay không.");

            return _khuVucDAL.ThemKhuVuc(khuVuc);
        }

        public bool CapNhatKhuVuc(KhuVuc khuVuc)
        {
            if (khuVuc == null)
                throw new ArgumentNullException(nameof(khuVuc), "Đối tượng khu vực không được null.");

            if (khuVuc.MaKhuVuc == 0)
                throw new ArgumentException("Mã khu vực không được để trống.");

            if (string.IsNullOrEmpty(khuVuc.TenKhuVuc))
                throw new ArgumentException("Tên khu vực không được để trống.");
            if (!khuVuc.KhaDung.HasValue)
                throw new ArgumentException("Vui lòng cho biết khu đất có còn trống hay không.");

            return _khuVucDAL.CapNhatKhuVuc(khuVuc);
        }

        //public bool XoaCayTrong(int maCayTrong)
        //{

        //    return _cayTrongDAL.XoaCayTrong(maCayTrong); // Gọi phương thức xóa của DAL
        //}

        // Các phương thức khác (Cập nhật, Xóa): Tương tự phương thức ThemKhuVuc
        // ...
    }
}
