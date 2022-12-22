using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using RestSharp;
using Syncfusion.Windows.Forms;
using ESCHOLPMS.API.AccessHistoryRequest;
using ESCHOLPMS.API.AccessHistoryResponse;
using Syncfusion.WinForms.Input.Enums;


using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.GridHelperClasses;
using System.Data.SqlClient;
using SQLHelper;
using Syncfusion.GroupingGridExcelConverter;
using Syncfusion.XlsIO;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;



namespace ESCHOLPMS
{
    public partial class frmAttendanceOfTheDay : Form
    {
        string spintlyOrgID = Convert.ToString(GlobalVariables.spintlyOrgID);
        string spintlyAccessToken = Convert.ToString(GlobalVariables.access_token);
        string strJsonRequest;
        AccessHistoryRequest   historyRequest = new AccessHistoryRequest();
        AccessHistoryResponse historyResponse = new AccessHistoryResponse();
        private static TimeZoneInfo INDIAN_ZONE = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time"); 
        PMS pms = new PMS();

        DataTable tabAccessHistory;

        string directoryName = null;
        string excelfileName = null;
        string pdffileName = null;

       
        public frmAttendanceOfTheDay()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (cmbAccessPoint.Text == "Select Access Point")
                return;
            excelfileName = Convert.ToString(cmbAccessPoint.Text).Trim();
            pdffileName = Convert.ToString(cmbAccessPoint.Text).Trim();
            btnExport.Visible = false;
            DisplayAccessHistory();
            btnExport.Visible = true;
            btnPDF.Visible = true;
            btnExport.Enabled = true;
            btnPDF.Enabled = true;
        }

        private void UpdateTodaysSwipes()
        {
            FormRequestHeader();
            FetchAcessHistory();
        }


        private void FormRequestHeader()
        {
            DateTime thisDay = DateTime.Today;
            string thisDayString = thisDay.ToString("d");

            AccessFetchPagination ap = new AccessFetchPagination();
            ap.perPage = 10000;
            ap.page = 1;
          
            historyRequest = new AccessHistoryRequest();
             
            Filters f = new Filters();

            DateTime startTime;
            string beginTimeString;
            DataSet dsLastFetch = pms.FetchAccessHitoryFetch();
            beginTimeString = Convert.ToString(dsLastFetch.Tables[0].Rows[0]["LastFetchDate"]).Trim();

          


            if (beginTimeString=="")
            {
                beginTimeString = "2022-NOV-04";
                startTime = DateTime.Parse(beginTimeString);
            }
            else
            {
                startTime = Convert.ToDateTime(dsLastFetch.Tables[0].Rows[0]["LastFetchDate"]);
            }

            string endDate = "2022-NOV-04";
            DateTime endTime = DateTime.Parse(endDate);
            //string startTimeString = Convert.ToDateTime(startTime).ToString("yyyy-MM-dd HH:mm:ss +05:30");
            //string endTimeString = Convert.ToDateTime(endTime).ToString("yyyy-MM-dd 23:59:59 +05:30");
            DateTime yesterDay = DateTime.Today.AddDays(-1);
            DateTime today = DateTime.Today;
            string startTimeString = today.ToString("yyyy-MM-dd 00:00:00 +05:30");
            string endTimeString = today.ToString("yyyy-MM-dd 23:59:59 +05:30");


            f.start = startTimeString;
            f.end = endTimeString;
           

            historyRequest.pagination = ap;
            historyRequest.filters = f;
            strJsonRequest = String.Empty;
            try
            {
                strJsonRequest = JsonConvert.SerializeObject(historyRequest);
            }
            catch (Exception ex)
            {
                string errorJson = "Your Data Failed To Convert To Json " + ex.Message;
                MessageBox.Show(errorJson);
            }




            
        }

        private void DisplayAccessHistory()
        {
            String startDateString;
            String endDateString;
            startDateString = Convert.ToDateTime(dtStartDate.Value).ToShortDateString();
            endDateString = Convert.ToDateTime(dtStartDate.Value).ToShortDateString();
            int accessPointID = Convert.ToInt16(cmbAccessPoint.SelectedValue);
            DataSet dsAttendance = pms.UpdateAttendanceHistory(startDateString, endDateString, accessPointID,1);
            SkinManager.SetVisualStyle(this.gridHistory, VisualTheme.Office2010Blue);
            SkinManager.SetVisualStyle(this, VisualTheme.Office2010Blue);
            gridHistory.DataSource = dsAttendance.Tables[0];

            gridHistory.TableDescriptor.Columns[0].HeaderText = "Site Name";
            gridHistory.TableDescriptor.Columns[0].Width = 200;
            gridHistory.TableDescriptor.Columns[0].AllowFilter = true;
            
            gridHistory.TableDescriptor.Columns[1].HeaderText = "Access Point Name";
            gridHistory.TableDescriptor.Columns[1].Width = 200;
            gridHistory.TableDescriptor.Columns[1].AllowFilter = true;

            gridHistory.TableDescriptor.Columns[2].HeaderText = "Access Card#";
            gridHistory.TableDescriptor.Columns[2].Width = 100;
            gridHistory.TableDescriptor.Columns[2].AllowFilter = true;

            gridHistory.TableDescriptor.Columns[3].HeaderText = "Staff Name";
            gridHistory.TableDescriptor.Columns[3].Width = 200;
            gridHistory.TableDescriptor.Columns[3].AllowFilter = true;

            gridHistory.TableDescriptor.Columns[4].HeaderText = "Check In Date";
            gridHistory.TableDescriptor.Columns[4].Width = 100;
        //    gridHistory.TableDescriptor.Columns[4].Appearance.AnyCell.CellType = "Date";
         //   gridHistory.TableDescriptor.Columns[4].Appearance.AnyCell.Format = "dd-MMM-yyyy";
            gridHistory.TableDescriptor.Columns[4].AllowFilter = true;
            gridHistory.TableDescriptor.Columns[4].Appearance.AnyRecordFieldCell.Format = "dd-MM-yyyy";

            gridHistory.TableDescriptor.Columns[5].HeaderText = "Check In Time";
            gridHistory.TableDescriptor.Columns[5].Width = 100;
            gridHistory.TableDescriptor.Columns[5].Appearance.AnyCell.CellType = "Time";
            gridHistory.TableDescriptor.Columns[5].AllowFilter = true;


            //Customize the DateFormat.
    
            this.gridHistory.TopLevelGroupOptions.ShowFilterBar = true;
            for (int i = 0; i < this.gridHistory.TableDescriptor.Columns.Count; i++)
            {
                this.gridHistory.TableDescriptor.Columns[i].AllowFilter = true;
            }
            GridDynamicFilter dynamicFilter = new GridDynamicFilter();
            dynamicFilter.WireGrid(this.gridHistory);

            foreach (Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor column in this.gridHistory.TableDescriptor.Columns)
            {
                column.AllowFilter = true;
            }

            gridHistory.Refresh();
          
           
        }

        

        private async void FetchAcessHistory()
        {
            string url = "https://api.spintly.com/v2/organisationManagement/integrator/organisations/" + spintlyOrgID+ "/accessHistory";


            if (spintlyAccessToken.Length == 0)
            {
                MessageBox.Show("First Authenticated. Then Run ");
                return;
            }

            try
            {
                RestClient client = new RestClient(url);
                RestRequest request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", spintlyAccessToken);
                request.AddParameter("application/json", strJsonRequest, ParameterType.RequestBody);

                IRestResponse response = await client.ExecuteAsync(request);



                AccessHistoryResponse accessHistoryLists = JsonConvert.DeserializeObject<AccessHistoryResponse>(response.Content);
                if (accessHistoryLists.type != "success")
                {
                    MessageBox.Show("Unable To Call API - Failed To Fetch Access Controlled Project Sites Details");
                    return;
                }


                List<AccessHistoryResponse> accessList = new List<AccessHistoryResponse>();
                Int64 accessedTime;
                Int64 accessID;
                Int64 accessPointID;
                Int64 userID;
                int success;
         
                DateTime swipeTime;
                DateTime swipeLocalTime;
                string localTimeString;
                string[] dateInfo;
                string[] months = { "Jan", "Feb", "Mar", "Apr" ,"May", "Jun", "Jul", "Aug", "Sep", "Oct",  "Nov", "Dec" };
                int monthID;
                string monthShortName;
                string revisedDateString;
                 
                int startIndex;
                string datePortion;
                string timePortion;


                DataTable tabAccessHistory = new DataTable("AccessHistory");
                // construct DataTable
                tabAccessHistory.Columns.Add(new DataColumn("HistoryID", typeof(int)));
                tabAccessHistory.Columns.Add(new DataColumn("AccessPointID", typeof(int)));
                tabAccessHistory.Columns.Add(new DataColumn("UserID", typeof(int)));
                tabAccessHistory.Columns.Add(new DataColumn("RevisedDateString", typeof(string)));


                int cnt=0;
                string userName;
                System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
                foreach (AccessHistory al in accessHistoryLists.message.accessHistory)
                {
                    cnt = cnt + 1;
                    accessPointID = Convert.ToInt64(al.accessPoint.id);
                    swipeTime = new DateTime(1970, 1, 1, 0, 0, 0, 0); //from start epoch time
                    accessID = Convert.ToInt64(al.id);
                    accessedTime = Convert.ToInt64(al.accessedAt);
                    swipeTime = swipeTime.AddSeconds(accessedTime);
                    swipeLocalTime = TimeZoneInfo.ConvertTimeFromUtc(swipeTime, INDIAN_ZONE);
                    localTimeString = Convert.ToString(swipeLocalTime);
                    datePortion = localTimeString.Substring(0, localTimeString.IndexOf(" "));
                    startIndex = localTimeString.Length - 8;
                    timePortion = localTimeString.Substring(startIndex,8 );
                    dateInfo = datePortion.Split('/');
                    monthID = Convert.ToInt16(dateInfo[1])-1;
                    monthShortName = Convert.ToString(months[monthID]);
                    revisedDateString = Convert.ToString(dateInfo[0]) + "/" + monthShortName + "/" + Convert.ToString(dateInfo[2]) + " " + timePortion;

                  

                    userID = Convert.ToInt64(al.user.id);
                    userName = Convert.ToString(al.user.name);
                  //  success = pms.InsertAccessHistory(cnt,accessPointID, userID, revisedDateString);
                    tabAccessHistory.Rows.Add(cnt,accessPointID, userID, revisedDateString);

                }

                try
                {
                    string _connectionString = SqlHelper.GetConnectionString(2);
                    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(_connectionString))
                    {
                        bulkCopy.BulkCopyTimeout = 600; // in seconds
                        bulkCopy.DestinationTableName = "AccessHistory";
                        bulkCopy.WriteToServer(tabAccessHistory);
                    }
                }
                catch
                {
                    MessageBox.Show("Failed To Save to History Table-Check Column Width and Column Data ", "Failed To Save ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    return;

                }
                btnView.Enabled = true;
                btnDownLoad.Enabled = false;
                lable2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                cmbAccessPoint.Visible = true;
                btnView.Visible = true;
                dtStartDate.Visible = true;
                gridHistory.Visible = true;
            }
            catch (Exception d)
            {
                string errorJson = "Error In Calling Access Points List " + d.Message;
                MessageBox.Show(errorJson);
            }

        }
         

        private void CreateHistoryTable()
        {
           
        }

        private void ResetAll()
        {


            this.gridHistory.ActivateCurrentCellBehavior = GridCellActivateAction.None;
            this.gridHistory.ShowGroupDropArea = true;
            this.gridHistory.TableOptions.AllowSortColumns = true;
            this.gridHistory.TopLevelGroupOptions.ShowCaption = true;
            this.gridHistory.TableOptions.RecordPreviewRowHeight = 55;
            this.gridHistory.TableOptions.ShowRowHeader = false;
            this.gridHistory.TableOptions.SelectionBackColor = Color.FromArgb(255, 128, 128);
            this.gridHistory.TableOptions.SelectionTextColor = Color.Maroon;
            this.gridHistory.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;
            this.gridHistory.TableOptions.DefaultColumnWidth = 65;
            this.gridHistory.TableOptions.CaptionRowHeight = 22;
            this.gridHistory.InvalidateAllWhenListChanged = true;
            this.gridHistory.ForceDisposeOnResetDataSource = true;
            this.gridHistory.AllowResetTableDescriptorWhenDataSourceSetNull = true;
            this.gridHistory.CacheRecordValues = false;
            this.gridHistory.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue;
            this.gridHistory.Font = new Font("Calibri", 10.0f);
            this.gridHistory.TopLevelGroupOptions.ShowFilterBar = true;
          
            gridHistory.Visible = false;
            lable2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            cmbAccessPoint.Visible = false;
            btnView.Visible = false;
            cmbAccessPoint.Text = "Select Project";
            cmbAccessPoint.Enabled = true;
            dtStartDate.Visible = false;
            lblFetch.Visible = false;

            btnExport.Visible = false;

            directoryName = @"C:\MIS\ExcelFiles\";

        }

     

       

       private void Load_AccessPoints()
       {
            DataSet dsAccessList = pms.GetAccessPoints();
            cmbAccessPoint.DataSource = dsAccessList.Tables[0];
            
            cmbAccessPoint.Refresh();
       }

       

        private void frmAccessHistory_Load(object sender, EventArgs e)
        {
            
            ResetAll();
            CreateHistoryTable();
            Load_AccessPoints();
            dtStartDate.DateTimePattern = DateTimePattern.LongDate;
             
            dtStartDate.Format = "yyyy-MM-dd hh:mm:ss";
          
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            gridHistory.DataSource = null;
            gridHistory.Refresh();
            gridHistory.Visible = false;
           
            ResetAll();
        }

        private void gridHistory_TableControlDrawCellDisplayText_1(object sender, GridTableControlDrawCellDisplayTextEventArgs e)
        {
            GridTableCellStyleInfo style = (GridTableCellStyleInfo)e.Inner.Style;
            if (style.TableCellIdentity.Column != null && style.TableCellIdentity.Column.Name == "Date" && style.TableCellIdentity.TableCellType == GridTableCellType.FilterBarCell)
            {
                if (style.Text != "(All)" && style.Text != "(Custom....)" && style.Text != "(Empty)")
                    e.Inner.DisplayText = string.Format("{0:dd-MMM-yyyy}", Convert.ToDateTime(style.Text));
            }
        }

        private void gridHistory_FilterBarSelectedItemChanged_1(object sender, FilterBarSelectedItemChangedEventArgs e)
        {
            if (e.Column != null && e.Column.Name == "CheckIn")
            {
                int row = this.gridHistory.TableControl.CurrentCell.RowIndex;
                int col = this.gridHistory.TableControl.CurrentCell.ColIndex;
                GridTableCellStyleInfo style = this.gridHistory.TableControl.GetTableViewStyleInfo(row, col);
                GridTableFilterBarExtCellRenderer renderer = this.gridHistory.TableControl.GetCellRenderer(row, col) as GridTableFilterBarExtCellRenderer;
                renderer.ControlText = string.Format("{0:dd-MMM-yyyy}", Convert.ToDateTime(style.Text));
            }
        }

        private void btnDownLoad_Click(object sender, EventArgs e)
        {
            btnView.Enabled = false;
            lblFetch.Visible = true;
            UpdateTodaysSwipes();

        }

       

        private void btnExport_Click(object sender, EventArgs e)
        {
            btnExport.Enabled = false;
            //Creating the converter control for Exporting the grid
            GroupingGridExcelConverterControl converter = new GroupingGridExcelConverterControl();

            GridGroupingExcelConverterControl excelConverter = new GridGroupingExcelConverterControl();

            //Disable auto fit rows and columns
            excelConverter.CanExportColumnWidth = false;
            excelConverter.CanExportRowHeight = false;

            //Set default row height and col width need to be export
            excelConverter.DefaultRowHeight = 20;
            excelConverter.DefaultColumnWidth = 20;

            converter.ExportBorders = true;
            converter.ExportImage = true;
            excelConverter.CanExportColumnWidth = true;
            excelConverter.CanExportRowHeight = true;
            excelConverter.ExcelVersion = Syncfusion.XlsIO.ExcelVersion.Excel2016;
            ExcelExportingOptions options = new ExcelExportingOptions();

            //Export the contents of the grid to excel

            string excelReportfileName = directoryName + excelfileName + DateTime.Now.ToString("yyyyMMddhhmmss") + ".xlsx";
            excelConverter.ExportToExcel(this.gridHistory, excelReportfileName, options);
            ExcelEngine excelEngine = new ExcelEngine();


            System.Diagnostics.Process.Start(excelReportfileName);






        }
        void pdfConverter_DrawPDFFooter(object sender, PDFHeaderFooterEventArgs e)
        {
            PdfPageTemplateElement footer = e.HeaderFooterTemplate;
            PdfSolidBrush brush = new PdfSolidBrush(Color.Gray);
            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 6, PdfFontStyle.Bold);
            PdfStringFormat format = new PdfStringFormat();
            format.Alignment = PdfTextAlignment.Center;
            format.LineAlignment = PdfVerticalAlignment.Top;
            footer.Graphics.DrawString("@Eschol ", font, brush, new RectangleF(0, footer.Height - 40, footer.Width, footer.Height), format);

        }
        void pdfConverter_DrawPDFHeader(object sender, PDFHeaderFooterEventArgs e)
        {
            PdfPageTemplateElement header = e.HeaderFooterTemplate;
            PdfSolidBrush brush = new PdfSolidBrush(Color.FromArgb(44, 71, 120));
            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 16, PdfFontStyle.Bold);

            //Set formatting's for the text
            PdfStringFormat format = new PdfStringFormat();
            format.Alignment = PdfTextAlignment.Center;
            format.LineAlignment = PdfVerticalAlignment.Middle;

            //Draw title
            header.Graphics.DrawString("Spintly Attendance Details", font, brush, new RectangleF(0, 0, header.Width, header.Height), format);

         
        }
        private void PDF_Click(object sender, EventArgs e)
        {
            //Create pdf converter
            GridPDFConverter pdfConverter = new GridPDFConverter();

            //Enable exporting of header and footer
            pdfConverter.ShowHeader = true;
            pdfConverter.ShowFooter = true;

            //Invoke this events to draw the text in header/footer
            pdfConverter.DrawPDFHeader += pdfConverter_DrawPDFHeader;
            pdfConverter.DrawPDFFooter += pdfConverter_DrawPDFFooter;
            string pdfReportfileName = directoryName + pdffileName + DateTime.Now.ToString("yyyyMMddhhmmss") + ".pdf";
            pdfConverter.ExportToPdf(pdfReportfileName, this.gridHistory.TableControl);

            System.Diagnostics.Process.Start(pdffileName);


        }
    }
}
