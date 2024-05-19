using NongTraiVuiVe.BLL;
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

        }

        private void btnSuaChiTieu_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaChiTieu_Click(object sender, EventArgs e)
        {

        }

        private void cbbNguoiThucHien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbNguoiThucHien.SelectedItem != null) // Kiểm tra SelectedItem thay vì SelectedValue
            {
                DataRowView selectedRow = cbbNguoiThucHien.SelectedItem as DataRowView;
                if (selectedRow != null)
                {
                    int maNguoiDung = Convert.ToInt32(selectedRow["MaNguoiDung"]); // Lấy giá trị từ cột MaNguoiDung
                    txtMaNguoiThucHien.Text = maNguoiDung.ToString();
                }
            }
        }
    }
}
