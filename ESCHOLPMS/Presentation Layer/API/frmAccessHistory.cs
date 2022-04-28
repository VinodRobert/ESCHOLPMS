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

namespace ESCHOLPMS 
{
    public partial class frmAccessHistory : Form
    {
        string spintlyOrgID = Convert.ToString(GlobalVariables.spintlyOrgID);
        string spintlyAccessToken = Convert.ToString(GlobalVariables.access_token);
        string strJsonRequest;
        AccessHistoryRequest   historyRequest = new AccessHistoryRequest();
        AccessHistoryResponse historyResponse = new AccessHistoryResponse();
        private static TimeZoneInfo INDIAN_ZONE = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time"); 
        PMS pms = new PMS();


        public frmAccessHistory()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
           
            DisplayAccessHistory();
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
                beginTimeString = "2000-JAN-01";
                startTime = DateTime.Parse(beginTimeString);
            }
            else
            {
                startTime = Convert.ToDateTime(dsLastFetch.Tables[0].Rows[0]["LastFetchDate"]);
            }

            string endDate = "2099-DEC-01";
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

        private void DisplayAccessHistory()
        {
            String startDateString;
            String endDateString;
            startDateString = Convert.ToDateTime(dtStartDate.Value).ToShortDateString();
            endDateString = Convert.ToDateTime(dtEndDate.Value).ToShortDateString();
            int accessPointID = Convert.ToInt16(GlobalVariables.spintlyAccessPointID);
            DataSet dsAttendance = pms.UpdateAttendanceHistory(startDateString, endDateString, accessPointID);
            SkinManager.SetVisualStyle(this.gridHistory, VisualTheme.Office2010Blue);
            SkinManager.SetVisualStyle(this, VisualTheme.Office2010Blue);
            gridHistory.DataSource = dsAttendance.Tables[0];

            gridHistory.TableDescriptor.Columns[0].HeaderText = "Site Name";
            gridHistory.TableDescriptor.Columns[0].Width = 150;
            gridHistory.TableDescriptor.Columns[0].AllowFilter = true;

            gridHistory.TableDescriptor.Columns[1].HeaderText = "Location";
            gridHistory.TableDescriptor.Columns[1].Width = 150;

            gridHistory.TableDescriptor.Columns[2].HeaderText = "Access Point Name";
            gridHistory.TableDescriptor.Columns[2].Width = 150;
            gridHistory.TableDescriptor.Columns[2].AllowFilter = true;

            gridHistory.TableDescriptor.Columns[3].HeaderText = "Staff Name";
            gridHistory.TableDescriptor.Columns[3].Width = 150;
            gridHistory.TableDescriptor.Columns[3].AllowFilter = true;

            gridHistory.TableDescriptor.Columns[4].HeaderText = "Check In";
            gridHistory.TableDescriptor.Columns[4].Width = 150;
            gridHistory.TableDescriptor.Columns[4].Appearance.AnyCell.CellType = "DateTime";
            gridHistory.TableDescriptor.Columns[4].AllowFilter = true;


            gridHistory.TableDescriptor.Columns[5].HeaderText = "Check Out";
            gridHistory.TableDescriptor.Columns[5].Width = 150;
            gridHistory.TableDescriptor.Columns[5].Appearance.AnyCell.CellType = "DateTime";
            gridHistory.TableDescriptor.Columns[5].AllowFilter = true;
            this.gridHistory.TopLevelGroupOptions.ShowFilterBar = true;


            //Customize the DateFormat.
            this.gridHistory.TableDescriptor.Columns[4].Appearance.FilterBarCell.Format = "dd-MMM-yyyy";
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
            gridHistory.Visible = true;
           
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
                    timePortion = localTimeString.Substring(startIndex,8 );
                    dateInfo = datePortion.Split('/');
                    monthID = Convert.ToInt16(dateInfo[1])-1;
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
        }

     

       

       

       

        private void frmAccessHistory_Load(object sender, EventArgs e)
        {
            UpdateTodaysSwipes();
            ResetAll();
           
            dtStartDate.DateTimePattern = DateTimePattern.LongDate;
            dtEndDate.DateTimePattern = DateTimePattern.LongDate;
            dtStartDate.Format = "yyyy-MM-dd hh:mm:ss";
            dtEndDate.Format = "yyyy-MM-dd hh:mm:ss";
           
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
    }
}
