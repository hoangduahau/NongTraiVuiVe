using NongTraiVuiVe.DAL;
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
    }
}
