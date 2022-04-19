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
    public partial class frmCheckLedgerCode : Form
    {
        Accounts ac = new Accounts();
        public frmCheckLedgerCode()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            DataSet ds = ac.fetchLedgerIDWhichIsZero();
            if (ds.Tables[0].Rows.Count == 0)
                lblResult.Text = "No Transaction Having Zero Ledger ID";
            else
            {
                gridEmpty.DataSource = ds.Tables[0];
                gridEmpty.Refresh();
                gridEmpty.Visible = true;
            }

        }
    }
}
