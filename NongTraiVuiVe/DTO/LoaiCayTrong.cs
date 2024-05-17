using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NongTraiVuiVe.DTO
{
    public class LoaiCayTrong
    {
        public int MaLoaiCayTrong { get; set; }
        public string TenLoaiCayTrong { get; set; }
        public string MoTa { get; set; }

        public LoaiCayTrong() { }

        public LoaiCayTrong(int maLoaiCayTrong, string tenLoaiCayTrong, string moTa)
        {
            MaLoaiCayTrong = maLoaiCayTrong;
            TenLoaiCayTrong = tenLoaiCayTrong;
            MoTa = moTa;
        }
    }
}
