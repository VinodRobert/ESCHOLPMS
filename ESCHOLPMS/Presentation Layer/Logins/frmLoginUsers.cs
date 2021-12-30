using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESCHOLPMS.Business_Layer.V2;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid;

namespace ESCHOLPMS.Presentation_Layer.Logins
{
    public partial class frmLoginUsers : Form
    {
        EscholV2 v2 = new EscholV2();
        public frmLoginUsers()
        {
            InitializeComponent();
        }
        private void ResetAll()
        {
            
        }
        private void LoadActiveLogins()
        {
            DataSet ds = v2.fetchActiveLogins();
            gridUsers.DataSource = null;
            gridUsers.DataSource = ds.Tables[0];

            gridUsers.TableOptions.AllowSelection = GridSelectionFlags.Row;

            gridUsers.Refresh();
        }
        private void frmLoginUsers_Load(object sender, EventArgs e)
        {

            LoadActiveLogins();
            ResetAll();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (btnNew.Text == "New")
            {
                ResetAll();
                btnNew.Text = "Update";
            }
            else
            {
                if (txtUserID.Text == "")
                    return;
                int j = v2.addLoginDetails(txtUserID.Text.Trim(), txtLoginName.Text.Trim(),1);

            }
            LoadActiveLogins();
            MessageBox.Show("Succcess!!");

        }

        
    }
}
