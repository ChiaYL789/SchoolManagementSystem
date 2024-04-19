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
using System.Xml.Linq;

namespace assignment3
{
    public partial class frmCClist : Form
    {

        private string selectedModule;
        private string selectedLevel;
        private string selectedID;
        private string schedule;
        private string trainerID;

        public frmCClist(string id)
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

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            RetrieveData();
        }

        private void dgvModuleList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                DataGridViewRow row = dgvModuleList.Rows[e.RowIndex];
                selectedModule = row.Cells[1].Value.ToString();
                selectedLevel = row.Cells[2].Value.ToString();
                selectedID = row.Cells[0].Value.ToString();
                schedule = row.Cells[4].Value.ToString();
                lblChosenEdit.Text = selectedModule;
            }


            if (e.ColumnIndex == 6)
            {
                DataGridViewRow row = dgvModuleList.Rows[e.RowIndex];
                selectedModule = row.Cells[1].Value.ToString();
                selectedLevel = row.Cells[2].Value.ToString();
                selectedID = row.Cells[0].Value.ToString();
                schedule = row.Cells[4].Value.ToString();
                lblChosenDelete.Text = selectedModule;
            }
        }

        private void btnEditStdList_Click(object sender, EventArgs e)
        {
            MessageBox.Show(selectedModule);
            if (lblChosenEdit.Text != "")
            {
                this.Hide();
                frmEditCC editModule = new frmEditCC(selectedModule, selectedLevel, selectedID, schedule, trainerID);
                editModule.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("No module was selected to be edited", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDeleteStdLst_Click(object sender, EventArgs e)
        {
            if (lblChosenDelete.Text != "")
            {
                Trainer_ModuleClass moduleclass = new Trainer_ModuleClass();
                moduleclass.DeleteCC(selectedID);
                RetrieveData();
            }
            else
            {
                MessageBox.Show("No module was selected to be deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void RetrieveData()
        {
            DataTable dt = new DataTable();
            Trainer_ModuleClass moduleclass = new Trainer_ModuleClass();
            dt = moduleclass.RetrieveData(trainerID);
            dgvModuleList.AutoGenerateColumns = false;
            dgvModuleList.DataSource = dt;
        }

        private void frmCClist_Load(object sender, EventArgs e)
        {

        }

        private void grpCClist_Enter(object sender, EventArgs e)
        {

        }
    }
}
