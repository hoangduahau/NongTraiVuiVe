namespace NongTraiVuiVe
{
    partial class Frm_DangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_TitleDangNhap = new Label();
            lbl_TaiKhoan = new Label();
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            lbl_MatKhau = new Label();
            btnDangNhap = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // lbl_TitleDangNhap
            // 
            lbl_TitleDangNhap.BackColor = Color.LawnGreen;
            lbl_TitleDangNhap.Dock = DockStyle.Top;
            lbl_TitleDangNhap.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_TitleDangNhap.ForeColor = SystemColors.ControlText;
            lbl_TitleDangNhap.Location = new Point(0, 0);
            lbl_TitleDangNhap.Name = "lbl_TitleDangNhap";
            lbl_TitleDangNhap.Size = new Size(741, 60);
            lbl_TitleDangNhap.TabIndex = 0;
            lbl_TitleDangNhap.Text = "Đăng Nhập Hệ Thống";
            lbl_TitleDangNhap.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_TaiKhoan
            // 
            lbl_TaiKhoan.AutoSize = true;
            lbl_TaiKhoan.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_TaiKhoan.Location = new Point(29, 106);
            lbl_TaiKhoan.Name = "lbl_TaiKhoan";
            lbl_TaiKhoan.Size = new Size(120, 32);
            lbl_TaiKhoan.TabIndex = 1;
            lbl_TaiKhoan.Text = "Tài khoản:";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenDangNhap.Location = new Point(180, 99);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(494, 39);
            txtTenDangNhap.TabIndex = 2;
            txtTenDangNhap.KeyDown += txtTenDangNhap_KeyDown;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatKhau.Location = new Point(180, 162);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(494, 39);
            txtMatKhau.TabIndex = 4;
            txtMatKhau.KeyDown += txtMatKhau_KeyDown;
            // 
            // lbl_MatKhau
            // 
            lbl_MatKhau.AutoSize = true;
            lbl_MatKhau.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_MatKhau.Location = new Point(29, 169);
            lbl_MatKhau.Name = "lbl_MatKhau";
            lbl_MatKhau.Size = new Size(120, 32);
            lbl_MatKhau.TabIndex = 3;
            lbl_MatKhau.Text = "Mật khẩu:";
            // 
            // btnDangNhap
            // 
            btnDangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDangNhap.Location = new Point(413, 237);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(121, 42);
            btnDangNhap.TabIndex = 6;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThoat.Location = new Point(553, 237);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(121, 42);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Frm_DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(741, 350);
            Controls.Add(btnThoat);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(lbl_MatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(lbl_TaiKhoan);
            Controls.Add(lbl_TitleDangNhap);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_DangNhap";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Frm_DangNhap";
            Load += Frm_DangNhap_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_TitleDangNhap;
        private Label lbl_TaiKhoan;
        private TextBox txtTenDangNhap;
        private TextBox txtMatKhau;
        private Label lbl_MatKhau;
        private Button btnDangNhap;
        private Button btnThoat;
    }
}