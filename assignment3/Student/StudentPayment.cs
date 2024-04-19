using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASSIGNMENT
{
    public partial class frmPay : Form
    {

        public static string studID;

        public frmPay(string id)
        {
            InitializeComponent();
            studID = id;
            //student ID passed here
        }

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        private void frmPay_Load(object sender, EventArgs e)
        {
            pnlApay.Visible = true;
            pnlViewinv.Visible = false;
            pnlApay.BringToFront();
            pnlViewinv.SendToBack();

            // Initialize the total amount variables
            decimal totalAmount = 0;

            Student module1 = new Student(studID);

            con.Open();

            // Retrieve the total amount from CoachingClass using a nested SQL query with SUM
            SqlCommand cmd1 = new SqlCommand("SELECT SUM(amount) AS TotalAmount FROM CoachingClass WHERE ClassID IN (SELECT ClassID FROM Module WHERE StudentID = @studentID)", con);
            cmd1.Parameters.AddWithValue("@studentID", studID);
            object totalAmountObj = cmd1.ExecuteScalar();

            if (totalAmountObj != DBNull.Value)
            {
                totalAmount = Convert.ToDecimal(totalAmountObj);
            }

            // Retrieve the payment from the Module table using select sql query
            SqlCommand cmd3 = new SqlCommand("SELECT Payment FROM Module WHERE StudentID = @studentID AND ClassID = @classID", con);
            cmd3.Parameters.AddWithValue("@studentID", studID);

            cmd3.Parameters.AddWithValue("@classID", module1.allmodule());
            object paymentObj = cmd3.ExecuteScalar();
            con.Close();

            // Update the labels on the form with the retrieved values
            lblTotalAmount.Text = totalAmount.ToString();

            //View invoice using sqlquery, then display on datagridview
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT c.Name,c.amount, c.level FROM CoachingClass c JOIN Module m ON c.ClassID = m.ClassID WHERE m.StudentID = @studentID", con);
            cmd.Parameters.AddWithValue("@studentID", studID);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable invoiceData = new DataTable();
                invoiceData.Load(reader);
                dgvInvoicePay.DataSource = invoiceData;
            }

            // executes a SELECT query to retrieve the payment status from the Module table.
            //then uses the SqlCommand object paymentStatusCmd to specify the SQL query and the necessary parameters.
            SqlCommand paymentStatusCmd = new SqlCommand("SELECT payment FROM Module WHERE StudentID = @studentID AND ClassID = @classID", con);

            //@studentID parameter is set to the value of the studID variable,
            paymentStatusCmd.Parameters.AddWithValue("@studentID", studID);

            //@classID parameter is set to the result of the allmodule() method of the module1 object
            paymentStatusCmd.Parameters.AddWithValue("@classID", module1.allmodule());

            //The ExecuteScalar() method is then called to retrieve the first column of the first row in the result set.
            object paymentStatusObj = paymentStatusCmd.ExecuteScalar();

            //The result is stored in the paymentStatusObj variable,
            //which can be used to check the payment status later in the code.
            con.Close();
            con.Close();

            // Update the labels on the form with the retrieved values
            lblTotalAmount.Text = totalAmount.ToString();
            lblTotalinInvoice.Text = totalAmount.ToString();

            if (paymentStatusObj != DBNull.Value)
            {
                string paymentStatus = paymentStatusObj.ToString();
                lblPaymentstatus.Text = paymentStatus;
            }
        }


        private void btnConfirmPay_Click(object sender, EventArgs e)
        {
            {
                con.Open();

                //update the database table when payment made(button clicked)
                SqlCommand updateCmd = new SqlCommand("UPDATE Module SET payment = @newStatus WHERE payment = 'pending' AND StudentID = @studentID", con);
                updateCmd.Parameters.AddWithValue("@newStatus", "paid"); // Set the new status value to Completed
                updateCmd.Parameters.AddWithValue("@studentID", studID); // Use the logged-in student ID
                int rowsAffected = updateCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                
                //checks if the payment update operation was successful by verifying the number of rows affected by the UPDATE statement
                {
                    //If success, it displays a message box and updates the payment status label accordingly
                    MessageBox.Show("Payment Success.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    lblPaymentstatus.Text = "paid";
                }
                else
                {
                    //else if failed, it displays an error message box indicating that the payment failed.
                    MessageBox.Show("Payment Failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
        }

        private void btnBackP_Click(object sender, EventArgs e)
        {
            frmStudentHome F1 = new frmStudentHome(studID);
            this.Hide();
            F1.ShowDialog();
            this.Close();
        }

        private void btnInvoiceP_Click(object sender, EventArgs e)
        {
            pnlViewinv.Visible = true;
            pnlApay.Visible = false;
            pnlViewinv.BringToFront();
            pnlApay.SendToBack();
        }

        private void btnBackInvoiceToAP_Click(object sender, EventArgs e)
        {
            pnlApay.Visible = true;
            pnlViewinv.Visible = false;
            pnlApay.BringToFront();
            pnlViewinv.SendToBack();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
