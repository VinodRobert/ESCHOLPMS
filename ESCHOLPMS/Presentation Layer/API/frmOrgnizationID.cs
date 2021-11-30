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
using ESCHOLPMS.Business_Layer.API;

namespace ESCHOLPMS 
{
    public partial class frmOrganizationID : Form
    {
        OauthTokenRequest       oathRequest = new OauthTokenRequest();
        OauthTokenResponse      oathResponse = new OauthTokenResponse();
        ResponseOrganizationID  responseOrgID = new ResponseOrganizationID();


        PMS pms = new PMS();

        public frmOrganizationID()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Authenticate();
        }

        private async void Authenticate()
        {
            string url = "https://6ipiqdho0m.execute-api.ap-south-1.amazonaws.com/dev/saamsIdm/oauth/organisation";

            string strJson = String.Empty;
            try
            {
                strJson = JsonConvert.SerializeObject(oathRequest);
            }
            catch (Exception s)
            {
                string errorJson = "Your Data Failed To Convert To Json " + s.Message;
                MessageBox.Show(errorJson);
            }


            try
            {
                RestClient client = new RestClient(url);
                RestRequest request = new RestRequest(Method.GET);
                request.AddHeader("Authorization", GlobalVariables.access_token);
                IRestResponse response = await client.ExecuteAsync(request);


                responseOrgID = JsonConvert.DeserializeObject<ResponseOrganizationID>(response.Content);
                if (responseOrgID.type != "success")
                {
                      MessageBox.Show("Unable To Call API - Failed Authentication ");
                      return;
                }


                GlobalVariables.spintlyOrgID =Convert.ToInt16(responseOrgID.message.organisationId);
                txtToken.Text = Convert.ToString(GlobalVariables.spintlyOrgID);
                int i = pms.UpdateAuthorizationKey(GlobalVariables.spintlyOrgID);

            }
            catch (Exception d)
            {
                string errorJson = "Error In Calling Authentication " + d.Message;
                MessageBox.Show(errorJson);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
