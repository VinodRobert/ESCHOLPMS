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
using ESCHOLPMS.API.SpintlyUsers;

namespace ESCHOLPMS 
{
    public partial class frmAccessUsers : Form
    {
        string spintlyOrgID = Convert.ToString(GlobalVariables.spintlyOrgID);
        string spintlyAccessToken = Convert.ToString(GlobalVariables.access_token);

        SpintlyUserLists spintlyUserCollection= new SpintlyUserLists();

        PMS pms = new PMS();


        public frmAccessUsers()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            FetchAcessPointSites();
        }

        private async void FetchAcessPointSites()
        {
            string url = "https://api.spintly.com/v2/organisationManagement/integrator/organisations/" + spintlyOrgID+ "/users/list";
          
         
            if (spintlyAccessToken.Length==0)
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
            
           
                IRestResponse response = await client.ExecuteAsync(request);

                spintlyUserCollection = JsonConvert.DeserializeObject<SpintlyUserLists>(response.Content);
                if (spintlyUserCollection.type != "success")
                {
                    MessageBox.Show("Unable To Call API - Failed To Fetch Access Controlled Project Sites Details");
                    return;
                }

           
                List<User> singleUser = new List<User>();
                int id = 0;
                string createdAt=string.Empty;
                bool cardAssigned=false;
                string accessExpiresAt=string.Empty;
                bool accessExpired=false;
                string deactivatedOn=string.Empty;
                string employeeCode=string.Empty;
                string credentialId=string.Empty;
                string userName = string.Empty;
                int success;
                try
                {
                    foreach (User u in spintlyUserCollection.message.users)
                    {
                        id = Convert.ToInt16(u.id);
                        userName = u.name.ToString();
                        createdAt = Convert.ToDateTime(u.createdAt).ToShortDateString();
                        cardAssigned = u.cardAssigned;
                        if (u.accessExpiresAt == null)
                            accessExpiresAt = "";
                        else
                            accessExpiresAt = Convert.ToDateTime(u.accessExpiresAt).ToShortDateString();
                        accessExpired = u.accessExpired;
                        if (u.deactivatedOn == null)
                            deactivatedOn = "";
                        else
                            deactivatedOn = Convert.ToDateTime(u.deactivatedOn).ToShortDateString();
                        if (u.employeeCode == null)
                            employeeCode = "";
                        else
                            employeeCode = u.employeeCode.ToString();
                        if (cardAssigned == false)
                            credentialId = "0";
                        else
                            credentialId = Convert.ToString(u.credentialId);
                        success = pms.InsertAccessUsers(id, userName, createdAt, cardAssigned, accessExpiresAt,
                            accessExpired, deactivatedOn, employeeCode, credentialId);
                    }
                
                }
                catch
                {
                    string errorMessage = "Error in ID" + Convert.ToString(id);
                    MessageBox.Show(errorMessage);
                }
               
            }
            catch (Exception d)
            {
                string errorJson = "Error In Calling Access Points List " + d.Message;
                MessageBox.Show(errorJson);
            }

            DataSet ds = pms.FetchAccessControlUsers();
            gridUsers.DataSource = ds.Tables[0];
            gridUsers.Refresh();
        }
    }
}
