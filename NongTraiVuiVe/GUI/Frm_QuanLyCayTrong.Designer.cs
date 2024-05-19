namespace NongTraiVuiVe.Quản_Lý
{
    partial class Frm_QuanLyCayTrong
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
            label1 = new Label();
            groupbox2 = new GroupBox();
            cbbKhuVuc = new ComboBox();
            cbbLoaiCayTrong = new ComboBox();
            txtTinhTrang = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtSoLuong = new TextBox();
            label6 = new Label();
            txtNguonGoc = new TextBox();
            label5 = new Label();
            txtGiongCay = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtTenCayTrong = new TextBox();
            label2 = new Label();
            btnThoatCT = new Button();
            btnXoaCayTrong = new Button();
            btnSuaCayTrong = new Button();
            btnThemCayTrong = new Button();
            txtMaCayTrong = new TextBox();
            groupBox1 = new GroupBox();
            dgvDanhSachCayTrong = new DataGridView();
            dtpNgayGieoTrong = new DateTimePicker();
            dtpNgayThuHoachDuKien = new DateTimePicker();
            dtpNgayThuHoachThucTe = new DateTimePicker();
            groupbox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachCayTrong).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(78, 48);
            label1.Name = "label1";
            label1.Size = new Size(119, 22);
            label1.TabIndex = 0;
            label1.Text = "Mã cây trồng:";
            // 
            // groupbox2
            // 
            groupbox2.Controls.Add(dtpNgayThuHoachThucTe);
            groupbox2.Controls.Add(dtpNgayThuHoachDuKien);
            groupbox2.Controls.Add(dtpNgayGieoTrong);
            groupbox2.Controls.Add(cbbKhuVuc);
            groupbox2.Controls.Add(cbbLoaiCayTrong);
            groupbox2.Controls.Add(txtTinhTrang);
            groupbox2.Controls.Add(label11);
            groupbox2.Controls.Add(label10);
            groupbox2.Controls.Add(label9);
            groupbox2.Controls.Add(label8);
            groupbox2.Controls.Add(label7);
            groupbox2.Controls.Add(txtSoLuong);
            groupbox2.Controls.Add(label6);
            groupbox2.Controls.Add(txtNguonGoc);
            groupbox2.Controls.Add(label5);
            groupbox2.Controls.Add(txtGiongCay);
            groupbox2.Controls.Add(label4);
            groupbox2.Controls.Add(label3);
            groupbox2.Controls.Add(txtTenCayTrong);
            groupbox2.Controls.Add(label2);
            groupbox2.Controls.Add(btnThoatCT);
            groupbox2.Controls.Add(btnXoaCayTrong);
            groupbox2.Controls.Add(btnSuaCayTrong);
            groupbox2.Controls.Add(btnThemCayTrong);
            groupbox2.Controls.Add(txtMaCayTrong);
            groupbox2.Controls.Add(label1);
            groupbox2.Location = new Point(798, -4);
            groupbox2.Name = "groupbox2";
            groupbox2.Size = new Size(515, 633);
            groupbox2.TabIndex = 3;
            groupbox2.TabStop = false;
            groupbox2.Text = "Thông tin khu vực";
            // 
            // cbbKhuVuc
            // 
            cbbKhuVuc.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbKhuVuc.FormattingEnabled = true;
            cbbKhuVuc.Location = new Point(213, 370);
            cbbKhuVuc.Name = "cbbKhuVuc";
            cbbKhuVuc.Size = new Size(295, 28);
            cbbKhuVuc.TabIndex = 27;
            // 
            // cbbLoaiCayTrong
            // 
            cbbLoaiCayTrong.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbLoaiCayTrong.FormattingEnabled = true;
            cbbLoaiCayTrong.Location = new Point(213, 114);
            cbbLoaiCayTrong.Name = "cbbLoaiCayTrong";
            cbbLoaiCayTrong.Size = new Size(295, 28);
            cbbLoaiCayTrong.TabIndex = 26;
            // 
            // txtTinhTrang
            // 
            txtTinhTrang.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTinhTrang.Location = new Point(213, 404);
            txtTinhTrang.Name = "txtTinhTrang";
            txtTinhTrang.Size = new Size(295, 30);
            txtTinhTrang.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(101, 407);
            label11.Name = "label11";
            label11.Size = new Size(96, 22);
            label11.TabIndex = 24;
            label11.Text = "Tình trạng:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(114, 376);
            label10.Name = "label10";
            label10.Size = new Size(83, 22);
            label10.TabIndex = 22;
            label10.Text = "Khu vực:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(3, 340);
            label9.Name = "label9";
            label9.Size = new Size(194, 22);
            label9.TabIndex = 20;
            label9.Text = "Ngày thu hoạch thực tế:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(-3, 304);
            label8.Name = "label8";
            label8.Size = new Size(200, 22);
            label8.TabIndex = 18;
            label8.Text = "Ngày thu hoạch dự kiến:";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(56, 263);
            label7.Name = "label7";
            label7.Size = new Size(141, 22);
            label7.TabIndex = 16;
            label7.Text = "Ngày gieo trồng:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoLuong.Location = new Point(213, 224);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(295, 30);
            txtSoLuong.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(109, 227);
            label6.Name = "label6";
            label6.Size = new Size(88, 22);
            label6.TabIndex = 14;
            label6.Text = "Số lượng:";
            // 
            // txtNguonGoc
            // 
            txtNguonGoc.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNguonGoc.Location = new Point(213, 188);
            txtNguonGoc.Name = "txtNguonGoc";
            txtNguonGoc.Size = new Size(295, 30);
            txtNguonGoc.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(97, 196);
            label5.Name = "label5";
            label5.Size = new Size(100, 22);
            label5.TabIndex = 12;
            label5.Text = "Nguồn gốc:";
            // 
            // txtGiongCay
            // 
            txtGiongCay.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtGiongCay.Location = new Point(213, 152);
            txtGiongCay.Name = "txtGiongCay";
            txtGiongCay.Size = new Size(295, 30);
            txtGiongCay.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(101, 160);
            label4.Name = "label4";
            label4.Size = new Size(96, 22);
            label4.TabIndex = 10;
            label4.Text = "Giống cây:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(65, 120);
            label3.Name = "label3";
            label3.Size = new Size(129, 22);
            label3.TabIndex = 8;
            label3.Text = "Loại cây trồng:";
            // 
            // txtTenCayTrong
            // 
            txtTenCayTrong.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenCayTrong.Location = new Point(213, 76);
            txtTenCayTrong.Name = "txtTenCayTrong";
            txtTenCayTrong.Size = new Size(295, 30);
            txtTenCayTrong.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(74, 84);
            label2.Name = "label2";
            label2.Size = new Size(123, 22);
            label2.TabIndex = 6;
            label2.Text = "Tên cây trồng:";
            // 
            // btnThoatCT
            // 
            btnThoatCT.Dock = DockStyle.Bottom;
            btnThoatCT.Location = new Point(3, 601);
            btnThoatCT.Name = "btnThoatCT";
            btnThoatCT.Size = new Size(509, 29);
            btnThoatCT.TabIndex = 5;
            btnThoatCT.Text = "Thoát";
            btnThoatCT.UseVisualStyleBackColor = true;
            btnThoatCT.Click += btnThoatCT_Click;
            // 
            // btnXoaCayTrong
            // 
            btnXoaCayTrong.Location = new Point(414, 539);
            btnXoaCayTrong.Name = "btnXoaCayTrong";
            btnXoaCayTrong.Size = new Size(94, 29);
            btnXoaCayTrong.TabIndex = 4;
            btnXoaCayTrong.Text = "Xóa";
            btnXoaCayTrong.UseVisualStyleBackColor = true;
            btnXoaCayTrong.Click += btnXoaCayTrong_Click;
            // 
            // btnSuaCayTrong
            // 
            btnSuaCayTrong.Location = new Point(251, 539);
            btnSuaCayTrong.Name = "btnSuaCayTrong";
            btnSuaCayTrong.Size = new Size(94, 29);
            btnSuaCayTrong.TabIndex = 3;
            btnSuaCayTrong.Text = "Sửa";
            btnSuaCayTrong.UseVisualStyleBackColor = true;
            btnSuaCayTrong.Click += btnSuaCayTrong_Click;
            // 
            // btnThemCayTrong
            // 
            btnThemCayTrong.Location = new Point(65, 539);
            btnThemCayTrong.Name = "btnThemCayTrong";
            btnThemCayTrong.Size = new Size(94, 29);
            btnThemCayTrong.TabIndex = 2;
            btnThemCayTrong.Text = "Thêm ";
            btnThemCayTrong.UseVisualStyleBackColor = true;
            btnThemCayTrong.Click += btnThemCayTrong_Click;
            // 
            // txtMaCayTrong
            // 
            txtMaCayTrong.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaCayTrong.Location = new Point(213, 40);
            txtMaCayTrong.Name = "txtMaCayTrong";
            txtMaCayTrong.ReadOnly = true;
            txtMaCayTrong.Size = new Size(295, 30);
            txtMaCayTrong.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvDanhSachCayTrong);
            groupBox1.Location = new Point(5, -4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(787, 633);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách khu vực";
            // 
            // dgvDanhSachCayTrong
            // 
            dgvDanhSachCayTrong.AllowUserToAddRows = false;
            dgvDanhSachCayTrong.AllowUserToDeleteRows = false;
            dgvDanhSachCayTrong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachCayTrong.Dock = DockStyle.Fill;
            dgvDanhSachCayTrong.Location = new Point(3, 23);
            dgvDanhSachCayTrong.Name = "dgvDanhSachCayTrong";
            dgvDanhSachCayTrong.ReadOnly = true;
            dgvDanhSachCayTrong.RowHeadersWidth = 51;
            dgvDanhSachCayTrong.RowTemplate.Height = 29;
            dgvDanhSachCayTrong.Size = new Size(781, 607);
            dgvDanhSachCayTrong.TabIndex = 0;
            dgvDanhSachCayTrong.CellClick += dgvDanhSachCayTrong_CellClick;
            // 
            // dtpNgayGieoTrong
            // 
            dtpNgayGieoTrong.Format = DateTimePickerFormat.Short;
            dtpNgayGieoTrong.Location = new Point(213, 260);
            dtpNgayGieoTrong.Name = "dtpNgayGieoTrong";
            dtpNgayGieoTrong.Size = new Size(295, 27);
            dtpNgayGieoTrong.TabIndex = 28;
            // 
            // dtpNgayThuHoachDuKien
            // 
            dtpNgayThuHoachDuKien.Format = DateTimePickerFormat.Short;
            dtpNgayThuHoachDuKien.Location = new Point(213, 299);
            dtpNgayThuHoachDuKien.Name = "dtpNgayThuHoachDuKien";
            dtpNgayThuHoachDuKien.Size = new Size(295, 27);
            dtpNgayThuHoachDuKien.TabIndex = 29;
            // 
            // dtpNgayThuHoachThucTe
            // 
            dtpNgayThuHoachThucTe.Format = DateTimePickerFormat.Short;
            dtpNgayThuHoachThucTe.Location = new Point(213, 335);
            dtpNgayThuHoachThucTe.Name = "dtpNgayThuHoachThucTe";
            dtpNgayThuHoachThucTe.Size = new Size(295, 27);
            dtpNgayThuHoachThucTe.TabIndex = 30;
            // 
            // Frm_QuanLyCayTrong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 625);
            Controls.Add(groupbox2);
            Controls.Add(groupBox1);
            Name = "Frm_QuanLyCayTrong";
            Text = "Frm_QuanLyCayTrong";
            Load += Frm_QuanLyCayTrong_Load;
            groupbox2.ResumeLayout(false);
            groupbox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachCayTrong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupbox2;
        private Label label3;
        private TextBox txtTenCayTrong;
        private Label label2;
        private Button btnThoatCT;
        private Button btnXoaCayTrong;
        private Button btnSuaCayTrong;
        private Button btnThemCayTrong;
        private TextBox txtMaCayTrong;
        private GroupBox groupBox1;
        private DataGridView dgvDanhSachCayTrong;
        private TextBox txtTinhTrang;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtSoLuong;
        private Label label6;
        private TextBox txtNguonGoc;
        private Label label5;
        private TextBox txtGiongCay;
        private Label label4;
        private ComboBox cbbKhuVuc;
        private ComboBox cbbLoaiCayTrong;
        private DateTimePicker dtpNgayThuHoachThucTe;
        private DateTimePicker dtpNgayThuHoachDuKien;
        private DateTimePicker dtpNgayGieoTrong;
    }
}