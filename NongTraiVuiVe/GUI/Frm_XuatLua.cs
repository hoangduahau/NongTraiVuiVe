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

namespace NongTraiVuiVe.GUI
{
    public partial class Frm_XuatLua : Form
    {
        public Frm_XuatLua()
        {
            InitializeComponent();
        }

        private void btnThoatXuatLua_Click(object sender, EventArgs e)
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

        private XuatLuaBLL _xuatLuaBLL;

        private void Frm_XuatLua_Load(object sender, EventArgs e)
        {
            HienThiDanhSachXuatLua();
            CayTrongBLL cayTrongBLL = new CayTrongBLL();
            List<string> danhSachTenCayTrong = cayTrongBLL.LayDanhSachTenCayTrong();
            cbbTenCayTrong.DataSource = danhSachTenCayTrong;
            cbbTenCayTrong.SelectedIndex = -1;
            KhachHangBLL khachHangBLL = new KhachHangBLL();
            List<string> danhSachTenKhachHang = khachHangBLL.LayDanhSachTenKhachHang();
            cbbKhachHang.DataSource = danhSachTenKhachHang;
            cbbKhachHang.SelectedIndex = -1;
        }

        private void HienThiDanhSachXuatLua()
        {
            _xuatLuaBLL = new XuatLuaBLL();

            DataTable dtXuatLua = _xuatLuaBLL.LayDanhSachXuatLua();
            dgvDanhSachXuatLua.DataSource = dtXuatLua;
            dgvDanhSachXuatLua.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void dgvDanhSachXuatLua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSachXuatLua.Rows.Count)
                {
                    DataGridViewRow selectedRow = dgvDanhSachXuatLua.Rows[e.RowIndex];

                    txtMaXuatLua.Text = selectedRow.Cells["MaXuatLua"].Value.ToString();
                    txtMaCayTrong.Text = selectedRow.Cells["MaCayTrong"].Value.ToString();
                    cbbTenCayTrong.SelectedItem = selectedRow.Cells["TenCayTrong"].Value.ToString();
                    txtSoLuong.Text = selectedRow.Cells["SoLuong"].Value.ToString();
                    if (selectedRow.Cells["Ngay"].Value is DateTime ngayXuat)
                    {
                        dtpNgayXuat.Value = ngayXuat;
                    }
                    else
                    {
                        dtpNgayXuat.Value = DateTimePicker.MinimumDateTime;
                    }
                    txtGiaXuat.Text = selectedRow.Cells["GiaXuat"].Value.ToString();
                    cbbKhachHang.SelectedItem = selectedRow.Cells["TenKhachHang"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btnThemPhieuXuat_Click(object sender, EventArgs e)
        {
            try
            {
                XuatLua xuatLua = new XuatLua();
                int.TryParse(txtMaCayTrong.Text, out int maCayTrong);
                xuatLua.MaCayTrong = maCayTrong;
                if (cbbTenCayTrong.SelectedIndex != -1)
                {
                    xuatLua.TenCayTrong = cbbTenCayTrong.SelectedItem.ToString();
                }
                else
                {
                    xuatLua.TenCayTrong = null;
                }
                int.TryParse(txtSoLuong.Text, out int soLuong);
                xuatLua.SoLuong = soLuong;
                xuatLua.Ngay = dtpNgayXuat.Value;
                decimal.TryParse(txtGiaXuat.Text, out decimal giaXuat);
                xuatLua.GiaXuat = giaXuat;                
                string tenKhachHang = cbbKhachHang.SelectedItem.ToString();
                KhachHangBLL khachHangBLL = new KhachHangBLL();
                xuatLua.MaKhachHang = khachHangBLL.LayMaKhachHangTheoTen(tenKhachHang);

                XuatLuaBLL xuatLuaBLL = new XuatLuaBLL();
                if (xuatLuaBLL.ThemPhieuXuat(xuatLua))
                {
                    cbbTenCayTrong.Focus();
                    txtMaXuatLua.Text = "";
                    txtMaCayTrong.Text = "";
                    cbbTenCayTrong.SelectedIndex = -1;
                    txtSoLuong.Text = "";
                    dtpNgayXuat.Value = DateTime.Now;
                    txtGiaXuat.Text = "";
                    cbbKhachHang.SelectedIndex = -1;
                    
                    HienThiDanhSachXuatLua();
                    MessageBox.Show("Thêm phiếu xuất lứa cây trồng thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm phiếu xuất lứa cây trồng thất bại. Vui lòng kiểm tra lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSuaPhieuXuat_Click(object sender, EventArgs e)
        {
            try
            {
                XuatLua xuatLua = new XuatLua();
                int.TryParse(txtMaXuatLua.Text, out int maXuatLua);
                xuatLua.MaXuatLua = maXuatLua;
                int.TryParse(txtMaCayTrong.Text, out int maCayTrong);
                xuatLua.MaCayTrong = maCayTrong;
                xuatLua.TenCayTrong = cbbTenCayTrong.SelectedItem.ToString();
                int.TryParse(txtSoLuong.Text, out int soLuong);
                xuatLua.SoLuong = soLuong;
                xuatLua.Ngay = dtpNgayXuat.Value;
                decimal.TryParse(txtGiaXuat.Text, out decimal giaXuat);
                xuatLua.GiaXuat = giaXuat;
                string tenKhachHang = cbbKhachHang.SelectedItem.ToString();
                KhachHangBLL khachHangBLL = new KhachHangBLL();
                xuatLua.MaKhachHang = khachHangBLL.LayMaKhachHangTheoTen(tenKhachHang);

                XuatLuaBLL xuatLuaBLL = new XuatLuaBLL();
                if (xuatLuaBLL.CapNhatXuatLua(xuatLua))
                {
                    cbbTenCayTrong.Focus();
                    txtMaXuatLua.Text = "";
                    txtMaCayTrong.Text = "";
                    cbbTenCayTrong.SelectedIndex = -1;
                    txtSoLuong.Text = "";
                    dtpNgayXuat.Value = DateTime.Now;
                    txtGiaXuat.Text = "";
                    cbbKhachHang.SelectedIndex = -1;

                    HienThiDanhSachXuatLua();
                    MessageBox.Show("Cập nhật phiếu xuất lứa cây trồng thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật phiếu xuất lứa cây trồng thất bại. Vui lòng kiểm tra lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoaPhieuXuat_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachXuatLua.SelectedRows.Count > 0)
            {
                int maPhieuXuat = (int)dgvDanhSachXuatLua.SelectedRows[0].Cells["MaXuatLua"].Value;

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu xuất này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (_xuatLuaBLL.XoaPhieuXuat(maPhieuXuat))
                    {
                        MessageBox.Show("Xóa phiếu xuất thành công!");
                        HienThiDanhSachXuatLua();
                    }
                    else
                    {
                        MessageBox.Show("Xóa phiếu xuất thất bại!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phiếu xuất để xóa.");
            }
        }

        private void cbbTenCayTrong_SelectedIndexChanged(object sender, EventArgs e)
        {
            CayTrongBLL _cayTrongBLL = new CayTrongBLL();
            if (cbbTenCayTrong.SelectedIndex != -1) 
            {
                txtMaCayTrong.Text = _cayTrongBLL.LayMaCayTrongTheoTen(cbbTenCayTrong.SelectedItem.ToString()).ToString();
            }
            else
            {
                txtMaCayTrong.Text = "";
            }
            
        }
    }
}
