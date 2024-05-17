namespace NongTraiVuiVe.Quản_Lý
{
    partial class Frm_QuanLyNguyenVatLieu
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
            gbnvl = new GroupBox();
            textBox2 = new TextBox();
            label2 = new Label();
            btnThoatNvl = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            gbnvl.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // gbnvl
            // 
            gbnvl.Controls.Add(textBox5);
            gbnvl.Controls.Add(label5);
            gbnvl.Controls.Add(textBox6);
            gbnvl.Controls.Add(label6);
            gbnvl.Controls.Add(textBox3);
            gbnvl.Controls.Add(label3);
            gbnvl.Controls.Add(textBox4);
            gbnvl.Controls.Add(label4);
            gbnvl.Controls.Add(textBox2);
            gbnvl.Controls.Add(label2);
            gbnvl.Controls.Add(btnThoatNvl);
            gbnvl.Controls.Add(button3);
            gbnvl.Controls.Add(button2);
            gbnvl.Controls.Add(button1);
            gbnvl.Controls.Add(textBox1);
            gbnvl.Controls.Add(label1);
            gbnvl.Location = new Point(801, 12);
            gbnvl.Name = "gbnvl";
            gbnvl.Size = new Size(512, 613);
            gbnvl.TabIndex = 7;
            gbnvl.TabStop = false;
            gbnvl.Text = "Thông tin nguyên vật liệu";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(210, 133);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(295, 30);
            textBox2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(32, 141);
            label2.Name = "label2";
            label2.Size = new Size(169, 22);
            label2.TabIndex = 6;
            label2.Text = "Tên nguyên vật liệu:";
            label2.Click += label2_Click;
            // 
            // btnThoatNvl
            // 
            btnThoatNvl.Dock = DockStyle.Bottom;
            btnThoatNvl.Location = new Point(3, 581);
            btnThoatNvl.Name = "btnThoatNvl";
            btnThoatNvl.Size = new Size(506, 29);
            btnThoatNvl.TabIndex = 5;
            btnThoatNvl.Text = "Thoát";
            btnThoatNvl.UseVisualStyleBackColor = true;
            btnThoatNvl.Click += btnThoatNvl_Click;
            // 
            // button3
            // 
            button3.Location = new Point(370, 516);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(210, 516);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(40, 516);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Thêm ";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(210, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(295, 30);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, 72);
            label1.Name = "label1";
            label1.Size = new Size(165, 22);
            label1.TabIndex = 0;
            label1.Text = "Mã nguyên vật liệu:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(5, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(790, 613);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách nguyên vật liệu";
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
            dataGridView1.Size = new Size(784, 587);
            dataGridView1.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(210, 251);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(295, 30);
            textBox3.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(109, 259);
            label3.Name = "label3";
            label3.Size = new Size(88, 22);
            label3.TabIndex = 10;
            label3.Text = "Số lượng:";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(210, 198);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(295, 30);
            textBox4.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(0, 206);
            label4.Name = "label4";
            label4.Size = new Size(201, 22);
            label4.TabIndex = 8;
            label4.Text = "Mã loại nguyên vật liệu:";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(210, 386);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(295, 98);
            textBox5.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(57, 389);
            label5.Name = "label5";
            label5.Size = new Size(140, 22);
            label5.TabIndex = 14;
            label5.Text = "Mô tả tình trạng:";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(210, 317);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(295, 30);
            textBox6.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(81, 325);
            label6.Name = "label6";
            label6.Size = new Size(116, 22);
            label6.TabIndex = 12;
            label6.Text = "Mã kho hàng:";
            // 
            // Frm_QuanLyNguyenVatLieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 623);
            Controls.Add(gbnvl);
            Controls.Add(groupBox1);
            Name = "Frm_QuanLyNguyenVatLieu";
            Text = "Frm_QuanLyNguyenVatLieu";
            gbnvl.ResumeLayout(false);
            gbnvl.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbnvl;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox2;
        private Label label2;
        private Button btnThoatNvl;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
    }
}