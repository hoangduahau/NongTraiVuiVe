namespace NongTraiVuiVe.Quản_Lý
{
    partial class Frm_QuanLyChiTieu
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
            btnThoat = new GroupBox();
            txtMaNguoiThucHien = new TextBox();
            cbbNguoiThucHien = new ComboBox();
            dtpNgayChiTieu = new DateTimePicker();
            cbbLoaiChiTieu = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtChiPhi = new TextBox();
            label2 = new Label();
            btnThoatLnvl = new Button();
            btnXoaChiTieu = new Button();
            btnSuaChiTieu = new Button();
            btnThemChiTieu = new Button();
            txtMaChiTieu = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dgvDanhSachChiTieu = new DataGridView();
            btnThoat.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachChiTieu).BeginInit();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.Controls.Add(txtMaNguoiThucHien);
            btnThoat.Controls.Add(cbbNguoiThucHien);
            btnThoat.Controls.Add(dtpNgayChiTieu);
            btnThoat.Controls.Add(cbbLoaiChiTieu);
            btnThoat.Controls.Add(label6);
            btnThoat.Controls.Add(label5);
            btnThoat.Controls.Add(label4);
            btnThoat.Controls.Add(label3);
            btnThoat.Controls.Add(txtChiPhi);
            btnThoat.Controls.Add(label2);
            btnThoat.Controls.Add(btnThoatLnvl);
            btnThoat.Controls.Add(btnXoaChiTieu);
            btnThoat.Controls.Add(btnSuaChiTieu);
            btnThoat.Controls.Add(btnThemChiTieu);
            btnThoat.Controls.Add(txtMaChiTieu);
            btnThoat.Controls.Add(label1);
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThoat.Location = new Point(1352, 1);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(556, 864);
            btnThoat.TabIndex = 5;
            btnThoat.TabStop = false;
            btnThoat.Text = "Thông tin hoạt động chi tiêu";
            // 
            // txtMaNguoiThucHien
            // 
            txtMaNguoiThucHien.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaNguoiThucHien.Location = new Point(255, 420);
            txtMaNguoiThucHien.Name = "txtMaNguoiThucHien";
            txtMaNguoiThucHien.ReadOnly = true;
            txtMaNguoiThucHien.Size = new Size(295, 34);
            txtMaNguoiThucHien.TabIndex = 15;
            // 
            // cbbNguoiThucHien
            // 
            cbbNguoiThucHien.FormattingEnabled = true;
            cbbNguoiThucHien.Location = new Point(255, 355);
            cbbNguoiThucHien.Name = "cbbNguoiThucHien";
            cbbNguoiThucHien.Size = new Size(295, 36);
            cbbNguoiThucHien.TabIndex = 14;
            cbbNguoiThucHien.SelectedIndexChanged += cbbNguoiThucHien_SelectedIndexChanged;
            // 
            // dtpNgayChiTieu
            // 
            dtpNgayChiTieu.Format = DateTimePickerFormat.Short;
            dtpNgayChiTieu.Location = new Point(255, 290);
            dtpNgayChiTieu.Name = "dtpNgayChiTieu";
            dtpNgayChiTieu.Size = new Size(295, 34);
            dtpNgayChiTieu.TabIndex = 13;
            // 
            // cbbLoaiChiTieu
            // 
            cbbLoaiChiTieu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbLoaiChiTieu.FormattingEnabled = true;
            cbbLoaiChiTieu.Items.AddRange(new object[] { "Nhập giống cây trồng", "Nhập nguyên vật liệu", "Mua thiết bị mới", "Mua vật liệu xây dựng", "Chi phí sửa chữa", "Chi phí bảo dưỡng", "Chi phí marketing", "Chi phí quảng cáo", "Chi phí thuê nhân công", "Các loại chi phí khác" });
            cbbLoaiChiTieu.Location = new Point(255, 153);
            cbbLoaiChiTieu.Name = "cbbLoaiChiTieu";
            cbbLoaiChiTieu.Size = new Size(295, 36);
            cbbLoaiChiTieu.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(20, 429);
            label6.Name = "label6";
            label6.Size = new Size(189, 25);
            label6.TabIndex = 11;
            label6.Text = "Mã người thực hiện:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(15, 366);
            label5.Name = "label5";
            label5.Size = new Size(194, 25);
            label5.TabIndex = 10;
            label5.Text = "Tên người thực hiện:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(15, 299);
            label4.Name = "label4";
            label4.Size = new Size(136, 25);
            label4.TabIndex = 9;
            label4.Text = "Ngày chi tiêu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(15, 233);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 8;
            label3.Text = "Chi phí:";
            // 
            // txtChiPhi
            // 
            txtChiPhi.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtChiPhi.Location = new Point(255, 224);
            txtChiPhi.Name = "txtChiPhi";
            txtChiPhi.Size = new Size(295, 34);
            txtChiPhi.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 164);
            label2.Name = "label2";
            label2.Size = new Size(128, 25);
            label2.TabIndex = 6;
            label2.Text = "Loại chi tiêu:";
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
            // btnXoaChiTieu
            // 
            btnXoaChiTieu.Location = new Point(405, 608);
            btnXoaChiTieu.Name = "btnXoaChiTieu";
            btnXoaChiTieu.Size = new Size(104, 34);
            btnXoaChiTieu.TabIndex = 4;
            btnXoaChiTieu.Text = "Xóa";
            btnXoaChiTieu.UseVisualStyleBackColor = true;
            btnXoaChiTieu.Click += btnXoaChiTieu_Click;
            // 
            // btnSuaChiTieu
            // 
            btnSuaChiTieu.Location = new Point(245, 608);
            btnSuaChiTieu.Name = "btnSuaChiTieu";
            btnSuaChiTieu.Size = new Size(104, 34);
            btnSuaChiTieu.TabIndex = 3;
            btnSuaChiTieu.Text = "Sửa";
            btnSuaChiTieu.UseVisualStyleBackColor = true;
            btnSuaChiTieu.Click += btnSuaChiTieu_Click;
            // 
            // btnThemChiTieu
            // 
            btnThemChiTieu.Location = new Point(75, 608);
            btnThemChiTieu.Name = "btnThemChiTieu";
            btnThemChiTieu.Size = new Size(104, 34);
            btnThemChiTieu.TabIndex = 2;
            btnThemChiTieu.Text = "Thêm ";
            btnThemChiTieu.UseVisualStyleBackColor = true;
            btnThemChiTieu.Click += btnThemChiTieu_Click;
            // 
            // txtMaChiTieu
            // 
            txtMaChiTieu.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaChiTieu.Location = new Point(255, 85);
            txtMaChiTieu.Name = "txtMaChiTieu";
            txtMaChiTieu.ReadOnly = true;
            txtMaChiTieu.Size = new Size(295, 34);
            txtMaChiTieu.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 94);
            label1.Name = "label1";
            label1.Size = new Size(118, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã chi tiêu:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvDanhSachChiTieu);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(8, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1341, 864);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách hoạt động chi tiêu";
            // 
            // dgvDanhSachChiTieu
            // 
            dgvDanhSachChiTieu.AllowUserToAddRows = false;
            dgvDanhSachChiTieu.AllowUserToDeleteRows = false;
            dgvDanhSachChiTieu.BackgroundColor = Color.Honeydew;
            dgvDanhSachChiTieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachChiTieu.Dock = DockStyle.Fill;
            dgvDanhSachChiTieu.GridColor = Color.Honeydew;
            dgvDanhSachChiTieu.Location = new Point(3, 30);
            dgvDanhSachChiTieu.Name = "dgvDanhSachChiTieu";
            dgvDanhSachChiTieu.ReadOnly = true;
            dgvDanhSachChiTieu.RowHeadersWidth = 51;
            dgvDanhSachChiTieu.RowTemplate.Height = 29;
            dgvDanhSachChiTieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachChiTieu.Size = new Size(1335, 831);
            dgvDanhSachChiTieu.TabIndex = 0;
            dgvDanhSachChiTieu.CellClick += dgvDanhSachChiTieu_CellClick;
            // 
            // Frm_QuanLyChiTieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1914, 877);
            Controls.Add(btnThoat);
            Controls.Add(groupBox1);
            Name = "Frm_QuanLyChiTieu";
            Text = "Frm_QuanLyLoaiNguyenVatLieu";
            Load += Frm_QuanLyChiTieu_Load;
            btnThoat.ResumeLayout(false);
            btnThoat.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachChiTieu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox btnThoat;
        private TextBox txtMaNguoiThucHien;
        private Label label3;
        private TextBox txtChiPhi;
        private Label label2;
        private Button btnThoatLnvl;
        private Button btnXoaChiTieu;
        private Button btnSuaChiTieu;
        private Button btnThemChiTieu;
        private TextBox txtMaChiTieu;
        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dgvDanhSachChiTieu;
        private ComboBox cbbLoaiChiTieu;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox cbbNguoiThucHien;
        private DateTimePicker dtpNgayChiTieu;
    }
}