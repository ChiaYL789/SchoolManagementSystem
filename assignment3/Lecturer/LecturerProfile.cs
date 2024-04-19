using ASSIGNMENT;
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

namespace asmt5._0
{
    public partial class LecturerProfile : Form
    {
        public static string username;
        string email, contact, address, password;

        SqlDataReader rd;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        private void show_btn_Click(object sender, EventArgs e)
        {
            if (show_btn.Text == "Show")
            {
                newpw_tb.PasswordChar = '\0';
                show_btn.Text = "Hide";
            }
            else
            {
                newpw_tb.PasswordChar = '*';
                show_btn.Text = "Show";
            }
        }

        private void LecturerProfile_Load(object sender, EventArgs e)
        {
            Lecturer lecturer = new Lecturer(username);

            Lecturer.viewProfile(lecturer);


            // Update the UI labels with the retrieved student data
            ID_lb.Text = username;
            name_lb.Text = lecturer.LecturerName1;
            email_tb.Text = lecturer.LecturerEmail1;
            newpw_tb.Text = lecturer.LecturerPassword1;
            contact_tb.Text = "0"+lecturer.LecturerContactNo1;
            address_tb.Text = lecturer.LecturerAddress1;

            //txtContactNo.Text = "0" + obj1.ContactNumber.ToString();

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLecturerHome home = new frmLecturerHome();
            home.ShowDialog();
            this.Close();
        }

        public LecturerProfile()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public LecturerProfile(string un)
        {
            InitializeComponent();
            username = un;
        }

        private void clear()
        {
            email_tb.Clear();
            address_tb.Clear();
            contact_tb.Clear();
            newpw_tb.Clear();
        }

        private void saveprofile_btn_Click(object sender, EventArgs e)
        {
            if (email_tb.Text.Contains("@") && email_tb.Text.EndsWith("mail.com"))
            {
                if (contact_tb.Text.Length == 10 && contact_tb.Text.StartsWith("01"))
                {
                    password = newpw_tb.Text;

                    if (password.Length >= 8)
                    {
                        email = email_tb.Text;
                        contact = contact_tb.Text;
                        address = address_tb.Text;

                        con.Open();
                        SqlCommand cmdProfile1 = new SqlCommand("UPDATE Users SET password = @Password WHERE userID = @Username AND role = 'Lecturer'", con);
                        cmdProfile1.Parameters.AddWithValue("@Password", password);
                        cmdProfile1.Parameters.AddWithValue("@Username", username);
                        cmdProfile1.ExecuteNonQuery();
                        clear();
                        MessageBox.Show("Update Successful");
                        con.Close();

                        con.Open();
                        SqlCommand cmdProfile2 = new SqlCommand("UPDATE Lecturer SET password = @Password, contactNumber = @ContactNum, email = @Email, address = @Address WHERE username = @Username", con);
                        cmdProfile2.Parameters.AddWithValue("@Password", password);
                        cmdProfile2.Parameters.AddWithValue("@ContactNum", contact);
                        cmdProfile2.Parameters.AddWithValue("@Email", email);
                        cmdProfile2.Parameters.AddWithValue("@Address", address);
                        cmdProfile2.Parameters.AddWithValue("@Username", username);
                        cmdProfile2.ExecuteNonQuery();
                        clear();
                        MessageBox.Show("Update Successful");
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Password must be at least 8 characters long.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid contact number");
                }
            }
            else
            {
                MessageBox.Show("Invalid email address");
            }
        }
    }
}
