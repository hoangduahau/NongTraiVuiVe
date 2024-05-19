namespace NongTraiVuiVe.GUI
{
    partial class Frm_DoiMatKhau
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
            txtMatKhauMoi = new TextBox();
            label2 = new Label();
            btnThoat = new Button();
            btnDoiMatKhau = new Button();
            txtMatKhauCu = new TextBox();
            label1 = new Label();
            lbl_TitleQuenMatKhau = new Label();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtXacNhanMatKhau = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatKhauMoi.Location = new Point(3, 146);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.PasswordChar = '*';
            txtMatKhauMoi.Size = new Size(618, 39);
            txtMatKhauMoi.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 111);
            label2.Name = "label2";
            label2.Size = new Size(227, 32);
            label2.TabIndex = 13;
            label2.Text = "Nhập mật khẩu mới";
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThoat.Location = new Point(525, 343);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(96, 37);
            btnThoat.TabIndex = 12;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDoiMatKhau
            // 
            btnDoiMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDoiMatKhau.Location = new Point(371, 340);
            btnDoiMatKhau.Name = "btnDoiMatKhau";
            btnDoiMatKhau.Size = new Size(148, 37);
            btnDoiMatKhau.TabIndex = 11;
            btnDoiMatKhau.Text = "Đổi mật khẩu";
            btnDoiMatKhau.UseVisualStyleBackColor = true;
            btnDoiMatKhau.Click += btnDoiMatKhau_Click;
            // 
            // txtMatKhauCu
            // 
            txtMatKhauCu.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatKhauCu.Location = new Point(3, 35);
            txtMatKhauCu.Name = "txtMatKhauCu";
            txtMatKhauCu.PasswordChar = '*';
            txtMatKhauCu.Size = new Size(618, 39);
            txtMatKhauCu.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(211, 32);
            label1.TabIndex = 9;
            label1.Text = "Nhập mật khẩu cũ";
            // 
            // lbl_TitleQuenMatKhau
            // 
            lbl_TitleQuenMatKhau.BackColor = Color.LawnGreen;
            lbl_TitleQuenMatKhau.Dock = DockStyle.Top;
            lbl_TitleQuenMatKhau.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_TitleQuenMatKhau.ForeColor = SystemColors.ControlText;
            lbl_TitleQuenMatKhau.Location = new Point(0, 0);
            lbl_TitleQuenMatKhau.Name = "lbl_TitleQuenMatKhau";
            lbl_TitleQuenMatKhau.Size = new Size(1147, 60);
            lbl_TitleQuenMatKhau.TabIndex = 8;
            lbl_TitleQuenMatKhau.Text = "Đổi Mật Khẩu";
            lbl_TitleQuenMatKhau.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtXacNhanMatKhau);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtMatKhauMoi);
            panel1.Controls.Add(txtMatKhauCu);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnDoiMatKhau);
            panel1.Controls.Add(btnThoat);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(633, 380);
            panel1.TabIndex = 15;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 60);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1147, 570);
            tableLayoutPanel1.TabIndex = 16;
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtXacNhanMatKhau.Location = new Point(3, 253);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.PasswordChar = '*';
            txtXacNhanMatKhau.Size = new Size(618, 39);
            txtXacNhanMatKhau.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 218);
            label3.Name = "label3";
            label3.Size = new Size(219, 32);
            label3.TabIndex = 15;
            label3.Text = "Xác nhận mật khẩu";
            // 
            // Frm_DoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 630);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(lbl_TitleQuenMatKhau);
            Name = "Frm_DoiMatKhau";
            Text = "Frm_DoiMatKhau";
            Load += Frm_DoiMatKhau_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMatKhauMoi;
        private Label label2;
        private Button btnThoat;
        private Button btnDoiMatKhau;
        private TextBox txtMatKhauCu;
        private Label label1;
        private Label lbl_TitleQuenMatKhau;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtXacNhanMatKhau;
        private Label label3;
    }
}