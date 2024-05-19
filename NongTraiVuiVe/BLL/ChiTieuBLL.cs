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
    public class ChiTieuBLL
    {
        private ChiTieuDAL _chiTieuDAL;

        public ChiTieuBLL()
        {
            _chiTieuDAL = new ChiTieuDAL();
        }

        public DataTable LayDuLieuChiTieu()
        {
            return _chiTieuDAL.LayDuLieuChiTieu();
        }

        public bool ThemChiTieu(ChiTieu chiTieu)
        {
            if (string.IsNullOrEmpty(chiTieu.LoaiChiTieu))
            {
                throw new ArgumentException("Vui lòng chọn loại chi tiêu.");
            }

            if (chiTieu.ChiPhi <= 0)
            {
                throw new ArgumentException("Chi phí phải lớn hơn 0.");
            }

            if (chiTieu.NgayChiTieu == DateTimePicker.MinimumDateTime)
            {
                throw new ArgumentException("Ngày chi tiêu không hợp lệ.");
            }

            return _chiTieuDAL.ThemChiTieu(chiTieu);
        }

        public bool CapNhatChiTieu(ChiTieu chiTieu)
        {
            if (chiTieu.MaChiTieu == 0)
                throw new ArgumentException("Mã chi tiêu không được để trống.");

            if (string.IsNullOrEmpty(chiTieu.LoaiChiTieu))
            {
                throw new ArgumentException("Vui lòng chọn loại chi tiêu.");
            }

            if (chiTieu.ChiPhi <= 0)
            {
                throw new ArgumentException("Chi phí phải lớn hơn 0.");
            }

            if (chiTieu.NgayChiTieu == DateTimePicker.MinimumDateTime)
            {
                throw new ArgumentException("Ngày chi tiêu không hợp lệ.");
            }

            return _chiTieuDAL.ThemChiTieu(chiTieu);
        }

        public bool XoaChiTieu(int maChiTieu)
        {

            return _chiTieuDAL.XoaChiTieu(maChiTieu);
        }
    }
}
