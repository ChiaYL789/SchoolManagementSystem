using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace assignment3
{
    public partial class frmAddCC : Form
    {


        private string trainerID;

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public frmAddCC()
        {
            InitializeComponent();
        }

        public frmAddCC(string id)
        {
            InitializeComponent();
            trainerID = id;
        }

        private async void btnAddNew_Click(object sender, EventArgs e)
        {
            string moduleName;
            string moduleLevel;
            string classID;
            string schedule;
            int moduleCharge;
            string day;
            string time;


            if (cmbModuleName.Text == "" || txtCharge.Text == "" || cmbboxDay.Text == "" || cmbboxTime.Text == "" || txtClassID.Text == "")
            {
                MessageBox.Show("Please fill in all the required details.");
            }
            else
            {
                // assign value to var 

                moduleName = cmbModuleName.Text;

                moduleLevel = cmbModuleLevel.Text;

                classID = txtClassID.Text;

                bool validcharge = true;
                int charge = 0;
                if (int.TryParse(txtCharge.Text, out charge))
                {
                    if (cmbModuleLevel.Text == "Beginner")
                    {
                        if (!(charge >= 200 && charge <= 300))
                        {
                            MessageBox.Show("For Beginner Level, please only input a charge range of RM200 to RM300");
                            validcharge = false;
                        }
                    }
                    if (cmbModuleLevel.Text == "Intermediate")
                    {
                        if (!(charge >= 400 && charge <= 500))
                        {
                            MessageBox.Show("For Intermediate Level, please only input a charge range of RM400 to RM500");
                            validcharge = false;
                        }
                    }
                    if (!(cmbModuleLevel.Text == "Advance"))
                    {
                        if (charge >= 600 && charge <= 700)
                        {
                            MessageBox.Show("For Advance Level, please only input a charge range of RM600 to RM700");
                            validcharge = false;
                        }
                    }
                    bool validClassID = Regex.IsMatch(classID, @"^M\d{3}$");
                    if (!validClassID)
                    {
                        MessageBox.Show("Please enter a valid class ID starting with 'M' followed by 3 digits.");
                        return;
                    }
                    //valdate no duplicate classID
                    con.Open();
                    SqlCommand checkDuplicateCmd = new SqlCommand("SELECT COUNT(*) FROM CoachingClass WHERE ClassID = @classID", con);
                    checkDuplicateCmd.Parameters.AddWithValue("@classID", classID);
                    int duplicateCount = (int)checkDuplicateCmd.ExecuteScalar();
                    con.Close();
                    if (duplicateCount > 0)
                    {
                        MessageBox.Show("Duplicate ClassID. Please enter a unique ClassID.");
                        return;
                    }

                    if (validcharge)
                    {

                        day = cmbboxDay.SelectedItem.ToString();
                        time = cmbboxTime.SelectedItem.ToString();
                        schedule = day + " (" + time + ") ";

                        Trainer_ModuleClass moduleClass = new Trainer_ModuleClass(moduleName, charge, moduleLevel, schedule, trainerID, classID);
                        moduleClass.AddCC();
                        MessageBox.Show("New coaching class has been successfully added.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid input for charge.");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTrainerHome home = new frmTrainerHome();
            home.ShowDialog();
            this.Close();
        }

        private void btnAddClear_Click(object sender, EventArgs e)
        {
            cmbModuleName.SelectedItem = null;
            txtCharge.Clear();  
            cmbboxTime.SelectedItem = null;
            cmbboxDay.SelectedItem = null;
        }

        private void frmAddCC_Load(object sender, EventArgs e)
        {

            con.Open();

            DataTable dt = new DataTable();
            string sql = "Select DISTINCT Module from AssignModule where TrainerID = '" + trainerID + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            con.Close();

            Collection<string> assignedmodules = new Collection<string>(); 
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string currentmodule = dt.Rows[i]["Module"].ToString();

                if (i > 0)
                {
                    for (int j = 0; j < assignedmodules.Count; j++)
                    {
                        if (currentmodule == assignedmodules[j])
                        {
                            break;
                        }
                        else
                        {
                            assignedmodules.Add(currentmodule);
                        }
                    }
                }
                else
                {
                    assignedmodules.Add(currentmodule);
                }
            }

            cmbModuleName.DataSource = assignedmodules;

            ExtractLevel();

    }

        private void cmbModuleName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExtractLevel();
        }

        private void ExtractLevel()
        {
            string selectedmodule = cmbModuleName.Text;


            con.Open();

            DataTable dt = new DataTable();
            string sql = "Select Level from AssignModule where TrainerID = '" + trainerID + "' and Module = '" + selectedmodule + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            con.Close();

            Collection<string> modulelevel = new Collection<string>();  

            for (int i = 0;i < dt.Rows.Count; i++)
            {
                modulelevel.Add(dt.Rows[i]["Level"].ToString());
            }

            cmbModuleLevel.DataSource = modulelevel;    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
