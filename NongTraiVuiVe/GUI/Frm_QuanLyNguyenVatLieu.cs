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
    public partial class Frm_QuanLyNguyenVatLieu : Form
    {
        public Frm_QuanLyNguyenVatLieu()
        {
            InitializeComponent();
            this.Resize += new EventHandler(Frm_QuanLyNguyenVatLieu_Resize);
        }
        private void Frm_QuanLyNguyenVatLieu_Resize(object sender, EventArgs e)
        {
            // Đảm bảo DataGridView thay đổi kích thước theo kích thước của Form
            dgvDanhSachNguyenVatLieu.Width = this.ClientSize.Width;
            dgvDanhSachNguyenVatLieu.Height = this.ClientSize.Height - dgvDanhSachNguyenVatLieu.Location.Y; // trừ đi vị trí Y của DataGridView
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
            KhoHangBLL khoHangBLL = new KhoHangBLL();
            List<string> danhSachTenKhoHang = khoHangBLL.LayDanhSachTenKhoHang();
            cbbKhoChua.DataSource = danhSachTenKhoHang;
            cbbKhoChua.SelectedIndex = -1;
            LoaiNguyenVatLieuBLL loaiNguyenVatLieuBLL = new LoaiNguyenVatLieuBLL();
            List<string> danhSachTenLoaiNguyenVatLieu = loaiNguyenVatLieuBLL.LayDanhSachTenLoaiNguyenVatLieu();
            cbbLoaiNguyenVatLieu.DataSource = danhSachTenLoaiNguyenVatLieu;
            cbbLoaiNguyenVatLieu.SelectedIndex = -1;
            dgvDanhSachNguyenVatLieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void HienThiDanhSachNguyenVatLieu()
        {
            nguyenVatLieuBLL = new NguyenVatLieuBLL();

            DataTable dtNguyenVatLieu = nguyenVatLieuBLL.LayDuLieuNguyenVatLieu();
            dgvDanhSachNguyenVatLieu.DataSource = dtNguyenVatLieu;
            dgvDanhSachNguyenVatLieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvDanhSachNguyenVatLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSachNguyenVatLieu.Rows.Count)
                {
                    DataGridViewRow selectedRow = dgvDanhSachNguyenVatLieu.Rows[e.RowIndex];

                    txtMaNguyenVatLieu.Text = selectedRow.Cells["MaNguyenVatLieu"].Value.ToString();
                    txtTenNguyenVatLieu.Text = selectedRow.Cells["TenNguyenVatLieu"].Value.ToString();
                    cbbLoaiNguyenVatLieu.Text = selectedRow.Cells["TenLoaiNguyenVatLieu"].Value.ToString();
                    txtSoLuong.Text = selectedRow.Cells["SoLuong"].Value.ToString();
                    cbbKhoChua.Text = selectedRow.Cells["TenKhoHang"].Value.ToString();
                    txtHanSuDung.Text = selectedRow.Cells["HanSuDung"].Value.ToString();
                    cbbTinhTrang.Text = selectedRow.Cells["TinhTrang"].Value.ToString();
                    txtSoLuongHong.Text = selectedRow.Cells["SoLuongHuHong"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btnThemNguyenVatLieu_Click(object sender, EventArgs e)
        {
            try
            {
                NguyenVatLieu nguyenVatLieu = new NguyenVatLieu();
                nguyenVatLieu.TenNguyenVatLieu = txtTenNguyenVatLieu.Text;
                string tenLoaiNguyenVatLieu = cbbLoaiNguyenVatLieu.SelectedItem.ToString();
                LoaiNguyenVatLieuBLL loaiNguyenVatLieuBLL = new LoaiNguyenVatLieuBLL();
                nguyenVatLieu.MaLoaiNguyenVatLieu = loaiNguyenVatLieuBLL.LayMaLoaiNguyenVatLieuTheoTen(tenLoaiNguyenVatLieu);
                int.TryParse(txtSoLuong.Text, out int soLuong);
                nguyenVatLieu.SoLuong = soLuong;

                KhoHangBLL khoHangBLL = new KhoHangBLL();
                string tenKhoHang = cbbKhoChua.SelectedItem.ToString();
                nguyenVatLieu.MaKhoHang = khoHangBLL.LayMaKhoHangTheoTen(tenKhoHang);

                if (DateTime.TryParse(txtHanSuDung.Text, out DateTime hanSuDung))
                {
                    nguyenVatLieu.HanSuDung = hanSuDung;
                }
                else
                {
                    nguyenVatLieu.HanSuDung = null;
                }
                nguyenVatLieu.TinhTrang = cbbTinhTrang.SelectedItem.ToString();
                int.TryParse(txtSoLuongHong.Text, out int soLuongHong);
                nguyenVatLieu.SoLuongHuHong = soLuongHong;

                NguyenVatLieuBLL nguyenVatLieuBLL = new NguyenVatLieuBLL();
                if (nguyenVatLieuBLL.ThemNguyenVatLieu(nguyenVatLieu))
                {
                    txtTenNguyenVatLieu.Focus();
                    txtMaNguyenVatLieu.Text = "";
                    txtTenNguyenVatLieu.Text = "";
                    cbbLoaiNguyenVatLieu.SelectedIndex = -1;
                    txtSoLuong.Text = "";
                    cbbKhoChua.SelectedIndex = -1;
                    txtHanSuDung.Text = "";
                    cbbTinhTrang.SelectedIndex = -1;
                    txtSoLuongHong.Text = "";
                    HienThiDanhSachNguyenVatLieu();
                    MessageBox.Show("Thêm nguyên vật liêu thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm nguyên vật liêu thất bại. Vui lòng kiểm tra lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSuaNguyenVatLieu_Click(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(txtMaNguyenVatLieu.Text, out int maNguyenVatLieu);
                NguyenVatLieu nguyenVatLieu = new NguyenVatLieu();
                nguyenVatLieu.MaNguyenVatLieu = maNguyenVatLieu;
                nguyenVatLieu.TenNguyenVatLieu = txtTenNguyenVatLieu.Text;
                string tenLoaiNguyenVatLieu = cbbLoaiNguyenVatLieu.SelectedItem.ToString();
                LoaiNguyenVatLieuBLL loaiNguyenVatLieuBLL = new LoaiNguyenVatLieuBLL();
                nguyenVatLieu.MaLoaiNguyenVatLieu = loaiNguyenVatLieuBLL.LayMaLoaiNguyenVatLieuTheoTen(tenLoaiNguyenVatLieu);
                int.TryParse(txtSoLuong.Text, out int soLuong);
                nguyenVatLieu.SoLuong = soLuong;

                KhoHangBLL khoHangBLL = new KhoHangBLL();
                string tenKhoHang = cbbKhoChua.SelectedItem.ToString();
                nguyenVatLieu.MaKhoHang = khoHangBLL.LayMaKhoHangTheoTen(tenKhoHang);

                if (DateTime.TryParse(txtHanSuDung.Text, out DateTime hanSuDung))
                {
                    nguyenVatLieu.HanSuDung = hanSuDung;
                }
                else
                {
                    nguyenVatLieu.HanSuDung = null;
                }
                nguyenVatLieu.TinhTrang = cbbTinhTrang.SelectedItem.ToString();
                int.TryParse(txtSoLuongHong.Text, out int soLuongHong);
                nguyenVatLieu.SoLuongHuHong = soLuongHong;

                NguyenVatLieuBLL nguyenVatLieuBLL = new NguyenVatLieuBLL();
                if (nguyenVatLieuBLL.CapNhatNguyenVatLieu(nguyenVatLieu))
                {
                    txtTenNguyenVatLieu.Focus();
                    txtMaNguyenVatLieu.Text = "";
                    txtTenNguyenVatLieu.Text = "";
                    cbbLoaiNguyenVatLieu.SelectedIndex = -1;
                    txtSoLuong.Text = "";
                    cbbKhoChua.SelectedIndex = -1;
                    txtHanSuDung.Text = "";
                    cbbTinhTrang.SelectedIndex = -1;
                    txtSoLuongHong.Text = "";
                    HienThiDanhSachNguyenVatLieu();
                    MessageBox.Show("Cập nhật nguyên vật liệu thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật nguyên vật liệu thất bại. Vui lòng kiểm tra lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoaNguyenVatLieu_Click(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(txtMaNguyenVatLieu.Text, out int maNguyenVatLieu);

                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa nguyên vật liệu này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    NguyenVatLieuBLL nguyenVatLieuBLL = new NguyenVatLieuBLL();
                    if (nguyenVatLieuBLL.XoaNguyenVatLieu(maNguyenVatLieu))
                    {
                        HienThiDanhSachNguyenVatLieu();

                        MessageBox.Show("Xóa nguyên vật liệu thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xóa nguyên vật liệu thất bại. Vui lòng kiểm tra lại.");
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
