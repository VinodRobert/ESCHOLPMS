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
    public partial class frmMain : Form
    {
        string UserName = ESCHOLPMS.GlobalVariables.UserName;
        string ProjectName = ESCHOLPMS.GlobalVariables.ProjectName;
        int UserRolesList = ESCHOLPMS.GlobalVariables.UserRole;


        

        public frmMain()
        {
            InitializeComponent();
        }

        

         

        

         

         
        

       

        
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            stripLoginName.Text = "Project :  " + ProjectName;
            stripProjectName.Text = "                                                                     Login User : " + UserName;
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepartment department = new frmDepartment();
            department.Show();
        }

        private void gettingKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuthToken authToken = new frmAuthToken();
            authToken.Show();
        }

        private void fetchAccessPointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccessSites accessSites = new frmAccessSites();
            accessSites.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfEmployees listEmployee = new frmListOfEmployees();
            listEmployee.Show();
        }

        private void designationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDesignation frmDesignation = new frmDesignation();
            frmDesignation.Show();
        }

        private void costCentresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCostCentre costCentre = new frmCostCentre();
            costCentre.Show();
        }

        private void getOrganizationIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrganizationID orgID = new frmOrganizationID();
            orgID.Show();
        }

        private void fetchAccessPointsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAccessPoints accessPoints = new frmAccessPoints();
            accessPoints.Show();
        }

        private void fetchUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccessUsers accessUsers = new frmAccessUsers();
            accessUsers.Show();
        }

        private void fetchAccessHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccessHistory accessHistory = new frmAccessHistory();
            accessHistory.Show();
        }

        private void clientBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientBill clientBill = new frmClientBill();
            clientBill.Show();
        }

        private void newLabourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLabourLists ll = new frmLabourLists();
            ll.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uploadDocumentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLabourListsCertificate fc = new frmLabourListsCertificate();
            fc.Show();
        }
    }
}
