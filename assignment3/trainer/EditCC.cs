using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment3
{
    public partial class frmEditCC : Form
    {
        private string selectedModule;
        private string selectedLevel;
        private string selectedID;
        private string selectedSchedule;
        private string trainerID;


        public frmEditCC(string s, string l, string id, string sch, string tid)
        {
            InitializeComponent();
            selectedModule = s;
            selectedLevel = l;
            selectedID = id;
            selectedSchedule = sch;
            trainerID = tid;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtCharge.Text == "" && cmbboxDay.Text == "" && cmbboxTime.Text == "")
            {
                MessageBox.Show("Please fill in all the required details.");
            }
            else
            {
                if (txtCharge.Text != "")
                {
                    bool validcharge = true;
                    bool validscheule = true;
                    int newCharge = 0;
                    if (int.TryParse(txtCharge.Text, out newCharge))
                    {
                        if (lblLevel.Text == "Beginner")
                        {
                            if (!(newCharge >= 200 && newCharge <= 300))
                            {
                                MessageBox.Show("For Beginner Level, please only input a charge range of RM200 to RM300", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                validcharge = false;
                            }
                        }
                        if (lblLevel.Text == "Intermediate")
                        {
                            if (!(newCharge >= 400 && newCharge <= 500))
                            {
                                MessageBox.Show("For Intermediate Level, please only input a charge range of RM400 to RM500", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                validcharge = false;
                            }
                        }
                        if (lblLevel.Text == "Advance")
                        {
                            if (!(newCharge >= 600 && newCharge <= 700))
                            {
                                MessageBox.Show("For Advanced Level, please only input a charge range of RM600 to RM700", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                validcharge = false;
                            }
                        }
                    }

                    else
                    {
                        validcharge = false;
                        MessageBox.Show("Please enter a valid charge", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    if (validcharge)
                    {
                        Trainer_ModuleClass moduleclass = new Trainer_ModuleClass(newCharge, "");
                        moduleclass.EditCharge(selectedID);
                    }

                    if (cmbboxDay.Text == "" || cmbboxTime.Text == "")
                    {
                        validscheule = false;
                        MessageBox.Show("Please provide both the day and time to update the schedule.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string newDay = cmbboxDay.Text.ToString();
                        string newTime = cmbboxTime.Text.ToString();
                        string newschedule = newDay + " (" + newTime + ")";

                        Trainer_ModuleClass moduleclass = new Trainer_ModuleClass(0,newschedule);
                        moduleclass.EditSchedule(selectedID);
                    }

                    if (validcharge && validscheule)
                    {
                        MessageBox.Show("Edit successful.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCClist moduleList = new frmCClist(trainerID);
            moduleList.ShowDialog();
            this.Close();
        }

        private void frmEditModule_Load(object sender, EventArgs e)
        {
            lblModuleName.Text = selectedModule;
            lblLevel.Text = selectedLevel;
            lblShowID.Text = selectedID;

            string day;
            string time;

            string[] splitschedule = selectedSchedule.Split(' ');
            day = splitschedule[0];
            //time = splitschedule[1] + " " +  splitschedule[2] + " " +  splitschedule[3];
            //time = time.Substring(1, time.Length - 2);
            string lstrip = splitschedule[1].Trim('(');
            string rstrip = splitschedule[3].Trim(')');
            time = lstrip + " " + splitschedule[2] + " " + rstrip;
            cmbboxDay.Text = day;
            cmbboxTime.Text = time;
        }
    }
}
