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
    public partial class frmISTMReport : Form
    {
        public TransferReports tp = new TransferReports();
        public frmISTMReport()
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
            this.gridReport.Font = new Font("Calibri",10.0f);
            this.gridReport.TopLevelGroupOptions.ShowFilterBar = true;
            this.gridReport.TableOptions.AllowSelection = GridSelectionFlags.Row;
            this.gridReport.Table.DefaultRecordRowHeight = 25;
            this.gridReport.Table.DefaultColumnHeaderRowHeight = 50;
            this.gridReport.Appearance.AlternateRecordFieldCell.BackColor = Color.LightGoldenrodYellow;

        }

        private void LoadDetail(DataTable _dt)
        {
            gridReport.DataSource = _dt;

            gridReport.TableDescriptor.Columns[0].HeaderText = "GRN";
            gridReport.TableDescriptor.Columns[0].Width = 100;
            gridReport.TableDescriptor.Columns[0].AllowFilter = true;
            gridReport.TableDescriptor.Columns[1].AllowGroupByColumn = true;

            gridReport.TableDescriptor.Columns[1].HeaderText = "GRN Date";
            gridReport.TableDescriptor.Columns[1].Width = 150;
            gridReport.TableDescriptor.Columns[1].Appearance.AnyCell.CellType = "Date";
            gridReport.TableDescriptor.Columns[1].AllowFilter = true;
            gridReport.TableDescriptor.Columns[1].AllowGroupByColumn = true;

            gridReport.TableDescriptor.Columns[2].HeaderText = "From Project";
            gridReport.TableDescriptor.Columns[2].Width = 350;
            gridReport.TableDescriptor.Columns[2].AllowFilter = true;
            gridReport.TableDescriptor.Columns[2].AllowGroupByColumn = true;

            gridReport.TableDescriptor.Columns[3].HeaderText = "To Project";
            gridReport.TableDescriptor.Columns[3].Width = 350;
            gridReport.TableDescriptor.Columns[3].AllowGroupByColumn = true;
            gridReport.TableDescriptor.Columns[3].AllowFilter = true;

            gridReport.TableDescriptor.Columns[4].HeaderText = "Vehicle #";
            gridReport.TableDescriptor.Columns[4].Width = 90;
            gridReport.TableDescriptor.Columns[4].AllowFilter = true;
            gridReport.TableDescriptor.Columns[4].AllowGroupByColumn = true;

            gridReport.TableDescriptor.Columns[5].HeaderText = "Material";
            gridReport.TableDescriptor.Columns[5].Width = 250;
            gridReport.TableDescriptor.Columns[5].AllowFilter = true;
            gridReport.TableDescriptor.Columns[5].AllowGroupByColumn = true;

            gridReport.TableDescriptor.Columns[6].HeaderText = "Unit";
            gridReport.TableDescriptor.Columns[6].Width = 100;
            gridReport.TableDescriptor.Columns[6].AllowFilter = false;

            gridReport.TableDescriptor.Columns[7].HeaderText = "Issued Qty";
            gridReport.TableDescriptor.Columns[7].Width = 100;
            gridReport.TableDescriptor.Columns[7].AllowFilter = false;
            gridReport.TableDescriptor.Columns[7].Appearance.AnyCell.Format = "F2";

            gridReport.TableDescriptor.Columns[8].HeaderText = "Accepted Qty";
            gridReport.TableDescriptor.Columns[8].Width = 100;
            gridReport.TableDescriptor.Columns[8].Appearance.AnyCell.Format = "F2";
            gridReport.TableDescriptor.Columns[8].AllowGroupByColumn = false;


            gridReport.TableDescriptor.Columns[9].HeaderText = "Remarks";
            gridReport.TableDescriptor.Columns[9].Width = 100;
            gridReport.TableDescriptor.Columns[9].AllowFilter = false;
            gridReport.TableDescriptor.Columns[9].AllowGroupByColumn = false;

            gridReport.TableDescriptor.Columns[10].HeaderText = "Notes";
            gridReport.TableDescriptor.Columns[10].Width = 100;
            gridReport.TableDescriptor.Columns[10].AllowFilter = false;
            gridReport.TableDescriptor.Columns[10].AllowGroupByColumn = false;

            gridReport.TableDescriptor.Columns[11].HeaderText = "Prepared By";
            gridReport.TableDescriptor.Columns[11].Width = 200;
            gridReport.TableDescriptor.Columns[11].AllowGroupByColumn = false;
            gridReport.TableDescriptor.Columns[11].AllowFilter = true;

            gridReport.TableDescriptor.Columns[12].HeaderText = "Accepted By";
            gridReport.TableDescriptor.Columns[12].Width = 200;
            gridReport.TableDescriptor.Columns[12].AllowFilter = true;
            gridReport.TableDescriptor.Columns[12].AllowGroupByColumn = false;

            gridReport.TableDescriptor.Columns[13].HeaderText = "Status";
            gridReport.TableDescriptor.Columns[13].Width = 155;
            gridReport.TableDescriptor.Columns[13].AllowFilter = true;
            gridReport.TableDescriptor.Columns[13].AllowGroupByColumn = false;

            ////this.gridReport.TableModel.Cols.FreezeRange(1, 8);
            gridReport.Visible = true;
        }

        private void frmCSTMReport_Load(object sender, EventArgs e)
        {
            ReSetAll();
            DataSet ds = tp.getISTMDetails();
            DataTable dt = ds.Tables[0];
            LoadDetail(dt);
            gridReport.Refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }
    }
}
