using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment3
{

    public partial class frmGiveFeedback : Form
    {
        public frmGiveFeedback()
        {
            InitializeComponent();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTrainerHome home = new frmTrainerHome();
            home.ShowDialog();
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string subject;
            string feedback;

            if (cmbFeedback.Text == "" || txtFeedback.Text == "")
            {
                MessageBox.Show("Please fill in all the required details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                subject = cmbFeedback.Text;
                feedback = txtFeedback.Text;

                AdminFeedback adminFeedback = new AdminFeedback(subject, feedback);
                adminFeedback.SendFeedback();

                MessageBox.Show("Your feedback was sent to the admin.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnFeedbackClear_Click(object sender, EventArgs e)
        {
            cmbFeedback.SelectedItem = null;
            txtFeedback.Clear();
        }

        private void frmGiveFeedback_Load(object sender, EventArgs e)
        {

        }
    }
}
