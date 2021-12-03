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
                int userID;
                DateTime swipeTime;
                DateTime swipeLocalTime;
                string userName;
                System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
                foreach (AccessHistory al in accessHistoryLists.message.accessHistory)
                {
                    swipeTime = new DateTime(1970, 1, 1, 0, 0, 0, 0); //from start epoch time
                    accessID = Convert.ToInt32(al.id);
                    accessedTime = Convert.ToInt64(al.accessedAt);
                    swipeTime = swipeTime.AddSeconds(accessedTime);
                    swipeLocalTime = TimeZoneInfo.ConvertTimeFromUtc(swipeTime, INDIAN_ZONE);
                    userID = Convert.ToInt16(al.user.id);
                    userName = Convert.ToString(al.user.name);
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

        private void frmAccessHistory_Load(object sender, EventArgs e)
        {
            dtStartDate.DateTimePattern = DateTimePattern.LongDate;
            dtEndDate.DateTimePattern = DateTimePattern.LongDate;
            dtStartDate.Format = "yyyy-MM-dd hh:mm:ss";
            dtEndDate.Format = "yyyy-MM-dd hh:mm:ss";
            LoadAccessPoints();
        }
    }
}
