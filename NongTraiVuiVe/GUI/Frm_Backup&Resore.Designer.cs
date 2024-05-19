namespace NongTraiVuiVe.GUI
{
    partial class Frm_Backup_Resore
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
            btnBackup = new Button();
            btnBrowse = new Button();
            txtPath = new TextBox();
            groupBox2 = new GroupBox();
            btnResore = new Button();
            btnBrowseResore = new Button();
            txtResore = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBackup);
            groupBox1.Controls.Add(btnBrowse);
            groupBox1.Controls.Add(txtPath);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1271, 318);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnBackup
            // 
            btnBackup.Location = new Point(877, 223);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(98, 46);
            btnBackup.TabIndex = 2;
            btnBackup.Text = "Sao lưu";
            btnBackup.UseVisualStyleBackColor = true;
            btnBackup.Click += btnBackup_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(877, 141);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(98, 46);
            btnBrowse.TabIndex = 1;
            btnBrowse.Text = "...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // txtPath
            // 
            txtPath.Location = new Point(60, 141);
            txtPath.Multiline = true;
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(737, 46);
            txtPath.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnResore);
            groupBox2.Controls.Add(btnBrowseResore);
            groupBox2.Controls.Add(txtResore);
            groupBox2.Location = new Point(12, 336);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1271, 359);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // btnResore
            // 
            btnResore.Location = new Point(877, 203);
            btnResore.Name = "btnResore";
            btnResore.Size = new Size(98, 46);
            btnResore.TabIndex = 5;
            btnResore.Text = "Phục hồi";
            btnResore.UseVisualStyleBackColor = true;
            // 
            // btnBrowseResore
            // 
            btnBrowseResore.Location = new Point(877, 121);
            btnBrowseResore.Name = "btnBrowseResore";
            btnBrowseResore.Size = new Size(98, 46);
            btnBrowseResore.TabIndex = 4;
            btnBrowseResore.Text = "...";
            btnBrowseResore.UseVisualStyleBackColor = true;
            // 
            // txtResore
            // 
            txtResore.Location = new Point(60, 121);
            txtResore.Multiline = true;
            txtResore.Name = "txtResore";
            txtResore.Size = new Size(737, 46);
            txtResore.TabIndex = 3;
            // 
            // Frm_Backup_Resore
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1295, 707);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "Frm_Backup_Resore";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Backup_Resore";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnBrowse;
        private TextBox txtPath;
        private GroupBox groupBox2;
        private Button btnBackup;
        private Button btnResore;
        private Button btnBrowseResore;
        private TextBox txtResore;
    }
}