﻿using NongTraiVuiVe.Quản_Lý;
using System.Windows.Forms.VisualStyles;

namespace NongTraiVuiVe
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }



        private void Frm_Main_Load(object sender, EventArgs e)
        {
            //Frm_DangNhap frm_DangNhap = new Frm_DangNhap();
            //frm_DangNhap.ShowDialog();
            //lblErr.Text
        }


        private void QuanLyTabPage(string tabPageName, Form formInstance)
        {
            if (!tabControl1.TabPages.ContainsKey(tabPageName))
            {
                // Tạo mới tab page
                TabPage tabPage = new TabPage(tabPageName);
                tabPage.Name = tabPageName;

                // Thêm form vào tab page
                formInstance.TopLevel = false;
                formInstance.FormBorderStyle = FormBorderStyle.None;
                formInstance.Dock = DockStyle.Fill;
                tabPage.Controls.Add(formInstance);

                // Thêm tab page vào tab control
                tabControl1.TabPages.Add(tabPage);

                // Chọn tab page mới được thêm vào
                tabControl1.SelectedTab = tabPage;

                // Hiển thị form
                formInstance.Show();
            }
            else
            {
                // Nếu tab page đã tồn tại, chuyển đến tab page đó
                tabControl1.SelectedTab = tabControl1.TabPages[tabPageName];
            }
        }

        private void quảnLýNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyTabPage("Quản Lý Người Dùng", new Frm_QuanLyNguoiDung());
        }

        private void quảnLýKhuVựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyTabPage("Quản Lý Khu Vực", new Frm_QuanLyKhuVuc());
        }

        private void quảnLýLoạiCâyTrồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyTabPage("Quản Lý Loại Cây Trồng", new Frm_QuanLyLoaiCay());
        }

        private void quảnLýCâyTrồngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            QuanLyTabPage("Quản Lý Cây Trồng", new Frm_QuanLyCayTrong());
        }

        private void quảnLýKhoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyTabPage("Quản Lý Kho Hàng", new Frm_QuanLyKhoHang());
        }

        private void quảnLýLoạiNguyênVậtLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyTabPage("Quản Lý Loại Nguyên Vật Liệu", new Frm_QuanLyLoaiNguyenVatLieu());
        }

        private void quảnLýNguyênVậtLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyTabPage("Quản Lý Nguyên Vật Liệu", new Frm_QuanLyNguyenVatLieu());
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyTabPage("Quản Lý Khách Hàng", new Frm_QuanLyKhachHang());
        }
    }
}