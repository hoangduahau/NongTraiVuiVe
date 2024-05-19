using NongTraiVuiVe.BLL;
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
            LoaiCayTrongBLL loaiCayTrongBLL = new LoaiCayTrongBLL();
            List<string> danhSachTenLoaiCayTrong = loaiCayTrongBLL.LayDanhSachTenLoaiCayTrong();
            cbbLoaiCayTrong.DataSource = danhSachTenLoaiCayTrong;
            cbbLoaiCayTrong.SelectedIndex = -1;
            KhuVucBLL khuVucBLL = new KhuVucBLL();
            List<string> danhSachKhuVuc = khuVucBLL.LayDanhSachTenKhuVuc();
            cbbKhuVuc.DataSource = danhSachKhuVuc;
            cbbKhuVuc.SelectedIndex = -1;
        }

        private void HienThiDanhSachCayTrong()
        {
            cayTrongBLL = new CayTrongBLL();

            DataTable dtCayTrong = cayTrongBLL.LayDuLieuCayTrong();
            dgvDanhSachCayTrong.DataSource = dtCayTrong;
        }

        private void dgvDanhSachCayTrong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSachCayTrong.Rows.Count)
                {
                    DataGridViewRow selectedRow = dgvDanhSachCayTrong.Rows[e.RowIndex];

                    txtMaCayTrong.Text = selectedRow.Cells["MaCayTrong"].Value.ToString();
                    txtTenCayTrong.Text = selectedRow.Cells["TenCayTrong"].Value.ToString();
                    cbbLoaiCayTrong.Text = selectedRow.Cells["TenLoaiCayTrong"].Value.ToString();
                    txtGiongCay.Text = selectedRow.Cells["Giong"].Value.ToString();
                    txtNguonGoc.Text = selectedRow.Cells["NguonGoc"].Value.ToString();
                    txtSoLuong.Text = selectedRow.Cells["SoLuong"].Value.ToString();
                    if (selectedRow.Cells["NgayGieoTrong"].Value is DateTime ngayGieoTrong)
                    {
                        dtpNgayGieoTrong.Value = ngayGieoTrong;
                    }
                    else
                    {
                        dtpNgayGieoTrong.Value = DateTimePicker.MinimumDateTime;
                    }
                    if (selectedRow.Cells["NgayThuHoachDuKien"].Value is DateTime ngayThuHoachDuKien)
                    {
                        dtpNgayThuHoachDuKien.Value = ngayThuHoachDuKien;
                    }
                    else
                    {
                        dtpNgayThuHoachDuKien.Value = DateTimePicker.MinimumDateTime;
                    }
                    if (selectedRow.Cells["NgayThuHoachThucTe"].Value is DateTime ngayThuHoachThucTe)
                    {
                        dtpNgayThuHoachThucTe.Value = ngayThuHoachThucTe;
                    }
                    else
                    {
                        dtpNgayThuHoachThucTe.Value = DateTimePicker.MinimumDateTime;
                    }
                    cbbKhuVuc.Text = selectedRow.Cells["TenKhuVuc"].Value.ToString();
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
                string tenLoaiCayTrong = cbbLoaiCayTrong.SelectedItem.ToString();
                LoaiCayTrongBLL loaiCayTrongBLL = new LoaiCayTrongBLL();
                cayTrong.MaLoaiCayTrong = loaiCayTrongBLL.LayMaLoaiCayTrongTheoTen(tenLoaiCayTrong);
                cayTrong.Giong = txtGiongCay.Text;
                cayTrong.NguonGoc = txtNguonGoc.Text;
                int.TryParse(txtSoLuong.Text, out int soLuong);
                cayTrong.SoLuong = soLuong;
                cayTrong.NgayGieoTrong = dtpNgayGieoTrong.Value;
                cayTrong.NgayThuHoachDuKien = dtpNgayThuHoachDuKien.Value;
                cayTrong.NgayThuHoachThucTe = dtpNgayThuHoachThucTe.Value;

                string tenKhuVuc = cbbKhuVuc.SelectedItem.ToString();
                KhuVucBLL khuVucBLL = new KhuVucBLL();
                cayTrong.MaKhuVuc = khuVucBLL.LayMaKhuVucTheoTen(tenKhuVuc);
                cayTrong.TinhTrang = txtTinhTrang.Text;

                CayTrongBLL cayTrongBLL = new CayTrongBLL();
                if (cayTrongBLL.ThemCayTrong(cayTrong))
                {
                    txtTenCayTrong.Focus();
                    txtMaCayTrong.Text = "";
                    txtTenCayTrong.Text = "";
                    cbbLoaiCayTrong.SelectedIndex = -1;
                    txtGiongCay.Text = "";
                    txtNguonGoc.Text = "";
                    txtSoLuong.Text = "";
                    dtpNgayGieoTrong.Value = DateTime.Now;
                    dtpNgayGieoTrong.Value = DateTime.Now;
                    dtpNgayGieoTrong.Value = DateTime.Now;
                    cbbKhuVuc.SelectedIndex = -1;
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

        private void btnSuaCayTrong_Click(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(txtMaCayTrong.Text, out int maCayTrong);
                CayTrong cayTrong = new CayTrong();
                cayTrong.MaCayTrong = maCayTrong;
                cayTrong.TenCayTrong = txtTenCayTrong.Text;
                string tenLoaiCayTrong = cbbLoaiCayTrong.SelectedItem.ToString();
                LoaiCayTrongBLL loaiCayTrongBLL = new LoaiCayTrongBLL();
                cayTrong.MaLoaiCayTrong = loaiCayTrongBLL.LayMaLoaiCayTrongTheoTen(tenLoaiCayTrong);
                cayTrong.Giong = txtGiongCay.Text;
                cayTrong.NguonGoc = txtNguonGoc.Text;
                int.TryParse(txtSoLuong.Text, out int soLuong);
                cayTrong.SoLuong = soLuong;
                cayTrong.NgayGieoTrong = dtpNgayGieoTrong.Value;
                cayTrong.NgayThuHoachDuKien = dtpNgayThuHoachDuKien.Value;
                cayTrong.NgayThuHoachThucTe = dtpNgayThuHoachThucTe.Value;
                string tenKhuVuc = cbbKhuVuc.SelectedItem.ToString();
                KhuVucBLL khuVucBLL = new KhuVucBLL();
                cayTrong.MaKhuVuc = khuVucBLL.LayMaKhuVucTheoTen(tenKhuVuc);
                cayTrong.TinhTrang = txtTinhTrang.Text;

                CayTrongBLL cayTrongBLL = new CayTrongBLL();
                if (cayTrongBLL.CapNhatCayTrong(cayTrong))
                {
                    txtTenCayTrong.Focus();
                    txtMaCayTrong.Text = "";
                    txtTenCayTrong.Text = "";
                    cbbLoaiCayTrong.SelectedIndex = -1;
                    txtGiongCay.Text = "";
                    txtNguonGoc.Text = "";
                    txtSoLuong.Text = "";
                    dtpNgayGieoTrong.Value = DateTime.Now;
                    dtpNgayGieoTrong.Value = DateTime.Now;
                    dtpNgayGieoTrong.Value = DateTime.Now;
                    cbbKhuVuc.SelectedIndex = -1;
                    txtTinhTrang.Text = "";
                    HienThiDanhSachCayTrong();
                    MessageBox.Show("Chỉnh sửa cây trồng thành công!");
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa cây trồng thất bại. Vui lòng kiểm tra lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoaCayTrong_Click(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(txtMaCayTrong.Text, out int maCayTrong);

                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa cây trồng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    CayTrongBLL cayTrongBLL = new CayTrongBLL();
                    if (cayTrongBLL.XoaCayTrong(maCayTrong))
                    {
                        HienThiDanhSachCayTrong();

                        MessageBox.Show("Xóa cây trồng thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xóa cây trồng thất bại. Vui lòng kiểm tra lại.");
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
