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
            btnThoatNhaCungCap = new Button();
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
            dgvDanhSachNhaCungCap.BackgroundColor = Color.Honeydew;
            dgvDanhSachNhaCungCap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachNhaCungCap.Dock = DockStyle.Fill;
            dgvDanhSachNhaCungCap.Location = new Point(3, 30);
            dgvDanhSachNhaCungCap.Name = "dgvDanhSachNhaCungCap";
            dgvDanhSachNhaCungCap.ReadOnly = true;
            dgvDanhSachNhaCungCap.RowHeadersWidth = 51;
            dgvDanhSachNhaCungCap.RowTemplate.Height = 29;
            dgvDanhSachNhaCungCap.Size = new Size(1335, 831);
            dgvDanhSachNhaCungCap.TabIndex = 0;
            dgvDanhSachNhaCungCap.CellClick += dgvDanhSachNhaCungCap_CellClick;
            // 
            // txtEmailNhaCungCap
            // 
            txtEmailNhaCungCap.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmailNhaCungCap.Location = new Point(213, 504);
            txtEmailNhaCungCap.Name = "txtEmailNhaCungCap";
            txtEmailNhaCungCap.Size = new Size(295, 34);
            txtEmailNhaCungCap.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(124, 513);
            label6.Name = "label6";
            label6.Size = new Size(69, 25);
            label6.TabIndex = 14;
            label6.Text = "Email:";
            // 
            // txtSoDienThoaiNhaCungCap
            // 
            txtSoDienThoaiNhaCungCap.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoDienThoaiNhaCungCap.Location = new Point(213, 401);
            txtSoDienThoaiNhaCungCap.Name = "txtSoDienThoaiNhaCungCap";
            txtSoDienThoaiNhaCungCap.Size = new Size(295, 34);
            txtSoDienThoaiNhaCungCap.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(59, 410);
            label4.Name = "label4";
            label4.Size = new Size(133, 25);
            label4.TabIndex = 10;
            label4.Text = "Số điện thoại:";
            // 
            // txtDiaChiNhaCungCap
            // 
            txtDiaChiNhaCungCap.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiaChiNhaCungCap.Location = new Point(213, 305);
            txtDiaChiNhaCungCap.Name = "txtDiaChiNhaCungCap";
            txtDiaChiNhaCungCap.Size = new Size(295, 34);
            txtDiaChiNhaCungCap.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(110, 308);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 8;
            label3.Text = "Địa chỉ:";
            // 
            // txtTenNhaCungCap
            // 
            txtTenNhaCungCap.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenNhaCungCap.Location = new Point(213, 211);
            txtTenNhaCungCap.Name = "txtTenNhaCungCap";
            txtTenNhaCungCap.Size = new Size(295, 34);
            txtTenNhaCungCap.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(20, 220);
            label2.Name = "label2";
            label2.Size = new Size(172, 25);
            label2.TabIndex = 6;
            label2.Text = "Tên nhà cung cấp:";
            // 
            // btnThoatNhaCungCap
            // 
            btnThoatNhaCungCap.Dock = DockStyle.Bottom;
            btnThoatNhaCungCap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThoatNhaCungCap.Location = new Point(3, 823);
            btnThoatNhaCungCap.Name = "btnThoatNhaCungCap";
            btnThoatNhaCungCap.Size = new Size(550, 38);
            btnThoatNhaCungCap.TabIndex = 5;
            btnThoatNhaCungCap.Text = "Thoát";
            btnThoatNhaCungCap.UseVisualStyleBackColor = true;
            btnThoatNhaCungCap.Click += btnThoatNhaCungCap_Click;
            // 
            // btnXoaNhaCungCap
            // 
            btnXoaNhaCungCap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoaNhaCungCap.Location = new Point(415, 621);
            btnXoaNhaCungCap.Name = "btnXoaNhaCungCap";
            btnXoaNhaCungCap.Size = new Size(106, 34);
            btnXoaNhaCungCap.TabIndex = 4;
            btnXoaNhaCungCap.Text = "Xóa";
            btnXoaNhaCungCap.UseVisualStyleBackColor = true;
            btnXoaNhaCungCap.Click += btnXoaNhaCungCap_Click;
            // 
            // btnSuaNhaCungCap
            // 
            btnSuaNhaCungCap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSuaNhaCungCap.Location = new Point(245, 621);
            btnSuaNhaCungCap.Name = "btnSuaNhaCungCap";
            btnSuaNhaCungCap.Size = new Size(106, 34);
            btnSuaNhaCungCap.TabIndex = 3;
            btnSuaNhaCungCap.Text = "Sửa";
            btnSuaNhaCungCap.UseVisualStyleBackColor = true;
            btnSuaNhaCungCap.Click += btnSuaNhaCungCap_Click;
            // 
            // btnThemNhaCungCap
            // 
            btnThemNhaCungCap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThemNhaCungCap.Location = new Point(76, 621);
            btnThemNhaCungCap.Name = "btnThemNhaCungCap";
            btnThemNhaCungCap.Size = new Size(106, 34);
            btnThemNhaCungCap.TabIndex = 2;
            btnThemNhaCungCap.Text = "Thêm ";
            btnThemNhaCungCap.UseVisualStyleBackColor = true;
            btnThemNhaCungCap.Click += btnThemNhaCungCap_Click;
            // 
            // txtMaNhaCungCap
            // 
            txtMaNhaCungCap.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaNhaCungCap.Location = new Point(213, 119);
            txtMaNhaCungCap.Name = "txtMaNhaCungCap";
            txtMaNhaCungCap.ReadOnly = true;
            txtMaNhaCungCap.Size = new Size(295, 34);
            txtMaNhaCungCap.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 128);
            label1.Name = "label1";
            label1.Size = new Size(167, 25);
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
            gpKh.Controls.Add(btnThoatNhaCungCap);
            gpKh.Controls.Add(btnXoaNhaCungCap);
            gpKh.Controls.Add(btnSuaNhaCungCap);
            gpKh.Controls.Add(btnThemNhaCungCap);
            gpKh.Controls.Add(txtMaNhaCungCap);
            gpKh.Controls.Add(label1);
            gpKh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gpKh.Location = new Point(1352, 1);
            gpKh.Name = "gpKh";
            gpKh.Size = new Size(556, 864);
            gpKh.TabIndex = 9;
            gpKh.TabStop = false;
            gpKh.Text = "Thông tin nhà cung cấp";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvDanhSachNhaCungCap);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(8, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1341, 864);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách nhà cung cấp";
            // 
            // Frm_QuanLyNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1914, 877);
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
        private Button btnThoatNhaCungCap;
        private Button btnXoaNhaCungCap;
        private Button btnSuaNhaCungCap;
        private Button btnThemNhaCungCap;
        private TextBox txtMaNhaCungCap;
        private Label label1;
        private GroupBox gpKh;
        private GroupBox groupBox1;
    }
}