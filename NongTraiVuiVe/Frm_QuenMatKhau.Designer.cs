namespace NongTraiVuiVe
{
    partial class Frm_QuenMatKhau
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
            lbl_TitleQuenMatKhau = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lbl_TitleQuenMatKhau
            // 
            lbl_TitleQuenMatKhau.BackColor = Color.LawnGreen;
            lbl_TitleQuenMatKhau.Dock = DockStyle.Top;
            lbl_TitleQuenMatKhau.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_TitleQuenMatKhau.ForeColor = SystemColors.ControlText;
            lbl_TitleQuenMatKhau.Location = new Point(0, 0);
            lbl_TitleQuenMatKhau.Name = "lbl_TitleQuenMatKhau";
            lbl_TitleQuenMatKhau.Size = new Size(701, 60);
            lbl_TitleQuenMatKhau.TabIndex = 1;
            lbl_TitleQuenMatKhau.Text = "Quên Mật Khẩu";
            lbl_TitleQuenMatKhau.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(60, 94);
            label1.Name = "label1";
            label1.Size = new Size(279, 32);
            label1.TabIndex = 2;
            label1.Text = "Email Or NumberPhone: ";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(60, 133);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(606, 39);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(60, 178);
            button1.Name = "button1";
            button1.Size = new Size(148, 37);
            button1.TabIndex = 4;
            button1.Text = "Gửi yêu cầu";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(570, 178);
            button2.Name = "button2";
            button2.Size = new Size(96, 37);
            button2.TabIndex = 5;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btn_Thoat_Click;
            // 
            // Frm_QuenMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 258);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(lbl_TitleQuenMatKhau);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_QuenMatKhau";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Frm_QuenMatKhau";
            FormClosed += Frm_QuenMatKhau_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_TitleQuenMatKhau;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}