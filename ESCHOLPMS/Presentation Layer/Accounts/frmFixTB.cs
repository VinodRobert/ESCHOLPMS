using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace ESCHOLPMS 
{
    public partial class frmFixTB : Form
    {
        Accounts ac = new Accounts();
        DataTable dtRow;
        public frmFixTB()
        {
            InitializeComponent();
        }

        private void FetchDifference()
        {
            if (txtFinYear.Text == "")
                return;
            Int16 finYear = Convert.ToInt16(txtFinYear.Text);
            if (finYear < 2021)
                return;
            DataSet dsDifference = ac.fetchOutofBalanceGroups(finYear);
            gridGroupIndex.DataSource = dsDifference.Tables[0];
            int counts = dsDifference.Tables[0].Rows.Count;
            if (counts == 0)
                panelCorrection.Visible = false;
            else
                panelCorrection.Visible = true;
            txtGroupIndex.Text = "";
        }
        private void btnFetch_Click(object sender, EventArgs e)
        {
            FetchDifference();
            ResetAll();
        }

        private void frmFixTB_Load(object sender, EventArgs e)
        {
            panelCorrection.Visible = false;
            btnSaveGroup.Visible = false;
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
          
            if (txtGroupIndex.Text == "")
                return;
            Int64 groupIndex = Convert.ToInt64(txtGroupIndex.Text);
            DataSet dsSingleTransaction = ac.fetchSingleTransactionGroup(groupIndex);
            if (dsSingleTransaction.Tables[0].Rows.Count == 0)
                return;
            dtRow = dsSingleTransaction.Tables[0];
            Decimal totalDebit = Convert.ToDecimal(dtRow.Compute("SUM(Debit)", string.Empty));
            Decimal totalCredit = Convert.ToDecimal(dtRow.Compute("SUM(Credit)", string.Empty));
            Decimal totalDifference = totalDebit - totalCredit;
            txtDifference.Text = Convert.ToString(totalDifference);
            gridDistribution.DataSource = dsSingleTransaction.Tables[0];
            gridDistribution.Refresh();
            gridDistribution.Visible = true;
            lblDifference.Visible = true;
            txtDifference.Visible = true;

            if (totalDifference==0)
            {
                lblRowID.Visible = false;
                btnUpdateLine.Visible = false;
                lblCorrection.Visible = false;
                txtRowID.Visible = false;
                btnSaveGroup.Visible = false;
                txtRowID.Text = "";
                txtCorrection.Value = 0.0;
            }
            else
            {
                lblRowID.Visible = true;
                txtRowID.Visible = true;
                lblCorrection.Visible = true;
                txtCorrection.Visible = true;
                txtCorrection.Value = -1.0 * txtDifference.Value;
                btnUpdateLine.Visible = true;
            }
        
        }

        private void btnUpdateLine_Click(object sender, EventArgs e)
        {
            if (txtCorrection.Text == "")
                return;
            decimal correction = Convert.ToDecimal(txtCorrection.Value);
            Int64 editedRowID = Convert.ToInt64(txtRowID.Text);
            string criteria = "ROWID=" + Convert.ToString(editedRowID);
            DataRow[] editedRow = dtRow.Select(criteria);

            Decimal debitValue = Convert.ToDecimal(editedRow[0]["Debit"]);
            Decimal creditValue = Convert.ToDecimal(editedRow[0]["Credit"]);
            if (debitValue > 0)
                editedRow[0]["Debit"] = debitValue  + correction;
            if (creditValue > 0)
                editedRow[0]["Credit"] = creditValue + correction;
            editedRow[0]["EditStatus"] = 1;
            dtRow.AcceptChanges();

            
            Decimal totalDebit = Convert.ToDecimal(dtRow.Compute("SUM(Debit)", string.Empty));
            Decimal totalCredit = Convert.ToDecimal(dtRow.Compute("SUM(Credit)", string.Empty));
            Decimal totalDifference = totalDebit - totalCredit;
            txtDifference.Text = Convert.ToString(totalDifference);

            if (totalDifference == 0)
            {
                btnSaveGroup.Visible = true;
                btnUpdateLine.Visible = false;
            }
            
        }

        private void ResetAll()
        {
            lblCorrection.Visible = false;
            txtCorrection.Text = "";
            btnUpdateLine.Visible = false;
            btnSaveGroup.Visible = false;
            txtRowID.Text = "";
            txtDifference.Text = "";
            lblRowID.Visible = false;
            btnUpdateLine.Visible = false;
            txtCorrection.Visible = false;
            lblDifference.Visible = false;
            txtDifference.Visible = false;
            gridDistribution.Visible = false;
            txtRowID.Visible = false;
        }
        private void btnSaveGroup_Click(object sender, EventArgs e)
        {
            string criteria = "EDITSTATUS=1";
            DataRow[] editedRow = dtRow.Select(criteria);

            Decimal debitValue = Convert.ToDecimal(editedRow[0]["Debit"]);
            Decimal creditValue = Convert.ToDecimal(editedRow[0]["Credit"]);
            Int64 transactionID = Convert.ToInt64(editedRow[0]["RowID"]);
            int j = ac.updateTransactions(transactionID, debitValue, creditValue);
            MessageBox.Show("Success");
            ResetAll();
            panelCorrection.Visible = false;
            FetchDifference();
        }
    }
}
 