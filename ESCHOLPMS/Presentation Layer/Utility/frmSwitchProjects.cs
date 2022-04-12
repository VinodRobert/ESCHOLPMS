using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESCHOLPMS  
{
    public partial class frmSwitchProjects : Form
    {
        PMS pm = new PMS();
        public frmSwitchProjects()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSwitchProjects_Load(object sender, EventArgs e)
        {
            string currentProject = Convert.ToString(GlobalVariables.ProjectName);
            lblCurrentProject.Text = currentProject;
            int loginID = Convert.ToInt32(GlobalVariables.LoginID);
            DataSet ds = pm.FetchProjects(loginID);
            cmbProjects.DataSource = ds.Tables[0];
            cmbProjects.Text = "Select Project";
            cmbProjects.Refresh();
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            Int16 newProjectID = Convert.ToInt16(cmbProjects.SelectedValue);
            if (GlobalVariables.projectID != newProjectID)
            {
                GlobalVariables.projectID = Convert.ToInt16(newProjectID);
                DataSet dsProjectDetails = pm.FetchProjectDetails(newProjectID);
                GlobalVariables.costCentreID = Convert.ToInt16(dsProjectDetails.Tables[0].Rows[0]["CostCentreID"]);
                GlobalVariables.ProjectName = Convert.ToString(cmbProjects.Text);
                this.Visible = false;
                this.Close();
                frmMain _main = new frmMain();
                _main.Show();
            }
        }
    }
}
