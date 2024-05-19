namespace NongTraiVuiVe
{
    partial class Frm_QuanLyNguoiDung
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
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            dtpNgayLamViec = new DateTimePicker();
            dtpNgaySinh = new DateTimePicker();
            cbbGioiTinh = new ComboBox();
            dtpNgayTao = new DateTimePicker();
            label7 = new Label();
            txtMaNhomNguoiDung = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtDienThoai = new TextBox();
            label11 = new Label();
            txtHoTen = new TextBox();
            label6 = new Label();
            txtDiaChi = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtMatKhau = new TextBox();
            label3 = new Label();
            txtTenDangNhap = new TextBox();
            label2 = new Label();
            btnXoaNguoiDung = new Button();
            btnSuaNguoiDung = new Button();
            btnThemNguoiDung = new Button();
            txtMaNguoiDung = new TextBox();
            label1 = new Label();
            btnThoatNguoiDung = new Button();
            groupBox1 = new GroupBox();
            dgvDanhSachNguoiDung = new DataGridView();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNguoiDung).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1914, 877);
            panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtpNgayLamViec);
            groupBox2.Controls.Add(dtpNgaySinh);
            groupBox2.Controls.Add(cbbGioiTinh);
            groupBox2.Controls.Add(dtpNgayTao);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtMaNhomNguoiDung);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtDienThoai);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtHoTen);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtDiaChi);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtMatKhau);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtTenDangNhap);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btnXoaNguoiDung);
            groupBox2.Controls.Add(btnSuaNguoiDung);
            groupBox2.Controls.Add(btnThemNguoiDung);
            groupBox2.Controls.Add(txtMaNguoiDung);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(btnThoatNguoiDung);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(1352, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(556, 864);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin người dùng";
            // 
            // dtpNgayLamViec
            // 
            dtpNgayLamViec.Format = DateTimePickerFormat.Short;
            dtpNgayLamViec.Location = new Point(239, 422);
            dtpNgayLamViec.Name = "dtpNgayLamViec";
            dtpNgayLamViec.Size = new Size(294, 34);
            dtpNgayLamViec.TabIndex = 44;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(239, 382);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(294, 34);
            dtpNgaySinh.TabIndex = 43;
            // 
            // cbbGioiTinh
            // 
            cbbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbGioiTinh.FormattingEnabled = true;
            cbbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbbGioiTinh.Location = new Point(238, 337);
            cbbGioiTinh.Name = "cbbGioiTinh";
            cbbGioiTinh.Size = new Size(294, 36);
            cbbGioiTinh.TabIndex = 42;
            // 
            // dtpNgayTao
            // 
            dtpNgayTao.Format = DateTimePickerFormat.Short;
            dtpNgayTao.Location = new Point(238, 170);
            dtpNgayTao.Name = "dtpNgayTao";
            dtpNgayTao.Size = new Size(294, 34);
            dtpNgayTao.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(30, 431);
            label7.Name = "label7";
            label7.Size = new Size(146, 25);
            label7.TabIndex = 39;
            label7.Text = "Ngày làm việc:";
            // 
            // txtMaNhomNguoiDung
            // 
            txtMaNhomNguoiDung.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaNhomNguoiDung.Location = new Point(238, 462);
            txtMaNhomNguoiDung.Name = "txtMaNhomNguoiDung";
            txtMaNhomNguoiDung.Size = new Size(295, 34);
            txtMaNhomNguoiDung.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(25, 471);
            label8.Name = "label8";
            label8.Size = new Size(204, 25);
            label8.TabIndex = 37;
            label8.Text = "Mã nhóm người dùng:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(30, 391);
            label9.Name = "label9";
            label9.Size = new Size(106, 25);
            label9.TabIndex = 35;
            label9.Text = "Ngày sinh:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(30, 348);
            label10.Name = "label10";
            label10.Size = new Size(96, 25);
            label10.TabIndex = 33;
            label10.Text = "Giới tính:";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtDienThoai.Location = new Point(238, 294);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(295, 34);
            txtDienThoai.TabIndex = 32;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(25, 303);
            label11.Name = "label11";
            label11.Size = new Size(109, 25);
            label11.TabIndex = 31;
            label11.Text = "Điện thoại:";
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtHoTen.Location = new Point(238, 210);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(295, 34);
            txtHoTen.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(30, 219);
            label6.Name = "label6";
            label6.Size = new Size(76, 25);
            label6.TabIndex = 29;
            label6.Text = "Họ tên:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiaChi.Location = new Point(238, 250);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(295, 34);
            txtDiaChi.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(25, 259);
            label5.Name = "label5";
            label5.Size = new Size(82, 25);
            label5.TabIndex = 27;
            label5.Text = "Địa chỉ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(30, 179);
            label4.Name = "label4";
            label4.Size = new Size(98, 25);
            label4.TabIndex = 25;
            label4.Text = "Ngày tạo:";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatKhau.Location = new Point(238, 127);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(295, 34);
            txtMatKhau.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(30, 136);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 23;
            label3.Text = "Mật khẩu:";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenDangNhap.Location = new Point(238, 82);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(295, 34);
            txtTenDangNhap.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 91);
            label2.Name = "label2";
            label2.Size = new Size(146, 25);
            label2.TabIndex = 21;
            label2.Text = "Tên đăng nhập:";
            // 
            // btnXoaNguoiDung
            // 
            btnXoaNguoiDung.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoaNguoiDung.Location = new Point(417, 668);
            btnXoaNguoiDung.Name = "btnXoaNguoiDung";
            btnXoaNguoiDung.Size = new Size(106, 37);
            btnXoaNguoiDung.TabIndex = 20;
            btnXoaNguoiDung.Text = "Xóa";
            btnXoaNguoiDung.UseVisualStyleBackColor = true;
            btnXoaNguoiDung.Click += btnXoaNguoiDung_Click;
            // 
            // btnSuaNguoiDung
            // 
            btnSuaNguoiDung.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSuaNguoiDung.Location = new Point(224, 668);
            btnSuaNguoiDung.Name = "btnSuaNguoiDung";
            btnSuaNguoiDung.Size = new Size(106, 37);
            btnSuaNguoiDung.TabIndex = 19;
            btnSuaNguoiDung.Text = "Sửa";
            btnSuaNguoiDung.UseVisualStyleBackColor = true;
            btnSuaNguoiDung.Click += btnSuaNguoiDung_Click;
            // 
            // btnThemNguoiDung
            // 
            btnThemNguoiDung.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThemNguoiDung.Location = new Point(30, 668);
            btnThemNguoiDung.Name = "btnThemNguoiDung";
            btnThemNguoiDung.Size = new Size(106, 37);
            btnThemNguoiDung.TabIndex = 18;
            btnThemNguoiDung.Text = "Thêm ";
            btnThemNguoiDung.UseVisualStyleBackColor = true;
            btnThemNguoiDung.Click += btnThemNguoiDung_Click;
            // 
            // txtMaNguoiDung
            // 
            txtMaNguoiDung.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaNguoiDung.Location = new Point(238, 39);
            txtMaNguoiDung.Name = "txtMaNguoiDung";
            txtMaNguoiDung.ReadOnly = true;
            txtMaNguoiDung.Size = new Size(295, 34);
            txtMaNguoiDung.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 48);
            label1.Name = "label1";
            label1.Size = new Size(151, 25);
            label1.TabIndex = 16;
            label1.Text = "Mã người dùng:";
            // 
            // btnThoatNguoiDung
            // 
            btnThoatNguoiDung.Dock = DockStyle.Bottom;
            btnThoatNguoiDung.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThoatNguoiDung.Location = new Point(3, 823);
            btnThoatNguoiDung.Name = "btnThoatNguoiDung";
            btnThoatNguoiDung.Size = new Size(550, 38);
            btnThoatNguoiDung.TabIndex = 6;
            btnThoatNguoiDung.Text = "Thoát";
            btnThoatNguoiDung.UseVisualStyleBackColor = true;
            btnThoatNguoiDung.Click += btnThoatNguoiDung_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvDanhSachNguoiDung);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(8, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1341, 864);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách người dùng";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dgvDanhSachNguoiDung
            // 
            dgvDanhSachNguoiDung.AllowUserToAddRows = false;
            dgvDanhSachNguoiDung.AllowUserToDeleteRows = false;
            dgvDanhSachNguoiDung.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDanhSachNguoiDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachNguoiDung.BackgroundColor = Color.Honeydew;
            dgvDanhSachNguoiDung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachNguoiDung.Location = new Point(3, 33);
            dgvDanhSachNguoiDung.Name = "dgvDanhSachNguoiDung";
            dgvDanhSachNguoiDung.ReadOnly = true;
            dgvDanhSachNguoiDung.RowHeadersWidth = 51;
            dgvDanhSachNguoiDung.RowTemplate.Height = 29;
            dgvDanhSachNguoiDung.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachNguoiDung.Size = new Size(1335, 821);
            dgvDanhSachNguoiDung.TabIndex = 0;
            dgvDanhSachNguoiDung.CellClick += dgvDanhSachNguoiDung_CellClick;
            // 
            // Frm_QuanLyNguoiDung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1914, 877);
            Controls.Add(panel1);
            Name = "Frm_QuanLyNguoiDung";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Frm_QuanLyNguoiDung";
            WindowState = FormWindowState.Maximized;
            Load += Frm_QuanLyNguoiDung_Load;
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNguoiDung).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button1;
        private DataGridView dgvDanhSachNguoiDung;
        private Button btnThoatNguoiDung;
        private TextBox txtHoTen;
        private Label label6;
        private TextBox txtDiaChi;
        private Label label5;
        private Label label4;
        private TextBox txtMatKhau;
        private Label label3;
        private TextBox txtTenDangNhap;
        private Label label2;
        private Button btnXoaNguoiDung;
        private Button btnSuaNguoiDung;
        private Button btnThemNguoiDung;
        private TextBox txtMaNguoiDung;
        private Label label1;
        private Label label7;
        private TextBox txtMaNhomNguoiDung;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtDienThoai;
        private Label label11;
        private DateTimePicker dtpNgayLamViec;
        private DateTimePicker dtpNgaySinh;
        private ComboBox cbbGioiTinh;
        private DateTimePicker dtpNgayTao;
    }
}