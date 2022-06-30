using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;
using RestSharp;
using System.IO;
using Syncfusion.Windows.Forms;
using Newtonsoft.Json.Linq;

using ESCHOLPMS.API.OauthToken;
using ESCHOLPMS.API.AccessHistoryRequest;
using ESCHOLPMS.API.AccessHistoryResponse;
using Syncfusion.WinForms.Input.Enums;


using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.GridHelperClasses;
using Syncfusion.WinForms.DataGridConverter;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Grid;

namespace ESCHOLPMS 
{
    public partial class frmLabourAttendance : Form
    {
        string spintlyOrgID = Convert.ToString(GlobalVariables.spintlyOrgID);
        string spintlyAccessToken = Convert.ToString(GlobalVariables.access_token);
        string strJsonRequest;
        AccessHistoryRequest historyRequest = new AccessHistoryRequest();
        AccessHistoryResponse historyResponse = new AccessHistoryResponse();
        private static TimeZoneInfo INDIAN_ZONE = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        PMS pms = new PMS();
        AccessCard ac = new AccessCard();

        string attendanceDate;
        public frmLabourAttendance()
        {
            InitializeComponent();
        }

        private void UpdateTodaysSwipes()
        {
            FormRequestHeader();
            FetchAcessHistory();
        }

        private async void FetchAcessHistory()
        {
            string url = "https://api.spintly.com/v2/organisationManagement/integrator/organisations/" + spintlyOrgID + "/accessHistory";


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
                string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
                int monthID;
                string monthShortName;
                string revisedDateString;

                int startIndex;
                string datePortion;
                string timePortion;

                string userName;
                System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
                foreach (AccessHistory al in accessHistoryLists.message.accessHistory)
                {
                    accessPointID = Convert.ToInt64(al.accessPoint.id);
                    swipeTime = new DateTime(1970, 1, 1, 0, 0, 0, 0); //from start epoch time
                    accessID = Convert.ToInt64(al.id);
                    accessedTime = Convert.ToInt64(al.accessedAt);
                    swipeTime = swipeTime.AddSeconds(accessedTime);
                    swipeLocalTime = TimeZoneInfo.ConvertTimeFromUtc(swipeTime, INDIAN_ZONE);
                    localTimeString = Convert.ToString(swipeLocalTime);
                    datePortion = localTimeString.Substring(0, localTimeString.IndexOf(" "));
                    startIndex = localTimeString.Length - 8;
                    timePortion = localTimeString.Substring(startIndex, 8);
                    dateInfo = datePortion.Split('/');
                    monthID = Convert.ToInt16(dateInfo[1]) - 1;
                    monthShortName = Convert.ToString(months[monthID]);
                    revisedDateString = Convert.ToString(dateInfo[0]) + "/" + monthShortName + "/" + Convert.ToString(dateInfo[2]) + " " + timePortion;
                    userID = Convert.ToInt64(al.user.id);
                    userName = Convert.ToString(al.user.name);
                    success = pms.InsertAccessHistory(accessPointID, userID, revisedDateString);
                }

            }
            catch (Exception d)
            {
                string errorJson = "Error In Calling Access Points List " + d.Message;
                MessageBox.Show(errorJson);
            }
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


            if (beginTimeString == "")
            {
                beginTimeString = attendanceDate;
                startTime = DateTime.Parse(beginTimeString);
            }
            else
            {
                startTime = Convert.ToDateTime(dsLastFetch.Tables[0].Rows[0]["LastFetchDate"]);
            }

            string endDate = attendanceDate;
            DateTime endTime = DateTime.Parse(endDate);
            string startTimeString = Convert.ToDateTime(startTime).ToString("yyyy-MM-dd HH:mm:ss +05:30");
            string endTimeString = Convert.ToDateTime(endTime).ToString("yyyy-MM-dd 23:59:59 +05:30");

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

        private void frmLabourAttendance_Load(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;
            dtAttendance.MaxDateTime = thisDay;

            string day = Convert.ToString(thisDay.Day);
            string month = Convert.ToString(thisDay.ToString("MMMM"));
            string year = Convert.ToString(thisDay.Year);

            attendanceDate = year.Trim() + "-" + month.Trim() + "-" + day.Trim();
            UpdateTodaysSwipes();
        }

        private void ResetAll()
        {
            this.gridAttendance.ShowRowHeader = true;
            this.gridAttendance.Style.RowHeaderStyle.BackColor = Color.CadetBlue;
            this.gridAttendance.Style.RowHeaderStyle.SelectionMarkerThickness = 4;
            this.gridAttendance.Style.RowHeaderStyle.SelectionMarkerColor = Color.Red;
            this.gridAttendance.Style.RowHeaderStyle.SelectionBackColor = Color.White;
        }
        private void btnFetch_Click(object sender, EventArgs e)
        {
            string dtTimeSheet = Convert.ToString(dtAttendance.Value);
            Int32 accessPointID = GlobalVariables.spintlyAccessPointID;
            DataSet dsAccessHistory = ac.FetchAccessHistory(accessPointID, dtTimeSheet);
            gridAttendance.DataSource = dsAccessHistory.Tables[0];
            gridAttendance.Refresh();
        }


        void options_HeaderFooterExporting(object sender, Syncfusion.WinForms.DataGridConverter.Events.PdfHeaderFooterEventArgs e)
        {
            PdfFont font = new PdfStandardFont(PdfFontFamily.TimesRoman, 15f, PdfFontStyle.Bold);
            var width = e.PdfPage.GetClientSize().Width;
            PdfPageTemplateElement header = new PdfPageTemplateElement(width, 38);
            string projectName = GlobalVariables.ProjectName;
            string attendanceOn = dtAttendance.DateTimeText;
            string heading = projectName + "=Attendance On " + attendanceOn;
            header.Graphics.DrawString(heading, font, PdfPens.Black, 15, 1);
            e.PdfDocumentTemplate.Top = header;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            PdfExportingOptions options = new PdfExportingOptions();
            options.AutoColumnWidth = false;
            options.AutoRowHeight = true;
            options.RepeatHeaders = true;
            options.FitAllColumnsInOnePage = true;
            options.ExcludeColumns.Add("LABOURID");
            options.ExcludeColumns.Add("WORKINGDAY");
            options.ExcludeColumns.Add("OTHOURS");
            options.HeaderFooterExporting += options_HeaderFooterExporting;
            
            var document = new PdfDocument();
            document.PageSettings.Orientation = PdfPageOrientation.Landscape;
            document = gridAttendance.ExportToPdf(options);
            //var page = document.Pages.Add();
            //var PDFGrid = gridAttendance.ExportToPdfGrid(gridAttendance.View, options);
            //var format = new PdfGridLayoutFormat()
            //{
            //    Layout = PdfLayoutType.Paginate,
            //    Break = PdfLayoutBreakType.FitPage
            //};

            //PDFGrid.Draw(page, new PointF(), format);







            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF Files(*.pdf)|*.pdf"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (Stream stream = saveFileDialog.OpenFile())
                {
                    document.Save(stream);
                }
                //Message box confirmation to view the created Pdf file.
                if (MessageBox.Show("Do you want to view the Pdf file?", "Pdf file has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //Launching the Pdf file using the default Application.
                    System.Diagnostics.Process.Start(saveFileDialog.FileName);
                }
            }
        }
    }
}
