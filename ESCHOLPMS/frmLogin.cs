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
            int connectedBy;
            if (txtUserName.Text == "")
                return;
            if (txtPassword.Text == "")
                return;
            if (rdLan.Checked)
                connectedBy = 0;
            else
                connectedBy = 1;
            int j = ams.Login(txtUserName.Text.Trim(), txtPassword.Text.Trim(), connectedBy);
        }
    }
}
