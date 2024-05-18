using NongTraiVuiVe.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NongTraiVuiVe
{
    public partial class Frm_QuanLyKhuVuc : Form
    {
        public Frm_QuanLyKhuVuc()
        {
            InitializeComponent();
        }

        private void btnThoatKv_Click(object sender, EventArgs e)
        {
            TabPage tabPage = this.Parent as TabPage;

            if (tabPage != null)
            {
                TabControl tabControl = tabPage.Parent as TabControl;

                if (tabControl != null)
                {
                    tabControl.TabPages.Remove(tabPage);
                }
            }
        }

        private KhuVucBLL khuVucBLL;
        private void Frm_QuanLyKhuVuc_Load(object sender, EventArgs e)
        {
            HienThiDanhSachKhuVuc();
        }

        private void HienThiDanhSachKhuVuc()
        {
            khuVucBLL = new KhuVucBLL();

            // Gọi phương thức từ BLL để lấy dữ liệu và hiển thị
            DataTable dtKhuVuc = khuVucBLL.LayDuLieuKhuVuc();
            dgvDanhSachKhuVuc.DataSource = dtKhuVuc;
        }
    }
}
