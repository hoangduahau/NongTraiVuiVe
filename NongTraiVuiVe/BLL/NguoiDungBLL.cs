using NongTraiVuiVe.DAL;
using NongTraiVuiVe.DTO;
using System;
using System.Collections.Generic;
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

        public bool DoiMatKhau(int maNguoiDung, string matKhauCu, string matKhauMoi)
        {
            return _nguoiDungDAL.DoiMatKhau(maNguoiDung, matKhauCu, matKhauMoi);
        }
    }
}
