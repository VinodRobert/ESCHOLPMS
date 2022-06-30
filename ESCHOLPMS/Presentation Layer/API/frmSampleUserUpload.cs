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

using ESCHOLPMS.Business_Layer.API;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.GridHelperClasses;
 
namespace ESCHOLPMS 
{
    public partial class frmSampleUserUpload : Form
    {
        string spintlyOrgID = Convert.ToString(GlobalVariables.spintlyOrgID);
        string spintlyAccessToken = Convert.ToString(GlobalVariables.access_token);
        string strJsonRequest;
        AccessHistoryRequest   historyRequest = new AccessHistoryRequest();
        AccessHistoryResponse historyResponse = new AccessHistoryResponse();
        private static TimeZoneInfo INDIAN_ZONE = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time"); 
        PMS pms = new PMS();

        SpintlyUserForUpload oneToUpload = new SpintlyUserForUpload();
        SingleUser single = new SingleUser();
        
        public frmSampleUserUpload()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            formulateUser();
            AddASingleUser();
             
        }

        private void formulateUser()
        {
            SingleUser single = new SingleUser();

            List<int> roleList = new List<int>();
            List<int> accessPointLists = new List<int>();

            roleList.Add(1750);
            accessPointLists.Add(1043);
            single.mobile = false;
            single.email = "worker@vettoor.com";
            single.gps = false;
            single.roles = roleList;
            single.reportingTo = null;
            single.employeeCode = "CVC/123445/3001";
            single.fingerprint = false;
            single.accessPoints = accessPointLists;
            single.card = true;
            single.clickToAccessRange = "5";
            single.credentialId = 1006207;
            single.deviceLock = false;
            single.joiningDate =  "25-May-2022";
            single.probationPeriod = 30;
            single.proximityAccess = true;
            single.tapToAccess = false;
            single.accessExpiresAt = Convert.ToDateTime("31-Dec-2025");
            single.phone = "+938787812687";
            single.gender = "male";
            single.name = "TestingUser7";

          

            IList<SingleUser> usersToAdd = new List<SingleUser>();
            usersToAdd.Add(single);

            oneToUpload.users = usersToAdd;



            strJsonRequest = String.Empty;
            try
            {
                strJsonRequest = JsonConvert.SerializeObject(oneToUpload);
            }
            catch (Exception ex)
            {
                string errorJson = "Your Data Failed To Convert To Json " + ex.Message;
                MessageBox.Show(errorJson);
            }
        }
     

       

   

        

        private async void AddASingleUser()
        {
            string url = "https://api.spintly.com/v2/organisationManagement/integrator/organisations/674/users";
                      
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



                ResponseSingleUserCreation createdUserList = JsonConvert.DeserializeObject<ResponseSingleUserCreation>(response.Content);
                if (createdUserList.type != "success")
                {
                    MessageBox.Show("Unable To Call API - Failed To Fetch Access Controlled Project Sites Details");
                    return;
                }
                 
                Int64 newUserID;
                newUserID = Convert.ToInt64(createdUserList.message.userIds[0]);
            }
            catch (Exception d)
            {
                string errorJson = "Error In Calling Access Points List " + d.Message;
                MessageBox.Show(errorJson);
            }

        }

      

    

     

       

       

       

        private void frmAccessHistory_Load(object sender, EventArgs e)
        {
            
           
           
           
           
        }

       

       

    
    }
}
