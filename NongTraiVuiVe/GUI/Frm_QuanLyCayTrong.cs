﻿using NongTraiVuiVe.BLL;
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
    public partial class Frm_QuanLyCayTrong : Form
    {
        public Frm_QuanLyCayTrong()
        {
            InitializeComponent();
        }

        private void btnThoatCT_Click(object sender, EventArgs e)
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

        private void label8_Click(object sender, EventArgs e)
        {

        }


        private CayTrongBLL cayTrongBLL;

        private void Frm_QuanLyCayTrong_Load(object sender, EventArgs e)
        {
            HienThiDanhSachCayTrong();
        }

        private void HienThiDanhSachCayTrong()
        {
            cayTrongBLL = new CayTrongBLL();

            // Gọi phương thức từ BLL để lấy dữ liệu và hiển thị
            DataTable dtCayTrong = cayTrongBLL.LayDuLieuCayTrong();
            dgvDanhSachCayTrong.DataSource = dtCayTrong;
        }

        private void dgvDanhSachCayTrong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Kiểm tra xem có dòng nào được chọn không và chỉ số dòng hợp lệ
                if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSachCayTrong.Rows.Count)
                {
                    // Lấy dòng được chọn
                    DataGridViewRow selectedRow = dgvDanhSachCayTrong.Rows[e.RowIndex];

                    // Hiển thị các thuộc tính vào TextBox (điều chỉnh tên các TextBox cho phù hợp)
                    txtMaCayTrong.Text = selectedRow.Cells["MaCayTrong"].Value.ToString();
                    txtTenCayTrong.Text = selectedRow.Cells["TenCayTrong"].Value.ToString();
                    txtMaLoaiCayTrong.Text = selectedRow.Cells["MaLoaiCayTrong"].Value.ToString();
                    txtGiongCay.Text = selectedRow.Cells["Giong"].Value.ToString();
                    txtNguonGoc.Text = selectedRow.Cells["NguonGoc"].Value.ToString();
                    txtSoLuong.Text = selectedRow.Cells["SoLuong"].Value.ToString();
                    txtNgayGieoTrong.Text = selectedRow.Cells["NgayGieoTrong"].Value.ToString();
                    txtNgayThuHoachDuKien.Text = selectedRow.Cells["NgayThuHoachDuKien"].Value.ToString();
                    txtNgayThuHoachThucTe.Text = selectedRow.Cells["NgayThuHoachThucTe"].Value.ToString();
                    txtMaKhuVuc.Text = selectedRow.Cells["MaKhuVuc"].Value.ToString();
                    txtTinhTrang.Text = selectedRow.Cells["TinhTrang"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btnThemCayTrong_Click(object sender, EventArgs e)
        {
            try
            {
                CayTrong cayTrong = new CayTrong();
                cayTrong.TenCayTrong = txtTenCayTrong.Text;
                int.TryParse(txtMaLoaiCayTrong.Text, out int maLoaiCayTrong);
                cayTrong.MaLoaiCayTrong = maLoaiCayTrong;
                cayTrong.Giong = txtGiongCay.Text;
                cayTrong.NguonGoc = txtNguonGoc.Text;
                int.TryParse(txtSoLuong.Text, out int soLuong);
                cayTrong.SoLuong = soLuong;
                if (DateTime.TryParse(txtNgayGieoTrong.Text, out DateTime ngayGieoTrong))
                {
                    cayTrong.NgayGieoTrong = ngayGieoTrong;
                }
                else
                {
                    cayTrong.NgayGieoTrong = null;
                }

                if (DateTime.TryParse(txtNgayThuHoachDuKien.Text, out DateTime ngayThuHoachDuKien))
                {
                    cayTrong.NgayThuHoachDuKien = ngayThuHoachDuKien;
                }
                else
                {
                    cayTrong.NgayThuHoachDuKien = null;
                }

                if (DateTime.TryParse(txtNgayThuHoachThucTe.Text, out DateTime ngayThuHoachThucTe))
                {
                    cayTrong.NgayThuHoachThucTe = ngayThuHoachThucTe;
                }
                else
                {
                    cayTrong.NgayThuHoachThucTe = null;
                }
                int.TryParse(txtMaKhuVuc.Text, out int maKhuVuc);
                cayTrong.MaKhuVuc = maKhuVuc;
                cayTrong.TinhTrang = txtTinhTrang.Text;

                CayTrongBLL cayTrongBLL = new CayTrongBLL();
                if (cayTrongBLL.ThemCayTrong(cayTrong))
                {
                    txtTenCayTrong.Focus();
                    txtTenCayTrong.Text = "";
                    txtMaLoaiCayTrong.Text = "";
                    txtGiongCay.Text = "";
                    txtNguonGoc.Text = "";
                    txtSoLuong.Text = "";
                    txtNgayGieoTrong.Text = "";
                    txtNgayThuHoachDuKien.Text = "";
                    txtNgayThuHoachThucTe.Text = "";
                    txtMaKhuVuc.Text = "";
                    txtTinhTrang.Text = "";
                    HienThiDanhSachCayTrong();
                    MessageBox.Show("Thêm cây trồng thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm cây trồng thất bại. Vui lòng kiểm tra lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}