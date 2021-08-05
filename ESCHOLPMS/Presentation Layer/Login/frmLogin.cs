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
        ESCHOLPMS.AMS ams = new AMS();

        public frmLogin()
        {
            InitializeComponent();
        }
        private void ResetAll()
        {
            txtPassword.Text = "";
            txtUserName.Text = "";
            rdLan.Checked = true;
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            ResetAll();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            if (txtUserName.Text == "")
                return;
            if (txtPassword.Text == "")
                return;
            if (rdLan.Checked == true)
                GlobalVariables.connectedBy = 0;
            if (rdRemote.Checked == true)
                GlobalVariables.connectedBy = 1;

            DataSet ds = ams.Login(txtUserName.Text.Trim(), txtPassword.Text.Trim());

            int existing = Convert.ToInt16(ds.Tables[0].Rows.Count);
            if (existing == 0)
            {
                MessageBox.Show("Invalid User ID or Password ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                btnLogin.Enabled = true;
                return;
            }
            else
            {
                GlobalVariables.UserName = Convert.ToString(ds.Tables[0].Rows[0]["LOGINNAME"]);
                GlobalVariables.ProjectName = Convert.ToString(ds.Tables[0].Rows[0]["PROJECTNAME"]);

                this.Visible = false;
                frmMain _main = new frmMain();
                _main.Show();

            }
        }
    }
}
