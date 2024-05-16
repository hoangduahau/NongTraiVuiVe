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
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            btnThoatKH = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            gp1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // gp1
            // 
            gp1.Controls.Add(textBox4);
            gp1.Controls.Add(label4);
            gp1.Controls.Add(textBox3);
            gp1.Controls.Add(label3);
            gp1.Controls.Add(textBox2);
            gp1.Controls.Add(label2);
            gp1.Controls.Add(btnThoatKH);
            gp1.Controls.Add(button3);
            gp1.Controls.Add(button2);
            gp1.Controls.Add(button1);
            gp1.Controls.Add(textBox1);
            gp1.Controls.Add(label1);
            gp1.Location = new Point(830, 12);
            gp1.Name = "gp1";
            gp1.Size = new Size(481, 614);
            gp1.TabIndex = 5;
            gp1.TabStop = false;
            gp1.Text = "Thông tin kho hàng";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(180, 370);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(295, 30);
            textBox4.TabIndex = 11;
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
            // textBox3
            // 
            textBox3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(180, 299);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(295, 30);
            textBox3.TabIndex = 9;
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
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(180, 202);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(295, 30);
            textBox2.TabIndex = 7;
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
            label1.Location = new Point(25, 120);
            label1.Name = "label1";
            label1.Size = new Size(116, 22);
            label1.TabIndex = 0;
            label1.Text = "Mã kho hàng:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(3, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(821, 614);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách kho hàng";
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
            dataGridView1.Size = new Size(815, 588);
            dataGridView1.TabIndex = 0;
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
            gp1.ResumeLayout(false);
            gp1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gp1;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private Button btnThoatKH;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private TextBox textBox4;
        private Label label4;
    }
}