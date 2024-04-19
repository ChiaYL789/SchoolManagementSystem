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
using System.Xml.Linq;

namespace assignment3
{



    public partial class frmTrainerHome : Form
    {
        public static string trainerID;


        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public frmTrainerHome()
        {
            InitializeComponent();
        }
        public frmTrainerHome(string un)
        {
            InitializeComponent();
            trainerID = un;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddCC addModule = new frmAddCC(trainerID);
            addModule.ShowDialog();
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCClist moduleList = new frmCClist(trainerID);
            moduleList.ShowDialog();
            this.Close();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGiveFeedback feedback = new frmGiveFeedback();
            feedback.ShowDialog();
            this.Close();
        }

        private void btnStdList_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewStdList studentlist = new frmViewStdList(trainerID);
            studentlist.ShowDialog();
            this.Close();
        }

        private void btnUserProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTrainerProfile profile = new frmTrainerProfile(trainerID);
            profile.ShowDialog();
            this.Close();
        }

        private void frmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT trainerName FROM Trainer WHERE trainerID = '" + trainerID + "'",con);
            string trainerName = cmd.ExecuteScalar()?.ToString();
            lblName.Text = trainerName;
            con.Close();

            Trainer obj1 = new Trainer(trainerID);
            Trainer.viewProfile(obj1);

            lblName.Text = obj1.TrainerName;
            lblTPNum.Text = obj1.TrainerID;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin lg = new frmLogin();
            lg.ShowDialog();
            this.Close();
        }

        private void lblTPNum_Click(object sender, EventArgs e)
        {

        }
    }
}
