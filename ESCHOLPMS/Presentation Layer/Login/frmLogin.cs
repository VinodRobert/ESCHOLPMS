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
   

    public partial class frmLogin : Form
    {
        ESCHOLPMS.PMS ams = new PMS();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void myEventHander(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }


        private void ResetAll()
        {
            txtPassword.Text = "";
            txtUserName.Text = "";
            lblProject.Visible = false;
            cmbProjects.Visible = false;
           
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            ResetAll();
            foreach (Control ctl in this.Controls)
            {
                ctl.KeyDown += myEventHander;
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            if (txtUserName.Text == "")
                return;
            if (txtPassword.Text == "")
                return;
           

        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            DataSet dsLogin =new DataSet();
            DataSet dsProjects = new DataSet();
            btnLogin.Enabled = false;
            if (btnLogin.Text == "Login")
            {
                if (txtUserName.Text == "")
                {
                    btnLogin.Enabled = true;
                    return;
                }
                if (txtPassword.Text == "")
                {
                    btnLogin.Enabled = true;
                    return;
                }
                dsLogin = ams.Login(txtUserName.Text.Trim(), txtPassword.Text.Trim());

                int existing = Convert.ToInt16(dsLogin.Tables[0].Rows.Count);
                if (existing == 0)
                {
                    MessageBox.Show("Invalid User ID or Password ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    btnLogin.Enabled = true;
                    return;
                }
                txtPassword.Enabled = false;
                txtUserName.Enabled = false;
                Int16 loginID;
                loginID = Convert.ToInt16(dsLogin.Tables[0].Rows[0]["LOGINID"]);
                GlobalVariables.LoginID = Convert.ToInt16(loginID);
                GlobalVariables.UserName = Convert.ToString(dsLogin.Tables[0].Rows[0]["LOGINNAME"]);
                dsProjects = ams.FetchProjects(loginID);

                if (dsProjects.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No Projects Attached To This User. Contact Admin ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    btnLogin.Enabled = true;
                    this.Close();
                }

                cmbProjects.DataSource = dsProjects.Tables[0];
                cmbProjects.Refresh();
                lblProject.Visible = true;
                cmbProjects.Visible = true;

                btnLogin.Text = "Select";
                btnLogin.Enabled = true;
            }
            else
            {
                if (cmbProjects.Text == "Select Project Name")
                {
                    btnLogin.Enabled = true;
                    return;
                }
                int projectID = Convert.ToInt16(cmbProjects.SelectedValue);
                DataSet dsProjectDetails = ams.FetchProjectDetails(projectID);
                if (dsProjectDetails.Tables[0].Rows.Count == 0)
                    GlobalVariables.costCentreID = 0;
                else
                    GlobalVariables.costCentreID = Convert.ToInt16(dsProjectDetails.Tables[0].Rows[0]["CostCentreID"]);
                GlobalVariables.ProjectName = Convert.ToString(cmbProjects.Text);
                GlobalVariables.UserID = Convert.ToString(txtUserName.Text);
                DataSet dsSpintly = ams.GetAccessKeyDetails();
                GlobalVariables.access_token = dsSpintly.Tables[0].Rows[0]["AuthorizationKey"].ToString();
                GlobalVariables.spintlyOrgID = Convert.ToInt16(dsSpintly.Tables[0].Rows[0]["OrganizationID"]);

                DataSet dsAccessPoints = ams.FetchAccessPointsDetails(projectID);
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
                frmMain _main = new frmMain();
                _main.Show();
            }



        }
    }
}
