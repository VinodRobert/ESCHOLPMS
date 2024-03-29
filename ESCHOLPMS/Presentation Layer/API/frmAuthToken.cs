﻿using System;
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

namespace ESCHOLPMS 
{
    public partial class frmAuthToken : Form
    {
        OauthTokenRequest   oathRequest = new OauthTokenRequest();
        OauthTokenResponse  oathResponse = new OauthTokenResponse();
        PMS pms = new PMS();

        public frmAuthToken()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Authenticate();
        }

        private async void Authenticate()
        {
            string url = "https://qlwtofmb58.execute-api.ap-south-1.amazonaws.com/prod/saamsIdm/oauth/token";
            string clientID = "ce681063-5d5e-4169-a4e5-2605fba34f6f";
            string clientSecret = "27038351-68cb-4919-b821-88e07e6d484e";
            string grantType = "urn:ietf:params:oauth:grant-type:client-credentials";
            try
            {
                oathRequest.clientId = clientID;
                oathRequest.clientSecret = clientSecret;
                oathRequest.grantType = grantType;
            }
            catch (Exception f)
            {
                MessageBox.Show("Error In Formation"+ f.Message);

            }

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
                RestRequest request = new RestRequest(Method.POST);
                request.AddJsonBody(oathRequest);
           
                IRestResponse response = await client.ExecuteAsync(request);


                oathResponse = JsonConvert.DeserializeObject<OauthTokenResponse>(response.Content);
                if (oathResponse.type != "success")
                {
                      MessageBox.Show("Unable To Call API - Failed Authentication ");
                      return;
                }
               
                GlobalVariables.access_token = oathResponse.message.payload.access_token;
                GlobalVariables.spintlyOrgID = 694;
                txtToken.Text = Convert.ToString(GlobalVariables.access_token);
                int i = pms.UpdateAuthorizationKey(GlobalVariables.access_token);

            }
            catch (Exception d)
            {
                string errorJson = "Error In Calling Authentication " + d.Message;
                MessageBox.Show(errorJson);
            }

        }
    }
}
