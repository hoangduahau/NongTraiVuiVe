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

namespace NongTraiVuiVe.GUI
{
    public partial class Frm_DoiMatKhau : Form
    {
        private NguoiDungBLL _nguoiDungBLL = new NguoiDungBLL();
        private int _maNguoiDung; // ID của người dùng hiện tại
        public Frm_DoiMatKhau(int maNguoiDung)
        {
            InitializeComponent();
            _maNguoiDung = maNguoiDung;
        }

        private void Frm_DoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            string matKhauCu = txtMatKhauCu.Text;
            string matKhauMoi = txtMatKhauMoi.Text;
            string xacNhanMatKhauMoi = txtXacNhanMatKhau.Text;

            if (matKhauMoi != xacNhanMatKhauMoi)
            {
                MessageBox.Show("Xác nhận mật khẩu không khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool result = _nguoiDungBLL.DoiMatKhau(_maNguoiDung, matKhauCu, matKhauMoi);

            if (result)
            {
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnThoat_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
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
