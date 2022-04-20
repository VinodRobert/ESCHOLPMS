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
            frmList_ActiveLabours ll = new frmList_ActiveLabours();
            ll.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uploadDocumentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmList_CertificateUpload fc = new frmList_CertificateUpload();
            fc.Show();
        }

        private void approveDocumentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmList_ApproveCertificate fa = new frmList_ApproveCertificate();
            fa.Show();
        }

        private void transferOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmList_ForTransferOut to = new frmList_ForTransferOut();
            to.Show();
        }

        private void listOfSubContractorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmContractorsLabours cl = new frmContractorsLabours();
            //cl.Show();
        }

        private void terminateLaboursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmList_ApproveTerminateForEver tr = new frmList_ApproveTerminateForEver();
            tr.Show();
        }

        private void listTerminatedLaboursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmList_ApproveTerminateForEver fa = new frmList_ApproveTerminateForEver();
            fa.Show();
        }

        private void transferInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmList_ForTransferIn ti = new frmList_ForTransferIn();
            ti.Show();
        }

        private void updateJobStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmList_ForChangingAccounts ca = new frmList_ForChangingAccounts();
            ca.Show();
        }

        private void listOfInactiveLaboursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmList_Complete cl = new frmList_Complete();
            cl.Show();
        }

        private void listOfProjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfProjects lp = new frmListOfProjects();
            lp.Show();
        }

        private void listContractorsAndLaboursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContractLabours cl = new frmContractLabours();
            cl.Show();
        }

        private void listEshcolLoginsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEshcolLogins el = new frmEshcolLogins();
            el.Show();
        }

        private void switchProjetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSwitchProjects sp = new frmSwitchProjects();
            sp.Show();
        }

        private void fixTBDifferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFixTB fixTB = new frmFixTB();
            fixTB.Show();
        }

        private void missingLedgerCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCheckLedgerCode cl = new frmCheckLedgerCode();
            cl.Show();
        }

        private void openingBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOpeningBalance op = new frmOpeningBalance();
            op.Show();
        }
    }
}
