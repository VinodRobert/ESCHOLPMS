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
    public partial class frmStockMovement : Form
    {
        PRIVATEWORKS pw = new PRIVATEWORKS();
        public frmStockMovement()
        {
            InitializeComponent();
        }

        private void LoadPrivateJobs()
        {
            DataSet dsPrivateJobs = pw.Fetch();
            cmbPrivateJob.DataSource = dsPrivateJobs.Tables[0];
            cmbPrivateJob.Refresh();
        }
        private void ReSetAll()
        {
            cmbPrivateJob.Text = "Select Project";
            btnExport.Visible = false;
            rdBoth.Enabled = true;
            rdIssue.Enabled = false;
            rdReturn.Enabled = false;
        }
        private void frmStockMovement_Load(object sender, EventArgs e)
        {
            ReSetAll();
            LoadPrivateJobs();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (cmbPrivateJob.Text=="Select Project")
            {
                MessageBox.Show("Select Project");
                return;
            }

            int projectID = Convert.ToInt32(cmbPrivateJob.SelectedValue);
            DateTime dtStartDate = Convert.ToDateTime(dtTransferFrom.Value);
            DateTime dtEndDate = Convert.ToDateTime(dtTransferTo.Value);


        }
    }
}
