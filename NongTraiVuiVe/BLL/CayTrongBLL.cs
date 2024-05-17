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

            // Kiểm tra dữ liệu đầu vào (ví dụ)
            if (string.IsNullOrEmpty(cayTrong.TenCayTrong))
                throw new ArgumentException("Tên cây trồng không được để trống.");
            if (!cayTrong.MaLoaiCayTrong.HasValue)
                throw new ArgumentException("Mã loại cây trồng không được để trống.");
            if (!cayTrong.MaKhuVuc.HasValue)
                throw new ArgumentException("Mã khu vực không được để trống.");

            // Kiểm tra mã loại cây trồng có tồn tại
            if (!_loaiCayTrongDAL.KiemTraTonTaiMaLoaiCayTrong(cayTrong.MaLoaiCayTrong.Value))
                throw new ArgumentException("Mã loại cây trồng không tồn tại.");

            // Kiểm tra mã khu vực có tồn tại
            if (!_khuVucDAL.KiemTraTonTaiMaKhuVuc(cayTrong.MaKhuVuc.Value))
                throw new ArgumentException("Mã khu vực không tồn tại.");

            return _cayTrongDAL.ThemCayTrong(cayTrong);
        }

        public bool CapNhatCayTrong(CayTrong cayTrong)
        {
            if (cayTrong == null)
                throw new ArgumentNullException(nameof(cayTrong), "Đối tượng cây trồng không được null.");

            // Kiểm tra MaCayTrong có giá trị hay không
            if (cayTrong.MaCayTrong == 0)
                throw new ArgumentException("Mã cây trồng không được để trống.");

            // Kiểm tra dữ liệu đầu vào (ví dụ)
            if (string.IsNullOrEmpty(cayTrong.TenCayTrong))
                throw new ArgumentException("Tên cây trồng không được để trống.");
            if (!cayTrong.MaLoaiCayTrong.HasValue)
                throw new ArgumentException("Mã loại cây trồng không được để trống.");
            if (!cayTrong.MaKhuVuc.HasValue)
                throw new ArgumentException("Mã khu vực không được để trống.");

            // Kiểm tra mã loại cây trồng có tồn tại
            if (!_loaiCayTrongDAL.KiemTraTonTaiMaLoaiCayTrong(cayTrong.MaLoaiCayTrong.Value))
                throw new ArgumentException("Mã loại cây trồng không tồn tại.");

            // Kiểm tra mã khu vực có tồn tại
            if (!_khuVucDAL.KiemTraTonTaiMaKhuVuc(cayTrong.MaKhuVuc.Value))
                throw new ArgumentException("Mã khu vực không tồn tại.");

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
