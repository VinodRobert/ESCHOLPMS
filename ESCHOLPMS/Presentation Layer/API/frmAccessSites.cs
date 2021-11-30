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
        string spintlyAccessToken = Convert.ToString(GlobalVariables.access_token);

        AccessSites accessControledProjets = new AccessSites();
        PMS pms = new PMS();
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
            string url = "https://api.spintly.com/v2/organisationManagement/integrator/organisations/" + spintlyOrgID+"/sites";
          
         
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

                accessControledProjets = JsonConvert.DeserializeObject<AccessSites>(response.Content);
                if (accessControledProjets.type != "success")
                {
                    MessageBox.Show("Unable To Call API - Failed To Fetch Access Controlled Project Sites Details");
                    return;
                }

                int i = pms.DeleteAllSites();
                List<Sites> accessSitesList = new List<Sites>();
                string siteName;
                int siteID;
                string siteLocation;
                foreach (Sites s in accessControledProjets.message.sites)
                {
                    siteName = s.name.ToUpper();
                    siteID = Convert.ToInt16(s.id);
                    siteLocation = Convert.ToString(s.location).ToUpper();
                    i = pms.InsertSite(siteID, siteName, siteLocation);
                }
                DataSet ds = pms.GetAccessSites();
                gridSites.DataSource = ds.Tables[0];
            }
            catch (Exception d)
            {
                string errorJson = "Error In Calling Access Points List " + d.Message;
                MessageBox.Show(errorJson);
            }
           
        }
    }
}
