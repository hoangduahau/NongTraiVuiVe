namespace NongTraiVuiVe
{
    partial class Frm_QuanLyLoaiCay
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
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            btnThoatLCT = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dgvDanhSachLoaiCay = new DataGridView();
            btnThoat.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachLoaiCay).BeginInit();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.Controls.Add(textBox3);
            btnThoat.Controls.Add(label3);
            btnThoat.Controls.Add(textBox2);
            btnThoat.Controls.Add(label2);
            btnThoat.Controls.Add(btnThoatLCT);
            btnThoat.Controls.Add(button3);
            btnThoat.Controls.Add(button2);
            btnThoat.Controls.Add(button1);
            btnThoat.Controls.Add(textBox1);
            btnThoat.Controls.Add(label1);
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThoat.Location = new Point(1352, 1);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(556, 864);
            btnThoat.TabIndex = 3;
            btnThoat.TabStop = false;
            btnThoat.Text = "Thông tin loại cây trồng";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(205, 419);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(295, 34);
            textBox3.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(114, 428);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 8;
            label3.Text = "Mô tả:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(205, 288);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(295, 34);
            textBox2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 297);
            label2.Name = "label2";
            label2.Size = new Size(178, 25);
            label2.TabIndex = 6;
            label2.Text = "Tên loại cây trồng:";
            // 
            // btnThoatLCT
            // 
            btnThoatLCT.Dock = DockStyle.Bottom;
            btnThoatLCT.Location = new Point(3, 824);
            btnThoatLCT.Name = "btnThoatLCT";
            btnThoatLCT.Size = new Size(550, 37);
            btnThoatLCT.TabIndex = 5;
            btnThoatLCT.Text = "Thoát";
            btnThoatLCT.UseVisualStyleBackColor = true;
            btnThoatLCT.Click += btnThoatLCT_Click;
            // 
            // button3
            // 
            button3.Location = new Point(413, 569);
            button3.Name = "button3";
            button3.Size = new Size(101, 37);
            button3.TabIndex = 4;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(253, 569);
            button2.Name = "button2";
            button2.Size = new Size(101, 37);
            button2.TabIndex = 3;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(83, 569);
            button1.Name = "button1";
            button1.Size = new Size(101, 37);
            button1.TabIndex = 2;
            button1.Text = "Thêm ";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(205, 150);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(295, 34);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 159);
            label1.Name = "label1";
            label1.Size = new Size(173, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã loại cây trồng:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvDanhSachLoaiCay);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(8, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1341, 864);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách loại cây trồng";
            // 
            // dgvDanhSachLoaiCay
            // 
            dgvDanhSachLoaiCay.AllowUserToAddRows = false;
            dgvDanhSachLoaiCay.AllowUserToDeleteRows = false;
            dgvDanhSachLoaiCay.BackgroundColor = Color.Honeydew;
            dgvDanhSachLoaiCay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachLoaiCay.Dock = DockStyle.Fill;
            dgvDanhSachLoaiCay.Location = new Point(3, 30);
            dgvDanhSachLoaiCay.Name = "dgvDanhSachLoaiCay";
            dgvDanhSachLoaiCay.ReadOnly = true;
            dgvDanhSachLoaiCay.RowHeadersWidth = 51;
            dgvDanhSachLoaiCay.RowTemplate.Height = 29;
            dgvDanhSachLoaiCay.Size = new Size(1335, 831);
            dgvDanhSachLoaiCay.TabIndex = 0;
            // 
            // Frm_QuanLyLoaiCay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1914, 877);
            Controls.Add(btnThoat);
            Controls.Add(groupBox1);
            Name = "Frm_QuanLyLoaiCay";
            Text = "Frm_QuanLyLoaiCay";
            WindowState = FormWindowState.Maximized;
            Load += Frm_QuanLyLoaiCay_Load;
            btnThoat.ResumeLayout(false);
            btnThoat.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachLoaiCay).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox btnThoat;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private Button btnThoatLCT;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dgvDanhSachLoaiCay;
    }
}