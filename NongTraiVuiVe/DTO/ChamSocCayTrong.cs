using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NongTraiVuiVe.DTO
{
    public class ChamSocCayTrong
    {
        public int MaChamSoc { get; set; }
        public int MaCayTrong { get; set; }
        public string LoaiChamSoc { get; set; }
        public string MoTa { get; set; }
        public int NguoiChamSoc { get; set; }
        public DateTime Ngay { get; set; }

        public ChamSocCayTrong() { }

        public ChamSocCayTrong(int maCayTrong, string loaiChamSoc, string moTa, int nguoiChamSoc, DateTime ngay)
        {
            MaCayTrong = maCayTrong;
            LoaiChamSoc = loaiChamSoc;
            MoTa = moTa;
            NguoiChamSoc = nguoiChamSoc;
            Ngay = ngay;
        }
    }
}
