using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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

    public partial class frmTrainerProfile : Form
    {
        public static string trainerID;
        private string trainerName;
        private string gender;


        public frmTrainerProfile()
        {
            InitializeComponent();
        }
        public frmTrainerProfile(string id)
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

        private void frmTrainerProfile_Load(object sender, EventArgs e)
        {
            Trainer obj1 = new Trainer(trainerID);
            Trainer.viewProfile(obj1);

            txtTrainerName.Text = obj1.TrainerName;
            txtGender.Text = obj1.Gender;
            txtEmail.Text = obj1.Email;
            txtContactNo.Text = "0" + obj1.ContactNumber.ToString();
            txtAddress.Text = obj1.Address;
            txtTrainerID.Text = obj1.TrainerID;
            txtPassword.Text = obj1.Password;
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtPassword.Text == "" || txtAddress.Text == "" || txtContactNo.Text == "")
            {
                MessageBox.Show("Please fill in all your details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                string updatedAddress = txtAddress.Text;
                string updatedEmail = txtEmail.Text;
                string updatedContactNumber = txtContactNo.Text;
                string updatedPassword = txtPassword.Text;

                if (txtEmail.Text.Contains("@") && txtEmail.Text.EndsWith("mail.com"))
                {
                    if (txtContactNo.Text.Length == 10 && txtContactNo.Text.StartsWith("01"))
                    {
                        if (!(int.TryParse(updatedContactNumber, out int updatedContact)))
                        {
                            MessageBox.Show("Please input a valid contact number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            if (updatedPassword.Length >= 8)
                            {
                                Trainer profile = new Trainer(trainerName, gender, updatedEmail, updatedContact, updatedAddress, trainerID, updatedPassword);
                                profile.EditProfile();
                                MessageBox.Show("Your profile is updated successfully. ", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Your password must be at least 8 characters long. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please input a 10-digit contact numnber.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                else
                {
                    MessageBox.Show("Please input a valid email. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void txtTrainerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTrainerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (btnShow.Text == "Show")
            {
                txtPassword.PasswordChar = '\0';
                btnShow.Text = "Hide";
            }
            else
            {
                txtPassword.PasswordChar = '*';
                btnShow.Text = "Show";
            }
        }
    }
}

