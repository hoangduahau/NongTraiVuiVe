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
    public class NguoiDungBLL
    {
        private NguoiDungDAL _nguoiDungDAL;

        public NguoiDungBLL()
        {
            _nguoiDungDAL = new NguoiDungDAL();
        }

        public NguoiDung DangNhap(string tenDangNhap, string matKhau)
        {
            NguoiDung nguoiDung = _nguoiDungDAL.GetNguoiDungByTenDangNhap(tenDangNhap);
            if (nguoiDung != null)
            {
                byte[] hashedPassword = Encoding.UTF8.GetBytes(matKhau);
                if (nguoiDung.MatKhau.SequenceEqual(hashedPassword))
                {
                    return nguoiDung;
                }
            }
            return null;
        }

        public List<string> LayDanhSachTenNguoiDung()
        {
            return _nguoiDungDAL.LayDanhSachTenNguoiDung();
        }

        public DataTable LayThongTinCobanNguoiDung()
        {
            return _nguoiDungDAL.LayDuLieuNguoiDung();
        }

        public bool DoiMatKhau(int maNguoiDung, string matKhauCu, string matKhauMoi)
        {
            return _nguoiDungDAL.DoiMatKhau(maNguoiDung, matKhauCu, matKhauMoi);
        }

        public DataTable LayDuLieuNguoiDung()
        {
            return _nguoiDungDAL.LayDuLieuNguoiDung();
        }

        public bool KiemTraTonTaiTenDangNhap(string tenDangNhap)
        {
            return _nguoiDungDAL.KiemTraTonTaiTenDangNhap(tenDangNhap);
        }

        public bool ThemNguoiDung(NguoiDung nguoiDung)
        {
            if (nguoiDung == null)
                throw new ArgumentNullException(nameof(nguoiDung), "Đối tượng người dùng không được null.");

            if (string.IsNullOrEmpty(nguoiDung.TenDangNhap))
                throw new ArgumentException("Tên đăng nhập không được để trống.");
            if (nguoiDung.MatKhau == null)
                throw new ArgumentException("Mật khẩu không được để trống.");
            if (string.IsNullOrEmpty(nguoiDung.HoTen))
                throw new ArgumentException("Họ tên không được để trống.");
            if (string.IsNullOrEmpty(nguoiDung.DiaChi))
                throw new ArgumentException("Địa chỉ không được để trống.");
            if (string.IsNullOrEmpty(nguoiDung.DienThoai))
                throw new ArgumentException("Số điện thoại không được để trống.");
            if (string.IsNullOrEmpty(nguoiDung.GioiTinh))
                throw new ArgumentException("Vui lòng chọn giới tính.");

            if (KiemTraTonTaiTenDangNhap(nguoiDung.TenDangNhap))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên khác.");
            }

            return _nguoiDungDAL.ThemNguoiDung(nguoiDung);
        }

        public bool CapNhatNguoiDung(NguoiDung nguoiDung)
        {
            if (nguoiDung == null)
                throw new ArgumentNullException(nameof(nguoiDung), "Đối tượng người dùng không được null.");

            if (nguoiDung.MaNguoiDung == 0)
                throw new ArgumentException("Mã người dùng không được để trống.");

            if (string.IsNullOrEmpty(nguoiDung.TenDangNhap))
                throw new ArgumentException("Tên đăng nhập không được để trống.");
            if (nguoiDung.MatKhau == null)
                throw new ArgumentException("Mật khẩu không được để trống.");
            if (string.IsNullOrEmpty(nguoiDung.HoTen))
                throw new ArgumentException("Họ tên không được để trống.");
            if (string.IsNullOrEmpty(nguoiDung.DiaChi))
                throw new ArgumentException("Địa chỉ không được để trống.");
            if (string.IsNullOrEmpty(nguoiDung.DienThoai))
                throw new ArgumentException("Số điện thoại không được để trống.");

            if (KiemTraTonTaiTenDangNhap(nguoiDung.TenDangNhap) && _nguoiDungDAL.LayMaNguoiDungTheoTenDangNhap(nguoiDung.TenDangNhap) != nguoiDung.MaNguoiDung)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên khác.");
            }

            return _nguoiDungDAL.CapNhatNguoiDung(nguoiDung);
        }

        public bool XoaNguoiDung(int maNguoiDung)
        {
            return _nguoiDungDAL.XoaNguoiDung(maNguoiDung);
        }
    }
}
