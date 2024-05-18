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
    public class KhoHangBLL
    {
        private KhoHangDAL _khoHangDAL;

        public KhoHangBLL()
        {
            _khoHangDAL = new KhoHangDAL();
        }

        public DataTable LayDuLieuKhoHang()
        {
            return _khoHangDAL.LayDuLieuKhoHang();
        }

        public bool ThemKhoHang(KhoHang khoHang)
        {
            if (khoHang == null)
                throw new ArgumentNullException(nameof(khoHang), "Đối tượng kho hàng không được null.");

            if (string.IsNullOrEmpty(khoHang.TenKhoHang))
                throw new ArgumentException("Tên kho hàng không được để trống.");
            if (string.IsNullOrEmpty(khoHang.ViTri))
                throw new ArgumentException("Vị trí kho hàng không được để trống.");
            if (!khoHang.KhaDung.HasValue)
                throw new ArgumentException("Vui lòng cho biết kho hàng có còn trống hay không.");

            return _khoHangDAL.ThemKhoHang(khoHang);
        }

        public bool CapNhatKhoHang(KhoHang khoHang)
        {
            if (khoHang == null)
                throw new ArgumentNullException(nameof(khoHang), "Đối tượng kho hàng không được null.");

            if (khoHang.MaKhoHang == 0)
                throw new ArgumentException("Mã kho hàng không được để trống.");

            if (string.IsNullOrEmpty(khoHang.TenKhoHang))
                throw new ArgumentException("Tên kho hàng không được để trống.");
            if (string.IsNullOrEmpty(khoHang.ViTri))
                throw new ArgumentException("Vị trí kho hàng không được để trống.");
            if (!khoHang.KhaDung.HasValue)
                throw new ArgumentException("Vui lòng cho biết kho hàng có còn trống hay không.");

            return _khoHangDAL.CapNhatKhoHang(khoHang);
        }

        public bool XoaKhoHang(int maKhoHang)
        {

            return _khoHangDAL.XoaKhoHang(maKhoHang);
        }
    }
}
