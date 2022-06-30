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
    public partial class frmStockIssueToPrivateWorks : Form
    {
        PRIVATEWORKS pw = new PRIVATEWORKS();
        DataSet dsStock;
        public frmStockIssueToPrivateWorks()
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
            DataSet ds = pw.Fetch();
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
            LoadStock();
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
           
            decimal inStock;
            decimal issueQty;
            int materialID;
            for (int i = 0; i <= dsStock.Tables[0].Rows.Count-1;i++)
            {
               
                inStock = Convert.ToDecimal(dsStock.Tables[0].Rows[i]["Qty"]);
                issueQty = Convert.ToDecimal(dsStock.Tables[0].Rows[i]["ISSUEQTY"]);
                if (issueQty> inStock) {
                    MessageBox.Show("Stock Issue Must be Less Than Stock Qty ");
                    return;
                } 
                    
            }
            DataSet dsLastTransfer = pw.GetLastTransferID();
            int lastTransferID;
            lastTransferID = Convert.ToInt32(dsLastTransfer.Tables[0].Rows[0]["TransferID"]);
            DateTime issueDate = Convert.ToDateTime(dtIssueDate.Value);
            for (int i = 0; i <= dsStock.Tables[0].Rows.Count - 1; i++)
            {
                materialID = Convert.ToInt16(dsStock.Tables[0].Rows[i]["MATERIALID"]);
                inStock = Convert.ToDecimal(dsStock.Tables[0].Rows[i]["Qty"]);
                issueQty = Convert.ToDecimal(dsStock.Tables[0].Rows[i]["ISSUEQTY"]);
                if (issueQty >0)
                {
                    pw.Issue(lastTransferID,privateJobID, issueDate, issueQty, materialID);
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
    }
}
