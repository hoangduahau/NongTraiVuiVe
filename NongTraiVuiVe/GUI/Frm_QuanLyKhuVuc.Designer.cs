﻿namespace NongTraiVuiVe
{
    partial class Frm_QuanLyKhuVuc
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
            dgvDanhSachKhuVuc = new DataGridView();
            groupbox2 = new GroupBox();
            cbbKhaDungKhuVuc = new ComboBox();
            label3 = new Label();
            txtTenKhuVuc = new TextBox();
            label2 = new Label();
            btnThoatKv = new Button();
            btnXoaKhuVuc = new Button();
            btnSuaKhuVuc = new Button();
            btnThemKhuVuc = new Button();
            txtMaKhuVuc = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachKhuVuc).BeginInit();
            groupbox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvDanhSachKhuVuc);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1137, 864);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách khu vực";
            // 
            // dgvDanhSachKhuVuc
            // 
            dgvDanhSachKhuVuc.AllowUserToAddRows = false;
            dgvDanhSachKhuVuc.AllowUserToDeleteRows = false;
            dgvDanhSachKhuVuc.BackgroundColor = Color.Honeydew;
            dgvDanhSachKhuVuc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachKhuVuc.Dock = DockStyle.Fill;
            dgvDanhSachKhuVuc.Location = new Point(3, 30);
            dgvDanhSachKhuVuc.Name = "dgvDanhSachKhuVuc";
            dgvDanhSachKhuVuc.ReadOnly = true;
            dgvDanhSachKhuVuc.RowHeadersWidth = 51;
            dgvDanhSachKhuVuc.RowTemplate.Height = 29;
            dgvDanhSachKhuVuc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachKhuVuc.Size = new Size(1131, 831);
            dgvDanhSachKhuVuc.TabIndex = 0;
            dgvDanhSachKhuVuc.CellClick += dgvDanhSachKhuVuc_CellClick;
            // 
            // groupbox2
            // 
            groupbox2.Controls.Add(cbbKhaDungKhuVuc);
            groupbox2.Controls.Add(label3);
            groupbox2.Controls.Add(txtTenKhuVuc);
            groupbox2.Controls.Add(label2);
            groupbox2.Controls.Add(btnThoatKv);
            groupbox2.Controls.Add(btnXoaKhuVuc);
            groupbox2.Controls.Add(btnSuaKhuVuc);
            groupbox2.Controls.Add(btnThemKhuVuc);
            groupbox2.Controls.Add(txtMaKhuVuc);
            groupbox2.Controls.Add(label1);
            groupbox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupbox2.Location = new Point(1155, 21);
            groupbox2.Name = "groupbox2";
            groupbox2.Size = new Size(757, 855);
            groupbox2.TabIndex = 1;
            groupbox2.TabStop = false;
            groupbox2.Text = "Thông tin khu vực";
            // 
            // cbbKhaDungKhuVuc
            // 
            cbbKhaDungKhuVuc.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbKhaDungKhuVuc.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbbKhaDungKhuVuc.FormattingEnabled = true;
            cbbKhaDungKhuVuc.Items.AddRange(new object[] { "Có", "Không" });
            cbbKhaDungKhuVuc.Location = new Point(247, 366);
            cbbKhaDungKhuVuc.Name = "cbbKhaDungKhuVuc";
            cbbKhaDungKhuVuc.Size = new Size(461, 37);
            cbbKhaDungKhuVuc.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(101, 378);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 8;
            label3.Text = "Khả dụng:";
            // 
            // txtTenKhuVuc
            // 
            txtTenKhuVuc.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenKhuVuc.Location = new Point(247, 250);
            txtTenKhuVuc.Name = "txtTenKhuVuc";
            txtTenKhuVuc.Size = new Size(461, 34);
            txtTenKhuVuc.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(74, 259);
            label2.Name = "label2";
            label2.Size = new Size(129, 25);
            label2.TabIndex = 6;
            label2.Text = "Tên khu vực:";
            // 
            // btnThoatKv
            // 
            btnThoatKv.Dock = DockStyle.Bottom;
            btnThoatKv.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThoatKv.Location = new Point(3, 814);
            btnThoatKv.Name = "btnThoatKv";
            btnThoatKv.Size = new Size(751, 38);
            btnThoatKv.TabIndex = 5;
            btnThoatKv.Text = "Thoát";
            btnThoatKv.UseVisualStyleBackColor = true;
            btnThoatKv.Click += btnThoatKv_Click;
            // 
            // btnXoaKhuVuc
            // 
            btnXoaKhuVuc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoaKhuVuc.Location = new Point(602, 562);
            btnXoaKhuVuc.Name = "btnXoaKhuVuc";
            btnXoaKhuVuc.Size = new Size(106, 41);
            btnXoaKhuVuc.TabIndex = 4;
            btnXoaKhuVuc.Text = "Xóa";
            btnXoaKhuVuc.UseVisualStyleBackColor = true;
            btnXoaKhuVuc.Click += btnXoaKhuVuc_Click;
            // 
            // btnSuaKhuVuc
            // 
            btnSuaKhuVuc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSuaKhuVuc.Location = new Point(367, 562);
            btnSuaKhuVuc.Name = "btnSuaKhuVuc";
            btnSuaKhuVuc.Size = new Size(106, 41);
            btnSuaKhuVuc.TabIndex = 3;
            btnSuaKhuVuc.Text = "Sửa";
            btnSuaKhuVuc.UseVisualStyleBackColor = true;
            btnSuaKhuVuc.Click += btnSuaKhuVuc_Click;
            // 
            // btnThemKhuVuc
            // 
            btnThemKhuVuc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThemKhuVuc.Location = new Point(112, 562);
            btnThemKhuVuc.Name = "btnThemKhuVuc";
            btnThemKhuVuc.Size = new Size(106, 41);
            btnThemKhuVuc.TabIndex = 2;
            btnThemKhuVuc.Text = "Thêm ";
            btnThemKhuVuc.UseVisualStyleBackColor = true;
            btnThemKhuVuc.Click += btnThemKhuVuc_Click;
            // 
            // txtMaKhuVuc
            // 
            txtMaKhuVuc.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaKhuVuc.Location = new Point(247, 132);
            txtMaKhuVuc.Name = "txtMaKhuVuc";
            txtMaKhuVuc.ReadOnly = true;
            txtMaKhuVuc.Size = new Size(461, 34);
            txtMaKhuVuc.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(73, 141);
            label1.Name = "label1";
            label1.Size = new Size(130, 25);
            label1.TabIndex = 0;
            label1.Text = " Mã khu vực:";
            // 
            // Frm_QuanLyKhuVuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1914, 877);
            Controls.Add(groupbox2);
            Controls.Add(groupBox1);
            Name = "Frm_QuanLyKhuVuc";
            Text = "Frm_QuanLyKhuVuc";
            Load += Frm_QuanLyKhuVuc_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachKhuVuc).EndInit();
            groupbox2.ResumeLayout(false);
            groupbox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvDanhSachKhuVuc;
        private GroupBox groupbox2;
        private Label label3;
        private TextBox txtTenKhuVuc;
        private Label label2;
        private Button btnThoatKv;
        private Button btnXoaKhuVuc;
        private Button btnSuaKhuVuc;
        private Button btnThemKhuVuc;
        private TextBox txtMaKhuVuc;
        private Label label1;
        private ComboBox cbbKhaDungKhuVuc;
    }
}