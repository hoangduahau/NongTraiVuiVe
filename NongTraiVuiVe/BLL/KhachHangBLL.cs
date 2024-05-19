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
    public class KhachHangBLL
    {
        private KhachHangDAL _khachHangDAL;

        public KhachHangBLL()
        {
            _khachHangDAL = new KhachHangDAL();
        }

        public DataTable LayDuLieuKhachHang()
        {
            return _khachHangDAL.LayDuLieuKhachHang();
        }

        public bool ThemKhachHang(KhachHang khachHang)
        {
            if (khachHang == null)
                throw new ArgumentNullException(nameof(khachHang), "Đối tượng khách hàng không được null.");

            if (string.IsNullOrEmpty(khachHang.TenKhachHang))
                throw new ArgumentException("Tên khách hàng không được để trống.");
            if (string.IsNullOrEmpty(khachHang.DiaChi))
                throw new ArgumentException("Địa chỉ khách hàng không được để trống.");
            if (string.IsNullOrEmpty(khachHang.DienThoai))
                throw new ArgumentException("Số điện thoại khách hàng không được để trống.");
            if (khachHang.NgaySinh == DateTimePicker.MinimumDateTime)
            {
                throw new ArgumentException("Ngày sinh không hợp lệ.");
            }

            return _khachHangDAL.ThemKhachHang(khachHang);
        }

        public bool CapNhatKhachHang(KhachHang khachHang)
        {
            if (khachHang == null)
                throw new ArgumentNullException(nameof(khachHang), "Đối tượng khách hàng không được null.");

            if (khachHang.MaKhachHang == 0)
                throw new ArgumentException("Mã khách hàng không được để trống.");

            if (string.IsNullOrEmpty(khachHang.TenKhachHang))
                throw new ArgumentException("Tên khách hàng không được để trống.");
            if (string.IsNullOrEmpty(khachHang.DiaChi))
                throw new ArgumentException("Địa chỉ khách hàng không được để trống.");
            if (string.IsNullOrEmpty(khachHang.DienThoai))
                throw new ArgumentException("Số điện thoại khách hàng không được để trống.");
            if (khachHang.NgaySinh == DateTimePicker.MinimumDateTime)
            {
                throw new ArgumentException("Ngày sinh không hợp lệ.");
            }


            return _khachHangDAL.CapNhatKhachHang(khachHang);
        }

        public bool XoaKhachHang(int maKhachHang)
        {

            return _khachHangDAL.XoaKhachHang(maKhachHang);
        }
    }
}
