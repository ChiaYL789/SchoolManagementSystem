using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment3.admin
{
    public partial class frmViewTrainerList : Form
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public frmViewTrainerList()
        {
            InitializeComponent();
        }

        private void ViewTrainerList_Load(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.ComboTrainerID(cbTrainerID);
            ViewOrRefreshDataGridView();
        }
        private void ViewOrRefreshDataGridView()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT trainerID,trainerName,gender,contactNumber,email,address FROM Trainer", con);
            da.Fill(dt);
            sgvTrainerList.AutoGenerateColumns = true;
            sgvTrainerList.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbTrainerID.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please Fill Up All The Required Fields!", "Error", MessageBoxButtons.OK);
            }
            else
            {
                Admin dt = new Admin(cbTrainerID.Text.Trim());
                dt.deleteTrainer();
                con.Open();
                ViewOrRefreshDataGridView();
            }
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cbTrainerID.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminHome am = new frmAdminHome();
            am.ShowDialog();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
