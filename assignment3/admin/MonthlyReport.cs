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
    public partial class frmMonthlyReport : Form
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public frmMonthlyReport()
        {
            InitializeComponent();
        }

        private void cbTrainerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTrainerID.Text.ToString().Length == 0)
            {
                MessageBox.Show("You Are Required to Select a Trainer ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                con.Close();
                con.Open();
                string ID = cbTrainerID.Text.ToString();
                SqlCommand cmd = new SqlCommand("select trainerName from trainer where trainerID = '" + ID + "'", con);
                string trainerName = cmd.ExecuteScalar()?.ToString();
                lblName.Text = trainerName;
                ViewOrRefreshDataGridView(ID);
            }
            con.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminHome am = new frmAdminHome();
            am.ShowDialog();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void MonthlyReport_Load(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.ComboTrainerID(cbTrainerID);
            con.Close();
        }

        private void ViewOrRefreshDataGridView(string trainerID)
        {
            // Calculate the total cost earned by the trainer
            string sql = "SELECT SUM(CoachingClass.amount) AS TotalCost FROM CoachingClass JOIN Module ON CoachingClass.ClassID = Module.ClassID WHERE CoachingClass.trainerID = @TrainerID";
            int totalCost = 0;
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@TrainerID", trainerID);
                con.Close();
                con.Open();
                object totalCostObj = cmd.ExecuteScalar();
                if (totalCostObj != DBNull.Value)
                {
                    totalCost = Convert.ToInt32(totalCostObj);
                }
                lbltotal.Text = totalCost.ToString();

                con.Close();
            }

            // Display the total cost in a label or any other desired UI element

            // Retrieve the data for the monthly report and bind it to the DataGridView
            DataTable dt = new DataTable();
            string reportSql = "SELECT CoachingClass.ClassID AS ClassID, Student.studentName AS StudentName, CoachingClass.name AS ClassName, CoachingClass.amount AS Amount FROM Module JOIN Student ON Module.studentID = Student.studentID JOIN CoachingClass ON Module.ClassID = CoachingClass.ClassID WHERE CoachingClass.trainerID = @trainerID";

            using (SqlCommand reportCmd = new SqlCommand(reportSql, con)) 
            {
                reportCmd.Parameters.AddWithValue("@TrainerID", trainerID);
                SqlDataAdapter adapter = new SqlDataAdapter(reportCmd);
                con.Open();
                adapter.Fill(dt);
                con.Close();
            }
            dgvMonthlyReport.AutoGenerateColumns = true;
            dgvMonthlyReport.DataSource = dt;
        }

        private void frmMonthlyReport_Load(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.ComboTrainerID(cbTrainerID);
            con.Close();
        }
    }
}
