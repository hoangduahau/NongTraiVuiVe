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
    public class NhapLuaBLL
    {
        private NhapLuaDAL _nhapLuaDAL;
        public NhapLuaBLL() 
        {
            _nhapLuaDAL = new NhapLuaDAL();
        }

        public DataTable LayDanhSachNhapLua()
        {
            return _nhapLuaDAL.LayDanhSachNhapLua();
        }

        public bool ThemPhieuNhap(NhapLua nhapLua)
        {
            if (string.IsNullOrEmpty(nhapLua.TenCayTrong))
                throw new ArgumentException("Tên cây trồng không được để trống.");
            if (nhapLua.MaLoaiCayTrong <= 0)
                throw new ArgumentException("Mã loại cây trồng không hợp lệ.");
            if (nhapLua.SoLuong <= 0)
                throw new ArgumentException("Số lượng phải lớn hơn 0.");
            if (nhapLua.MaNhaCungCap <= 0)
                throw new ArgumentException("Mã nhà cung cấp không hợp lệ.");
            if (nhapLua.GiaNhap <= 0)
                throw new ArgumentException("Giá nhập phải lớn hơn 0.");

            return _nhapLuaDAL.ThemPhieuNhap(nhapLua);
        }

        public bool SuaPhieuNhap(NhapLua nhapLua)
        {
            if (string.IsNullOrEmpty(nhapLua.TenCayTrong))
                throw new ArgumentException("Tên cây trồng không được để trống.");
            if (nhapLua.MaLoaiCayTrong <= 0)
                throw new ArgumentException("Mã loại cây trồng không hợp lệ.");
            if (nhapLua.SoLuong <= 0)
                throw new ArgumentException("Số lượng phải lớn hơn 0.");
            if (nhapLua.MaNhaCungCap <= 0)
                throw new ArgumentException("Mã nhà cung cấp không hợp lệ.");
            if (nhapLua.GiaNhap <= 0)
                throw new ArgumentException("Giá nhập phải lớn hơn 0.");

            return _nhapLuaDAL.SuaPhieuNhap(nhapLua);
        }

        public bool XoaPhieuNhap(int maPhieuNhap)
        {
            return _nhapLuaDAL.XoaPhieuNhap(maPhieuNhap);
        }
    }
}
