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
                GlobalVariables.ProjectName = Convert.ToString(cmbProjects.Text);
           
             
                if (dsProjectDetails.Tables[0].Rows.Count == 0)
                    GlobalVariables.costCentreID = 0;
                else
                    GlobalVariables.costCentreID = Convert.ToInt16(dsProjectDetails.Tables[0].Rows[0]["CostCentreID"]);


                DataSet dsAccessPoints = pm.FetchAccessPointsDetails(newProjectID);
                if (dsAccessPoints.Tables[0].Rows.Count == 0)
                {
                    GlobalVariables.spintlyOrgID = 0;
                    GlobalVariables.spintlySiteID = 0;
                    GlobalVariables.spintlyAccessPointID = 0;
                }
                else
                {
                    GlobalVariables.spintlyOrgID = Convert.ToInt16(dsAccessPoints.Tables[0].Rows[0]["OrgID"]);
                    GlobalVariables.spintlySiteID = Convert.ToInt16(dsAccessPoints.Tables[0].Rows[0]["GateWayID"]);
                    GlobalVariables.spintlyAccessPointID = Convert.ToInt16(dsAccessPoints.Tables[0].Rows[0]["AccessPointID"]);
                }

                this.Visible = false;
                this.Close();
                frmMain _main = new frmMain();
                _main.Show();
            }
        }
    }
}
