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

namespace NongTraiVuiVe.Quản_Lý
{
    public partial class Frm_QuanLyNguyenVatLieu : Form
    {
        public Frm_QuanLyNguyenVatLieu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnThoatNvl_Click(object sender, EventArgs e)
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

        private NguyenVatLieuBLL nguyenVatLieuBLL;
        private void Frm_QuanLyNguyenVatLieu_Load(object sender, EventArgs e)
        {
            HienThiDanhSachNguyenVatLieu();
        }

        private void HienThiDanhSachNguyenVatLieu()
        {
            nguyenVatLieuBLL = new NguyenVatLieuBLL();

            DataTable dtNguyenVatLieu = nguyenVatLieuBLL.LayDuLieuNguyenVatLieu();
            dgvDanhSachNguyenVatLieu.DataSource = dtNguyenVatLieu;
        }

        private void dgvDanhSachNguyenVatLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThemNguyenVatLieu_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaNguyenVatLieu_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaNguyenVatLieu_Click(object sender, EventArgs e)
        {

        }
    }
}
