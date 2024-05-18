namespace NongTraiVuiVe.GUI
{
    partial class Frm_QuanLyNhaCungCap
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
            dgvDanhSachNhaCungCap = new DataGridView();
            txtEmailNhaCungCap = new TextBox();
            label6 = new Label();
            txtSoDienThoaiNhaCungCap = new TextBox();
            label4 = new Label();
            txtDiaChiNhaCungCap = new TextBox();
            label3 = new Label();
            txtTenNhaCungCap = new TextBox();
            label2 = new Label();
            btnThoatKhachHang = new Button();
            btnXoaNhaCungCap = new Button();
            btnSuaNhaCungCap = new Button();
            btnThemNhaCungCap = new Button();
            txtMaNhaCungCap = new TextBox();
            label1 = new Label();
            gpKh = new GroupBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNhaCungCap).BeginInit();
            gpKh.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDanhSachNhaCungCap
            // 
            dgvDanhSachNhaCungCap.AllowUserToAddRows = false;
            dgvDanhSachNhaCungCap.AllowUserToDeleteRows = false;
            dgvDanhSachNhaCungCap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachNhaCungCap.Dock = DockStyle.Fill;
            dgvDanhSachNhaCungCap.Location = new Point(3, 23);
            dgvDanhSachNhaCungCap.Name = "dgvDanhSachNhaCungCap";
            dgvDanhSachNhaCungCap.ReadOnly = true;
            dgvDanhSachNhaCungCap.RowHeadersWidth = 51;
            dgvDanhSachNhaCungCap.RowTemplate.Height = 29;
            dgvDanhSachNhaCungCap.Size = new Size(815, 588);
            dgvDanhSachNhaCungCap.TabIndex = 0;
            dgvDanhSachNhaCungCap.CellClick += dgvDanhSachNhaCungCap_CellClick;
            // 
            // txtEmailNhaCungCap
            // 
            txtEmailNhaCungCap.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmailNhaCungCap.Location = new Point(180, 347);
            txtEmailNhaCungCap.Name = "txtEmailNhaCungCap";
            txtEmailNhaCungCap.Size = new Size(295, 30);
            txtEmailNhaCungCap.TabIndex = 15;
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
            // txtSoDienThoaiNhaCungCap
            // 
            txtSoDienThoaiNhaCungCap.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoDienThoaiNhaCungCap.Location = new Point(180, 288);
            txtSoDienThoaiNhaCungCap.Name = "txtSoDienThoaiNhaCungCap";
            txtSoDienThoaiNhaCungCap.Size = new Size(295, 30);
            txtSoDienThoaiNhaCungCap.TabIndex = 11;
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
            // txtDiaChiNhaCungCap
            // 
            txtDiaChiNhaCungCap.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiaChiNhaCungCap.Location = new Point(180, 236);
            txtDiaChiNhaCungCap.Name = "txtDiaChiNhaCungCap";
            txtDiaChiNhaCungCap.Size = new Size(295, 30);
            txtDiaChiNhaCungCap.TabIndex = 9;
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
            // txtTenNhaCungCap
            // 
            txtTenNhaCungCap.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenNhaCungCap.Location = new Point(180, 148);
            txtTenNhaCungCap.Name = "txtTenNhaCungCap";
            txtTenNhaCungCap.Size = new Size(295, 30);
            txtTenNhaCungCap.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 156);
            label2.Name = "label2";
            label2.Size = new Size(152, 22);
            label2.TabIndex = 6;
            label2.Text = "Tên nhà cung cấp:";
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
            // 
            // btnXoaNhaCungCap
            // 
            btnXoaNhaCungCap.Location = new Point(387, 495);
            btnXoaNhaCungCap.Name = "btnXoaNhaCungCap";
            btnXoaNhaCungCap.Size = new Size(94, 29);
            btnXoaNhaCungCap.TabIndex = 4;
            btnXoaNhaCungCap.Text = "Xóa";
            btnXoaNhaCungCap.UseVisualStyleBackColor = true;
            btnXoaNhaCungCap.Click += btnXoaNhaCungCap_Click;
            // 
            // btnSuaNhaCungCap
            // 
            btnSuaNhaCungCap.Location = new Point(217, 495);
            btnSuaNhaCungCap.Name = "btnSuaNhaCungCap";
            btnSuaNhaCungCap.Size = new Size(94, 29);
            btnSuaNhaCungCap.TabIndex = 3;
            btnSuaNhaCungCap.Text = "Sửa";
            btnSuaNhaCungCap.UseVisualStyleBackColor = true;
            btnSuaNhaCungCap.Click += btnSuaNhaCungCap_Click;
            // 
            // btnThemNhaCungCap
            // 
            btnThemNhaCungCap.Location = new Point(48, 495);
            btnThemNhaCungCap.Name = "btnThemNhaCungCap";
            btnThemNhaCungCap.Size = new Size(94, 29);
            btnThemNhaCungCap.TabIndex = 2;
            btnThemNhaCungCap.Text = "Thêm ";
            btnThemNhaCungCap.UseVisualStyleBackColor = true;
            btnThemNhaCungCap.Click += btnThemNhaCungCap_Click;
            // 
            // txtMaNhaCungCap
            // 
            txtMaNhaCungCap.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaNhaCungCap.Location = new Point(180, 68);
            txtMaNhaCungCap.Name = "txtMaNhaCungCap";
            txtMaNhaCungCap.ReadOnly = true;
            txtMaNhaCungCap.Size = new Size(295, 30);
            txtMaNhaCungCap.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 76);
            label1.Name = "label1";
            label1.Size = new Size(148, 22);
            label1.TabIndex = 0;
            label1.Text = "Mã nhà cung cấp:";
            // 
            // gpKh
            // 
            gpKh.Controls.Add(txtEmailNhaCungCap);
            gpKh.Controls.Add(label6);
            gpKh.Controls.Add(txtSoDienThoaiNhaCungCap);
            gpKh.Controls.Add(label4);
            gpKh.Controls.Add(txtDiaChiNhaCungCap);
            gpKh.Controls.Add(label3);
            gpKh.Controls.Add(txtTenNhaCungCap);
            gpKh.Controls.Add(label2);
            gpKh.Controls.Add(btnThoatKhachHang);
            gpKh.Controls.Add(btnXoaNhaCungCap);
            gpKh.Controls.Add(btnSuaNhaCungCap);
            gpKh.Controls.Add(btnThemNhaCungCap);
            gpKh.Controls.Add(txtMaNhaCungCap);
            gpKh.Controls.Add(label1);
            gpKh.Location = new Point(842, 25);
            gpKh.Name = "gpKh";
            gpKh.Size = new Size(481, 614);
            gpKh.TabIndex = 9;
            gpKh.TabStop = false;
            gpKh.Text = "Thông tin nhà cung cấp";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvDanhSachNhaCungCap);
            groupBox1.Location = new Point(15, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(821, 614);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách nhà cung cấp";
            // 
            // Frm_QuanLyNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1339, 665);
            Controls.Add(gpKh);
            Controls.Add(groupBox1);
            Name = "Frm_QuanLyNhaCungCap";
            Text = "Frm_QuanLyNhaCungCap";
            Load += Frm_QuanLyNhaCungCap_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNhaCungCap).EndInit();
            gpKh.ResumeLayout(false);
            gpKh.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDanhSachNhaCungCap;
        private TextBox txtEmailNhaCungCap;
        private Label label6;
        private TextBox txtSoDienThoaiNhaCungCap;
        private Label label4;
        private TextBox txtDiaChiNhaCungCap;
        private Label label3;
        private TextBox txtTenNhaCungCap;
        private Label label2;
        private Button btnThoatKhachHang;
        private Button btnXoaNhaCungCap;
        private Button btnSuaNhaCungCap;
        private Button btnThemNhaCungCap;
        private TextBox txtMaNhaCungCap;
        private Label label1;
        private GroupBox gpKh;
        private GroupBox groupBox1;
    }
}