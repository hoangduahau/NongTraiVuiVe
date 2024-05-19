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
    public partial class Frm_QuanLyLoaiCay : Form
    {
        public Frm_QuanLyLoaiCay()
        {
            InitializeComponent();
            this.Resize += new EventHandler(Frm_QuanLyLoaiCay_Resize);
        }

        private void Frm_QuanLyLoaiCay_Resize(object sender, EventArgs e)
        {
            // Đảm bảo DataGridView thay đổi kích thước theo kích thước của Form
            dgvDanhSachLoaiCay.Width = this.ClientSize.Width;
            dgvDanhSachLoaiCay.Height = this.ClientSize.Height - dgvDanhSachLoaiCay.Location.Y; // trừ đi vị trí Y của DataGridView
        }


        private void btnThoatLCT_Click(object sender, EventArgs e)
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

        private void Frm_QuanLyLoaiCay_Load(object sender, EventArgs e)
        {

            dgvDanhSachLoaiCay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
