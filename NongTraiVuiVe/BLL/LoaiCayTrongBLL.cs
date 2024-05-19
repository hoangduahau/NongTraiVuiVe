using NongTraiVuiVe.DAL;
using NongTraiVuiVe.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NongTraiVuiVe.BLL
{
    public class LoaiCayTrongBLL
    {
        private LoaiCayTrongDAL _loaiCayTrongDAL;

        public LoaiCayTrongBLL()
        {
            _loaiCayTrongDAL = new LoaiCayTrongDAL();
        }

        public List<string> LayDanhSachTenLoaiCayTrong()
        {
            return _loaiCayTrongDAL.LayDanhSachTenLoaiCayTrong();
        }

        public int LayMaLoaiCayTrongTheoTen(string tenLoaiCayTrong)
        {
            if (string.IsNullOrWhiteSpace(tenLoaiCayTrong))
            {
                throw new ArgumentException("Tên loại cây trồng không được để trống.");
            }

            return _loaiCayTrongDAL.LayMaLoaiCayTrongTheoTen(tenLoaiCayTrong);
        }
    }
}
