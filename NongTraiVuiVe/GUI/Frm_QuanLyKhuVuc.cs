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

namespace NongTraiVuiVe
{
    public partial class Frm_QuanLyKhuVuc : Form
    {
        public Frm_QuanLyKhuVuc()
        {
            InitializeComponent();
        }

        private void btnThoatKv_Click(object sender, EventArgs e)
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

        private KhuVucBLL khuVucBLL;
        private void Frm_QuanLyKhuVuc_Load(object sender, EventArgs e)
        {
            HienThiDanhSachKhuVuc();
        }

        private void HienThiDanhSachKhuVuc()
        {
            khuVucBLL = new KhuVucBLL();

            // Gọi phương thức từ BLL để lấy dữ liệu và hiển thị
            DataTable dtKhuVuc = khuVucBLL.LayDuLieuKhuVuc();
            dgvDanhSachKhuVuc.DataSource = dtKhuVuc;
        }

        private void dgvDanhSachKhuVuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Kiểm tra xem có dòng nào được chọn không và chỉ số dòng hợp lệ
                if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSachKhuVuc.Rows.Count)
                {
                    // Lấy dòng được chọn
                    DataGridViewRow selectedRow = dgvDanhSachKhuVuc.Rows[e.RowIndex];

                    // Hiển thị các thuộc tính vào TextBox (điều chỉnh tên các TextBox cho phù hợp)
                    txtMaKhuVuc.Text = selectedRow.Cells["MaKhuVuc"].Value.ToString();
                    txtTenKhuVuc.Text = selectedRow.Cells["TenKhuVuc"].Value.ToString();
                    if (selectedRow.Cells["KhaDung"].Value.ToString() == "True")
                    {
                        cbbKhaDungKhuVuc.SelectedIndex = 0;
                    }
                    else
                    {
                        cbbKhaDungKhuVuc.SelectedIndex = 1;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btnThemKhuVuc_Click(object sender, EventArgs e)
        {
            try
            {
                KhuVuc khuVuc = new KhuVuc();
                khuVuc.TenKhuVuc = txtTenKhuVuc.Text;
                if (cbbKhaDungKhuVuc.SelectedItem != null)
                {
                    if (cbbKhaDungKhuVuc.SelectedItem.ToString() == "Có")
                    {
                        khuVuc.KhaDung = true;
                    }
                    else
                    {
                        khuVuc.KhaDung = false;
                    }
                }
                else
                {
                    khuVuc.KhaDung = null;
                }

                KhuVucBLL khuVucBLL = new KhuVucBLL();
                if (khuVucBLL.ThemKhuVuc(khuVuc))
                {
                    txtTenKhuVuc.Focus();
                    txtMaKhuVuc.Text = "";
                    txtTenKhuVuc.Text = "";
                    cbbKhaDungKhuVuc.SelectedIndex = -1;
                    HienThiDanhSachKhuVuc();
                    MessageBox.Show("Thêm khu vực thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm khu vực thất bại. Vui lòng kiểm tra lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSuaKhuVuc_Click(object sender, EventArgs e)
        {
            try
            {
                KhuVuc khuVuc = new KhuVuc();
                int.TryParse(txtMaKhuVuc.Text, out int maKhuVuc);
                khuVuc.MaKhuVuc = maKhuVuc;
                khuVuc.TenKhuVuc = txtTenKhuVuc.Text;
                if (cbbKhaDungKhuVuc.SelectedItem != null)
                {
                    if (cbbKhaDungKhuVuc.SelectedItem.ToString() == "Có")
                    {
                        khuVuc.KhaDung = true;
                    }
                    else
                    {
                        khuVuc.KhaDung = false;
                    }
                }
                else
                {
                    khuVuc.KhaDung = null;
                }

                KhuVucBLL khuVucBLL = new KhuVucBLL();
                if (khuVucBLL.CapNhatKhuVuc(khuVuc))
                {
                    txtTenKhuVuc.Focus();
                    txtMaKhuVuc.Text = "";
                    txtTenKhuVuc.Text = "";
                    cbbKhaDungKhuVuc.SelectedIndex = -1;
                    HienThiDanhSachKhuVuc();
                    MessageBox.Show("Chỉnh sửa khu vực thành công!");
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa khu vực thất bại. Vui lòng kiểm tra lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
