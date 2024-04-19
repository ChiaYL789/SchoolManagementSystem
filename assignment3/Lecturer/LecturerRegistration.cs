using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asmt5._0
{
    public partial class LecturerRegistration : Form
    {
        public LecturerRegistration()
        {
            InitializeComponent();
        }

        //clear input
        private void Clear()
        {
            name_tb.Clear();
            gender_cb.SelectedItem = null;
            contact_tb.Clear();
            email_tb.Clear();
            address_tb.Clear();
            tp_tb.Clear();
            password_tb.Clear();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            string password = password_tb.Text;

            if (email_tb.Text.Contains("@") && email_tb.Text.EndsWith("mail.com"))
            {
                if (contact_tb.Text.Length == 10 && contact_tb.Text.StartsWith("01"))
                {
                    if (password.Length >= 8)
                    {
                        string patternID = "^SA[0-9]{3}$";
                        if (Regex.IsMatch(tp_tb.Text, patternID))
                        {
                            Lecturer objRegister = new Lecturer(tp_tb.Text, password_tb.Text, name_tb.Text, gender_cb.Text, contact_tb.Text, email_tb.Text, address_tb.Text, month_cb.Text);
                            objRegister.Register();
                            Clear();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect format. Please follow SA___");
                            tp_tb.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password must be at least 8 characters long.");
                        password_tb.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid contact number");
                    contact_tb.Clear();
                }
            }
            else
            {
                MessageBox.Show("Invalid email address");
                email_tb.Clear();
            }
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            if(show_btn.Text == "Show")
            {
                password_tb.PasswordChar = '\0';
                show_btn.Text = "Hide";
            }
            else
            {
                password_tb.PasswordChar = '*';
                show_btn.Text = "Show";
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLecturerHome home = new frmLecturerHome();
            home.ShowDialog();
            this.Close();
        }

        private void LecturerRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
