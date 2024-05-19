using NongTraiVuiVe.BLL;
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

namespace NongTraiVuiVe
{
    public partial class Frm_QuanLyNguoiDung : Form
    {
        public Frm_QuanLyNguoiDung()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnThoatNguoiDung_Click(object sender, EventArgs e)
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

        private NguoiDungBLL _nguoiDungBLL;
        private void Frm_QuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            HienThiDanhSachNguoiDung();
            dgvDanhSachNguoiDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void HienThiDanhSachNguoiDung()
        {
            _nguoiDungBLL = new NguoiDungBLL();

            DataTable dtNguoiDung = _nguoiDungBLL.LayDuLieuNguoiDung();
            dgvDanhSachNguoiDung.DataSource = dtNguoiDung;
            dgvDanhSachNguoiDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void dgvDanhSachNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSachNguoiDung.Rows.Count)
                {
                    DataGridViewRow selectedRow = dgvDanhSachNguoiDung.Rows[e.RowIndex];

                    txtMaNguoiDung.Text = selectedRow.Cells["MaNguoiDung"].Value.ToString();
                    txtTenDangNhap.Text = selectedRow.Cells["TenDangNhap"].Value.ToString();
                    txtMatKhau.Text = selectedRow.Cells["Password"].Value.ToString();
                    if (selectedRow.Cells["NgayTao"].Value is DateTime ngayTao)
                    {
                        dtpNgayTao.Value = ngayTao;
                    }
                    else
                    {
                        MessageBox.Show("Ngày tạo không hợp lệ.");
                    }
                    txtHoTen.Text = selectedRow.Cells["HoTen"].Value.ToString();
                    txtDiaChi.Text = selectedRow.Cells["DiaChi"].Value.ToString();
                    txtDienThoai.Text = selectedRow.Cells["DienThoai"].Value.ToString();
                    cbbGioiTinh.SelectedItem = selectedRow.Cells["GioiTinh"].Value.ToString();
                    if (selectedRow.Cells["NgaySinh"].Value is DateTime ngaySinh)
                    {
                        dtpNgaySinh.Value = ngaySinh;
                    }
                    else
                    {
                        MessageBox.Show("Ngày sinh không hợp lệ.");
                    }
                    if (selectedRow.Cells["NgayBatDauLamViec"].Value is DateTime ngayLamViec)
                    {
                        dtpNgayLamViec.Value = ngayLamViec;
                    }
                    else
                    {
                        MessageBox.Show("Ngày làm việc không hợp lệ.");
                    }
                    txtMaNhomNguoiDung.Text = selectedRow.Cells["MaNhomNguoiDung"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btnThemNguoiDung_Click(object sender, EventArgs e)
        {
            try
            {
                NguoiDung nguoiDung = new NguoiDung
                {
                    TenDangNhap = txtTenDangNhap.Text,
                    MatKhau = Encoding.UTF8.GetBytes(txtMatKhau.Text),
                    NgayTao = DateTime.Now,
                    HoTen = txtHoTen.Text,
                    DiaChi = txtDiaChi.Text,
                    DienThoai = txtDienThoai.Text,
                    GioiTinh = cbbGioiTinh.SelectedItem.ToString(),
                    NgaySinh = dtpNgaySinh.Value,
                    NgayBatDauLamViec = dtpNgayLamViec.Value,
                    MaNhomNguoiDung = int.Parse(txtMaNhomNguoiDung.Text)
                };

                if (_nguoiDungBLL.ThemNguoiDung(nguoiDung))
                {
                    txtTenDangNhap.Focus();
                    txtMaNguoiDung.Text = "";
                    txtTenDangNhap.Text = "";
                    txtMatKhau.Text = "";
                    txtHoTen.Text = "";
                    txtDiaChi.Text = "";
                    txtDienThoai.Text = "";
                    cbbGioiTinh.SelectedIndex = -1;
                    dtpNgaySinh.Value = DateTime.Now;
                    dtpNgayLamViec.Value = DateTime.Now;
                    txtMaNhomNguoiDung.Text = "";
                    HienThiDanhSachNguoiDung();
                    MessageBox.Show("Thêm người dùng thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm người dùng thất bại. Vui lòng kiểm tra lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSuaNguoiDung_Click(object sender, EventArgs e)
        {
            try
            {
                NguoiDung nguoiDung = new NguoiDung
                {
                    MaNguoiDung = int.Parse(txtMaNguoiDung.Text),
                    TenDangNhap = txtTenDangNhap.Text,
                    MatKhau = Encoding.UTF8.GetBytes(txtMatKhau.Text),
                    NgayTao = DateTime.Now,
                    HoTen = txtHoTen.Text,
                    DiaChi = txtDiaChi.Text,
                    DienThoai = txtDienThoai.Text,
                    GioiTinh = cbbGioiTinh.SelectedItem.ToString(),
                    NgaySinh = dtpNgaySinh.Value,
                    NgayBatDauLamViec = dtpNgayLamViec.Value,
                    MaNhomNguoiDung = int.Parse(txtMaNhomNguoiDung.Text)

                };

                if (_nguoiDungBLL.CapNhatNguoiDung(nguoiDung))
                {
                    txtTenDangNhap.Focus();
                    txtMaNguoiDung.Text = "";
                    txtTenDangNhap.Text = "";
                    txtMatKhau.Text = "";
                    txtHoTen.Text = "";
                    txtDiaChi.Text = "";
                    txtDienThoai.Text = "";
                    cbbGioiTinh.SelectedIndex = -1;
                    dtpNgaySinh.Value = DateTime.Now;
                    dtpNgayLamViec.Value = DateTime.Now;
                    txtMaNhomNguoiDung.Text = "";
                    HienThiDanhSachNguoiDung();
                    MessageBox.Show("Chỉnh sửa người dùng thành công!");
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa người dùng thất bại. Vui lòng kiểm tra lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoaNguoiDung_Click(object sender, EventArgs e)
        {
            try
            {
                int maNguoiDung = int.Parse(txtMaNguoiDung.Text);

                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa người dùng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    if (_nguoiDungBLL.XoaNguoiDung(maNguoiDung))
                    {
                        HienThiDanhSachNguoiDung();
                        MessageBox.Show("Xóa người dùng thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xóa người dùng thất bại. Vui lòng kiểm tra lại.");
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
