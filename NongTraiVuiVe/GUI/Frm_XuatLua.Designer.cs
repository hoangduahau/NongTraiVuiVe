namespace NongTraiVuiVe.GUI
{
    partial class Frm_XuatLua
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
            gpKh = new GroupBox();
            cbbTenCayTrong = new ComboBox();
            cbbKhachHang = new ComboBox();
            label7 = new Label();
            dtpNgayXuat = new DateTimePicker();
            txtGiaXuat = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtSoLuong = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtMaCayTrong = new TextBox();
            label2 = new Label();
            txtMaXuatLua = new TextBox();
            label1 = new Label();
            btnThoatXuatLua = new Button();
            btnXoaPhieuXuat = new Button();
            btnSuaPhieuXuat = new Button();
            btnThemPhieuXuat = new Button();
            groupBox1 = new GroupBox();
            dgvDanhSachXuatLua = new DataGridView();
            gpKh.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachXuatLua).BeginInit();
            SuspendLayout();
            // 
            // gpKh
            // 
            gpKh.Controls.Add(cbbTenCayTrong);
            gpKh.Controls.Add(cbbKhachHang);
            gpKh.Controls.Add(label7);
            gpKh.Controls.Add(dtpNgayXuat);
            gpKh.Controls.Add(txtGiaXuat);
            gpKh.Controls.Add(label6);
            gpKh.Controls.Add(label5);
            gpKh.Controls.Add(txtSoLuong);
            gpKh.Controls.Add(label4);
            gpKh.Controls.Add(label3);
            gpKh.Controls.Add(txtMaCayTrong);
            gpKh.Controls.Add(label2);
            gpKh.Controls.Add(txtMaXuatLua);
            gpKh.Controls.Add(label1);
            gpKh.Controls.Add(btnThoatXuatLua);
            gpKh.Controls.Add(btnXoaPhieuXuat);
            gpKh.Controls.Add(btnSuaPhieuXuat);
            gpKh.Controls.Add(btnThemPhieuXuat);
            gpKh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gpKh.Location = new Point(1351, 6);
            gpKh.Name = "gpKh";
            gpKh.Size = new Size(556, 864);
            gpKh.TabIndex = 9;
            gpKh.TabStop = false;
            gpKh.Text = "Thông tin xuất lứa";
            // 
            // cbbTenCayTrong
            // 
            cbbTenCayTrong.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTenCayTrong.FormattingEnabled = true;
            cbbTenCayTrong.Location = new Point(209, 228);
            cbbTenCayTrong.Name = "cbbTenCayTrong";
            cbbTenCayTrong.Size = new Size(295, 36);
            cbbTenCayTrong.TabIndex = 33;
            cbbTenCayTrong.SelectedIndexChanged += cbbTenCayTrong_SelectedIndexChanged;
            // 
            // cbbKhachHang
            // 
            cbbKhachHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbKhachHang.FormattingEnabled = true;
            cbbKhachHang.Location = new Point(209, 537);
            cbbKhachHang.Name = "cbbKhachHang";
            cbbKhachHang.Size = new Size(295, 36);
            cbbKhachHang.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(69, 548);
            label7.Name = "label7";
            label7.Size = new Size(119, 25);
            label7.TabIndex = 31;
            label7.Text = "Khách hàng:";
            // 
            // dtpNgayXuat
            // 
            dtpNgayXuat.Format = DateTimePickerFormat.Short;
            dtpNgayXuat.Location = new Point(209, 384);
            dtpNgayXuat.Name = "dtpNgayXuat";
            dtpNgayXuat.Size = new Size(295, 34);
            dtpNgayXuat.TabIndex = 30;
            // 
            // txtGiaXuat
            // 
            txtGiaXuat.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtGiaXuat.Location = new Point(209, 463);
            txtGiaXuat.Name = "txtGiaXuat";
            txtGiaXuat.Size = new Size(295, 34);
            txtGiaXuat.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(95, 472);
            label6.Name = "label6";
            label6.Size = new Size(93, 25);
            label6.TabIndex = 28;
            label6.Text = "Giá xuất:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(123, 393);
            label5.Name = "label5";
            label5.Size = new Size(65, 25);
            label5.TabIndex = 27;
            label5.Text = "Ngày:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoLuong.Location = new Point(209, 307);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(295, 34);
            txtSoLuong.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(95, 316);
            label4.Name = "label4";
            label4.Size = new Size(97, 25);
            label4.TabIndex = 25;
            label4.Text = "Số lượng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(58, 239);
            label3.Name = "label3";
            label3.Size = new Size(139, 25);
            label3.TabIndex = 23;
            label3.Text = "Tên cây trồng:";
            // 
            // txtMaCayTrong
            // 
            txtMaCayTrong.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaCayTrong.Location = new Point(209, 156);
            txtMaCayTrong.Name = "txtMaCayTrong";
            txtMaCayTrong.ReadOnly = true;
            txtMaCayTrong.Size = new Size(295, 34);
            txtMaCayTrong.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(58, 165);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 21;
            label2.Text = "Mã cây trồng:";
            // 
            // txtMaXuatLua
            // 
            txtMaXuatLua.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaXuatLua.Location = new Point(209, 84);
            txtMaXuatLua.Name = "txtMaXuatLua";
            txtMaXuatLua.ReadOnly = true;
            txtMaXuatLua.Size = new Size(295, 34);
            txtMaXuatLua.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(64, 93);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 19;
            label1.Text = "Mã xuất lứa:";
            // 
            // btnThoatXuatLua
            // 
            btnThoatXuatLua.Dock = DockStyle.Bottom;
            btnThoatXuatLua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThoatXuatLua.Location = new Point(3, 822);
            btnThoatXuatLua.Name = "btnThoatXuatLua";
            btnThoatXuatLua.Size = new Size(550, 39);
            btnThoatXuatLua.TabIndex = 5;
            btnThoatXuatLua.Text = "Thoát";
            btnThoatXuatLua.UseVisualStyleBackColor = true;
            btnThoatXuatLua.Click += btnThoatXuatLua_Click;
            // 
            // btnXoaPhieuXuat
            // 
            btnXoaPhieuXuat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoaPhieuXuat.Location = new Point(413, 641);
            btnXoaPhieuXuat.Name = "btnXoaPhieuXuat";
            btnXoaPhieuXuat.Size = new Size(106, 37);
            btnXoaPhieuXuat.TabIndex = 4;
            btnXoaPhieuXuat.Text = "Xóa";
            btnXoaPhieuXuat.UseVisualStyleBackColor = true;
            btnXoaPhieuXuat.Click += btnXoaPhieuXuat_Click;
            // 
            // btnSuaPhieuXuat
            // 
            btnSuaPhieuXuat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSuaPhieuXuat.Location = new Point(243, 641);
            btnSuaPhieuXuat.Name = "btnSuaPhieuXuat";
            btnSuaPhieuXuat.Size = new Size(106, 37);
            btnSuaPhieuXuat.TabIndex = 3;
            btnSuaPhieuXuat.Text = "Sửa";
            btnSuaPhieuXuat.UseVisualStyleBackColor = true;
            btnSuaPhieuXuat.Click += btnSuaPhieuXuat_Click;
            // 
            // btnThemPhieuXuat
            // 
            btnThemPhieuXuat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThemPhieuXuat.Location = new Point(74, 641);
            btnThemPhieuXuat.Name = "btnThemPhieuXuat";
            btnThemPhieuXuat.Size = new Size(106, 37);
            btnThemPhieuXuat.TabIndex = 2;
            btnThemPhieuXuat.Text = "Thêm ";
            btnThemPhieuXuat.UseVisualStyleBackColor = true;
            btnThemPhieuXuat.Click += btnThemPhieuXuat_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvDanhSachXuatLua);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(7, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1341, 864);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách xuất lứa";
            // 
            // dgvDanhSachXuatLua
            // 
            dgvDanhSachXuatLua.AllowUserToAddRows = false;
            dgvDanhSachXuatLua.AllowUserToDeleteRows = false;
            dgvDanhSachXuatLua.BackgroundColor = Color.Honeydew;
            dgvDanhSachXuatLua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachXuatLua.Dock = DockStyle.Fill;
            dgvDanhSachXuatLua.Location = new Point(3, 30);
            dgvDanhSachXuatLua.Name = "dgvDanhSachXuatLua";
            dgvDanhSachXuatLua.ReadOnly = true;
            dgvDanhSachXuatLua.RowHeadersWidth = 51;
            dgvDanhSachXuatLua.RowTemplate.Height = 29;
            dgvDanhSachXuatLua.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachXuatLua.Size = new Size(1335, 831);
            dgvDanhSachXuatLua.TabIndex = 0;
            dgvDanhSachXuatLua.CellClick += dgvDanhSachXuatLua_CellClick;
            // 
            // Frm_XuatLua
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1914, 877);
            Controls.Add(gpKh);
            Controls.Add(groupBox1);
            Name = "Frm_XuatLua";
            Text = "Frm_XuatLua";
            Load += Frm_XuatLua_Load;
            gpKh.ResumeLayout(false);
            gpKh.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachXuatLua).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpKh;
        private DateTimePicker dtpNgayXuat;
        private TextBox txtGiaXuat;
        private Label label6;
        private Label label5;
        private TextBox txtSoLuong;
        private Label label4;
        private Label label3;
        private TextBox txtMaCayTrong;
        private Label label2;
        private Button btnThoatXuatLua;
        private Button btnXoaPhieuXuat;
        private Button btnSuaPhieuXuat;
        private Button btnThemPhieuXuat;
        private TextBox txtMaXuatLua;
        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dgvDanhSachXuatLua;
        private Label label7;
        private ComboBox cbbKhachHang;
        private ComboBox cbbTenCayTrong;
    }
}