using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NongTraiVuiVe.DTO
{
    public class KhuVuc
    {
        public int MaKhuVuc { get; set; }
        public string TenKhuVuc { get; set; }
        public bool KhaDung { get; set; }

        public KhuVuc() { }

        public KhuVuc(int maKhuVuc, string tenKhuVuc, bool khaDung)
        {
            MaKhuVuc = maKhuVuc;
            TenKhuVuc = tenKhuVuc;
            KhaDung = khaDung;
        }
    }
}
