﻿using NongTraiVuiVe.BLL;
using NongTraiVuiVe.DAL;
using NongTraiVuiVe.DTO;
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
    public partial class Frm_QuanLyKhachHang : Form
    {
        public Frm_QuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void btnThoatKhachHang_Click(object sender, EventArgs e)
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

        private KhachHangBLL khachHangBLL;
        private void Frm_QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            HienThiDanhSachKhachHang();
        }

        private void HienThiDanhSachKhachHang()
        {
            khachHangBLL = new KhachHangBLL();

            DataTable dtKhachHang = khachHangBLL.LayDuLieuKhachHang();
            dgvDanhSachKhachHang.DataSource = dtKhachHang;
        }

        private void dgvDanhSachKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSachKhachHang.Rows.Count)
                {
                    DataGridViewRow selectedRow = dgvDanhSachKhachHang.Rows[e.RowIndex];

                    txtMaKhachHang.Text = selectedRow.Cells["MaKhachHang"].Value.ToString();
                    txtTenKhachHang.Text = selectedRow.Cells["TenKhachHang"].Value.ToString();
                    txtDiaChiKhachHang.Text = selectedRow.Cells["DiaChi"].Value.ToString();
                    txtSoDienThoaiKhachHang.Text = selectedRow.Cells["DienThoai"].Value.ToString();
                    txtEmailKhachHang.Text = selectedRow.Cells["Email"].Value.ToString();
                    txtNgaySinhKhachHang.Text = (selectedRow.Cells["NgaySinh"].Value is DateTime ngaySinh) ?
                        ngaySinh.ToString("dd/MM/yyyy") : string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                KhachHang khachHang = new KhachHang();
                khachHang.TenKhachHang = txtTenKhachHang.Text;
                khachHang.DiaChi = txtDiaChiKhachHang.Text;
                khachHang.DienThoai = txtSoDienThoaiKhachHang.Text;
                khachHang.Email = txtEmailKhachHang.Text;
                if (DateTime.TryParse(txtNgaySinhKhachHang.Text, out DateTime ngaySinh))
                {
                    if (ngaySinh >= new DateTime(1753, 1, 1))
                    {
                        khachHang.NgaySinh = ngaySinh;
                    }
                    else
                    {
                        MessageBox.Show("Ngày sinh phải từ ngày 1/1/1753 trở đi.");
                        return;
                    }
                }
                else
                {
                    khachHang.NgaySinh = null;
                }

                KhachHangBLL khachHangBLL = new KhachHangBLL();
                if (khachHangBLL.ThemKhachHang(khachHang))
                {
                    txtTenKhachHang.Focus();
                    txtMaKhachHang.Text = "";
                    txtTenKhachHang.Text = "";
                    txtDiaChiKhachHang.Text = "";
                    txtSoDienThoaiKhachHang.Text = "";
                    txtEmailKhachHang.Text = "";
                    txtNgaySinhKhachHang.Text = "";
                    HienThiDanhSachKhachHang();
                    MessageBox.Show("Thêm khách hàng thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng thất bại. Vui lòng kiểm tra lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSuaKhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                KhachHang khachHang = new KhachHang();
                int.TryParse(txtMaKhachHang.Text, out int maKhachHang);
                khachHang.MaKhachHang = maKhachHang;
                khachHang.TenKhachHang = txtTenKhachHang.Text;
                khachHang.DiaChi = txtDiaChiKhachHang.Text;
                khachHang.DienThoai = txtSoDienThoaiKhachHang.Text;
                khachHang.Email = txtEmailKhachHang.Text;
                if (DateTime.TryParse(txtNgaySinhKhachHang.Text, out DateTime ngaySinh))
                {
                    if (ngaySinh >= new DateTime(1753, 1, 1))
                    {
                        khachHang.NgaySinh = ngaySinh;
                    }
                    else
                    {
                        MessageBox.Show("Ngày sinh phải từ ngày 1/1/1753 trở đi.");
                        return;
                    }
                }
                else
                {
                    khachHang.NgaySinh = null;
                }

                KhachHangBLL khachHangBLL = new KhachHangBLL();
                if (khachHangBLL.CapNhatKhachHang(khachHang))
                {
                    txtTenKhachHang.Focus();
                    txtMaKhachHang.Text = "";
                    txtTenKhachHang.Text = "";
                    txtDiaChiKhachHang.Text = "";
                    txtSoDienThoaiKhachHang.Text = "";
                    txtEmailKhachHang.Text = "";
                    txtNgaySinhKhachHang.Text = "";
                    HienThiDanhSachKhachHang();
                    MessageBox.Show("Chỉnh sửa khách hàng thành công!");
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa khách hàng thất bại. Vui lòng kiểm tra lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoaKhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(txtMaKhachHang.Text, out int maKhachHang);

                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    KhachHangBLL khachHangBLL = new KhachHangBLL();
                    if (khachHangBLL.XoaKhachHang(maKhachHang))
                    {
                        HienThiDanhSachKhachHang();

                        MessageBox.Show("Xóa khách hàng thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xóa khách hàng thất bại. Vui lòng kiểm tra lại.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
