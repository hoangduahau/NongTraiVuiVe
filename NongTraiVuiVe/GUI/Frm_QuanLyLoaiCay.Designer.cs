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
            dataGridView1 = new DataGridView();
            btnThoat.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            btnThoat.Location = new Point(833, 12);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(481, 633);
            btnThoat.TabIndex = 3;
            btnThoat.TabStop = false;
            btnThoat.Text = "Thông tin loại cây trồng";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(180, 354);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(295, 30);
            textBox3.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(99, 362);
            label3.Name = "label3";
            label3.Size = new Size(62, 22);
            label3.TabIndex = 8;
            label3.Text = "Mô tả:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(180, 230);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(295, 30);
            textBox2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(2, 233);
            label2.Name = "label2";
            label2.Size = new Size(159, 22);
            label2.TabIndex = 6;
            label2.Text = "Tên loại cây trồng:";
            // 
            // btnThoatLCT
            // 
            btnThoatLCT.Dock = DockStyle.Bottom;
            btnThoatLCT.Location = new Point(3, 601);
            btnThoatLCT.Name = "btnThoatLCT";
            btnThoatLCT.Size = new Size(475, 29);
            btnThoatLCT.TabIndex = 5;
            btnThoatLCT.Text = "Thoát";
            btnThoatLCT.UseVisualStyleBackColor = true;
            btnThoatLCT.Click += btnThoatLCT_Click;
            // 
            // button3
            // 
            button3.Location = new Point(381, 464);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(221, 464);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(51, 464);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Thêm ";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(180, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(295, 30);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 120);
            label1.Name = "label1";
            label1.Size = new Size(155, 22);
            label1.TabIndex = 0;
            label1.Text = "Mã loại cây trồng:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(6, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(821, 633);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách loại cây trồng";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(815, 607);
            dataGridView1.TabIndex = 0;
            // 
            // Frm_QuanLyLoaiCay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1321, 656);
            Controls.Add(btnThoat);
            Controls.Add(groupBox1);
            Name = "Frm_QuanLyLoaiCay";
            Text = "Frm_QuanLyLoaiCay";
            WindowState = FormWindowState.Maximized;
            btnThoat.ResumeLayout(false);
            btnThoat.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
    }
}