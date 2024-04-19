
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ASSIGNMENT
{
    public partial class frmEnroll : Form
    {
        public static string studID;

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public frmEnroll(string id)
        {
            InitializeComponent();
            studID = id;
        }

        private void frmEnroll_Load(object sender, EventArgs e)
        {
            pnlEnroll.Visible = false;//hide the panel for choosing schedule during form load
            con.Open();

            // Retrieve distinct module names from the CoachingClass table and populate the cbModuleEn combo box
            SqlCommand cmd1 = new SqlCommand("SELECT DISTINCT Name FROM CoachingClass", con);
            SqlDataReader rd1 = cmd1.ExecuteReader();
            while (rd1.Read())
            {
                cbModuleEn.Items.Add(rd1["Name"].ToString());//add module name to combobox
            }
            rd1.Close();
            con.Close();
        }


        private void btnSubmitEn_Click(object sender, EventArgs e)
        {    // Get the selected module , level, schedule from the combobox and convert it to a string
            string selectedModule = cbModuleEn.SelectedItem?.ToString();
            string selectedLevel = cbLvlEn.SelectedItem?.ToString();
            string selectedSchedule = cbScheduleEn.SelectedItem?.ToString();



            if (string.IsNullOrEmpty(selectedModule) || string.IsNullOrEmpty(selectedLevel) || string.IsNullOrEmpty(selectedSchedule))
            {
                //user need to choose all combobox
                MessageBox.Show("Please fill all choices.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            con.Open();


            Student module1 = new Student(studID);

            // Insert the new module record
            SqlCommand cmd = new SqlCommand("INSERT INTO Module (StudentID, status, payment, ClassID) VALUES (@studentID, 'pending', 'pending', @ClassID)", con);
            cmd.Parameters.AddWithValue("@studentID", studID); // Use the logged-in student ID




            // Retrieve the ClassID for the selected module, level, and schedule
            string query = "SELECT ClassID FROM CoachingClass WHERE name = @Module AND level = @Level AND schedule = @Schedule";
            SqlCommand classIdCmd = new SqlCommand(query, con);
            classIdCmd.Parameters.AddWithValue("@Module", selectedModule);
            classIdCmd.Parameters.AddWithValue("@Level", selectedLevel);
            classIdCmd.Parameters.AddWithValue("@Schedule", selectedSchedule);
            object classIdObj = classIdCmd.ExecuteScalar();


            if (classIdObj != null)
            {
                cmd.Parameters.AddWithValue("@ClassID", classIdObj);
            }
            else
            {
                // Handle the case where the ClassID is not found
                MessageBox.Show("Invalid module, level, or schedule selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return;
            }



            int rowsAffected = cmd.ExecuteNonQuery();



            con.Close();



            if (rowsAffected > 0)
            {
                MessageBox.Show("Enrollment successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to enroll, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Open();
            SqlCommand cmd1 = new SqlCommand("INSErt INTO Module (StudentID, status, payment, ClassID) VALUES ('SA000', 'pending', 'pending', @ClassID)", con);
            cmd1.Parameters.AddWithValue("@studentID", studID);
            con.Close();
        }


        private void deletePendingReq(string studentID)
        {

            con.Open();


            Student module1 = new Student(studID);

            // // Count the number of rows in the "Module" table where the status is "pending" for the specified student ID
            SqlCommand cmd = new SqlCommand("SELECT COUNT (*) FROM Module WHERE status = @status AND StudentID = @studentID", con);
            cmd.Parameters.AddWithValue("@status", "pending");
            cmd.Parameters.AddWithValue("@studentID", studentID); // Use the logged-in student ID
            int count = Convert.ToInt32(cmd.ExecuteScalar());



            if (count > 0)
            {
                MessageBox.Show("Enrolled, unable to remove enrollment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand cmd1 = new SqlCommand("DELETE FROM Module WHERE status = @status AND StudentID = @studentID", con);
                cmd1.Parameters.AddWithValue("@status", "pending"); // Or the appropriate status value
                cmd1.Parameters.AddWithValue("@studentID", studentID); // Use the logged-in student ID
                int rowsAffected = cmd1.ExecuteNonQuery();



                if (rowsAffected > 0)
                {
                    MessageBox.Show("Delete Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No matching records found to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            con.Close();
        }

        private void btnDltReqEN_Click(object sender, EventArgs e)
        {
            if (cbModuleEn.Text.Trim().Length == 0 || cbLvlEn.Text.Trim().Length == 0 || cbScheduleEn.Text.Trim().Length == 0)
            {
                //prevent empty user input
                MessageBox.Show("Please Fill Up All The Required Fields!", "Error", MessageBoxButtons.OK);
            }
            else
            {
                deletePendingReq(studID); // Call the deletePendingReq() method passing the student ID
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            if (cbModuleEn.Text.Trim().Length == 0 || cbLvlEn.Text.Trim().Length == 0)
            {
                //prevent empty user input, if empty will show message box error
                pnlEnroll.Visible = false;
                cbScheduleEn.Items.Clear();
                cbScheduleEn.Text = "Please choose both of the two selections";
            }
            else
            {
                //choose all then data from database will input into combobox
                pnlEnroll.Visible = true;
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT schedule FROM CoachingClass WHERE Name = '" + cbModuleEn.Text + "' AND level ='" + cbLvlEn.Text + "'", con);
                SqlDataReader rd1 = cmd.ExecuteReader();


                int rowCount = 0; //create a variable to count the number of rows retrieved
                while (rd1.Read())
                {
                    cbScheduleEn.Items.Clear();
                    cbScheduleEn.Items.Add(rd1["schedule"].ToString());
                    rowCount++;
                }

                if (rowCount == 0)
                {
                    // Display error message
                    pnlEnroll.Visible = false;
                    MessageBox.Show("No schedules found for the selected module and level.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                rd1.Close();
            }
            con.Close();
        }

        private void btnBackEn_Click(object sender, EventArgs e)
        {
            frmStudentHome F1 = new frmStudentHome(studID);
            this.Hide();
            F1.ShowDialog();
            this.Close();
        }

        private void cbLvlEn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbScheduleEn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbModuleEn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

