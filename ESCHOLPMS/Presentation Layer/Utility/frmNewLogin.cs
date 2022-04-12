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
    public partial class frmNewLogin : Form
    {
        General ge = new General();
        public frmNewLogin()
        {
            InitializeComponent();
        }

        private void LoadCompany()
        {
            DataSet dsCompany = ge.FetchListofCompany();
            cmbCompany.DataSource = dsCompany.Tables[0];
            cmbCompany.Refresh();
        }
        private void frmNewLogin_Load(object sender, EventArgs e)
        {
            txtLoginID.Visible = false;
            LoadCompany();
            
        }

        private void cmbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCompany.Text == "Select Company")
                return;
            DataSet dsSites = ge.FetchListofSites(Convert.ToInt32(cmbCompany.SelectedValue));
            cmbSite.DataSource = dsSites.Tables[0];
            cmbSite.Text = "Select Site";
            cmbSite.Refresh();

            DataSet dsRoles = ge.FetchListofLoginRoles();
            cmbLoginRoles.DataSource = dsRoles.Tables[0];
            cmbLoginRoles.Text = "Select Role";
            cmbLoginRoles.Refresh();

        }

        private void cmbLoginRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLoginRoles.Text == "Select Roles")
                return;
            if (cmbSite.Text == "Select Site")
                return;
            txtLoginID.Text = "";
            txtLoginID.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtLoginID.Text == "")
                return;
            int roleID = Convert.ToInt16(cmbLoginRoles.SelectedValue);
            int siteID = Convert.ToInt16(cmbSite.SelectedValue);
            int companyID = Convert.ToInt16(cmbCompany.SelectedValue);
            string loginName = Convert.ToString(txtLoginID.Text.Trim());
            int i = ge.CreateNewLogin(loginName, roleID, siteID, companyID);
            MessageBox.Show("Successfully Created User ");
            this.Close();
            return;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            return;
        }
    }
}
