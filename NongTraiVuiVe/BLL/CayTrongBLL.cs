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
    public class CayTrongBLL
    {
        private CayTrongDAL _cayTrongDAL;

        public CayTrongBLL()
        {
            _cayTrongDAL = new CayTrongDAL();
        }

        public DataTable LayDuLieuCayTrong()
        {
            return _cayTrongDAL.LayDuLieuCayTrong(); // Gọi phương thức từ DAL
        }

        //public bool ThemCayTrong(CayTrong cayTrong)
        //{
        //    ... (kiểm tra dữ liệu đầu vào, xử lý logic)
        //    return _cayTrongDAL.ThemCayTrong(cayTrong);
        //}

        // Các phương thức khác: CapNhatCayTrong, XoaCayTrong
        // ... (viết tương tự như ThemCayTrong)
    }
}
