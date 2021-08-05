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
    }
}
