using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NongTraiVuiVe.GUI
{
    public partial class Frm_Backup_Resore : Form
    {
        public Frm_Backup_Resore()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=103.74.117.98;Initial Catalog=Garden_Funny;User ID=Garden_Funny_User;Password=s8G@g7hQ3#;");

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = fd.SelectedPath;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string qry = "BACKUP DATABASE ["+con.Database+ "] TO  DISK = N'"+txtPath.Text+".bak'";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Backup File Successfully Done");
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
