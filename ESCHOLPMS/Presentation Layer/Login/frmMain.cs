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
        General gen = new General();
        public frmMain()
        {
            InitializeComponent();
        }

        private void DisableTabs()
        {
            DataSet ds = gen.FetchAllTabs();
            int tabOrder;

            for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                tabOrder = Convert.ToInt16(ds.Tables[0].Rows[i]["TABORDER"]);
                MainMenu.Items[tabOrder].Visible = false;

            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            stripLoginName.Text = "Project :  " + ProjectName;
            stripProjectName.Text = "                                                                     Login User : " + UserName;
          
          
            DisableTabs();
            EnableTabs();
        
        }

        private void EnableTabs()
        {
            int loginID = GlobalVariables.LoginID;
            DataSet ds = gen.FetchPermittedTabs(loginID);
            string tabName = string.Empty;
            int tabOrder;
       
            for (int i = 0; i<= ds.Tables[0].Rows.Count-1; i++)
            {
                tabName = Convert.ToString(ds.Tables[0].Rows[i]["TabName"]);
                tabOrder = Convert.ToInt16(ds.Tables[0].Rows[i]["TABORDER"]);
                MainMenu.Items[tabOrder].Visible = true;
            }
            MainMenu.Items[1].Visible = true;
        }
       

        private void gettingKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuthToken authToken = new frmAuthToken();
            authToken.Show();
        }

        private void fetchAccessPointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccessGateways accessSites = new frmAccessGateways();
            accessSites.Show();
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
            frmListSubContractor_Workers cl = new frmListSubContractor_Workers();
            cl.Show();
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

       

        private void assignAccessPointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProjectAccessPoints pa = new frmProjectAccessPoints();
            pa.Show();
        }

        private void privateWorksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrivateWorks fpw = new frmPrivateWorks();
            fpw.Show();
        }

        private void stockIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStockIssueToPrivateWorks issue = new frmStockIssueToPrivateWorks();
            issue.Show();
        }

        private void stockReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStockReturnFromPrivateWorks returns = new frmStockReturnFromPrivateWorks();
            returns.Show();
        }

        private void stockReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStockMovement sm = new frmStockMovement();
            sm.Show();
        }

        private void accessCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmList_ForAccessCards ac = new frmList_ForAccessCards();
            ac.Show();
        }

        private void sampleUserUploadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSampleUserUpload su = new frmSampleUserUpload();
            su.Show();
        }

        private void listOfCompleteLaboursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmList_CompleteLabours cl = new frmList_CompleteLabours();
            cl.Show();
        }

     
        private void terminateLabourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmList_ForTransferOut to = new frmList_ForTransferOut();
            to.Show();
        }

        private void transferOutLabourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmList_ForTransferIn ti = new frmList_ForTransferIn();
            ti.Show();
        }

        private void subContractorLabourListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListSubContractor_Workers cl = new frmListSubContractor_Workers();
            cl.Show();
        }

        private void subContractorDebitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmSubContractorDebits sd = new frmSubContractorDebits();
            //sd.Show();
        }

      

        private void toolStripLinkedAccounts_Click(object sender, EventArgs e)
        {
            frmLinkedAccounts lc = new frmLinkedAccounts();
            lc.Show();
        }

        private void wBSReorderingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWBSRenumbering wbr = new frmWBSRenumbering();
            wbr.Show();
        }

      

        private void departmentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDepartment department = new frmDepartment();
            department.Show();
        }

        private void designationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDesignation frmDesignation = new frmDesignation();
            frmDesignation.Show();
        }

        private void employeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmListOfEmployees listEmployee = new frmListOfEmployees();
            listEmployee.Show();
        }

      

        private void costCentresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCostCentre costCentre = new frmCostCentre();
            costCentre.Show();
        }

       

      

       

        private void clientBIllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmClientBill clientBill = new frmClientBill();
            clientBill.Show();
        }


        private void projectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfProjects lp = new frmListOfProjects();
            lp.Show();
        }

      
        private void menuContractors_Click(object sender, EventArgs e)
        {
            frmContractLabours cl = new frmContractLabours();
            cl.Show();
        }

        private void menuLogins_Click(object sender, EventArgs e)
        {
            frmEshcolLogins el = new frmEshcolLogins();
            el.Show();
        }

        private void switchProjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSwitchProjects sp = new frmSwitchProjects();
            sp.Show();
        }

        private void switchProjectsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSwitchProjects sp = new frmSwitchProjects();
            sp.Show();
        }

        private void fixTBDifferenceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmFixTB fixTB = new frmFixTB();
            fixTB.Show();
        }

        private void missingLedgerCodesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCheckLedgerCode cl = new frmCheckLedgerCode();
            cl.Show();
        }

        private void openingBalanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmOpeningBalance op = new frmOpeningBalance();
            op.Show();
        }

        private void viewAttendanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLabourAttendance la = new frmLabourAttendance();
            la.Show();
        }

        

        private void listOfAssignCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfAccessCards LC = new frmListOfAccessCards();
            LC.Show();
        }

        private void unAssignCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnAssignAccessCard uc = new frmUnAssignAccessCard();
            uc.Show();
        }

        private void assignCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAssignAccessCard ac = new frmAssignAccessCard();
            ac.Show();
        }
    }
}
