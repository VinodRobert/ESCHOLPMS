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
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Drawing;

namespace ESCHOLPMS 
{
    public partial class frmWBSRenumbering : Form
    {
        BillingDepartment bd = new BillingDepartment();
        DataSet dsWBS;
        public frmWBSRenumbering()
        {
            InitializeComponent();
        }
        private void LoadProjects()
        {
            DataSet ds = bd.FetchProjectsHavingBOQUploaded();
            cmbProjects.DataSource = ds.Tables[0];
            cmbProjects.Refresh();
        }
        private void frmWBSRenumbering_Load(object sender, EventArgs e)
        {
            ResetAll();
            LoadProjects();
        }
        public void ResetAll()
        {

            gridWBS.Visible = false;
            this.gridWBS.ActivateCurrentCellBehavior = GridCellActivateAction.None;
            this.gridWBS.ShowGroupDropArea = false;
            this.gridWBS.TableOptions.AllowSortColumns = false;
            this.gridWBS.TopLevelGroupOptions.ShowCaption = false;
            this.gridWBS.TableOptions.RecordPreviewRowHeight = 55;
            this.gridWBS.TableOptions.ShowRowHeader = false;
            this.gridWBS.TableOptions.SelectionBackColor = Color.FromArgb(255, 128, 128);
            this.gridWBS.TableOptions.SelectionTextColor = Color.Maroon;
            this.gridWBS.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;
            this.gridWBS.TableOptions.DefaultColumnWidth = 65;
            this.gridWBS.TableOptions.CaptionRowHeight = 22;
            this.gridWBS.InvalidateAllWhenListChanged = true;
            this.gridWBS.ForceDisposeOnResetDataSource = true;
            this.gridWBS.AllowResetTableDescriptorWhenDataSourceSetNull = true;
            this.gridWBS.CacheRecordValues = false;
            this.gridWBS.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue;
            this.gridWBS.Font = new Font("Calibri", 9.0f);

            //this.gridWBS.TableDescriptor.AllowEdit = false;
            lblAlert.Visible = false;

        }
        private void btnFetch_Click(object sender, EventArgs e)
        {
            if (btnFetch.Text == "Fetch")
            {
                if (cmbProjects.Text == "Select Project")
                    return;
                int costCentreID = Convert.ToInt16(cmbProjects.SelectedValue);


                dsWBS = bd.FetchWBSLoaded(costCentreID);
                LoadDetail(dsWBS.Tables[0]);
                btnFetch.Text = "Update";
                lblAlert.Visible = true;
            }
            else
            {
                dsWBS.AcceptChanges();

                if (btnFetch.Text == "Update")
                    UpdateOrderNumbers();
            }
        }
        private void LoadDetail(DataTable _dt)
        {
            gridWBS.DataSource = _dt;
            gridWBS.Visible = true;
            gridWBS.TableDescriptor.Columns[0].HeaderText = "ScheduledCode";
            gridWBS.TableDescriptor.Columns[0].Width = 0;
          

            gridWBS.TableDescriptor.Columns[1].HeaderText = "Client BOQ";
            gridWBS.TableDescriptor.Columns[1].Width = 100;
           

            gridWBS.TableDescriptor.Columns[2].HeaderText = "Description";
            gridWBS.TableDescriptor.Columns[2].Width = 500;
          
           


            gridWBS.TableDescriptor.Columns[3].HeaderText = "UOM";
            gridWBS.TableDescriptor.Columns[3].Width = 100;
           

    

            this.gridWBS.TableModel.Cols.FreezeRange(0, 3);

            gridWBS.TableDescriptor.Columns[4].HeaderText = "Display Order";
            gridWBS.TableDescriptor.Columns[4].Width = 120;

            gridWBS.TableDescriptor.Columns[5].HeaderText = "Origianl Order";
            gridWBS.TableDescriptor.Columns[5].Width = 0;


            this.gridWBS.TableDescriptor.Appearance.AnyCell.WrapText = true;
            this.gridWBS.TableDescriptor.Appearance.AnyCell.AutoSize = true;//automatically increase the cell height
            this.gridWBS.TableDescriptor.Appearance.AnyCell.AllowEnter = true;//Accept the EnterKey in a cell

            this.gridWBS.Table.DefaultRecordRowHeight =  40;
            gridWBS.TableDescriptor.Columns[4].Appearance.AnyRecordFieldCell.ReadOnly = false;
        } 

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateOrderNumbers()
        {
            DataTable dt = dsWBS.Tables[0];
            Decimal originalNo;
            Decimal newNo;
            Int32  scheduleCode;
            foreach (DataRow row in dt.Rows)
            {
                originalNo = Convert.ToDecimal(row.Field<decimal>("OriginalOrder"));
                newNo = Convert.ToDecimal(row.Field<decimal>("NewDisplayOrder"));
                scheduleCode = Convert.ToInt32(row.Field<Int32>("SCHEDULECODE"));
                if (originalNo != newNo)
                    bd.UpdateDisplayOrder(scheduleCode, originalNo, newNo);
            }
            MessageBox.Show("Success !!!!");
            this.Close();
        }
        private void gridWBS_QueryCellStyleInfo(object sender, GridTableCellStyleInfoEventArgs e)
        {
           
        }
    }
}
