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

        public List<string> LayDanhSachTenKhuVuc()
        {
            return _khuVucDAL.LayDanhSachTenKhuVuc();
        }

        public int LayMaKhuVucTheoTen(string tenKhuVuc)
        {
            if (string.IsNullOrWhiteSpace(tenKhuVuc))
            {
                throw new ArgumentException("Tên khu vực không được để trống.");
            }

            return _khuVucDAL.LayMaKhuVucTheoTen(tenKhuVuc);
        }

        public bool ThemKhuVuc(KhuVuc khuVuc)
        {
            if (khuVuc == null)
                throw new ArgumentNullException(nameof(khuVuc), "Đối tượng khu vực không được null.");

            if (string.IsNullOrEmpty(khuVuc.TenKhuVuc))
                throw new ArgumentException("Tên khu vực không được để trống.");
            if (!khuVuc.KhaDung.HasValue)
                throw new ArgumentException("Vui lòng cho biết khu đất có còn trống hay không.");

            if (_khuVucDAL.KiemTraTonTaiTenKhuVuc(khuVuc.TenKhuVuc))
            {
                throw new ArgumentException("Khu vực đã tồn tại.");
            }

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

            if (_khuVucDAL.KiemTraTonTaiTenKhuVuc(khuVuc.TenKhuVuc) && _khuVucDAL.LayMaKhuVucTheoTen(khuVuc.TenKhuVuc) != khuVuc.MaKhuVuc)
            {
                throw new ArgumentException("Khu vực đã tồn tại.");
            }

            return _khuVucDAL.CapNhatKhuVuc(khuVuc);
        }

        public bool XoaKhuVuc(int maKhuVuc)
        {

            return _khuVucDAL.XoaKhuVuc(maKhuVuc); 
        }
    }
}
