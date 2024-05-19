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

namespace NongTraiVuiVe.Quản_Lý
{
    public partial class Frm_QuanLyKhachHang : Form
    {
        public Frm_QuanLyKhachHang()
        {
            InitializeComponent();
            this.Resize += new EventHandler(Frm_QuanLyKhachHang_Resize);
        }

        private void Frm_QuanLyKhachHang_Resize(object sender, EventArgs e)
        {
            // Đảm bảo DataGridView thay đổi kích thước theo kích thước của Form
            dgvDanhSachKhachHang.Width = this.ClientSize.Width;
            dgvDanhSachKhachHang.Height = this.ClientSize.Height - dgvDanhSachKhachHang.Location.Y; // trừ đi vị trí Y của DataGridView
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
            dgvDanhSachKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void HienThiDanhSachKhachHang()
        {
            khachHangBLL = new KhachHangBLL();

            DataTable dtKhachHang = khachHangBLL.LayDuLieuKhachHang();
            dgvDanhSachKhachHang.DataSource = dtKhachHang;
            dgvDanhSachKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                    if (selectedRow.Cells["NgaySinh"].Value is DateTime ngaySinh)
                    {
                        dtpNgaySinh.Value = ngaySinh;
                    }
                    else
                    {
                        dtpNgaySinh.Value = DateTimePicker.MinimumDateTime;
                    }
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
                khachHang.NgaySinh = dtpNgaySinh.Value;

                KhachHangBLL khachHangBLL = new KhachHangBLL();
                if (khachHangBLL.ThemKhachHang(khachHang))
                {
                    txtTenKhachHang.Focus();
                    txtMaKhachHang.Text = "";
                    txtTenKhachHang.Text = "";
                    txtDiaChiKhachHang.Text = "";
                    txtSoDienThoaiKhachHang.Text = "";
                    txtEmailKhachHang.Text = "";
                    dtpNgaySinh.Value = DateTime.Now;
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
                khachHang.NgaySinh = dtpNgaySinh.Value;

                KhachHangBLL khachHangBLL = new KhachHangBLL();
                if (khachHangBLL.CapNhatKhachHang(khachHang))
                {
                    txtTenKhachHang.Focus();
                    txtMaKhachHang.Text = "";
                    txtTenKhachHang.Text = "";
                    txtDiaChiKhachHang.Text = "";
                    txtSoDienThoaiKhachHang.Text = "";
                    txtEmailKhachHang.Text = "";
                    dtpNgaySinh.Value = DateTime.Now;
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
