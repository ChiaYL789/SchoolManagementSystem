using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace assignment3
{
    public partial class frmFeedback : Form
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public frmFeedback()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbTrainerID.Text.ToString().Length == 0)
            {
                MessageBox.Show("You Are Required to Select a Trainer ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                con.Open();
                string ID = cbTrainerID.Text.ToString();
                SqlCommand cmd = new SqlCommand("select trainerName from Trainer where trainerID = '" + ID + "'", con);
                string trainerName = cmd.ExecuteScalar()?.ToString();
                lblTrainerName.Text = trainerName;
                ViewOrRefreshDataGridView();
            }
            con.Close();

        }
        private void ViewOrRefreshDataGridView()
        {
            string ID = cbTrainerID.Text.ToString();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT subject, feedback FROM Feedback where trainerID = '" + ID + "'", con);
            da.Fill(dt);
            dgvFeedback.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminHome am = new frmAdminHome();
            am.ShowDialog();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmFeedback_Load(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.FComboTrainerID(cbTrainerID);
        }
    }
}
