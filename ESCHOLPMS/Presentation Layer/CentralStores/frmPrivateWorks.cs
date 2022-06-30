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
    public partial class frmPrivateWorks : Form
    {
        PRIVATEWORKS pw = new PRIVATEWORKS();
        public frmPrivateWorks()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void  LoadGrid()
        {
            pw = new PRIVATEWORKS();
            DataSet ds = pw.Fetch();

    
            List<PRIVATEWORKS> privateWorksList = new List<PRIVATEWORKS>();
            privateWorksList = CommonMethods.ConvertToList<PRIVATEWORKS>(ds.Tables[0]);

            gridResult.DataSource = privateWorksList;
            gridResult.Refresh();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "New")
                btnSave.Text = "Save";
            if (btnSave.Text == "Save")
            {
                if (txtLocation.Text == "")
                {
                    MessageBox.Show("Missing Location");
                    return;
                }
                if (txtPrivateWorks.Text == "")
                {
                    MessageBox.Show("Missing Work Short Name");
                    return;
                }
                if (txtWorkFullName.Text == "")
                {
                    MessageBox.Show("Missing Work Full Name");
                    return;
                }

                pw = new PRIVATEWORKS();
                pw.PRIVATEWORKID = 0;
                pw.WORKSHORTNAME = Convert.ToString(txtPrivateWorks.Text).Trim();
                pw.WORKNAME = Convert.ToString(txtWorkFullName.Text).Trim();
                pw.LOCATION = Convert.ToString(txtLocation.Text).Trim();
                pw.STARTDATE = Convert.ToDateTime(dtStartDate.Value);
                pw.ENDDATE = Convert.ToDateTime(dtEndDate.Value);
                pw.Save();
                MessageBox.Show("Success !!!!");
                LoadGrid();
            }
        }

        private void ReSetAll()
        {
            txtLocation.Text = "";
            txtPrivateWorks.Text = "";
            txtWorkFullName.Text = "";
        }
        private void frmPrivateWorks_Load(object sender, EventArgs e)
        {
            ReSetAll();
            LoadGrid();
        }
    }
}
