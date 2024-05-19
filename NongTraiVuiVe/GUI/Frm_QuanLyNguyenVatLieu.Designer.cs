namespace NongTraiVuiVe.Quản_Lý
{
    partial class Frm_QuanLyNguyenVatLieu
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
            gbnvl = new GroupBox();
            txtSoLuongHong = new TextBox();
            label8 = new Label();
            cbbTinhTrang = new ComboBox();
            label7 = new Label();
            cbbKhoChua = new ComboBox();
            cbbLoaiNguyenVatLieu = new ComboBox();
            txtHanSuDung = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtSoLuong = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtTenNguyenVatLieu = new TextBox();
            label2 = new Label();
            btnThoatNvl = new Button();
            btnXoaNguyenVatLieu = new Button();
            btnSuaNguyenVatLieu = new Button();
            btnThemNguyenVatLieu = new Button();
            txtMaNguyenVatLieu = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dgvDanhSachNguyenVatLieu = new DataGridView();
            gbnvl.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNguyenVatLieu).BeginInit();
            SuspendLayout();
            // 
            // gbnvl
            // 
            gbnvl.Controls.Add(txtSoLuongHong);
            gbnvl.Controls.Add(label8);
            gbnvl.Controls.Add(cbbTinhTrang);
            gbnvl.Controls.Add(label7);
            gbnvl.Controls.Add(cbbKhoChua);
            gbnvl.Controls.Add(cbbLoaiNguyenVatLieu);
            gbnvl.Controls.Add(txtHanSuDung);
            gbnvl.Controls.Add(label5);
            gbnvl.Controls.Add(label6);
            gbnvl.Controls.Add(txtSoLuong);
            gbnvl.Controls.Add(label3);
            gbnvl.Controls.Add(label4);
            gbnvl.Controls.Add(txtTenNguyenVatLieu);
            gbnvl.Controls.Add(label2);
            gbnvl.Controls.Add(btnThoatNvl);
            gbnvl.Controls.Add(btnXoaNguyenVatLieu);
            gbnvl.Controls.Add(btnSuaNguyenVatLieu);
            gbnvl.Controls.Add(btnThemNguyenVatLieu);
            gbnvl.Controls.Add(txtMaNguyenVatLieu);
            gbnvl.Controls.Add(label1);
            gbnvl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbnvl.Location = new Point(1349, 10);
            gbnvl.Name = "gbnvl";
            gbnvl.Size = new Size(563, 855);
            gbnvl.TabIndex = 7;
            gbnvl.TabStop = false;
            gbnvl.Text = "Thông tin nguyên vật liệu";
            // 
            // txtSoLuongHong
            // 
            txtSoLuongHong.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoLuongHong.Location = new Point(258, 563);
            txtSoLuongHong.Name = "txtSoLuongHong";
            txtSoLuongHong.Size = new Size(295, 34);
            txtSoLuongHong.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(91, 572);
            label8.Name = "label8";
            label8.Size = new Size(144, 25);
            label8.TabIndex = 20;
            label8.Text = "Số lượng hỏng:";
            // 
            // cbbTinhTrang
            // 
            cbbTinhTrang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTinhTrang.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbbTinhTrang.FormattingEnabled = true;
            cbbTinhTrang.Items.AddRange(new object[] { "Còn sử dụng", "Hỏng" });
            cbbTinhTrang.Location = new Point(258, 489);
            cbbTinhTrang.Name = "cbbTinhTrang";
            cbbTinhTrang.Size = new Size(295, 37);
            cbbTinhTrang.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(128, 501);
            label7.Name = "label7";
            label7.Size = new Size(107, 25);
            label7.TabIndex = 18;
            label7.Text = "Tình trạng:";
            // 
            // cbbKhoChua
            // 
            cbbKhoChua.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbKhoChua.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbbKhoChua.FormattingEnabled = true;
            cbbKhoChua.Location = new Point(257, 353);
            cbbKhoChua.Name = "cbbKhoChua";
            cbbKhoChua.Size = new Size(295, 37);
            cbbKhoChua.TabIndex = 17;
            // 
            // cbbLoaiNguyenVatLieu
            // 
            cbbLoaiNguyenVatLieu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbLoaiNguyenVatLieu.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbbLoaiNguyenVatLieu.FormattingEnabled = true;
            cbbLoaiNguyenVatLieu.Location = new Point(257, 214);
            cbbLoaiNguyenVatLieu.Name = "cbbLoaiNguyenVatLieu";
            cbbLoaiNguyenVatLieu.Size = new Size(295, 37);
            cbbLoaiNguyenVatLieu.TabIndex = 16;
            // 
            // txtHanSuDung
            // 
            txtHanSuDung.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtHanSuDung.Location = new Point(257, 425);
            txtHanSuDung.Name = "txtHanSuDung";
            txtHanSuDung.Size = new Size(295, 34);
            txtHanSuDung.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(107, 434);
            label5.Name = "label5";
            label5.Size = new Size(128, 25);
            label5.TabIndex = 14;
            label5.Text = "Hạn sử dụng:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(133, 365);
            label6.Name = "label6";
            label6.Size = new Size(102, 25);
            label6.TabIndex = 12;
            label6.Text = "Kho chứa:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoLuong.Location = new Point(257, 285);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(295, 34);
            txtSoLuong.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(138, 294);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 10;
            label3.Text = "Số lượng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(38, 226);
            label4.Name = "label4";
            label4.Size = new Size(197, 25);
            label4.TabIndex = 8;
            label4.Text = "Loại nguyên vật liệu:";
            // 
            // txtTenNguyenVatLieu
            // 
            txtTenNguyenVatLieu.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenNguyenVatLieu.Location = new Point(257, 147);
            txtTenNguyenVatLieu.Name = "txtTenNguyenVatLieu";
            txtTenNguyenVatLieu.Size = new Size(295, 34);
            txtTenNguyenVatLieu.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(43, 156);
            label2.Name = "label2";
            label2.Size = new Size(192, 25);
            label2.TabIndex = 6;
            label2.Text = "Tên nguyên vật liệu:";
            // 
            // btnThoatNvl
            // 
            btnThoatNvl.Dock = DockStyle.Bottom;
            btnThoatNvl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThoatNvl.Location = new Point(3, 811);
            btnThoatNvl.Name = "btnThoatNvl";
            btnThoatNvl.Size = new Size(557, 41);
            btnThoatNvl.TabIndex = 5;
            btnThoatNvl.Text = "Thoát";
            btnThoatNvl.UseVisualStyleBackColor = true;
            btnThoatNvl.Click += btnThoatNvl_Click;
            // 
            // btnXoaNguyenVatLieu
            // 
            btnXoaNguyenVatLieu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoaNguyenVatLieu.Location = new Point(453, 674);
            btnXoaNguyenVatLieu.Name = "btnXoaNguyenVatLieu";
            btnXoaNguyenVatLieu.Size = new Size(107, 42);
            btnXoaNguyenVatLieu.TabIndex = 4;
            btnXoaNguyenVatLieu.Text = "Xóa";
            btnXoaNguyenVatLieu.UseVisualStyleBackColor = true;
            btnXoaNguyenVatLieu.Click += btnXoaNguyenVatLieu_Click;
            // 
            // btnSuaNguyenVatLieu
            // 
            btnSuaNguyenVatLieu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSuaNguyenVatLieu.Location = new Point(269, 674);
            btnSuaNguyenVatLieu.Name = "btnSuaNguyenVatLieu";
            btnSuaNguyenVatLieu.Size = new Size(107, 42);
            btnSuaNguyenVatLieu.TabIndex = 3;
            btnSuaNguyenVatLieu.Text = "Sửa";
            btnSuaNguyenVatLieu.UseVisualStyleBackColor = true;
            btnSuaNguyenVatLieu.Click += btnSuaNguyenVatLieu_Click;
            // 
            // btnThemNguyenVatLieu
            // 
            btnThemNguyenVatLieu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThemNguyenVatLieu.Location = new Point(84, 674);
            btnThemNguyenVatLieu.Name = "btnThemNguyenVatLieu";
            btnThemNguyenVatLieu.Size = new Size(107, 42);
            btnThemNguyenVatLieu.TabIndex = 2;
            btnThemNguyenVatLieu.Text = "Thêm ";
            btnThemNguyenVatLieu.UseVisualStyleBackColor = true;
            btnThemNguyenVatLieu.Click += btnThemNguyenVatLieu_Click;
            // 
            // txtMaNguyenVatLieu
            // 
            txtMaNguyenVatLieu.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaNguyenVatLieu.Location = new Point(257, 78);
            txtMaNguyenVatLieu.Name = "txtMaNguyenVatLieu";
            txtMaNguyenVatLieu.ReadOnly = true;
            txtMaNguyenVatLieu.Size = new Size(295, 34);
            txtMaNguyenVatLieu.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(48, 87);
            label1.Name = "label1";
            label1.Size = new Size(187, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã nguyên vật liệu:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvDanhSachNguyenVatLieu);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(5, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1341, 852);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách nguyên vật liệu";
            // 
            // dgvDanhSachNguyenVatLieu
            // 
            dgvDanhSachNguyenVatLieu.AllowUserToAddRows = false;
            dgvDanhSachNguyenVatLieu.AllowUserToDeleteRows = false;
            dgvDanhSachNguyenVatLieu.BackgroundColor = Color.Honeydew;
            dgvDanhSachNguyenVatLieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachNguyenVatLieu.Dock = DockStyle.Fill;
            dgvDanhSachNguyenVatLieu.Location = new Point(3, 30);
            dgvDanhSachNguyenVatLieu.Name = "dgvDanhSachNguyenVatLieu";
            dgvDanhSachNguyenVatLieu.ReadOnly = true;
            dgvDanhSachNguyenVatLieu.RowHeadersWidth = 51;
            dgvDanhSachNguyenVatLieu.RowTemplate.Height = 29;
            dgvDanhSachNguyenVatLieu.Size = new Size(1335, 819);
            dgvDanhSachNguyenVatLieu.TabIndex = 0;
            dgvDanhSachNguyenVatLieu.CellClick += dgvDanhSachNguyenVatLieu_CellClick;
            // 
            // Frm_QuanLyNguyenVatLieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1914, 877);
            Controls.Add(gbnvl);
            Controls.Add(groupBox1);
            Name = "Frm_QuanLyNguyenVatLieu";
            Text = "Frm_QuanLyNguyenVatLieu";
            Load += Frm_QuanLyNguyenVatLieu_Load;
            gbnvl.ResumeLayout(false);
            gbnvl.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNguyenVatLieu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbnvl;
        private TextBox txtSoLuong;
        private Label label3;
        private Label label4;
        private TextBox txtTenNguyenVatLieu;
        private Label label2;
        private Button btnThoatNvl;
        private Button btnXoaNguyenVatLieu;
        private Button btnSuaNguyenVatLieu;
        private Button btnThemNguyenVatLieu;
        private TextBox txtMaNguyenVatLieu;
        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dgvDanhSachNguyenVatLieu;
        private TextBox txtHanSuDung;
        private Label label5;
        private Label label6;
        private ComboBox cbbKhoChua;
        private ComboBox cbbLoaiNguyenVatLieu;
        private TextBox txtSoLuongHong;
        private Label label8;
        private ComboBox cbbTinhTrang;
        private Label label7;
    }
}