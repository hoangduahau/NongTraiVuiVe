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
    public class XuatLuaBLL
    {
        private XuatLuaDAL _xuatLuaDAL;
        public XuatLuaBLL() 
        {
            _xuatLuaDAL = new XuatLuaDAL();
        }

        public DataTable LayDanhSachXuatLua()
        {
            return _xuatLuaDAL.LayDanhSachXuatLua();
        }

        public bool ThemPhieuXuat(XuatLua xuatLua)
        {
            if (xuatLua.MaCayTrong <= 0)
                throw new ArgumentException("Mã cây trồng không hợp lệ.");
            if (string.IsNullOrEmpty(xuatLua.TenCayTrong))
                throw new ArgumentException("Tên cây trồng không được để trống.");
            if (xuatLua.SoLuong <= 0)
                throw new ArgumentException("Số lượng phải lớn hơn 0.");
            if (xuatLua.GiaXuat <= 0)
                throw new ArgumentException("Giá xuất phải lớn hơn 0.");
            if (xuatLua.MaKhachHang <= 0)
                throw new ArgumentException("Mã khách hàng không hợp lệ.");

            return _xuatLuaDAL.ThemPhieuXuat(xuatLua);
        }

        public bool CapNhatXuatLua(XuatLua xuatLua)
        {
            if (xuatLua.MaXuatLua <= 0)
                throw new ArgumentException("Mã xuất lúa không hợp lệ.");
            if (xuatLua.MaCayTrong <= 0)
                throw new ArgumentException("Mã cây trồng không hợp lệ.");
            if (string.IsNullOrEmpty(xuatLua.TenCayTrong))
                throw new ArgumentException("Tên cây trồng không được để trống.");
            if (xuatLua.SoLuong <= 0)
                throw new ArgumentException("Số lượng phải lớn hơn 0.");
            if (xuatLua.GiaXuat <= 0)
                throw new ArgumentException("Giá xuất phải lớn hơn 0.");
            if (xuatLua.MaKhachHang <= 0)
                throw new ArgumentException("Mã khách hàng không hợp lệ.");

            return _xuatLuaDAL.CapNhatXuatLua(xuatLua);
        }

        public bool XoaPhieuXuat(int maPhieuNhap)
        {
            return _xuatLuaDAL.XoaPhieuXuat(maPhieuNhap);
        }
    }
}
