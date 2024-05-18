namespace NongTraiVuiVe.Quản_Lý
{
    partial class Frm_QuanLyKhachHang
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
            txtNgaySinhKhachHang = new TextBox();
            label5 = new Label();
            txtSoDienThoaiKhachHang = new TextBox();
            label4 = new Label();
            txtDiaChiKhachHang = new TextBox();
            label3 = new Label();
            txtTenKhachHang = new TextBox();
            label2 = new Label();
            btnThoatKhachHang = new Button();
            btnXoaKhachHang = new Button();
            btnSuaKhachHang = new Button();
            btnThemKhachHang = new Button();
            txtMaKhachHang = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dgvDanhSachKhachHang = new DataGridView();
            label6 = new Label();
            txtEmailKhachHang = new TextBox();
            gpKh.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachKhachHang).BeginInit();
            SuspendLayout();
            // 
            // gpKh
            // 
            gpKh.Controls.Add(txtEmailKhachHang);
            gpKh.Controls.Add(label6);
            gpKh.Controls.Add(txtNgaySinhKhachHang);
            gpKh.Controls.Add(label5);
            gpKh.Controls.Add(txtSoDienThoaiKhachHang);
            gpKh.Controls.Add(label4);
            gpKh.Controls.Add(txtDiaChiKhachHang);
            gpKh.Controls.Add(label3);
            gpKh.Controls.Add(txtTenKhachHang);
            gpKh.Controls.Add(label2);
            gpKh.Controls.Add(btnThoatKhachHang);
            gpKh.Controls.Add(btnXoaKhachHang);
            gpKh.Controls.Add(btnSuaKhachHang);
            gpKh.Controls.Add(btnThemKhachHang);
            gpKh.Controls.Add(txtMaKhachHang);
            gpKh.Controls.Add(label1);
            gpKh.Location = new Point(833, 5);
            gpKh.Name = "gpKh";
            gpKh.Size = new Size(481, 614);
            gpKh.TabIndex = 7;
            gpKh.TabStop = false;
            gpKh.Text = "Thông tin kho hàng";
            // 
            // txtNgaySinhKhachHang
            // 
            txtNgaySinhKhachHang.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNgaySinhKhachHang.Location = new Point(180, 409);
            txtNgaySinhKhachHang.Name = "txtNgaySinhKhachHang";
            txtNgaySinhKhachHang.Size = new Size(295, 30);
            txtNgaySinhKhachHang.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(68, 417);
            label5.Name = "label5";
            label5.Size = new Size(94, 22);
            label5.TabIndex = 12;
            label5.Text = "Ngày sinh:";
            // 
            // txtSoDienThoaiKhachHang
            // 
            txtSoDienThoaiKhachHang.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoDienThoaiKhachHang.Location = new Point(180, 288);
            txtSoDienThoaiKhachHang.Name = "txtSoDienThoaiKhachHang";
            txtSoDienThoaiKhachHang.Size = new Size(295, 30);
            txtSoDienThoaiKhachHang.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(38, 296);
            label4.Name = "label4";
            label4.Size = new Size(120, 22);
            label4.TabIndex = 10;
            label4.Text = "Số điện thoại:";
            // 
            // txtDiaChiKhachHang
            // 
            txtDiaChiKhachHang.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiaChiKhachHang.Location = new Point(180, 236);
            txtDiaChiKhachHang.Name = "txtDiaChiKhachHang";
            txtDiaChiKhachHang.Size = new Size(295, 30);
            txtDiaChiKhachHang.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(84, 244);
            label3.Name = "label3";
            label3.Size = new Size(74, 22);
            label3.TabIndex = 8;
            label3.Text = "Địa chỉ:";
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenKhachHang.Location = new Point(180, 148);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(295, 30);
            txtTenKhachHang.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 156);
            label2.Name = "label2";
            label2.Size = new Size(137, 22);
            label2.TabIndex = 6;
            label2.Text = "Tên khách hàng:";
            // 
            // btnThoatKhachHang
            // 
            btnThoatKhachHang.Dock = DockStyle.Bottom;
            btnThoatKhachHang.Location = new Point(3, 582);
            btnThoatKhachHang.Name = "btnThoatKhachHang";
            btnThoatKhachHang.Size = new Size(475, 29);
            btnThoatKhachHang.TabIndex = 5;
            btnThoatKhachHang.Text = "Thoát";
            btnThoatKhachHang.UseVisualStyleBackColor = true;
            btnThoatKhachHang.Click += btnThoatKhachHang_Click;
            // 
            // btnXoaKhachHang
            // 
            btnXoaKhachHang.Location = new Point(387, 495);
            btnXoaKhachHang.Name = "btnXoaKhachHang";
            btnXoaKhachHang.Size = new Size(94, 29);
            btnXoaKhachHang.TabIndex = 4;
            btnXoaKhachHang.Text = "Xóa";
            btnXoaKhachHang.UseVisualStyleBackColor = true;
            btnXoaKhachHang.Click += btnXoaKhachHang_Click;
            // 
            // btnSuaKhachHang
            // 
            btnSuaKhachHang.Location = new Point(217, 495);
            btnSuaKhachHang.Name = "btnSuaKhachHang";
            btnSuaKhachHang.Size = new Size(94, 29);
            btnSuaKhachHang.TabIndex = 3;
            btnSuaKhachHang.Text = "Sửa";
            btnSuaKhachHang.UseVisualStyleBackColor = true;
            btnSuaKhachHang.Click += btnSuaKhachHang_Click;
            // 
            // btnThemKhachHang
            // 
            btnThemKhachHang.Location = new Point(48, 495);
            btnThemKhachHang.Name = "btnThemKhachHang";
            btnThemKhachHang.Size = new Size(94, 29);
            btnThemKhachHang.TabIndex = 2;
            btnThemKhachHang.Text = "Thêm ";
            btnThemKhachHang.UseVisualStyleBackColor = true;
            btnThemKhachHang.Click += btnThemKhachHang_Click;
            // 
            // txtMaKhachHang
            // 
            txtMaKhachHang.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaKhachHang.Location = new Point(180, 68);
            txtMaKhachHang.Name = "txtMaKhachHang";
            txtMaKhachHang.ReadOnly = true;
            txtMaKhachHang.Size = new Size(295, 30);
            txtMaKhachHang.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 76);
            label1.Name = "label1";
            label1.Size = new Size(133, 22);
            label1.TabIndex = 0;
            label1.Text = "Mã khách hàng:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvDanhSachKhachHang);
            groupBox1.Location = new Point(6, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(821, 614);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách kho hàng";
            // 
            // dgvDanhSachKhachHang
            // 
            dgvDanhSachKhachHang.AllowUserToAddRows = false;
            dgvDanhSachKhachHang.AllowUserToDeleteRows = false;
            dgvDanhSachKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachKhachHang.Dock = DockStyle.Fill;
            dgvDanhSachKhachHang.Location = new Point(3, 23);
            dgvDanhSachKhachHang.Name = "dgvDanhSachKhachHang";
            dgvDanhSachKhachHang.ReadOnly = true;
            dgvDanhSachKhachHang.RowHeadersWidth = 51;
            dgvDanhSachKhachHang.RowTemplate.Height = 29;
            dgvDanhSachKhachHang.Size = new Size(815, 588);
            dgvDanhSachKhachHang.TabIndex = 0;
            dgvDanhSachKhachHang.CellClick += dgvDanhSachKhachHang_CellClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(38, 355);
            label6.Name = "label6";
            label6.Size = new Size(63, 22);
            label6.TabIndex = 14;
            label6.Text = "Email:";
            // 
            // txtEmailKhachHang
            // 
            txtEmailKhachHang.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmailKhachHang.Location = new Point(180, 347);
            txtEmailKhachHang.Name = "txtEmailKhachHang";
            txtEmailKhachHang.Size = new Size(295, 30);
            txtEmailKhachHang.TabIndex = 15;
            // 
            // Frm_QuanLyKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1321, 625);
            Controls.Add(gpKh);
            Controls.Add(groupBox1);
            Name = "Frm_QuanLyKhachHang";
            Text = "Frm_QuanLyKhachHang";
            Load += Frm_QuanLyKhachHang_Load;
            gpKh.ResumeLayout(false);
            gpKh.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachKhachHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpKh;
        private TextBox txtSoDienThoaiKhachHang;
        private Label label4;
        private TextBox txtDiaChiKhachHang;
        private Label label3;
        private TextBox txtTenKhachHang;
        private Label label2;
        private Button btnThoatKhachHang;
        private Button btnXoaKhachHang;
        private Button btnSuaKhachHang;
        private Button btnThemKhachHang;
        private TextBox txtMaKhachHang;
        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dgvDanhSachKhachHang;
        private TextBox txtNgaySinhKhachHang;
        private Label label5;
        private TextBox txtEmailKhachHang;
        private Label label6;
    }
}