namespace NongTraiVuiVe
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
            dataGridView1 = new DataGridView();
            groupbox2 = new GroupBox();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            btnThoatKv = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupbox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(821, 633);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách khu vực";
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
            // groupbox2
            // 
            groupbox2.Controls.Add(textBox3);
            groupbox2.Controls.Add(label3);
            groupbox2.Controls.Add(textBox2);
            groupbox2.Controls.Add(label2);
            groupbox2.Controls.Add(btnThoatKv);
            groupbox2.Controls.Add(button3);
            groupbox2.Controls.Add(button2);
            groupbox2.Controls.Add(button1);
            groupbox2.Controls.Add(textBox1);
            groupbox2.Controls.Add(label1);
            groupbox2.Location = new Point(839, 12);
            groupbox2.Name = "groupbox2";
            groupbox2.Size = new Size(481, 633);
            groupbox2.TabIndex = 1;
            groupbox2.TabStop = false;
            groupbox2.Text = "Thông tin khu vực";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(165, 354);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(295, 30);
            textBox3.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(44, 354);
            label3.Name = "label3";
            label3.Size = new Size(90, 22);
            label3.TabIndex = 8;
            label3.Text = "Khả dụng:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(165, 230);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(295, 30);
            textBox2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(20, 230);
            label2.Name = "label2";
            label2.Size = new Size(113, 22);
            label2.TabIndex = 6;
            label2.Text = "Tên khu vực:";
            // 
            // btnThoatKv
            // 
            btnThoatKv.Dock = DockStyle.Bottom;
            btnThoatKv.Location = new Point(3, 601);
            btnThoatKv.Name = "btnThoatKv";
            btnThoatKv.Size = new Size(475, 29);
            btnThoatKv.TabIndex = 5;
            btnThoatKv.Text = "Thoát";
            btnThoatKv.UseVisualStyleBackColor = true;
            btnThoatKv.Click += btnThoatKv_Click;
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
            textBox1.Location = new Point(165, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(295, 30);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 120);
            label1.Name = "label1";
            label1.Size = new Size(114, 22);
            label1.TabIndex = 0;
            label1.Text = " Mã khu vực:";
            // 
            // Frm_QuanLyKhuVuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1322, 657);
            Controls.Add(groupbox2);
            Controls.Add(groupBox1);
            Name = "Frm_QuanLyKhuVuc";
            Text = "Frm_QuanLyKhuVuc";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupbox2.ResumeLayout(false);
            groupbox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private GroupBox groupbox2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private Button btnThoatKv;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
    }
}