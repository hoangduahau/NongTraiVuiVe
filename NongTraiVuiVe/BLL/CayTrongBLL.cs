using Microsoft.IdentityModel.Tokens;
using NongTraiVuiVe.DAL;
using NongTraiVuiVe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NongTraiVuiVe.BLL
{
    public class CayTrongBLL
    {
        private CayTrongDAL _cayTrongDAL;
        private LoaiCayTrongDAL _loaiCayTrongDAL;
        private KhuVucDAL _khuVucDAL;

        public CayTrongBLL()
        {
            _cayTrongDAL = new CayTrongDAL();
            _loaiCayTrongDAL = new LoaiCayTrongDAL();
            _khuVucDAL = new KhuVucDAL();
        }

        public DataTable LayDuLieuCayTrong()
        {
            return _cayTrongDAL.LayDuLieuCayTrong(); 
        }

        public bool ThemCayTrong(CayTrong cayTrong)
        {
            if (cayTrong == null)
                throw new ArgumentNullException(nameof(cayTrong), "Đối tượng cây trồng không được null.");

            if (string.IsNullOrEmpty(cayTrong.TenCayTrong))
                throw new ArgumentException("Tên cây trồng không được để trống.");
            if (!cayTrong.MaLoaiCayTrong.HasValue)
                throw new ArgumentException("Mã loại cây trồng không được để trống.");
            if (!cayTrong.MaKhuVuc.HasValue)
                throw new ArgumentException("Mã khu vực không được để trống.");

            if (!_loaiCayTrongDAL.KiemTraTonTaiMaLoaiCayTrong(cayTrong.MaLoaiCayTrong.Value))
                throw new ArgumentException("Mã loại cây trồng không tồn tại.");

            if (!_khuVucDAL.KiemTraTonTaiMaKhuVuc(cayTrong.MaKhuVuc.Value))
                throw new ArgumentException("Mã khu vực không tồn tại.");

            if (cayTrong.NgayGieoTrong == DateTimePicker.MinimumDateTime)
            {
                throw new ArgumentException("Ngày gieo trồng không hợp lệ.");
            }
            if (cayTrong.NgayThuHoachDuKien == DateTimePicker.MinimumDateTime)
            {
                throw new ArgumentException("Ngày thu hoạch dự kiến không hợp lệ.");
            }
            if (cayTrong.NgayThuHoachThucTe == DateTimePicker.MinimumDateTime)
            {
                throw new ArgumentException("Ngày thu hoạch thực tế không hợp lệ.");
            }
            if (cayTrong.NgayGieoTrong >= cayTrong.NgayThuHoachDuKien)
            {
                throw new ArgumentException("Ngày gieo trồng phải nhỏ hơn ngày thu hoạch dự kiến.");
            }
            if (cayTrong.NgayGieoTrong >= cayTrong.NgayThuHoachThucTe)
            {
                throw new ArgumentException("Ngày gieo trồng phải nhỏ hơn ngày thu hoạch thực tế.");
            }

            if (_cayTrongDAL.KiemTraTonTaiTenCayTrong(cayTrong.TenCayTrong))
            {
                throw new ArgumentException("Cây trồng đã tồn tại.");
            }

            return _cayTrongDAL.ThemCayTrong(cayTrong);
        }

        public bool CapNhatCayTrong(CayTrong cayTrong)
        {
            if (cayTrong == null)
                throw new ArgumentNullException(nameof(cayTrong), "Đối tượng cây trồng không được null.");

            if (cayTrong.MaCayTrong == 0)
                throw new ArgumentException("Mã cây trồng không được để trống.");

            if (string.IsNullOrEmpty(cayTrong.TenCayTrong))
                throw new ArgumentException("Tên cây trồng không được để trống.");
            if (!cayTrong.MaLoaiCayTrong.HasValue)
                throw new ArgumentException("Mã loại cây trồng không được để trống.");
            if (!cayTrong.MaKhuVuc.HasValue)
                throw new ArgumentException("Mã khu vực không được để trống.");

            if (!_loaiCayTrongDAL.KiemTraTonTaiMaLoaiCayTrong(cayTrong.MaLoaiCayTrong.Value))
                throw new ArgumentException("Mã loại cây trồng không tồn tại.");

            if (!_khuVucDAL.KiemTraTonTaiMaKhuVuc(cayTrong.MaKhuVuc.Value))
                throw new ArgumentException("Mã khu vực không tồn tại.");

            if (cayTrong.NgayGieoTrong == DateTimePicker.MinimumDateTime)
            {
                throw new ArgumentException("Ngày gieo trồng không hợp lệ.");
            }
            if (cayTrong.NgayThuHoachDuKien == DateTimePicker.MinimumDateTime)
            {
                throw new ArgumentException("Ngày thu hoạch dự kiến không hợp lệ.");
            }
            if (cayTrong.NgayThuHoachThucTe == DateTimePicker.MinimumDateTime)
            {
                throw new ArgumentException("Ngày thu hoạch thực tế không hợp lệ.");
            }
            if (cayTrong.NgayGieoTrong >= cayTrong.NgayThuHoachDuKien)
            {
                throw new ArgumentException("Ngày gieo trồng phải nhỏ hơn ngày thu hoạch dự kiến.");
            }
            if (cayTrong.NgayGieoTrong >= cayTrong.NgayThuHoachThucTe)
            {
                throw new ArgumentException("Ngày gieo trồng phải nhỏ hơn ngày thu hoạch thực tế.");
            }

            if (_cayTrongDAL.KiemTraTonTaiTenCayTrong(cayTrong.TenCayTrong) && _cayTrongDAL.LayMaCayTrongTheoTen(cayTrong.TenCayTrong) != cayTrong.MaCayTrong)
            {
                throw new ArgumentException("Cây trồng đã tồn tại.");
            }

            return _cayTrongDAL.CapNhatCayTrong(cayTrong); 
        }

        public bool XoaCayTrong(int maCayTrong)
        {

            return _cayTrongDAL.XoaCayTrong(maCayTrong); // Gọi phương thức xóa của DAL
        }

        // Các phương thức khác: CapNhatCayTrong, XoaCayTrong
        // ... (viết tương tự như ThemCayTrong)
    }
}
