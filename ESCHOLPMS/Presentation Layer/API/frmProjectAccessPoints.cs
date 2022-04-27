using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using RestSharp;
using System.IO;
using Syncfusion.Windows.Forms;
using Newtonsoft.Json.Linq;
using ESCHOLPMS.API.OauthToken;
using ESCHOLPMS.API.AccessPoints;

namespace ESCHOLPMS 
{
    public partial class frmProjectAccessPoints : Form
    {
        string spintlyOrgID = Convert.ToString(GlobalVariables.spintlyOrgID);
        string spintlyAccessToken = Convert.ToString(GlobalVariables.access_token);

        AccessPoints accessControledPoints = new AccessPoints();
        PMS pms = new PMS();


        public frmProjectAccessPoints()
        {
            InitializeComponent();
        }

        private void ShowProjectAccessPoints()
        {
            DataSet ds = pms.FetchProjectAccessPoints();
            gridSites.DataSource = ds.Tables[0];
            gridSites.Refresh();
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadProjects()
        {
            Int16 loginID = GlobalVariables.LoginID;
            DataSet dsProjects = pms.FetchProjects(loginID);
            cmbProjects.DataSource = dsProjects.Tables[0];
            cmbProjects.Text = "Select Project";
            cmbProjects.Refresh();
        }

        private void LoadGateWays()
        {
            DataSet dsGateWays = pms.GetAccessSites();
            cmbGateWays.DataSource = dsGateWays.Tables[0];
            cmbGateWays.Text = "Select GateWay";
            cmbGateWays.Refresh();
        }
        private void frmProjectAccessPoints_Load(object sender, EventArgs e)
        {
            ShowProjectAccessPoints();
            LoadProjects();
            LoadGateWays();
              
        }

        private void LoadAccessPoints(int gateWayID)
        {
            DataSet dsAccessPoints = pms.FetchAccessPointsOfGateWay(gateWayID);
            cmbAccessPoint.DataSource = dsAccessPoints.Tables[0];
            cmbAccessPoint.Text = "Select Access Point";
            cmbAccessPoint.Refresh();
        }

        private void ResetAll()
        {
            cmbAccessPoint.DataSource = null;
            cmbAccessPoint.Refresh();
            LoadProjects();
            LoadGateWays();

        }
        private void cmbGateWays_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGateWays.Text == "Select GateWay")
                return;
            int gateWayID = Convert.ToInt16(cmbGateWays.SelectedValue);
            LoadAccessPoints(gateWayID);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbProjects.Text == "Select Project")
                return;
            if (cmbGateWays.Text == "Select GateWay")
                return;
            if (cmbAccessPoint.Text == "Select Access Point")
                return;

            Int16 projectID = Convert.ToInt16(cmbProjects.SelectedValue);
            Int16 gateWayID = Convert.ToInt16(cmbGateWays.SelectedValue);
            Int16 accessPointID = Convert.ToInt16(cmbAccessPoint.SelectedValue);
            int k = pms.ChangeStatus(projectID, gateWayID, accessPointID);
            int j = pms.AddProjectAccessPoint(projectID, gateWayID, accessPointID);
            ShowProjectAccessPoints();
            ResetAll();
        }
    }
}
