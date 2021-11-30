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
using ESCHOLPMS.API.AccessPoints;

namespace ESCHOLPMS 
{
    public partial class frmAccessPoints : Form
    {
        string spintlyOrgID = Convert.ToString(GlobalVariables.spintlyOrgID);
        string spintlyAccessToken = Convert.ToString(GlobalVariables.access_token);

        AccessPoints accessControledPoints = new AccessPoints();
        PMS pms = new PMS();


        public frmAccessPoints()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            FetchAcessPointSites();
        }

        private async void FetchAcessPointSites()
        {
            string url = "https://api.spintly.com/v2/organisationManagement/integrator/organisations/" + spintlyOrgID+ "/accessPoint";
          
         
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

                accessControledPoints = JsonConvert.DeserializeObject<AccessPoints>(response.Content);
                if (accessControledPoints.type != "success")
                {
                    MessageBox.Show("Unable To Call API - Failed To Fetch Access Controlled Project Sites Details");
                    return;
                }

                int i = pms.DeleteAllAccessPoints();
                List<AccessPoint> accessSitesList = new List<AccessPoint>();
                int accessPointID;
                int siteID;
                string accessPointName;
                foreach (AccessPoint ap in accessControledPoints.message.accessPoints)
                {
                    
                    siteID = Convert.ToInt16(ap.siteId);
                    accessPointID = Convert.ToInt16(ap.id);
                    accessPointName = Convert.ToString(ap.name).ToUpper();
                    i = pms.InsertAccessPoint(siteID, accessPointID,accessPointName);
                }
                DataSet ds = pms.GetAccessPoints();
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
