using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESCHOLPMS.Business_Layer.MIS;
using Syncfusion.Data;
using Syncfusion.Drawing;
using Syncfusion.GridExcelConverter;
using Syncfusion.GridHelperClasses;
using Syncfusion.GroupingGridExcelConverter;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;

namespace ESCHOLPMS 
{
    public partial class frmClientBill : Form
    {
        DataSet dsProjects;
        DataSet dsClientBills;
        DataSet dsReports;
        DataSet dsResult;

        int costCentreID;
        int clientBillID;
        MIS mis = new MIS();

        public frmClientBill()
        {
            InitializeComponent();
        }

        private void ReSet()
        {
            btnLoad.Enabled = false;
            cmbClientBIll.Enabled = false;
            cmbProjects.Enabled = true;
            btnFetch.Enabled = true;
            cmbReports.Enabled = false;

            btnLoad.Visible = false;
            btnView.Visible = false;
            btnFetch.Visible = true;



            this.gridGeneral.ActivateCurrentCellBehavior = GridCellActivateAction.None;
            this.gridGeneral.ShowGroupDropArea = true;
        
            this.gridGeneral.TopLevelGroupOptions.ShowCaption = true;
            this.gridGeneral.TableOptions.RecordPreviewRowHeight = 55;
            this.gridGeneral.TableOptions.ShowRowHeader = false;
            this.gridGeneral.TableOptions.SelectionBackColor = Color.FromArgb(255, 128, 128);
            this.gridGeneral.TableOptions.SelectionTextColor = Color.Maroon;
            this.gridGeneral.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;
            this.gridGeneral.TableOptions.DefaultColumnWidth = 65;
            this.gridGeneral.TableOptions.CaptionRowHeight = 22;
            this.gridGeneral.InvalidateAllWhenListChanged = true;
            this.gridGeneral.ForceDisposeOnResetDataSource = true;
            this.gridGeneral.AllowResetTableDescriptorWhenDataSourceSetNull = true;
            this.gridGeneral.CacheRecordValues = false;
            this.gridGeneral.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Silver;
            this.gridGeneral.Font = new Font("verdana", 10.0f);
      
            this.gridGeneral.TableDescriptor.Appearance.AnyCell.WrapText = false;
            this.gridGeneral.TableDescriptor.Appearance.AnyCell.Trimming = StringTrimming.EllipsisWord;
            this.gridGeneral.TableDescriptor.Appearance.AnyCell.AutoSize = true;//automatically increase the cell height
            this.gridGeneral.TableDescriptor.Appearance.AnyCell.AllowEnter = true;//Ac

            this.gridGeneral.Table.DefaultRecordRowHeight = 40;

            GridExcelFilter gridExcelFilterG = new GridExcelFilter();

 
            gridExcelFilterG.WireGrid(this.gridGeneral);


            this.gridTripizoidal.ActivateCurrentCellBehavior = GridCellActivateAction.None;
            this.gridTripizoidal.ShowGroupDropArea = true;

            this.gridTripizoidal.TopLevelGroupOptions.ShowCaption = true;
            this.gridTripizoidal.TableOptions.RecordPreviewRowHeight = 55;
            this.gridTripizoidal.TableOptions.ShowRowHeader = false;
            this.gridTripizoidal.TableOptions.SelectionBackColor = Color.FromArgb(255, 128, 128);
            this.gridTripizoidal.TableOptions.SelectionTextColor = Color.Maroon;
            this.gridTripizoidal.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;
            this.gridTripizoidal.TableOptions.DefaultColumnWidth = 65;
            this.gridTripizoidal.TableOptions.CaptionRowHeight = 22;
            this.gridTripizoidal.InvalidateAllWhenListChanged = true;
            this.gridTripizoidal.ForceDisposeOnResetDataSource = true;
            this.gridTripizoidal.AllowResetTableDescriptorWhenDataSourceSetNull = true;
            this.gridTripizoidal.CacheRecordValues = false;
            this.gridTripizoidal.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Silver;
            this.gridTripizoidal.Font = new Font("verdana", 10.0f);

            this.gridTripizoidal.TableDescriptor.Appearance.AnyCell.WrapText = false;
            this.gridTripizoidal.TableDescriptor.Appearance.AnyCell.Trimming = StringTrimming.EllipsisWord;
            this.gridTripizoidal.TableDescriptor.Appearance.AnyCell.AutoSize = true;//automatically increase the cell height
            this.gridTripizoidal.TableDescriptor.Appearance.AnyCell.AllowEnter = true;//Ac

            this.gridTripizoidal.Table.DefaultRecordRowHeight = 40;

            GridExcelFilter gridExcelFilterT = new GridExcelFilter();


            gridExcelFilterT.WireGrid(this.gridTripizoidal);


            this.gridSteel.ActivateCurrentCellBehavior = GridCellActivateAction.None;
            this.gridSteel.ShowGroupDropArea = true;

            this.gridSteel.TopLevelGroupOptions.ShowCaption = true;
            this.gridSteel.TableOptions.RecordPreviewRowHeight = 55;
            this.gridSteel.TableOptions.ShowRowHeader = false;
            this.gridSteel.TableOptions.SelectionBackColor = Color.FromArgb(255, 128, 128);
            this.gridSteel.TableOptions.SelectionTextColor = Color.Maroon;
            this.gridSteel.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;
            this.gridSteel.TableOptions.DefaultColumnWidth = 65;
            this.gridSteel.TableOptions.CaptionRowHeight = 22;
            this.gridSteel.InvalidateAllWhenListChanged = true;
            this.gridSteel.ForceDisposeOnResetDataSource = true;
            this.gridSteel.AllowResetTableDescriptorWhenDataSourceSetNull = true;
            this.gridSteel.CacheRecordValues = false;
            this.gridSteel.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Silver;
            this.gridSteel.Font = new Font("verdana", 10.0f);

            this.gridSteel.TableDescriptor.Appearance.AnyCell.WrapText = false;
            this.gridSteel.TableDescriptor.Appearance.AnyCell.Trimming = StringTrimming.EllipsisWord;
            this.gridSteel.TableDescriptor.Appearance.AnyCell.AutoSize = true;//automatically increase the cell height
            this.gridSteel.TableDescriptor.Appearance.AnyCell.AllowEnter = true;//Ac

            this.gridSteel.Table.DefaultRecordRowHeight = 40;

            GridExcelFilter gridExcelFilterS = new GridExcelFilter();


            gridExcelFilterS.WireGrid(this.gridSteel);





        }
        private void LoadProjects()
        {
            dsProjects = mis.FetchActiveProjects();
            cmbProjects.DataSource = dsProjects.Tables[0];
            cmbProjects.Text = "Select Project";
            cmbProjects.Refresh();
        }

        private void LoadClientBills()
        {
            dsClientBills = mis.FetchClientBills(costCentreID);
            cmbClientBIll.DataSource = dsClientBills.Tables[0];
            cmbClientBIll.Text = "Select Client Bill";
            cmbClientBIll.Refresh();
            cmbClientBIll.Enabled = true;
            btnLoad.Enabled = true;
            btnLoad.Visible = true;

        }
        private void frmClientBill_Load(object sender, EventArgs e)
        {
            ReSet();
            LoadProjects();
            
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            if (cmbProjects.Text != "Select Project")
            {
                costCentreID = Convert.ToInt16(cmbProjects.SelectedValue);
                btnFetch.Enabled = false;
                btnFetch.Visible = false;
                cmbProjects.Enabled = false;
                LoadClientBills();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (cmbClientBIll.Text != "Select Client Bill")
            {
                dsReports = mis.LoadReports();
                cmbReports.DataSource = dsReports.Tables[0];
                cmbReports.Text = "Select Report";
                cmbReports.Refresh();
                cmbReports.Enabled = true;
                cmbReports.Visible = true;
                btnView.Enabled = true;
                btnView.Visible = true;
                btnLoad.Visible = false;

            }
        }

        private void ViewMeasurementBookGeneral()
        {

            dsResult = mis.GenerateMeasurementBookGeneral(clientBillID,0);
            gridGeneral.DataSource = dsResult.Tables[0];
            gridGeneral.Refresh();

            gridGeneral.TableDescriptor.Columns[0].HeaderText = "Description";
            gridGeneral.TableDescriptor.Columns[0].Width = 600;
            gridGeneral.TableDescriptor.Columns[0].AllowFilter = true;
            gridGeneral.TableDescriptor.Columns[0].AllowGroupByColumn = true;
            this.gridGeneral.TableModel.Cols.FreezeRange(0, 0);

            gridGeneral.TableDescriptor.Columns[1].HeaderText = "UOM";
            gridGeneral.TableDescriptor.Columns[1].Width = 70;

            gridGeneral.TableDescriptor.Columns[2].HeaderText = "Grid";
            gridGeneral.TableDescriptor.Columns[2].Width = 80;
            gridGeneral.TableDescriptor.Columns[2].AllowFilter = true;
            gridGeneral.TableDescriptor.Columns[2].AllowGroupByColumn = true;



            gridGeneral.TableDescriptor.Columns[3].HeaderText = "Comments";
            gridGeneral.TableDescriptor.Columns[3].Width = 200;
            gridGeneral.TableDescriptor.Columns[3].AllowFilter = true;

            gridGeneral.TableDescriptor.Columns[4].HeaderText = "Number";
            gridGeneral.TableDescriptor.Columns[4].Width = 80;
        
         

            gridGeneral.TableDescriptor.Columns[5].HeaderText = "Length";
            gridGeneral.TableDescriptor.Columns[5].Width = 80;
            gridGeneral.TableDescriptor.Columns[5].AllowGroupByColumn = false;


            gridGeneral.TableDescriptor.Columns[6].HeaderText = "Breadth";
            gridGeneral.TableDescriptor.Columns[6].Width = 80;
            gridGeneral.TableDescriptor.Columns[6].AllowGroupByColumn = false;
            gridGeneral.TableDescriptor.Columns[6].Appearance.AnyCell.Format = "F2";

            gridGeneral.TableDescriptor.Columns[7].HeaderText = "Width";
            gridGeneral.TableDescriptor.Columns[7].Width = 80;
            gridGeneral.TableDescriptor.Columns[7].AllowGroupByColumn = false;
            gridGeneral.TableDescriptor.Columns[7].Appearance.AnyCell.Format = "F2";

         
            gridGeneral.TableDescriptor.Columns[8].HeaderText = "Quantity";
            gridGeneral.TableDescriptor.Columns[8].Width = 80;
            gridGeneral.TableDescriptor.Columns[8].Appearance.AnyCell.Format = "F2";
            gridGeneral.TableDescriptor.Columns[8].AllowGroupByColumn = false;


            this.gridGeneral.TableDescriptor.GroupedColumns.Add("Description", ListSortDirection.Ascending);

            GridSummaryColumnDescriptor summaryColumnDescriptor = new GridSummaryColumnDescriptor();
            summaryColumnDescriptor.Appearance.AnySummaryCell.Interior = new BrushInfo(Color.FromArgb(192, 255, 162));
            summaryColumnDescriptor.DataMember = "Quantity";
            summaryColumnDescriptor.Format = "{Sum}";
            summaryColumnDescriptor.Name = "TotalQty";
            summaryColumnDescriptor.SummaryType = Syncfusion.Grouping.SummaryType.DoubleAggregate;

            GridSummaryRowDescriptor summaryRowDescriptor = new GridSummaryRowDescriptor();
            summaryRowDescriptor.SummaryColumns.Add(summaryColumnDescriptor);
             
            summaryRowDescriptor.Appearance.AnySummaryCell.Interior = new BrushInfo(Color.FromArgb(255, 231, 162));

            this.gridGeneral.TableDescriptor.SummaryRows.Add(summaryRowDescriptor);

            this.gridGeneral.Appearance.AnySummaryCell.HorizontalAlignment = GridHorizontalAlignment.Right;

        }


        private void ViewMeasurementBookSteel()
        {

            dsResult = mis.GenerateMeasurementBookGeneral(clientBillID, 2);
            gridSteel.DataSource = dsResult.Tables[0];
            gridSteel.Refresh();

            gridSteel.TableDescriptor.Columns[0].HeaderText = "Description";
            gridSteel.TableDescriptor.Columns[0].Width = 600;
            gridSteel.TableDescriptor.Columns[0].AllowFilter = true;
            gridSteel.TableDescriptor.Columns[0].AllowGroupByColumn = true;
            gridSteel.TableModel.Cols.FreezeRange(0, 0);

            gridSteel.TableDescriptor.Columns[1].HeaderText = "Member";
            gridSteel.TableDescriptor.Columns[1].Width = 70;

            gridSteel.TableDescriptor.Columns[2].HeaderText = "Grid";
            gridSteel.TableDescriptor.Columns[2].Width = 80;
            gridSteel.TableDescriptor.Columns[2].AllowGroupByColumn = true;
            
            gridSteel.TableDescriptor.Columns[3].HeaderText = "Diameter";
            gridSteel.TableDescriptor.Columns[3].Width = 80;
            gridSteel.TableDescriptor.Columns[3].AllowGroupByColumn = false;
          
            gridSteel.TableDescriptor.Columns[4].HeaderText = "Number";
            gridSteel.TableDescriptor.Columns[4].Width = 80;
            gridSteel.TableDescriptor.Columns[4].AllowGroupByColumn = false;
            
            gridSteel.TableDescriptor.Columns[5].HeaderText = "Count";
            gridSteel.TableDescriptor.Columns[5].Width = 80;
            gridSteel.TableDescriptor.Columns[5].AllowGroupByColumn = false;
      
            gridSteel.TableDescriptor.Columns[6].HeaderText = "# Bars";
            gridSteel.TableDescriptor.Columns[6].Width = 80;
            gridSteel.TableDescriptor.Columns[6].AllowGroupByColumn = false;

            gridSteel.TableDescriptor.Columns[7].HeaderText = "Length";
            gridSteel.TableDescriptor.Columns[7].Width = 80;
            gridSteel.TableDescriptor.Columns[7].AllowGroupByColumn = false;

            gridSteel.TableDescriptor.Columns[8].HeaderText = " 6 ";
            gridSteel.TableDescriptor.Columns[8].Width = 80;
            gridSteel.TableDescriptor.Columns[8].Width = 80;

            gridSteel.TableDescriptor.Columns[9].HeaderText = " 8 ";
            gridSteel.TableDescriptor.Columns[9].Width = 80;
            gridSteel.TableDescriptor.Columns[9].AllowGroupByColumn = false;
         
            gridSteel.TableDescriptor.Columns[10].HeaderText = " 10 ";
            gridSteel.TableDescriptor.Columns[10].Width = 100;
            gridSteel.TableDescriptor.Columns[10].AllowGroupByColumn = false;

            gridSteel.TableDescriptor.Columns[11].HeaderText = " 12 ";
            gridSteel.TableDescriptor.Columns[11].Width = 80;
            gridSteel.TableDescriptor.Columns[11].Width = 80;

            gridSteel.TableDescriptor.Columns[12].HeaderText = " 16 ";
            gridSteel.TableDescriptor.Columns[12].Width = 80;
            gridSteel.TableDescriptor.Columns[12].AllowGroupByColumn = false;

            gridSteel.TableDescriptor.Columns[13].HeaderText = " 20 ";
            gridSteel.TableDescriptor.Columns[13].Width = 100;
            gridSteel.TableDescriptor.Columns[13].AllowGroupByColumn = false;

            gridSteel.TableDescriptor.Columns[14].HeaderText = " 24 ";
            gridSteel.TableDescriptor.Columns[14].Width = 100;
            gridSteel.TableDescriptor.Columns[14].AllowGroupByColumn = false;

            gridSteel.TableDescriptor.Columns[15].HeaderText = " 32 ";
            gridSteel.TableDescriptor.Columns[15].Width = 100;
            gridSteel.TableDescriptor.Columns[15].AllowGroupByColumn = false;

            gridSteel.TableDescriptor.Columns[16].HeaderText = "Quantity";
            gridSteel.TableDescriptor.Columns[16].Width = 100;
            gridSteel.TableDescriptor.Columns[16].AllowGroupByColumn = false;

            this.gridSteel.TableDescriptor.GroupedColumns.Add("Description", ListSortDirection.Ascending);
            this.gridSteel.TableDescriptor.GroupedColumns.Add("Member", ListSortDirection.Ascending);
            this.gridSteel.TableDescriptor.GroupedColumns.Add("Grid", ListSortDirection.Ascending);


            GridSummaryColumnDescriptor summaryColumnDescriptor = new GridSummaryColumnDescriptor();
            summaryColumnDescriptor.Appearance.AnySummaryCell.Interior = new BrushInfo(Color.FromArgb(192, 255, 162));
            summaryColumnDescriptor.DataMember = "Quantity";
            summaryColumnDescriptor.Format = "{Sum}";
            summaryColumnDescriptor.Name = "TotalQty";
            summaryColumnDescriptor.SummaryType = Syncfusion.Grouping.SummaryType.DoubleAggregate;

            GridSummaryRowDescriptor summaryRowDescriptor = new GridSummaryRowDescriptor();
            summaryRowDescriptor.SummaryColumns.Add(summaryColumnDescriptor);

            summaryRowDescriptor.Appearance.AnySummaryCell.Interior = new BrushInfo(Color.FromArgb(255, 231, 162));

            this.gridSteel.TableDescriptor.SummaryRows.Add(summaryRowDescriptor);

            this.gridSteel.Appearance.AnySummaryCell.HorizontalAlignment = GridHorizontalAlignment.Right;

        }
        private void ViewMeasurementBookTripizoidal()
        {

            dsResult = mis.GenerateMeasurementBookGeneral(clientBillID, 1);
            gridTripizoidal.DataSource = dsResult.Tables[0];
            gridTripizoidal.Refresh();

            gridTripizoidal.TableDescriptor.Columns[0].HeaderText = "Description";
            gridTripizoidal.TableDescriptor.Columns[0].Width = 600;
            gridTripizoidal.TableDescriptor.Columns[0].AllowFilter = true;
            gridTripizoidal.TableDescriptor.Columns[0].AllowGroupByColumn = true;
            this.gridTripizoidal.TableModel.Cols.FreezeRange(0, 0);

            gridTripizoidal.TableDescriptor.Columns[1].HeaderText = "Number";
            gridTripizoidal.TableDescriptor.Columns[1].Width = 70;

            gridTripizoidal.TableDescriptor.Columns[2].HeaderText = "Base FL";
            gridTripizoidal.TableDescriptor.Columns[2].Width = 80;
            gridTripizoidal.TableDescriptor.Columns[2].AllowGroupByColumn = true;
            gridTripizoidal.TableDescriptor.Columns[2].Appearance.AnyCell.Format = "F2";

            gridTripizoidal.TableDescriptor.Columns[3].HeaderText = "Base FW";
            gridTripizoidal.TableDescriptor.Columns[3].Width = 80;
            gridTripizoidal.TableDescriptor.Columns[3].AllowGroupByColumn = false;
            gridTripizoidal.TableDescriptor.Columns[3].Appearance.AnyCell.Format = "F2";

            gridTripizoidal.TableDescriptor.Columns[4].HeaderText = "DMin";
            gridTripizoidal.TableDescriptor.Columns[4].Width = 80;
            gridTripizoidal.TableDescriptor.Columns[4].AllowGroupByColumn = false;
            gridTripizoidal.TableDescriptor.Columns[4].Appearance.AnyCell.Format = "F2";


            gridTripizoidal.TableDescriptor.Columns[5].HeaderText = "Bottom FL";
            gridTripizoidal.TableDescriptor.Columns[5].Width = 80;
            gridTripizoidal.TableDescriptor.Columns[5].AllowGroupByColumn = false;
            gridTripizoidal.TableDescriptor.Columns[5].Appearance.AnyCell.Format = "F2";

            gridTripizoidal.TableDescriptor.Columns[6].HeaderText = "Bottom FW";
            gridTripizoidal.TableDescriptor.Columns[6].Width = 80;
            gridTripizoidal.TableDescriptor.Columns[6].Appearance.AnyCell.Format = "F2";
            gridTripizoidal.TableDescriptor.Columns[6].AllowGroupByColumn = false;


            gridTripizoidal.TableDescriptor.Columns[7].HeaderText = "Top FL";
            gridTripizoidal.TableDescriptor.Columns[7].Width = 80;
            gridTripizoidal.TableDescriptor.Columns[7].Appearance.AnyCell.Format = "F2";
            gridTripizoidal.TableDescriptor.Columns[7].AllowGroupByColumn = false;

            gridTripizoidal.TableDescriptor.Columns[8].HeaderText = "Top FW";
            gridTripizoidal.TableDescriptor.Columns[8].Width = 80;
            gridTripizoidal.TableDescriptor.Columns[8].AllowGroupByColumn = false;
            gridTripizoidal.TableDescriptor.Columns[8].Appearance.AnyCell.Format = "F2";

            gridTripizoidal.TableDescriptor.Columns[9].HeaderText = "DMax";
            gridTripizoidal.TableDescriptor.Columns[9].Width = 80;
            gridTripizoidal.TableDescriptor.Columns[9].AllowGroupByColumn = false;
            gridTripizoidal.TableDescriptor.Columns[9].Appearance.AnyCell.Format = "F2";

            gridTripizoidal.TableDescriptor.Columns[8].HeaderText = "Quantity";
            gridTripizoidal.TableDescriptor.Columns[8].Width = 100;
            gridTripizoidal.TableDescriptor.Columns[8].Appearance.AnyCell.Format = "F4";
            gridTripizoidal.TableDescriptor.Columns[8].AllowGroupByColumn = false;


            this.gridTripizoidal.TableDescriptor.GroupedColumns.Add("Description", ListSortDirection.Ascending);

            GridSummaryColumnDescriptor summaryColumnDescriptor = new GridSummaryColumnDescriptor();
            summaryColumnDescriptor.Appearance.AnySummaryCell.Interior = new BrushInfo(Color.FromArgb(192, 255, 162));
            summaryColumnDescriptor.DataMember = "Quantity";
            summaryColumnDescriptor.Format = "{Sum}";
            summaryColumnDescriptor.Name = "TotalQty";
            summaryColumnDescriptor.SummaryType = Syncfusion.Grouping.SummaryType.DoubleAggregate;

            GridSummaryRowDescriptor summaryRowDescriptor = new GridSummaryRowDescriptor();
            summaryRowDescriptor.SummaryColumns.Add(summaryColumnDescriptor);

            summaryRowDescriptor.Appearance.AnySummaryCell.Interior = new BrushInfo(Color.FromArgb(255, 231, 162));

            this.gridTripizoidal.TableDescriptor.SummaryRows.Add(summaryRowDescriptor);

            this.gridTripizoidal.Appearance.AnySummaryCell.HorizontalAlignment = GridHorizontalAlignment.Right;

        }   

          

        private void LoadGrid(int reportIndex)
        {
            clientBillID = Convert.ToInt16(cmbClientBIll.SelectedValue);
            if (reportIndex == 1)
                ViewMeasurementBookGeneral();
            else if (reportIndex == 2)
                ViewMeasurementBookTripizoidal();
            else if (reportIndex == 3)
                ViewMeasurementBookSteel();

        }
        private void btnView_Click(object sender, EventArgs e)
        {
            if (cmbReports.Text!="Select Report")
            {
                int reportID = Convert.ToInt16(cmbReports.SelectedValue);
                LoadGrid(reportID);
                btnExcel.Visible = true;
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            GroupingGridExcelConverterControl converter = new GroupingGridExcelConverterControl();

            //Export Groups as the Excel Groups
            converter.ExportGroupPlusMinus = true;
            converter.GroupingGridToExcel(this.gridGeneral, "FileName.xls", ConverterOptions.Default);
        }
    }
}
