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
    public partial class Frm_QuanLyNhaCungCap : Form
    {
        public Frm_QuanLyNhaCungCap()
        {
            InitializeComponent();
        }

        private NhaCungCapBLL nhaCungCapBLL;
        private void Frm_QuanLyNhaCungCap_Load(object sender, EventArgs e)
        {
            HienThiDanhSachNhaCungCap();
        }

        private void HienThiDanhSachNhaCungCap()
        {
            nhaCungCapBLL = new NhaCungCapBLL();

            DataTable dtNhaCungCap = nhaCungCapBLL.LayDuLieuNhaCungCap();
            dgvDanhSachNhaCungCap.DataSource = dtNhaCungCap;
        }

        private void dgvDanhSachNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSachNhaCungCap.Rows.Count)
                {
                    DataGridViewRow selectedRow = dgvDanhSachNhaCungCap.Rows[e.RowIndex];

                    txtMaNhaCungCap.Text = selectedRow.Cells["MaNhaCungCap"].Value.ToString();
                    txtTenNhaCungCap.Text = selectedRow.Cells["TenNhaCungCap"].Value.ToString();
                    txtDiaChiNhaCungCap.Text = selectedRow.Cells["DiaChi"].Value.ToString();
                    txtSoDienThoaiNhaCungCap.Text = selectedRow.Cells["DienThoai"].Value.ToString();
                    txtEmailNhaCungCap.Text = selectedRow.Cells["Email"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btnThemNhaCungCap_Click(object sender, EventArgs e)
        {
            try
            {
                NhaCungCap nhaCungCap = new NhaCungCap();
                nhaCungCap.TenNhaCungCap = txtTenNhaCungCap.Text;
                nhaCungCap.DiaChi = txtDiaChiNhaCungCap.Text;
                nhaCungCap.DienThoai = txtSoDienThoaiNhaCungCap.Text;
                nhaCungCap.Email = txtEmailNhaCungCap.Text;

                NhaCungCapBLL nhaCungCapBLL = new NhaCungCapBLL();
                if (nhaCungCapBLL.ThemNhaCungCap(nhaCungCap))
                {
                    txtTenNhaCungCap.Focus();
                    txtMaNhaCungCap.Text = "";
                    txtTenNhaCungCap.Text = "";
                    txtDiaChiNhaCungCap.Text = "";
                    txtSoDienThoaiNhaCungCap.Text = "";
                    txtEmailNhaCungCap.Text = "";
                    HienThiDanhSachNhaCungCap();
                    MessageBox.Show("Thêm nhà cung cấp thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm nhà cung cấp thất bại. Vui lòng kiểm tra lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSuaNhaCungCap_Click(object sender, EventArgs e)
        {
            try
            {
                NhaCungCap nhaCungCap = new NhaCungCap();
                int.TryParse(txtMaNhaCungCap.Text, out int maNhaCungCap);
                nhaCungCap.MaNhaCungCap = maNhaCungCap;
                nhaCungCap.TenNhaCungCap = txtTenNhaCungCap.Text;
                nhaCungCap.DiaChi = txtDiaChiNhaCungCap.Text;
                nhaCungCap.DienThoai = txtSoDienThoaiNhaCungCap.Text;
                nhaCungCap.Email = txtEmailNhaCungCap.Text;

                NhaCungCapBLL nhaCungCapBLL = new NhaCungCapBLL();
                if (nhaCungCapBLL.CapNhatNhaCungCap(nhaCungCap))
                {
                    txtTenNhaCungCap.Focus();
                    txtMaNhaCungCap.Text = "";
                    txtTenNhaCungCap.Text = "";
                    txtDiaChiNhaCungCap.Text = "";
                    txtSoDienThoaiNhaCungCap.Text = "";
                    txtEmailNhaCungCap.Text = "";
                    HienThiDanhSachNhaCungCap();
                    MessageBox.Show("Chỉnh sửa nhà cung cấp thành công!");
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa nhà cung cấp thất bại. Vui lòng kiểm tra lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoaNhaCungCap_Click(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(txtMaNhaCungCap.Text, out int maNhaCungCap);

                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    NhaCungCapBLL nhaCungCapBLL = new NhaCungCapBLL();
                    if (nhaCungCapBLL.XoaNhaCungCap(maNhaCungCap))
                    {
                        HienThiDanhSachNhaCungCap();

                        MessageBox.Show("Xóa nhà cung cấp thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhà cung cấp thất bại. Vui lòng kiểm tra lại.");
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
