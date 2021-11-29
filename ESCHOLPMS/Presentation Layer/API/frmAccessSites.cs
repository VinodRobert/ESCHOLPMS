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
using ESCHOLPMS.API.AccessSites;

namespace ESCHOLPMS 
{
    public partial class frmAccessSites : Form
    {
        string spintlyOrgID = Convert.ToString(GlobalVariables.spintlyOrgID);
        AccessSites accessControledProjets = new AccessSites();

        public frmAccessSites()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            FetchAcessPointSites();
        }

        private async void FetchAcessPointSites()
        {
            string url = "https://test.api.spintly.com/v2/organisationManagement/integrator/organisations/"+spintlyOrgID+"/sites";
          
            string accesstoken = Convert.ToString(GlobalVariables.access_token);
            if (accesstoken.Length==0)
            {
                MessageBox.Show("First Authenticated. Then Run ");
                return;
            }

            try
            {
                RestClient client = new RestClient(url);
                RestRequest request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", accesstoken);
            
           
                IRestResponse response = await client.ExecuteAsync(request);

                accessControledProjets = JsonConvert.DeserializeObject<AccessSites>(response.Content);
                if (accessControledProjets.type != "success")
                {
                    MessageBox.Show("Unable To Call API - Failed To Fetch Access Controlled Project Sites Details");
                    return;
                }

                List<Sites> accessSitesList = new List<Sites>();
                string siteName;
                foreach (Sites s in accessControledProjets.message.sites)
                {
                    siteName = s.name;
                }
            }
            catch (Exception d)
            {
                string errorJson = "Error In Calling Access Points List " + d.Message;
                MessageBox.Show(errorJson);
            }

        }
    }
}
