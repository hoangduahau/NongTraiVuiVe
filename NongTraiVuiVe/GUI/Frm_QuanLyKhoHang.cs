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
    public partial class Frm_QuanLyKhoHang : Form
    {
        public Frm_QuanLyKhoHang()
        {
            InitializeComponent();
        }

        private void btnThoatKH_Click(object sender, EventArgs e)
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

        private void Frm_QuanLyKhoHang_Load(object sender, EventArgs e)
        {
            HienThiDanhSachKhoHang();
        }

        private KhoHangBLL khoHangBLL;
        private void HienThiDanhSachKhoHang()
        {
            khoHangBLL = new KhoHangBLL();

            // Gọi phương thức từ BLL để lấy dữ liệu và hiển thị
            DataTable dtKhoHang = khoHangBLL.LayDuLieuKhoHang();
            dgvDanhSachKhoHang.DataSource = dtKhoHang;
        }

        private void btnThemKhoHang_Click(object sender, EventArgs e)
        {
            try
            {
                KhoHang khoHang = new KhoHang();
                khoHang.TenKhoHang = txtTenKhoHang.Text;
                khoHang.ViTri = txtViTri.Text;
                if (cbbKhaDungKhoHang.SelectedItem != null)
                {
                    if (cbbKhaDungKhoHang.SelectedItem.ToString() == "Có")
                    {
                        khoHang.KhaDung = true;
                    }
                    else
                    {
                        khoHang.KhaDung = false;
                    }
                }
                else
                {
                    khoHang.KhaDung = null;
                }

                KhoHangBLL khoHangBLL = new KhoHangBLL();
                if (khoHangBLL.ThemKhoHang(khoHang))
                {
                    txtTenKhoHang.Focus();
                    txtMaKhoHang.Text = "";
                    txtTenKhoHang.Text = "";
                    txtViTri.Text = "";
                    cbbKhaDungKhoHang.SelectedIndex = -1;
                    HienThiDanhSachKhoHang();
                    MessageBox.Show("Thêm kho hàng thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm kho hàng thất bại. Vui lòng kiểm tra lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dgvDanhSachKhoHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSachKhoHang.Rows.Count)
                {
                    DataGridViewRow selectedRow = dgvDanhSachKhoHang.Rows[e.RowIndex];

                    txtMaKhoHang.Text = selectedRow.Cells["MaKhoHang"].Value.ToString();
                    txtTenKhoHang.Text = selectedRow.Cells["TenKhoHang"].Value.ToString();
                    txtViTri.Text = selectedRow.Cells["ViTri"].Value.ToString();
                    if (selectedRow.Cells["KhaDung"].Value.ToString() == "True")
                    {
                        cbbKhaDungKhoHang.SelectedIndex = 0;
                    }
                    else
                    {
                        cbbKhaDungKhoHang.SelectedIndex = 1;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btnSuaKhoHang_Click(object sender, EventArgs e)
        {
            try
            {
                KhoHang khoHang = new KhoHang();
                int.TryParse(txtMaKhoHang.Text, out int maKhoHang);
                khoHang.MaKhoHang = maKhoHang;
                khoHang.TenKhoHang = txtTenKhoHang.Text;
                khoHang.ViTri = txtViTri.Text;
                if (cbbKhaDungKhoHang.SelectedItem != null)
                {
                    if (cbbKhaDungKhoHang.SelectedItem.ToString() == "Có")
                    {
                        khoHang.KhaDung = true;
                    }
                    else
                    {
                        khoHang.KhaDung = false;
                    }
                }
                else
                {
                    khoHang.KhaDung = null;
                }

                KhoHangBLL khoHangBLL = new KhoHangBLL();
                if (khoHangBLL.CapNhatKhoHang(khoHang))
                {
                    txtTenKhoHang.Focus();
                    txtMaKhoHang.Text = "";
                    txtTenKhoHang.Text = "";
                    txtViTri.Text = "";
                    cbbKhaDungKhoHang.SelectedIndex = -1;
                    HienThiDanhSachKhoHang();
                    MessageBox.Show("Chỉnh sửa kho hàng thành công!");
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa kho hàng thất bại. Vui lòng kiểm tra lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoaKhoHang_Click(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(txtMaKhoHang.Text, out int maKhoHang);

                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa kho hàng này? Các nguyên vật liệu chứa trong kho hàng này cũng sẽ bị xoá!", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    KhoHangBLL khoHangBLL = new KhoHangBLL();
                    if (khoHangBLL.XoaKhoHang(maKhoHang))
                    {
                        HienThiDanhSachKhoHang();

                        MessageBox.Show("Xóa kho hàng thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xóa kho hàng thất bại. Vui lòng kiểm tra lại.");
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
