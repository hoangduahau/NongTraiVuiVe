namespace NongTraiVuiVe.Quản_Lý
{
    partial class Frm_QuanLyKhoHang
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
            gp1 = new GroupBox();
            cbbKhaDungKhoHang = new ComboBox();
            label4 = new Label();
            txtViTri = new TextBox();
            label3 = new Label();
            txtTenKhoHang = new TextBox();
            label2 = new Label();
            btnThoatKH = new Button();
            btnXoaKhoHang = new Button();
            btnSuaKhoHang = new Button();
            btnThemKhoHang = new Button();
            txtMaKhoHang = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dgvDanhSachKhoHang = new DataGridView();
            gp1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachKhoHang).BeginInit();
            SuspendLayout();
            // 
            // gp1
            // 
            gp1.Controls.Add(cbbKhaDungKhoHang);
            gp1.Controls.Add(label4);
            gp1.Controls.Add(txtViTri);
            gp1.Controls.Add(label3);
            gp1.Controls.Add(txtTenKhoHang);
            gp1.Controls.Add(label2);
            gp1.Controls.Add(btnThoatKH);
            gp1.Controls.Add(btnXoaKhoHang);
            gp1.Controls.Add(btnSuaKhoHang);
            gp1.Controls.Add(btnThemKhoHang);
            gp1.Controls.Add(txtMaKhoHang);
            gp1.Controls.Add(label1);
            gp1.Location = new Point(830, 12);
            gp1.Name = "gp1";
            gp1.Size = new Size(481, 614);
            gp1.TabIndex = 5;
            gp1.TabStop = false;
            gp1.Text = "Thông tin kho hàng";
            // 
            // cbbKhaDungKhoHang
            // 
            cbbKhaDungKhoHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbKhaDungKhoHang.FormattingEnabled = true;
            cbbKhaDungKhoHang.Items.AddRange(new object[] { "Có", "Không" });
            cbbKhaDungKhoHang.Location = new Point(180, 372);
            cbbKhaDungKhoHang.Name = "cbbKhaDungKhoHang";
            cbbKhaDungKhoHang.Size = new Size(295, 28);
            cbbKhaDungKhoHang.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(51, 378);
            label4.Name = "label4";
            label4.Size = new Size(90, 22);
            label4.TabIndex = 10;
            label4.Text = "Khả dụng:";
            // 
            // txtViTri
            // 
            txtViTri.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtViTri.Location = new Point(180, 299);
            txtViTri.Name = "txtViTri";
            txtViTri.Size = new Size(295, 30);
            txtViTri.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(83, 307);
            label3.Name = "label3";
            label3.Size = new Size(58, 22);
            label3.TabIndex = 8;
            label3.Text = "Vị trí:";
            // 
            // txtTenKhoHang
            // 
            txtTenKhoHang.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenKhoHang.Location = new Point(180, 202);
            txtTenKhoHang.Name = "txtTenKhoHang";
            txtTenKhoHang.Size = new Size(295, 30);
            txtTenKhoHang.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 210);
            label2.Name = "label2";
            label2.Size = new Size(120, 22);
            label2.TabIndex = 6;
            label2.Text = "Tên kho hàng:";
            // 
            // btnThoatKH
            // 
            btnThoatKH.Dock = DockStyle.Bottom;
            btnThoatKH.Location = new Point(3, 582);
            btnThoatKH.Name = "btnThoatKH";
            btnThoatKH.Size = new Size(475, 29);
            btnThoatKH.TabIndex = 5;
            btnThoatKH.Text = "Thoát";
            btnThoatKH.UseVisualStyleBackColor = true;
            btnThoatKH.Click += btnThoatKH_Click;
            // 
            // btnXoaKhoHang
            // 
            btnXoaKhoHang.Location = new Point(381, 464);
            btnXoaKhoHang.Name = "btnXoaKhoHang";
            btnXoaKhoHang.Size = new Size(94, 29);
            btnXoaKhoHang.TabIndex = 4;
            btnXoaKhoHang.Text = "Xóa";
            btnXoaKhoHang.UseVisualStyleBackColor = true;
            btnXoaKhoHang.Click += btnXoaKhoHang_Click;
            // 
            // btnSuaKhoHang
            // 
            btnSuaKhoHang.Location = new Point(221, 464);
            btnSuaKhoHang.Name = "btnSuaKhoHang";
            btnSuaKhoHang.Size = new Size(94, 29);
            btnSuaKhoHang.TabIndex = 3;
            btnSuaKhoHang.Text = "Sửa";
            btnSuaKhoHang.UseVisualStyleBackColor = true;
            btnSuaKhoHang.Click += btnSuaKhoHang_Click;
            // 
            // btnThemKhoHang
            // 
            btnThemKhoHang.Location = new Point(51, 464);
            btnThemKhoHang.Name = "btnThemKhoHang";
            btnThemKhoHang.Size = new Size(94, 29);
            btnThemKhoHang.TabIndex = 2;
            btnThemKhoHang.Text = "Thêm ";
            btnThemKhoHang.UseVisualStyleBackColor = true;
            btnThemKhoHang.Click += btnThemKhoHang_Click;
            // 
            // txtMaKhoHang
            // 
            txtMaKhoHang.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaKhoHang.Location = new Point(180, 112);
            txtMaKhoHang.Name = "txtMaKhoHang";
            txtMaKhoHang.ReadOnly = true;
            txtMaKhoHang.Size = new Size(295, 30);
            txtMaKhoHang.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 120);
            label1.Name = "label1";
            label1.Size = new Size(116, 22);
            label1.TabIndex = 0;
            label1.Text = "Mã kho hàng:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvDanhSachKhoHang);
            groupBox1.Location = new Point(3, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(821, 614);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách kho hàng";
            // 
            // dgvDanhSachKhoHang
            // 
            dgvDanhSachKhoHang.AllowUserToAddRows = false;
            dgvDanhSachKhoHang.AllowUserToDeleteRows = false;
            dgvDanhSachKhoHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachKhoHang.Dock = DockStyle.Fill;
            dgvDanhSachKhoHang.Location = new Point(3, 23);
            dgvDanhSachKhoHang.Name = "dgvDanhSachKhoHang";
            dgvDanhSachKhoHang.ReadOnly = true;
            dgvDanhSachKhoHang.RowHeadersWidth = 51;
            dgvDanhSachKhoHang.RowTemplate.Height = 29;
            dgvDanhSachKhoHang.Size = new Size(815, 588);
            dgvDanhSachKhoHang.TabIndex = 0;
            dgvDanhSachKhoHang.CellClick += dgvDanhSachKhoHang_CellClick;
            // 
            // Frm_QuanLyKhoHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1314, 625);
            Controls.Add(gp1);
            Controls.Add(groupBox1);
            Name = "Frm_QuanLyKhoHang";
            Text = "Frm_QuanLyKhoHang";
            Load += Frm_QuanLyKhoHang_Load;
            gp1.ResumeLayout(false);
            gp1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachKhoHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gp1;
        private TextBox txtViTri;
        private Label label3;
        private TextBox txtTenKhoHang;
        private Label label2;
        private Button btnThoatKH;
        private Button btnXoaKhoHang;
        private Button btnSuaKhoHang;
        private Button btnThemKhoHang;
        private TextBox txtMaKhoHang;
        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dgvDanhSachKhoHang;
        private Label label4;
        private ComboBox cbbKhaDungKhoHang;
    }
}