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

namespace assignment3
{
    public partial class frmViewStdList : Form
    {
        private string trainerID;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public frmViewStdList(string id)
        {
            InitializeComponent();
            trainerID = id;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTrainerHome home = new frmTrainerHome();
            home.ShowDialog();
            this.Close();
        }

        private void frmViewStdList_Load(object sender, EventArgs e)
        {

        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            con.Open();

            // Create a DataTable to store the student information
            DataTable dt = new DataTable();

            // Define the SQL query
            string sql = @"SELECT Student.studentID AS StudentID, Student.studentName AS StudentName, CoachingClass.Name AS ModuleName, CoachingClass.level AS Level, Student.enrollMonth AS MonthOfEnrollment
                            FROM Module 
                            JOIN Student ON Module.studentID = Student.studentID
                            JOIN CoachingClass ON Module.ClassID = CoachingClass.ClassID
                            WHERE Module.payment = 'paid'";


            // Create a SqlCommand object with the SQL query and connection
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                // Add the TrainerID parameter
                cmd.Parameters.AddWithValue("@TrainerID", trainerID);

                // Create a SqlDataAdapter to execute the SqlCommand and fill the DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

                // Set the DataTable as the data source for the DataGridView
                dgvStdList.DataSource = dt;
            }

            // Close the database connection
            con.Close();

        }

        private void dgvStdList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
