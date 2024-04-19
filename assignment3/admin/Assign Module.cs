using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace assignment3
{
    public partial class frmAssign : Form
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public frmAssign()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminHome am = new frmAdminHome();
            am.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cbModule.Text.Trim().Length == 0 || cbLevel.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please Fill Up All The Required Fields!", "Error", MessageBoxButtons.OK);
            }
            else
            {
                Admin am = new Admin(cbTrainerID.Text.Trim(),cbModule.Text.Trim(), cbLevel.Text.Trim());
                am.assignTrainerModule();
                con.Open();
                ViewOrRefreshDataGridView();
            }
            con.Close();
                
        }

        private void cbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
            if (cbTrainerID.Text.ToString().Length == 0)
            {
                MessageBox.Show("You Are Required to Select a Trainer ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                con.Open();
                string ID = cbTrainerID.Text.ToString();
                SqlCommand cmd = new SqlCommand("select trainerName from trainer where trainerID = '" + ID + "'", con);
                string trainerName = cmd.ExecuteScalar()?.ToString();
                lblName.Text = trainerName;
                ViewOrRefreshDataGridView();    
            }
            con.Close();
        }

        private void ViewOrRefreshDataGridView()
        {
            string ID = cbTrainerID.Text.ToString();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT module, level FROM AssignModule where trainerID = '" + ID + "'", con);
            da.Fill(dt);
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;
        }



        private void frmAssign_Load(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.ComboTrainerID(cbTrainerID);
            panel1.Visible = false;
            con.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbModule.Text.Trim().Length == 0 || cbLevel.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please Fill Up All The Required Fields!", "Error", MessageBoxButtons.OK);
            }
            else
            {
                Admin dm = new Admin(cbTrainerID.Text.Trim(), cbModule.Text.Trim(), cbLevel.Text.Trim());
                dm.deleteTrainerModule();
                con.Open();
                ViewOrRefreshDataGridView();
            }
            con.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
