using Syncfusion.Windows.Forms.Grid;
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
    public partial class frmStockRegister : Form
    {
        public TransferReports tp = new TransferReports();
        public frmStockRegister()
        {
            InitializeComponent();
        }

        private void ReSetAll()
        {
            this.gridReport.ShowGroupDropArea = true;
            this.gridReport.Splitter.BackColor = Color.Green;
            this.gridReport.HierarchicalGroupDropArea = true;
            this.gridReport.TableOptions.AllowMultiColumnSort = true;
            this.gridReport.TopLevelGroupOptions.ShowFilterBar = true;
            this.gridReport.ThemesEnabled = true;
            this.gridReport.ShowNavigationBar = true;
            this.gridReport.RecordNavigationBar.BackColor = Color.Green;
            this.gridReport.RecordNavigationBar.ForeColor = Color.White;


            this.gridReport.ActivateCurrentCellBehavior = GridCellActivateAction.None;
            this.gridReport.ShowGroupDropArea = true;
            this.gridReport.TableOptions.AllowSortColumns = true;
            this.gridReport.TopLevelGroupOptions.ShowCaption = true;
            this.gridReport.TableOptions.RecordPreviewRowHeight = 55;
            this.gridReport.TableOptions.ShowRowHeader = false;
            this.gridReport.TableOptions.SelectionBackColor = Color.FromArgb(255, 128, 128);
            this.gridReport.TableOptions.SelectionTextColor = Color.Maroon;
            this.gridReport.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;
            this.gridReport.TableOptions.DefaultColumnWidth = 65;
            this.gridReport.TableOptions.CaptionRowHeight = 22;
            this.gridReport.InvalidateAllWhenListChanged = true;
            this.gridReport.ForceDisposeOnResetDataSource = true;
            this.gridReport.AllowResetTableDescriptorWhenDataSourceSetNull = true;
            this.gridReport.CacheRecordValues = false;
            this.gridReport.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue;
            this.gridReport.Font = new Font("Calibri", 11.0f);
            this.gridReport.TopLevelGroupOptions.ShowFilterBar = true;
            this.gridReport.TableOptions.AllowSelection = GridSelectionFlags.Row;
            this.gridReport.Table.DefaultRecordRowHeight = 25;
            this.gridReport.Table.DefaultColumnHeaderRowHeight = 50;
            this.gridReport.Appearance.AlternateRecordFieldCell.BackColor = Color.LightGoldenrodYellow;

        }

        private void LoadCostCentre()
        {
            DataSet ds = tp.FetchCostCentre();
            cmbCostCentre.DataSource = ds.Tables[0];
            cmbCostCentre.Refresh();
        }

        private void LoadPeriods()
        {
            DataTable dtFromYears = tp.FetchYears();
            cmbFromYear.DataSource = dtFromYears;
            cmbFromYear.Refresh();

            DataTable dtToYears = tp.FetchYears();
            cmbToYear.DataSource = dtToYears;
            cmbToYear.Refresh();

            DataTable dtFromMonth = tp.FetchMonths();
            cmbFromMonth.DataSource = dtFromMonth;
            cmbToMonth.Refresh();

            DataTable dtToMonth = tp.FetchMonths();
            cmbToMonth.DataSource = dtToMonth;
            cmbToMonth.Refresh();
        }
        private void LoadDetail(DataTable _dt)
        {
            gridReport.DataSource = _dt;

            gridReport.TableDescriptor.Columns[0].HeaderText = "Stock Category";
            gridReport.TableDescriptor.Columns[0].Width = 275;
            gridReport.TableDescriptor.Columns[0].AllowFilter = true;
            gridReport.TableDescriptor.Columns[1].AllowGroupByColumn = true;

            gridReport.TableDescriptor.Columns[1].HeaderText = "Stock Name";
            gridReport.TableDescriptor.Columns[1].Width = 350;
            gridReport.TableDescriptor.Columns[1].AllowFilter = true;
            gridReport.TableDescriptor.Columns[1].AllowGroupByColumn = true;

            gridReport.TableDescriptor.Columns[2].HeaderText = "Unit";
            gridReport.TableDescriptor.Columns[2].Width = 100;
            gridReport.TableDescriptor.Columns[2].AllowFilter = false;


            gridReport.TableDescriptor.Columns[3].HeaderText = "Opening Stock";
            gridReport.TableDescriptor.Columns[3].Width = 150;
            gridReport.TableDescriptor.Columns[3].AllowFilter = false;
            gridReport.TableDescriptor.Columns[3].AllowGroupByColumn = false;
            gridReport.TableDescriptor.Columns[3].Appearance.AnyCell.Format = "F2";

            gridReport.TableDescriptor.Columns[4].HeaderText = "Receipts";
            gridReport.TableDescriptor.Columns[4].Width = 150;
            gridReport.TableDescriptor.Columns[4].AllowGroupByColumn = false;
            gridReport.TableDescriptor.Columns[4].AllowFilter = false;
            gridReport.TableDescriptor.Columns[4].Appearance.AnyCell.Format = "F2";

            gridReport.TableDescriptor.Columns[5].HeaderText = "Issues";
            gridReport.TableDescriptor.Columns[5].Width = 150;
            gridReport.TableDescriptor.Columns[5].AllowFilter = false;
            gridReport.TableDescriptor.Columns[5].AllowGroupByColumn = false;
            gridReport.TableDescriptor.Columns[5].Appearance.AnyCell.Format = "F2";

            gridReport.TableDescriptor.Columns[6].HeaderText = "Closing Stock";
            gridReport.TableDescriptor.Columns[6].Width = 150;
            gridReport.TableDescriptor.Columns[6].AllowFilter = false;
            gridReport.TableDescriptor.Columns[6].AllowGroupByColumn = false;
            gridReport.TableDescriptor.Columns[6].Appearance.AnyCell.Format = "F2";

        
            gridReport.Visible = true;
        }

        private void frmCSTMReport_Load(object sender, EventArgs e)
        {
            ReSetAll();
            LoadCostCentre();
            LoadPeriods();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            int costCentreID = Convert.ToInt16(cmbCostCentre.SelectedValue);
            int fromYear = Convert.ToInt16(cmbFromYear.SelectedValue);
            int fromMonth = Convert.ToInt16(cmbFromMonth.SelectedValue);
            int toYear = Convert.ToInt16(cmbToYear.SelectedValue);
            int toMonth = Convert.ToInt16(cmbToMonth.SelectedValue);

            DataSet dsStock = tp.FetchStock(costCentreID, fromYear, fromMonth, toYear, toMonth);
            LoadDetail(dsStock.Tables[0]);

        }
    }
}
