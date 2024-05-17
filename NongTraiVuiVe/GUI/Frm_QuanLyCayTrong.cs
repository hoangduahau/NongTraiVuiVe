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
    public partial class Frm_QuanLyCayTrong : Form
    {
        public Frm_QuanLyCayTrong()
        {
            InitializeComponent();
        }

        private void btnThoatCT_Click(object sender, EventArgs e)
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

        private void label8_Click(object sender, EventArgs e)
        {

        }


        private CayTrongBLL cayTrongBLL;

        private void Frm_QuanLyCayTrong_Load(object sender, EventArgs e)
        {
            cayTrongBLL = new CayTrongBLL();

            // Gọi phương thức từ BLL để lấy dữ liệu và hiển thị
            DataTable dtCayTrong = cayTrongBLL.LayDuLieuCayTrong();
            dgvDanhSachCayTrong.DataSource = dtCayTrong;
        }

        private void dgvDanhSachCayTrong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Kiểm tra xem có dòng nào được chọn không và chỉ số dòng hợp lệ
                if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSachCayTrong.Rows.Count)
                {
                    // Lấy dòng được chọn
                    DataGridViewRow selectedRow = dgvDanhSachCayTrong.Rows[e.RowIndex];

                    // Hiển thị các thuộc tính vào TextBox (điều chỉnh tên các TextBox cho phù hợp)
                    txtMaCayTrong.Text = selectedRow.Cells["MaCayTrong"].Value.ToString();
                    txtTenCayTrong.Text = selectedRow.Cells["TenCayTrong"].Value.ToString();
                    txtMaLoaiCayTrong.Text = selectedRow.Cells["MaLoaiCayTrong"].Value.ToString();
                    txtGiongCay.Text = selectedRow.Cells["Giong"].Value.ToString();
                    txtNguonGoc.Text = selectedRow.Cells["NguonGoc"].Value.ToString();
                    txtSoLuong.Text = selectedRow.Cells["SoLuong"].Value.ToString();
                    txtNgayGieoTrong.Text = selectedRow.Cells["NgayGieoTrong"].Value.ToString();
                    txtNgayThuHoachDuKien.Text = selectedRow.Cells["NgayThuHoachDuKien"].Value.ToString();
                    txtNgayThuHoachThucTe.Text = selectedRow.Cells["NgayThuHoachThucTe"].Value.ToString();
                    txtMaKhuVuc.Text = selectedRow.Cells["MaKhuVuc"].Value.ToString();
                    txtTinhTrang.Text = selectedRow.Cells["TinhTrang"].Value.ToString();
                    // ... (hiển thị các thuộc tính khác tương tự)
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi (ví dụ: hiển thị thông báo lỗi)
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
}
