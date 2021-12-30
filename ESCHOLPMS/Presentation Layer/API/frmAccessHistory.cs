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
            if (cmbAccessPoint.Text == "Select Access Point")
                return;
            FormRequestHeader();
            FetchAcessHistory();
            DisplayAccessHistory();
        }

        private void FormRequestHeader()
        { 

            List<int> rolesList = new List<int>() {   1750 };
            historyRequest = new AccessHistoryRequest();

            Filters f = new Filters();
            f.roles = new List<int>() { 1750 };
            
            DateTime startTime   = Convert.ToDateTime(dtStartDate.Value);
            DateTime endTime = Convert.ToDateTime(dtEndDate.Value);
            string startTimeString = Convert.ToDateTime(startTime).ToString("yyyy-MM-dd HH:mm:ss +05:30");
            string endTimeString = Convert.ToDateTime(endTime).ToString("yyyy-MM-dd 23:59:59 +05:30");
            int accessPoint = Convert.ToInt16(cmbAccessPoint.SelectedValue);
            if (accessPoint!=0)
            {
                f.accessPoints = new List<int> { accessPoint };
            }
            f.start = startTimeString;
            f.end = endTimeString;
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

            //String startDateString;
            //String endDateString;
            //startDateString = Convert.ToDateTime(dtStartDate.Value).ToShortDateString();
            //endDateString = Convert.ToDateTime(dtEndDate.Value).ToShortDateString();
            //int selectedUser = Convert.ToInt16(cmbUsers.SelectedValue);
            //DataSet dsAttendance = pms.UpdateAttendanceHistory(startDateString, endDateString, selectedUser);
            //SkinManager.SetVisualStyle(this.gridHistory, VisualTheme.Office2010Blue);
            //SkinManager.SetVisualStyle(this, VisualTheme.Office2010Blue);
            //gridHistory.DataSource = dsAttendance.Tables[0];

            //gridHistory.TableDescriptor.Columns[0].HeaderText = "Site Name";
            //gridHistory.TableDescriptor.Columns[0].Width = 150;
            //gridHistory.TableDescriptor.Columns[0].AllowFilter = true;

            //gridHistory.TableDescriptor.Columns[1].HeaderText = "Location";
            //gridHistory.TableDescriptor.Columns[1].Width = 150;

            //gridHistory.TableDescriptor.Columns[2].HeaderText = "Access Point Name";
            //gridHistory.TableDescriptor.Columns[2].Width = 150;
            //gridHistory.TableDescriptor.Columns[2].AllowFilter = true;

            //gridHistory.TableDescriptor.Columns[3].HeaderText = "Staff Name";
            //gridHistory.TableDescriptor.Columns[3].Width = 150;
            //gridHistory.TableDescriptor.Columns[3].AllowFilter = true;

            //gridHistory.TableDescriptor.Columns[4].HeaderText = "Check In";
            //gridHistory.TableDescriptor.Columns[4].Width = 150;
            //gridHistory.TableDescriptor.Columns[4].Appearance.AnyCell.CellType = "DateTime";

            //gridHistory.TableDescriptor.Columns[5].HeaderText = "Check Out";
            //gridHistory.TableDescriptor.Columns[5].Width = 150;
            //gridHistory.TableDescriptor.Columns[5].Appearance.AnyCell.CellType = "DateTime";


            //foreach (Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor column in this.gridHistory.TableDescriptor.Columns)
            //{
            //    column.AllowFilter = true;
            //}

            //gridHistory.Refresh();
            //gridHistory.Visible = true;

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
                int accessPointID;
                int userID;
                int success;
         
                DateTime swipeTime;
                DateTime swipeLocalTime;
                string localTimeString;
                string[] dateInfo;
                
                int startIndex;
                string datePortion;
                string timePortion;
              
                string userName;
                System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
                foreach (AccessHistory al in accessHistoryLists.message.accessHistory)
                {
                    //swipeTime = new DateTime(1970, 1, 1, 0, 0, 0, 0); //from start epoch time
                    //accessID = Convert.ToInt32(al.id);
                    //accessedTime = Convert.ToInt64(al.accessedAt);
                    //swipeTime = swipeTime.AddSeconds(accessedTime);
                    //swipeLocalTime = TimeZoneInfo.ConvertTimeFromUtc(swipeTime, INDIAN_ZONE);
                    //userID = Convert.ToInt16(al.user.id);
                    //userName = Convert.ToString(al.user.name);
                    accessPointID = Convert.ToInt16(al.accessPoint.id);
                    swipeTime = new DateTime(1970, 1, 1, 0, 0, 0, 0); //from start epoch time
                    accessID = Convert.ToInt32(al.id);
                    accessedTime = Convert.ToInt64(al.accessedAt);
                    swipeTime = swipeTime.AddSeconds(accessedTime);
                    swipeLocalTime = TimeZoneInfo.ConvertTimeFromUtc(swipeTime, INDIAN_ZONE);
                    localTimeString = Convert.ToString(swipeLocalTime);
                    datePortion = localTimeString.Substring(0, localTimeString.IndexOf(" "));
                    startIndex = localTimeString.Length - 8;
                    timePortion = localTimeString.Substring(startIndex,8 );
                    dateInfo = datePortion.Split('/');

                    userID = Convert.ToInt16(al.user.id);
                    userName = Convert.ToString(al.user.name);
                    success = pms.InsertAccessHistory(accessPointID, userID, swipeLocalTime);
                }
                 
            }
            catch (Exception d)
            {
                string errorJson = "Error In Calling Access Points List " + d.Message;
                MessageBox.Show(errorJson);
            }

        }

        private void LoadAccessPoints()
        {
            DataSet dsAccessPoint = pms.FetchAccessPoints();
            cmbAccessPoint.DataSource = dsAccessPoint.Tables[0];
            cmbAccessPoint.Refresh();
            cmbAccessPoint.Text = "Select Access Point";
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
            rdWorker.Checked = false;
            rdStaff.Checked = false;
            rdBoth.Checked = true;
            gridHistory.Visible = false;
        }

        private void rdStaff_CheckedChanged(object sender, EventArgs e)
        {
            if (rdStaff.Checked == true)
                LoadUsers(1);
        }

        private void rdWorker_CheckedChanged(object sender, EventArgs e)
        {
            if (rdWorker.Checked == true)
                LoadUsers(2);
        }

        private void rdBoth_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBoth.Checked == true)
                LoadUsers(0);
        }

        private void LoadUsers(int i)
        {
            DataSet dsUsers = pms.GetAccessUsers(i);
            cmbUsers.DataSource = null;
            cmbUsers.DataSource = dsUsers.Tables[0];
            cmbUsers.Refresh();
            cmbUsers.Text = "--ALL USERS--";
        }

        private void frmAccessHistory_Load(object sender, EventArgs e)
        {
            ResetAll();
            LoadUsers(0);
            dtStartDate.DateTimePattern = DateTimePattern.LongDate;
            dtEndDate.DateTimePattern = DateTimePattern.LongDate;
            dtStartDate.Format = "yyyy-MM-dd hh:mm:ss";
            dtEndDate.Format = "yyyy-MM-dd hh:mm:ss";
            LoadAccessPoints();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            gridHistory.DataSource = null;
            gridHistory.Refresh();
            gridHistory.Visible = false;
            LoadUsers(0);
            ResetAll();
        }
    }
}
