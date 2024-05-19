namespace NongTraiVuiVe.GUI
{
    partial class Frm_NhapLua
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
            groupBox1 = new GroupBox();
            dgvDanhSachPhieuNhapLuaCayTrong = new DataGridView();
            txtSoLuong = new TextBox();
            cbbLoaiCayTrong = new ComboBox();
            dtpNgayNhap = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtGiong = new TextBox();
            label2 = new Label();
            btnThoatLnvl = new Button();
            btnXoaPhieuNhap = new Button();
            btnSuaPhieuNhap = new Button();
            btnThemPhieuNhap = new Button();
            txtMaNhapLuaCayTrong = new TextBox();
            label1 = new Label();
            btnThoat = new GroupBox();
            txtTenCayTrong = new TextBox();
            cbbNhaCungCap = new ComboBox();
            txtGiaNhap = new TextBox();
            label9 = new Label();
            label8 = new Label();
            txtNguonGoc = new TextBox();
            label7 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachPhieuNhapLuaCayTrong).BeginInit();
            btnThoat.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvDanhSachPhieuNhapLuaCayTrong);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(7, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1341, 864);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách phiếu nhập lứa cây trồng";
            // 
            // dgvDanhSachPhieuNhapLuaCayTrong
            // 
            dgvDanhSachPhieuNhapLuaCayTrong.AllowUserToAddRows = false;
            dgvDanhSachPhieuNhapLuaCayTrong.AllowUserToDeleteRows = false;
            dgvDanhSachPhieuNhapLuaCayTrong.BackgroundColor = Color.Honeydew;
            dgvDanhSachPhieuNhapLuaCayTrong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachPhieuNhapLuaCayTrong.Dock = DockStyle.Fill;
            dgvDanhSachPhieuNhapLuaCayTrong.GridColor = Color.Honeydew;
            dgvDanhSachPhieuNhapLuaCayTrong.Location = new Point(3, 30);
            dgvDanhSachPhieuNhapLuaCayTrong.Name = "dgvDanhSachPhieuNhapLuaCayTrong";
            dgvDanhSachPhieuNhapLuaCayTrong.ReadOnly = true;
            dgvDanhSachPhieuNhapLuaCayTrong.RowHeadersWidth = 51;
            dgvDanhSachPhieuNhapLuaCayTrong.RowTemplate.Height = 29;
            dgvDanhSachPhieuNhapLuaCayTrong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachPhieuNhapLuaCayTrong.Size = new Size(1335, 831);
            dgvDanhSachPhieuNhapLuaCayTrong.TabIndex = 0;
            dgvDanhSachPhieuNhapLuaCayTrong.CellClick += dgvDanhSachPhieuNhapLuaCayTrong_CellClick;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoLuong.Location = new Point(256, 256);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(295, 34);
            txtSoLuong.TabIndex = 15;
            // 
            // cbbLoaiCayTrong
            // 
            cbbLoaiCayTrong.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbLoaiCayTrong.FormattingEnabled = true;
            cbbLoaiCayTrong.Location = new Point(255, 134);
            cbbLoaiCayTrong.Name = "cbbLoaiCayTrong";
            cbbLoaiCayTrong.Size = new Size(295, 36);
            cbbLoaiCayTrong.TabIndex = 14;
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.Format = DateTimePickerFormat.Short;
            dtpNgayNhap.Location = new Point(255, 338);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(295, 34);
            dtpNgayNhap.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(7, 265);
            label6.Name = "label6";
            label6.Size = new Size(97, 25);
            label6.TabIndex = 11;
            label6.Text = "Số lượng:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(7, 185);
            label5.Name = "label5";
            label5.Size = new Size(71, 25);
            label5.TabIndex = 10;
            label5.Text = "Giống:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(7, 347);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 9;
            label4.Text = "Ngày nhập:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(7, 145);
            label3.Name = "label3";
            label3.Size = new Size(138, 25);
            label3.TabIndex = 8;
            label3.Text = "Loại cây trồng";
            // 
            // txtGiong
            // 
            txtGiong.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtGiong.Location = new Point(255, 176);
            txtGiong.Name = "txtGiong";
            txtGiong.Size = new Size(295, 34);
            txtGiong.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 103);
            label2.Name = "label2";
            label2.Size = new Size(139, 25);
            label2.TabIndex = 6;
            label2.Text = "Tên cây trồng:";
            // 
            // btnThoatLnvl
            // 
            btnThoatLnvl.Dock = DockStyle.Bottom;
            btnThoatLnvl.Location = new Point(3, 820);
            btnThoatLnvl.Name = "btnThoatLnvl";
            btnThoatLnvl.Size = new Size(550, 41);
            btnThoatLnvl.TabIndex = 5;
            btnThoatLnvl.Text = "Thoát";
            btnThoatLnvl.UseVisualStyleBackColor = true;
            btnThoatLnvl.Click += btnThoatLnvl_Click;
            // 
            // btnXoaPhieuNhap
            // 
            btnXoaPhieuNhap.Location = new Point(405, 608);
            btnXoaPhieuNhap.Name = "btnXoaPhieuNhap";
            btnXoaPhieuNhap.Size = new Size(104, 34);
            btnXoaPhieuNhap.TabIndex = 4;
            btnXoaPhieuNhap.Text = "Xóa";
            btnXoaPhieuNhap.UseVisualStyleBackColor = true;
            btnXoaPhieuNhap.Click += btnXoaPhieuNhap_Click;
            // 
            // btnSuaPhieuNhap
            // 
            btnSuaPhieuNhap.Location = new Point(245, 608);
            btnSuaPhieuNhap.Name = "btnSuaPhieuNhap";
            btnSuaPhieuNhap.Size = new Size(104, 34);
            btnSuaPhieuNhap.TabIndex = 3;
            btnSuaPhieuNhap.Text = "Sửa";
            btnSuaPhieuNhap.UseVisualStyleBackColor = true;
            btnSuaPhieuNhap.Click += btnSuaPhieuNhap_Click;
            // 
            // btnThemPhieuNhap
            // 
            btnThemPhieuNhap.Location = new Point(75, 608);
            btnThemPhieuNhap.Name = "btnThemPhieuNhap";
            btnThemPhieuNhap.Size = new Size(104, 34);
            btnThemPhieuNhap.TabIndex = 2;
            btnThemPhieuNhap.Text = "Thêm ";
            btnThemPhieuNhap.UseVisualStyleBackColor = true;
            btnThemPhieuNhap.Click += btnThemPhieuNhap_Click;
            // 
            // txtMaNhapLuaCayTrong
            // 
            txtMaNhapLuaCayTrong.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaNhapLuaCayTrong.Location = new Point(256, 52);
            txtMaNhapLuaCayTrong.Name = "txtMaNhapLuaCayTrong";
            txtMaNhapLuaCayTrong.ReadOnly = true;
            txtMaNhapLuaCayTrong.Size = new Size(295, 34);
            txtMaNhapLuaCayTrong.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 61);
            label1.Name = "label1";
            label1.Size = new Size(128, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã nhập lứa:";
            // 
            // btnThoat
            // 
            btnThoat.Controls.Add(txtTenCayTrong);
            btnThoat.Controls.Add(cbbNhaCungCap);
            btnThoat.Controls.Add(txtGiaNhap);
            btnThoat.Controls.Add(label9);
            btnThoat.Controls.Add(label8);
            btnThoat.Controls.Add(txtNguonGoc);
            btnThoat.Controls.Add(label7);
            btnThoat.Controls.Add(txtSoLuong);
            btnThoat.Controls.Add(cbbLoaiCayTrong);
            btnThoat.Controls.Add(dtpNgayNhap);
            btnThoat.Controls.Add(label6);
            btnThoat.Controls.Add(label5);
            btnThoat.Controls.Add(label4);
            btnThoat.Controls.Add(label3);
            btnThoat.Controls.Add(txtGiong);
            btnThoat.Controls.Add(label2);
            btnThoat.Controls.Add(btnThoatLnvl);
            btnThoat.Controls.Add(btnXoaPhieuNhap);
            btnThoat.Controls.Add(btnSuaPhieuNhap);
            btnThoat.Controls.Add(btnThemPhieuNhap);
            btnThoat.Controls.Add(txtMaNhapLuaCayTrong);
            btnThoat.Controls.Add(label1);
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThoat.Location = new Point(1351, 6);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(556, 864);
            btnThoat.TabIndex = 7;
            btnThoat.TabStop = false;
            btnThoat.Text = "Thông tin phiếu nhập lứa cây trồng";
            // 
            // txtTenCayTrong
            // 
            txtTenCayTrong.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenCayTrong.Location = new Point(255, 92);
            txtTenCayTrong.Name = "txtTenCayTrong";
            txtTenCayTrong.Size = new Size(295, 34);
            txtTenCayTrong.TabIndex = 22;
            // 
            // cbbNhaCungCap
            // 
            cbbNhaCungCap.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbNhaCungCap.FormattingEnabled = true;
            cbbNhaCungCap.Location = new Point(255, 296);
            cbbNhaCungCap.Name = "cbbNhaCungCap";
            cbbNhaCungCap.Size = new Size(295, 36);
            cbbNhaCungCap.TabIndex = 21;
            // 
            // txtGiaNhap
            // 
            txtGiaNhap.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtGiaNhap.Location = new Point(255, 378);
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.Size = new Size(295, 34);
            txtGiaNhap.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(6, 307);
            label9.Name = "label9";
            label9.Size = new Size(132, 25);
            label9.TabIndex = 19;
            label9.Text = "Nhà cung cấp";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(7, 387);
            label8.Name = "label8";
            label8.Size = new Size(97, 25);
            label8.TabIndex = 18;
            label8.Text = "Giá nhập:";
            // 
            // txtNguonGoc
            // 
            txtNguonGoc.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtNguonGoc.Location = new Point(256, 216);
            txtNguonGoc.Name = "txtNguonGoc";
            txtNguonGoc.Size = new Size(295, 34);
            txtNguonGoc.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(7, 225);
            label7.Name = "label7";
            label7.Size = new Size(113, 25);
            label7.TabIndex = 16;
            label7.Text = "Nguồn gốc:";
            // 
            // Frm_NhapLua
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1914, 877);
            Controls.Add(groupBox1);
            Controls.Add(btnThoat);
            Name = "Frm_NhapLua";
            Text = "Frm_NhapLua";
            Load += Frm_NhapLua_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachPhieuNhapLuaCayTrong).EndInit();
            btnThoat.ResumeLayout(false);
            btnThoat.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvDanhSachPhieuNhapLuaCayTrong;
        private TextBox txtSoLuong;
        private ComboBox cbbLoaiCayTrong;
        private DateTimePicker dtpNgayNhap;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtGiong;
        private Label label2;
        private Button btnThoatLnvl;
        private Button btnXoaPhieuNhap;
        private Button btnSuaPhieuNhap;
        private Button btnThemPhieuNhap;
        private TextBox txtMaNhapLuaCayTrong;
        private Label label1;
        private GroupBox btnThoat;
        private Label label9;
        private Label label8;
        private TextBox txtNguonGoc;
        private Label label7;
        private ComboBox cbbNhaCungCap;
        private TextBox txtGiaNhap;
        private TextBox txtTenCayTrong;
    }
}