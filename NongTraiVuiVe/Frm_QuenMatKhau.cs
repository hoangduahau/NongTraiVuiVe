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
    public partial class Frm_QuenMatKhau : Form
    {

            private Frm_DangNhap parentForm;

            public Frm_QuenMatKhau(Frm_DangNhap parentForm)
            {
                InitializeComponent();
                this.parentForm = parentForm;
            }

            private void btn_Thoat_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void Frm_QuenMatKhau_FormClosed(object sender, FormClosedEventArgs e)
            {
                parentForm.Show();
            }

    }
}
