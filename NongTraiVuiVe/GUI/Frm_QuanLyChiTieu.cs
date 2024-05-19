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
    public partial class Frm_QuanLyChiTieu : Form
    {
        public Frm_QuanLyChiTieu()
        {
            InitializeComponent();
        }

        private void btnThoatLnvl_Click(object sender, EventArgs e)
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
        private ChiTieuBLL _chiTieuBLL;
        private NguoiDungBLL _nguoiDungBLL;
        private void Frm_QuanLyChiTieu_Load(object sender, EventArgs e)
        {
            HienThiDanhSachChiTieu();
            dgvDanhSachChiTieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _nguoiDungBLL = new NguoiDungBLL();
            DataTable dtNguoiDung = _nguoiDungBLL.LayThongTinCobanNguoiDung();

            // Tạo một cột mới để hiển thị thông tin kết hợp
            dtNguoiDung.Columns.Add("ThongTinHienThi", typeof(string), "HoTen + ' - ' + TenDangNhap");

            cbbNguoiThucHien.DataSource = dtNguoiDung;
            cbbNguoiThucHien.DisplayMember = "ThongTinHienThi"; // Hiển thị thông tin kết hợp
            cbbNguoiThucHien.ValueMember = "MaNguoiDung"; // Giá trị là mã người dùng
        }

        private void HienThiDanhSachChiTieu()
        {
            _chiTieuBLL = new ChiTieuBLL();

            DataTable dtChiTieu = _chiTieuBLL.LayDuLieuChiTieu();
            dgvDanhSachChiTieu.DataSource = dtChiTieu;
            dgvDanhSachChiTieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void dgvDanhSachChiTieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSachChiTieu.Rows.Count)
                {
                    DataGridViewRow selectedRow = dgvDanhSachChiTieu.Rows[e.RowIndex];

                    txtMaChiTieu.Text = selectedRow.Cells["MaChiTieu"].Value.ToString();
                    cbbLoaiChiTieu.SelectedItem = selectedRow.Cells["LoaiChiTieu"].Value.ToString();
                    txtChiPhi.Text = selectedRow.Cells["ChiPhi"].Value.ToString();
                    if (selectedRow.Cells["NgayChiTieu"].Value is DateTime ngayChiTieu)
                    {
                        dtpNgayChiTieu.Value = ngayChiTieu;
                    }
                    else
                    {
                        dtpNgayChiTieu.Value = DateTimePicker.MinimumDateTime;
                    }
                    cbbNguoiThucHien.SelectedValue = selectedRow.Cells["MaNguoiThucHien"].Value;
                    txtMaNguoiThucHien.Text = selectedRow.Cells["MaNguoiThucHien"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btnThemChiTieu_Click(object sender, EventArgs e)
        {
            try
            {
                ChiTieu chiTieu = new ChiTieu();
                if (cbbLoaiChiTieu.SelectedIndex != -1)
                {
                    chiTieu.LoaiChiTieu = cbbLoaiChiTieu.SelectedItem.ToString();
                }
                else
                {
                    chiTieu.LoaiChiTieu = null;
                }
                decimal.TryParse(txtChiPhi.Text, out decimal chiPhi);
                chiTieu.ChiPhi = chiPhi;
                chiTieu.NgayChiTieu = dtpNgayChiTieu.Value;
                int.TryParse(txtMaNguoiThucHien.Text, out int maNguoiThucHien);
                chiTieu.MaNguoiThucHien = maNguoiThucHien;

                ChiTieuBLL chiTieuBLL = new ChiTieuBLL();
                if (chiTieuBLL.ThemChiTieu(chiTieu))
                {
                    txtMaChiTieu.Text = "";
                    cbbLoaiChiTieu.Focus();
                    cbbLoaiChiTieu.SelectedIndex = -1;
                    dtpNgayChiTieu.Value = DateTime.Now;
                    txtChiPhi.Text = "";
                    cbbNguoiThucHien.SelectedIndex = -1;
                    txtMaNguoiThucHien.Text = "";
                    HienThiDanhSachChiTieu();
                    MessageBox.Show("Thêm chi tiêu thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm chi tiêu thất bại. Vui lòng kiểm tra lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSuaChiTieu_Click(object sender, EventArgs e)
        {
            try
            {
                ChiTieu chiTieu = new ChiTieu();
                int.TryParse(txtMaChiTieu.Text, out int maChiTieu);
                chiTieu.MaChiTieu = maChiTieu;
                if (cbbLoaiChiTieu.SelectedIndex != -1)
                {
                    chiTieu.LoaiChiTieu = cbbLoaiChiTieu.SelectedItem.ToString();
                }
                else
                {
                    chiTieu.LoaiChiTieu = null;
                }
                decimal.TryParse(txtChiPhi.Text, out decimal chiPhi);
                chiTieu.ChiPhi = chiPhi;
                chiTieu.NgayChiTieu = dtpNgayChiTieu.Value;
                int.TryParse(txtMaNguoiThucHien.Text, out int maNguoiThucHien);
                chiTieu.MaNguoiThucHien = maNguoiThucHien;

                ChiTieuBLL chiTieuBLL = new ChiTieuBLL();
                if (chiTieuBLL.ThemChiTieu(chiTieu))
                {
                    cbbLoaiChiTieu.Focus();
                    txtMaChiTieu.Text = "";
                    cbbLoaiChiTieu.SelectedIndex = -1;
                    dtpNgayChiTieu.Value = DateTime.Now;
                    cbbNguoiThucHien.SelectedIndex = -1;
                    txtChiPhi.Text = "";
                    txtMaNguoiThucHien.Text = "";
                    HienThiDanhSachChiTieu();
                    MessageBox.Show("Cập nhật chi tiêu thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật chi tiêu thất bại. Vui lòng kiểm tra lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoaChiTieu_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachChiTieu.SelectedRows.Count > 0)
            {
                int maChiTieu = (int)dgvDanhSachChiTieu.SelectedRows[0].Cells["MaChiTieu"].Value;

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa chi tiêu này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (_chiTieuBLL.XoaChiTieu(maChiTieu))
                    {
                        MessageBox.Show("Xóa chi tiêu thành công!");
                        HienThiDanhSachChiTieu(); 
                    }
                    else
                    {
                        MessageBox.Show("Xóa chi tiêu thất bại!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một chi tiêu để xóa.");
            }
        }

        private void cbbNguoiThucHien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbNguoiThucHien.SelectedItem != null) 
            {
                DataRowView selectedRow = cbbNguoiThucHien.SelectedItem as DataRowView;
                if (selectedRow != null)
                {
                    int maNguoiDung = Convert.ToInt32(selectedRow["MaNguoiDung"]); 
                    txtMaNguoiThucHien.Text = maNguoiDung.ToString();
                }
            }
        }
    }
}
