using Syncfusion.WinForms.DataGrid.Enums;
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
    public partial class frmStockReturnFromPrivateWorks : Form
    {
        PRIVATEWORKS pw = new PRIVATEWORKS();
        DataSet dsStock;
        public frmStockReturnFromPrivateWorks()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadPrivateWorks()
        {
            pw = new PRIVATEWORKS();
            DataSet ds = pw.getStockIssued(0);
            cmbPrivateJobs.DataSource = ds.Tables[0];
            cmbPrivateJobs.Refresh();
        }
        private void ResetAll()
        {
            cmbPrivateJobs.Text = "Select Job";
            this.gridResult.ShowRowHeader = true;
            this.gridResult.Style.RowHeaderStyle.BackColor = Color.CadetBlue;
            this.gridResult.Style.RowHeaderStyle.SelectionMarkerThickness = 4;
            this.gridResult.Style.RowHeaderStyle.SelectionMarkerColor = Color.Red;
            this.gridResult.Style.RowHeaderStyle.SelectionBackColor = Color.White;
        }

        private void LoadStock()
        {
            dsStock = pw.LoadClosingStock();
            gridResult.DataSource = dsStock.Tables[0];
            gridResult.Refresh();
        }
        private void frmStockIssueToPrivateWorks_Load(object sender, EventArgs e)
        {
            ResetAll();
            LoadPrivateWorks();
            
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            int privateJobID;
            if (cmbPrivateJobs.Text == "Select Project")
            {
                MessageBox.Show("Project Selected");
                return;
            }
            else
            {
                privateJobID = Convert.ToInt32(cmbPrivateJobs.SelectedValue);

            }
            decimal returnQty;
            decimal issuedQty;
            int materialID;
            for (int i = 0; i <= dsStock.Tables[0].Rows.Count-1;i++)
            {
               
                issuedQty = Convert.ToDecimal(dsStock.Tables[0].Rows[i]["ISSUEDQTY"]);
                returnQty = Convert.ToDecimal(dsStock.Tables[0].Rows[i]["RETURNQTY"]);
                if (returnQty > issuedQty) {
                    MessageBox.Show("Stock Issued Qty Must be Greater Than Stock Return Qty ");
                    return;
                } 
                    
            }

            DataSet dsLastTransfer = pw.GetLastTransferID();
            int lastTransferID;
            lastTransferID = Convert.ToInt32(dsLastTransfer.Tables[0].Rows[0]["TransferID"]);


            DateTime returnDate = Convert.ToDateTime(dtReturnDate.Value);
            for (int i = 0; i <= dsStock.Tables[0].Rows.Count - 1; i++)
            {
                materialID = Convert.ToInt16(dsStock.Tables[0].Rows[i]["MATERIALID"]);
                issuedQty = Convert.ToDecimal(dsStock.Tables[0].Rows[i]["ISSUEDQTY"]);
                returnQty = Convert.ToDecimal(dsStock.Tables[0].Rows[i]["RETURNQTY"]);
                if (returnQty > 0)
                {
                    pw.Return(privateJobID, returnDate, returnQty, materialID,lastTransferID);
                }

            }
            pw.IncrementTransferID();
            MessageBox.Show("Success !!!");
            this.Close();
        }

        private void gridResult_DrawCell(object sender, Syncfusion.WinForms.DataGrid.Events.DrawCellEventArgs e)
        {
            if (gridResult.ShowRowHeader && e.RowIndex != 0)
            {
                if (e.ColumnIndex == 0)
                {
                    e.DisplayText = e.RowIndex.ToString();
                }

            }
        }

        private void gridResult_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow)
            {
                if (e.RowIndex % 2 == 0)
                    e.Style.BackColor = Color.Lavender;
                else
                    e.Style.BackColor = Color.AliceBlue;
            }
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            if (cmbPrivateJobs.Text =="Select Project")
            {
                MessageBox.Show("Select Project ");
                return;
            }

            int privateJobID = Convert.ToInt32(cmbPrivateJobs.SelectedValue);
            dsStock = pw.getStockIssued(privateJobID);
            gridResult.DataSource = dsStock.Tables[0];
            gridResult.Refresh();
            btnFetch.Enabled = false;
        }
    }
}
