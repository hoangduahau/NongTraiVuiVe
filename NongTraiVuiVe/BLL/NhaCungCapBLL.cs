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
    public class NhaCungCapBLL
    {
        private NhaCungCapDAL _nhaCungCapDAL;

        public NhaCungCapBLL()
        {
            _nhaCungCapDAL = new NhaCungCapDAL();
        }
        public DataTable LayDuLieuNhaCungCap()
        {
            return _nhaCungCapDAL.LayDuLieuNhaCungCap();
        }

        public List<string> LayDanhSachTenNhaCungCap()
        {
            return _nhaCungCapDAL.LayDanhSachTenNhaCungCap();
        }

        public int LayMaNhaCungCapTheoTen(string tenNhaCungCap)
        {
            return _nhaCungCapDAL.LayMaNhaCungCapTheoTen(tenNhaCungCap);
        }
        public bool ThemNhaCungCap(NhaCungCap nhaCungCap)
        {
            if (nhaCungCap == null)
                throw new ArgumentNullException(nameof(nhaCungCap), "Đối tượng nhà cung cấp không được null.");

            if (string.IsNullOrEmpty(nhaCungCap.TenNhaCungCap))
                throw new ArgumentException("Tên nhà cung cấp không được để trống.");
            if (string.IsNullOrEmpty(nhaCungCap.DiaChi))
                throw new ArgumentException("Địa chỉ nhà cung cấp không được để trống.");
            if (string.IsNullOrEmpty(nhaCungCap.DienThoai))
                throw new ArgumentException("Số điện thoại nhà cung cấp không được để trống.");

            return _nhaCungCapDAL.ThemNhaCungCap(nhaCungCap);
        }

        public bool CapNhatNhaCungCap(NhaCungCap nhaCungCap)
        {
            if (nhaCungCap == null)
                throw new ArgumentNullException(nameof(nhaCungCap), "Đối tượng nhà cung cấp không được null.");

            if (nhaCungCap.MaNhaCungCap == 0)
                throw new ArgumentException("Mã nhà cung cấp không được để trống.");

            if (string.IsNullOrEmpty(nhaCungCap.TenNhaCungCap))
                throw new ArgumentException("Tên nhà cung cấp không được để trống.");
            if (string.IsNullOrEmpty(nhaCungCap.DiaChi))
                throw new ArgumentException("Địa chỉ nhà cung cấp không được để trống.");
            if (string.IsNullOrEmpty(nhaCungCap.DienThoai))
                throw new ArgumentException("Số điện thoại nhà cung cấp không được để trống.");


            return _nhaCungCapDAL.CapNhatNhaCungCap(nhaCungCap);
        }

        public bool XoaNhaCungCap(int maNhaCungCap)
        {

            return _nhaCungCapDAL.XoaNhaCungCap(maNhaCungCap);
        }
    }
}
