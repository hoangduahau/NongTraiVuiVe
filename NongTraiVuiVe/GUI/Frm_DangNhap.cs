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

namespace NongTraiVuiVe
{
    public partial class Frm_DangNhap : Form
    {
        private NguoiDungBLL _nguoiDungBLL = new NguoiDungBLL();
        public bool isLogin { get; private set; }
        public Frm_DangNhap()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            bool isLogin = false;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linklbl_QuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Frm_QuenMatKhau frmQuenMatKhau = new Frm_QuenMatKhau(this);
            frmQuenMatKhau.ShowDialog();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;

            NguoiDung nguoiDung = _nguoiDungBLL.DangNhap(tenDangNhap, matKhau);

            if (nguoiDung != null)
            {
                isLogin = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại tên đăng nhập và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isLogin = false;
            }
        }

        private void txtTenDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e); 
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e); 
            }
        }
    }
}
