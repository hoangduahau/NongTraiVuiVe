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
            txt_TaiKhoan = new TextBox();
            txt_MatKhau = new TextBox();
            lbl_MatKhau = new Label();
            linklbl_QuenMatKhau = new LinkLabel();
            btn_DangNhap = new Button();
            btn_Thoat = new Button();
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
            // txt_TaiKhoan
            // 
            txt_TaiKhoan.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_TaiKhoan.Location = new Point(180, 99);
            txt_TaiKhoan.Name = "txt_TaiKhoan";
            txt_TaiKhoan.Size = new Size(494, 39);
            txt_TaiKhoan.TabIndex = 2;
            // 
            // txt_MatKhau
            // 
            txt_MatKhau.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_MatKhau.Location = new Point(180, 162);
            txt_MatKhau.Name = "txt_MatKhau";
            txt_MatKhau.Size = new Size(494, 39);
            txt_MatKhau.TabIndex = 4;
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
            // linklbl_QuenMatKhau
            // 
            linklbl_QuenMatKhau.AutoSize = true;
            linklbl_QuenMatKhau.Location = new Point(558, 204);
            linklbl_QuenMatKhau.Name = "linklbl_QuenMatKhau";
            linklbl_QuenMatKhau.Size = new Size(116, 20);
            linklbl_QuenMatKhau.TabIndex = 5;
            linklbl_QuenMatKhau.TabStop = true;
            linklbl_QuenMatKhau.Text = "Quên mật khẩu?";
            linklbl_QuenMatKhau.LinkClicked += linklbl_QuenMatKhau_LinkClicked;
            // 
            // btn_DangNhap
            // 
            btn_DangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_DangNhap.Location = new Point(413, 237);
            btn_DangNhap.Name = "btn_DangNhap";
            btn_DangNhap.Size = new Size(121, 42);
            btn_DangNhap.TabIndex = 6;
            btn_DangNhap.Text = "Đăng nhập";
            btn_DangNhap.UseVisualStyleBackColor = true;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Thoat.Location = new Point(553, 237);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(121, 42);
            btn_Thoat.TabIndex = 7;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            btn_Thoat.Click += btnThoat_Click;
            // 
            // Frm_DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 350);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_DangNhap);
            Controls.Add(linklbl_QuenMatKhau);
            Controls.Add(txt_MatKhau);
            Controls.Add(lbl_MatKhau);
            Controls.Add(txt_TaiKhoan);
            Controls.Add(lbl_TaiKhoan);
            Controls.Add(lbl_TitleDangNhap);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_DangNhap";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Frm_DangNhap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_TitleDangNhap;
        private Label lbl_TaiKhoan;
        private TextBox txt_TaiKhoan;
        private TextBox txt_MatKhau;
        private Label lbl_MatKhau;
        private LinkLabel linklbl_QuenMatKhau;
        private Button btn_DangNhap;
        private Button btn_Thoat;
    }
}