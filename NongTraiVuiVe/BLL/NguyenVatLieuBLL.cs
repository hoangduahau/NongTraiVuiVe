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
    public class NguyenVatLieuBLL
    {
        private NguyenVatLieuDAL _nguyenVatLieuDAL;

        public NguyenVatLieuBLL()
        {
            _nguyenVatLieuDAL = new NguyenVatLieuDAL();
        }

        public DataTable LayDuLieuNguyenVatLieu()
        {
            return _nguyenVatLieuDAL.LayDuLieuNguyenVatLieu();
        }
    }
}
