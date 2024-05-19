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

namespace NongTraiVuiVe.GUI
{
    public partial class Frm_NhapLua : Form
    {
        public Frm_NhapLua()
        {
            InitializeComponent();
        }

        private NhapLuaBLL _nhapLuaBLL;
        private void Frm_NhapLua_Load(object sender, EventArgs e)
        {
            HienThiDanhSachNhapLua();
            LoaiCayTrongBLL loaiCayTrongBLL = new LoaiCayTrongBLL();
            List<string> danhSachTenLoaiCayTrong = loaiCayTrongBLL.LayDanhSachTenLoaiCayTrong();
            cbbLoaiCayTrong.DataSource = danhSachTenLoaiCayTrong;
            cbbLoaiCayTrong.SelectedIndex = -1;
            NhaCungCapBLL nhaCungCapBLL = new NhaCungCapBLL();
            List<string> danhSachTenNhaCungCap = nhaCungCapBLL.LayDanhSachTenNhaCungCap();
            cbbNhaCungCap.DataSource = danhSachTenNhaCungCap;
            cbbNhaCungCap.SelectedIndex = -1;
        }

        private void HienThiDanhSachNhapLua()
        {
            _nhapLuaBLL = new NhapLuaBLL();

            DataTable dtNhapLua = _nhapLuaBLL.LayDanhSachNhapLua();
            dgvDanhSachPhieuNhapLuaCayTrong.DataSource = dtNhapLua;
            dgvDanhSachPhieuNhapLuaCayTrong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvDanhSachPhieuNhapLuaCayTrong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSachPhieuNhapLuaCayTrong.Rows.Count)
                {
                    DataGridViewRow selectedRow = dgvDanhSachPhieuNhapLuaCayTrong.Rows[e.RowIndex];

                    txtMaNhapLuaCayTrong.Text = selectedRow.Cells["MaNhapLua"].Value.ToString();
                    txtTenCayTrong.Text = selectedRow.Cells["TenCayTrong"].Value.ToString();
                    cbbLoaiCayTrong.SelectedItem = selectedRow.Cells["TenLoaiCayTrong"].Value.ToString();
                    txtGiong.Text = selectedRow.Cells["Giong"].Value.ToString();
                    txtNguonGoc.Text = selectedRow.Cells["NguonGoc"].Value.ToString();
                    txtSoLuong.Text = selectedRow.Cells["SoLuong"].Value.ToString();
                    cbbNhaCungCap.SelectedItem = selectedRow.Cells["TenNhaCungCap"].Value.ToString();
                    if (selectedRow.Cells["Ngay"].Value is DateTime ngayNhap)
                    {
                        dtpNgayNhap.Value = ngayNhap;
                    }
                    else
                    {
                        dtpNgayNhap.Value = DateTimePicker.MinimumDateTime;
                    }
                    txtGiaNhap.Text = selectedRow.Cells["GiaNhap"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btnThemPhieuNhap_Click(object sender, EventArgs e)
        {
            try
            {
                NhapLua nhapLua = new NhapLua();
                nhapLua.TenCayTrong = txtTenCayTrong.Text;
                string tenLoaiCayTrong = cbbLoaiCayTrong.SelectedItem.ToString();
                LoaiCayTrongBLL loaiCayTrongBLL = new LoaiCayTrongBLL();
                nhapLua.MaLoaiCayTrong = loaiCayTrongBLL.LayMaLoaiCayTrongTheoTen(tenLoaiCayTrong);
                nhapLua.Giong = txtGiong.Text;
                nhapLua.NguonGoc = txtNguonGoc.Text;
                int.TryParse(txtSoLuong.Text, out int soLuong);
                nhapLua.SoLuong = soLuong;
                string tenNhaCungCap = cbbNhaCungCap.SelectedItem.ToString();
                NhaCungCapBLL nhaCungCapBLL = new NhaCungCapBLL();
                nhapLua.MaNhaCungCap = nhaCungCapBLL.LayMaNhaCungCapTheoTen(tenNhaCungCap);
                nhapLua.Ngay = dtpNgayNhap.Value;
                decimal.TryParse(txtGiaNhap.Text, out decimal giaNhap);
                nhapLua.GiaNhap = giaNhap;

                NhapLuaBLL nhapLuaBLL = new NhapLuaBLL();
                if (nhapLuaBLL.ThemPhieuNhap(nhapLua))
                {
                    txtTenCayTrong.Focus();
                    txtMaNhapLuaCayTrong.Text = "";
                    txtTenCayTrong.Text = "";
                    cbbLoaiCayTrong.SelectedIndex = -1;
                    txtGiong.Text = "";
                    txtNguonGoc.Text = "";
                    txtSoLuong.Text = "";
                    cbbNhaCungCap.SelectedIndex = -1;
                    dtpNgayNhap.Value = DateTime.Now;
                    txtGiaNhap.Text = "";
                    HienThiDanhSachNhapLua();
                    MessageBox.Show("Thêm phiếu nhập lứa cây trồng thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm phiếu nhập lứa cây trồng thất bại. Vui lòng kiểm tra lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSuaPhieuNhap_Click(object sender, EventArgs e)
        {
            try
            {
                NhapLua nhapLua = new NhapLua();
                int.TryParse(txtMaNhapLuaCayTrong.Text, out int maNhap);
                nhapLua.MaNhapLua = maNhap;
                nhapLua.TenCayTrong = txtTenCayTrong.Text;
                string tenLoaiCayTrong = cbbLoaiCayTrong.SelectedItem.ToString();
                LoaiCayTrongBLL loaiCayTrongBLL = new LoaiCayTrongBLL();
                nhapLua.MaLoaiCayTrong = loaiCayTrongBLL.LayMaLoaiCayTrongTheoTen(tenLoaiCayTrong);
                nhapLua.Giong = txtGiong.Text;
                nhapLua.NguonGoc = txtNguonGoc.Text;
                int.TryParse(txtSoLuong.Text, out int soLuong);
                nhapLua.SoLuong = soLuong;
                string tenNhaCungCap = cbbNhaCungCap.SelectedItem.ToString();
                NhaCungCapBLL nhaCungCapBLL = new NhaCungCapBLL();
                nhapLua.MaNhaCungCap = nhaCungCapBLL.LayMaNhaCungCapTheoTen(tenNhaCungCap);
                nhapLua.Ngay = dtpNgayNhap.Value;
                decimal.TryParse(txtGiaNhap.Text, out decimal giaNhap);
                nhapLua.GiaNhap = giaNhap;

                NhapLuaBLL nhapLuaBLL = new NhapLuaBLL();
                if (nhapLuaBLL.ThemPhieuNhap(nhapLua))
                {
                    txtTenCayTrong.Focus();
                    txtMaNhapLuaCayTrong.Text = "";
                    txtTenCayTrong.Text = "";
                    cbbLoaiCayTrong.SelectedIndex = -1;
                    txtGiong.Text = "";
                    txtNguonGoc.Text = "";
                    txtSoLuong.Text = "";
                    cbbNhaCungCap.SelectedIndex = -1;
                    dtpNgayNhap.Value = DateTime.Now;
                    txtGiaNhap.Text = "";
                    HienThiDanhSachNhapLua();
                    MessageBox.Show("Sửa phiếu nhập lứa cây trồng thành công!");
                }
                else
                {
                    MessageBox.Show("Sửa phiếu nhập lứa cây trồng thất bại. Vui lòng kiểm tra lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoaPhieuNhap_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachPhieuNhapLuaCayTrong.SelectedRows.Count > 0)
            {
                int maPhieuNhap = (int)dgvDanhSachPhieuNhapLuaCayTrong.SelectedRows[0].Cells["MaNhapLua"].Value;

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu nhập này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (_nhapLuaBLL.XoaPhieuNhap(maPhieuNhap))
                    {
                        MessageBox.Show("Xóa phiếu nhập thành công!");
                        HienThiDanhSachNhapLua();
                    }
                    else
                    {
                        MessageBox.Show("Xóa phiếu nhập thất bại!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phiếu nhập để xóa.");
            }
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
    }
}
