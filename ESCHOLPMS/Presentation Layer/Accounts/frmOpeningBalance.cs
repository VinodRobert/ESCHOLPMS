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
    public partial class frmOpeningBalance : Form
    {
        Accounts ac = new Accounts();
        Int16 finYear;
        public frmOpeningBalance()
        {
            InitializeComponent();
        }

        private void frmOpeningBalance_Load(object sender, EventArgs e)
        {
            gridLedgers.Visible = false;
            panelAdditions.Visible = false;
            lblSubLedger.Visible = false;
            cmbSubLedger.Visible = false;
            btnFetchSubLedger.Visible = false;
            DataSet dsFinYear = ac.fetchLastFinYears();
            cmbFinYear.DataSource = dsFinYear.Tables[0];
            cmbFinYear.Text = "Select FinYear";
            cmbFinYear.Refresh();
        }

        private void LoadMissingLedgers()
        {
            DataSet dsLedgers = ac.FetchMissingLedgers(finYear);
            cmbLedger.DataSource = dsLedgers.Tables[0];
            cmbLedger.Text = "Select Ledger";
            cmbLedger.Refresh();
            cmbLedger.Visible = true;
            lblLedger.Visible = true;
        }

        private void LoadExistingLedgers()
        {
            DataSet dsLedgers = ac.FetchExistingLedgers(finYear);
            cmbLedger.DataSource = dsLedgers.Tables[0];
            cmbLedger.Text = "Select Ledger";
            cmbLedger.Refresh();
            cmbLedger.Visible = true;
            lblLedger.Visible = true;
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            if (cmbFinYear.Text != "Select FinYear")
            {
                finYear = Convert.ToInt16(cmbFinYear.SelectedValue);
                cmbFinYear.Enabled = false;
                LoadGrid();
            }
        }
        private void LoadGrid()
        {
                gridLedgers.DataSource = null;
                DataSet dsLedgers = ac.fetchLedgersSubLedgersForOB(finYear);
                gridLedgers.DataSource = dsLedgers.Tables[0];
                gridLedgers.Refresh();
                gridLedgers.Visible = true;
                panelAdditions.Visible = true;
                LoadMissingLedgers();
        }

        private void ResetAll()
        {
            lblLedger.Visible = false;
            cmbLedger.Visible = false;
            btnFetchSubLedger.Visible = false;
            chkNoSubLedger.Checked = true;
            lblSubLedger.Visible = false;
            cmbSubLedger.Visible = false;
            btnAdd.Visible = false;
            panelAdditions.Visible = false;
        }

         

       

        private void chkNoSubLedger_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNoSubLedger.Checked == true)
                LoadMissingLedgers();
            else
            {
                LoadExistingLedgers();
                btnFetchSubLedger.Visible = true;
            }
        }

        private void btnFetchSubLedger_Click(object sender, EventArgs e)
        {
            if (cmbLedger.Text == "Select Ledger")
                return;
            Int32 ledgerCode = Convert.ToInt32(cmbLedger.SelectedValue);
            Int32 controlAccountCode = ac.fetchControlAccountCode(ledgerCode);
            DataSet dsSubLedgers = ac.fetchSubLedgersOfControlAccount(controlAccountCode,finYear);
            cmbSubLedger.DataSource = dsSubLedgers.Tables[0];
            cmbSubLedger.Refresh();
            cmbSubLedger.Text = "Select Sub Ledger";
            cmbSubLedger.Visible = true;
            lblSubLedger.Visible = true;
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Int32 ledgerCode = Convert.ToInt32(cmbLedger.SelectedValue);
            Int32 subLedgerCode = Convert.ToInt32(cmbSubLedger.SelectedValue);
            int j = ac.addLedgerSubLedgerForOB(ledgerCode, subLedgerCode, finYear);
           
            ResetAll();
            gridLedgers.Visible = false;
            MessageBox.Show("Success !!!");
            LoadGrid();
        }
    }
}
